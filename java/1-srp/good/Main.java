package good;

/**
 * SRP 正確範例 — 主程式
 *
 * 每個類別只有一個職責：
 * - Employee：管理員工資料
 * - PayCalculator：計算薪資
 * - ReportGenerator：產生報表
 * - EmployeeRepository：資料儲存
 *
 * 當薪資計算邏輯改變時，只需要修改 PayCalculator。
 * 當報表格式改變時，只需要修改 ReportGenerator。
 * 當資料庫改變時，只需要修改 EmployeeRepository。
 */
public class Main {
    public static void main(String[] args) {
        Employee emp = new Employee("小明", 50000);

        PayCalculator calculator = new PayCalculator();
        ReportGenerator reporter = new ReportGenerator();
        EmployeeRepository repository = new EmployeeRepository();

        double pay = calculator.calculatePay(emp);
        System.out.println(reporter.generateReport(emp, pay));
        repository.save(emp);
    }
}
