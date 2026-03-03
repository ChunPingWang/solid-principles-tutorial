namespace Bad;

/// <summary>
/// ❌ 違反 ISP：一個大而全的介面，強迫所有實作者實作所有方法。
/// </summary>
public interface IWorker
{
    void Work();
    void Eat();
    void AttendMeeting();
    void WriteReport();
}

/// <summary>
/// 經理需要所有功能。
/// </summary>
public class Manager : IWorker
{
    public void Work() => Console.WriteLine("經理正在管理團隊");
    public void Eat() => Console.WriteLine("經理正在吃午餐");
    public void AttendMeeting() => Console.WriteLine("經理正在開會");
    public void WriteReport() => Console.WriteLine("經理正在寫報告");
}

/// <summary>
/// ❌ 實習生不需要開會和寫報告，但被迫實作這些方法。
/// </summary>
public class Intern : IWorker
{
    public void Work() => Console.WriteLine("實習生正在學習");
    public void Eat() => Console.WriteLine("實習生正在吃午餐");

    public void AttendMeeting()
    {
        // ❌ 實習生不需要開會，但被迫實作
        throw new NotSupportedException("實習生不需要開會");
    }

    public void WriteReport()
    {
        // ❌ 實習生不需要寫報告，但被迫實作
        throw new NotSupportedException("實習生不需要寫報告");
    }
}

/// <summary>
/// ISP 違反範例 — 主程式
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        IWorker manager = new Manager();
        IWorker intern = new Intern();

        Console.WriteLine("=== 經理 ===");
        manager.Work();
        manager.AttendMeeting();
        manager.WriteReport();

        Console.WriteLine("\n=== 實習生 ===");
        intern.Work();
        try
        {
            intern.AttendMeeting();  // ❌ 會丟出例外
        }
        catch (NotSupportedException e)
        {
            Console.WriteLine($"錯誤: {e.Message}");
        }
    }
}
