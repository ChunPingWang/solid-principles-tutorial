package bad;

/**
 * SRP 違反範例 — 主程式
 *
 * Employee 同時處理薪資計算、報表產生和資料庫儲存，
 * 任何一項需求變更都會影響 Employee 類別。
 */
public class Main {
    public static void main(String[] args) {
        Employee emp = new Employee("小明", 50000);

        // 一個類別做了太多事
        System.out.println(emp.generateReport());
        System.out.println("薪資: " + emp.calculatePay());
        emp.saveToDatabase();
    }
}
