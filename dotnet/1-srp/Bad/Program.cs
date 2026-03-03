namespace Bad;

/// <summary>
/// ❌ 違反 SRP：Employee 類別同時負責了「員工資料管理」、「薪資計算」和「資料儲存」三件事。
/// 當其中任何一個需求改變時，都必須修改這個類別，造成維護困難。
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

    // 責任 1：計算薪資（應該由薪資計算模組負責）
    public double CalculatePay()
    {
        return BaseSalary * 1.1; // 加上 10% 獎金
    }

    // 責任 2：產生報表（應該由報表模組負責）
    public string GenerateReport()
    {
        return $"員工: {Name}, 薪資: {CalculatePay()}";
    }

    // 責任 3：儲存到資料庫（應該由資料存取模組負責）
    public void SaveToDatabase()
    {
        Console.WriteLine($"將 {Name} 的資料儲存到資料庫...");
    }
}

/// <summary>
/// SRP 違反範例 — 主程式
/// Employee 同時處理薪資計算、報表產生和資料庫儲存。
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        var emp = new Employee("小明", 50000);

        // 一個類別做了太多事
        Console.WriteLine(emp.GenerateReport());
        Console.WriteLine($"薪資: {emp.CalculatePay()}");
        emp.SaveToDatabase();
    }
}
