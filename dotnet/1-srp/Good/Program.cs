namespace Good;

/// <summary>
/// ✅ 遵循 SRP：Employee 只負責管理員工資料。
/// </summary>
public class Employee
{
    public string Name { get; set; }
    public double BaseSalary { get; set; }

    public Employee(string name, double baseSalary)
    {
        Name = name;
        BaseSalary = baseSalary;
    }
}

/// <summary>
/// ✅ 遵循 SRP：PayCalculator 只負責薪資計算。
/// </summary>
public class PayCalculator
{
    public double CalculatePay(Employee employee)
    {
        return employee.BaseSalary * 1.1; // 加上 10% 獎金
    }
}

/// <summary>
/// ✅ 遵循 SRP：ReportGenerator 只負責產生報表。
/// </summary>
public class ReportGenerator
{
    public string GenerateReport(Employee employee, double pay)
    {
        return $"員工: {employee.Name}, 薪資: {pay}";
    }
}

/// <summary>
/// ✅ 遵循 SRP：EmployeeRepository 只負責資料儲存。
/// </summary>
public class EmployeeRepository
{
    public void Save(Employee employee)
    {
        Console.WriteLine($"將 {employee.Name} 的資料儲存到資料庫...");
    }
}

/// <summary>
/// SRP 正確範例 — 主程式
///
/// 每個類別只有一個職責：
/// - Employee：管理員工資料
/// - PayCalculator：計算薪資
/// - ReportGenerator：產生報表
/// - EmployeeRepository：資料儲存
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        var emp = new Employee("小明", 50000);

        var calculator = new PayCalculator();
        var reporter = new ReportGenerator();
        var repository = new EmployeeRepository();

        double pay = calculator.CalculatePay(emp);
        Console.WriteLine(reporter.GenerateReport(emp, pay));
        repository.Save(emp);
    }
}
