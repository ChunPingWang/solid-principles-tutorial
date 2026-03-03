namespace Good;

/// <summary>
/// ✅ 遵循 ISP：將大介面拆分成小而專一的介面。
/// </summary>
public interface IWorkable
{
    void Work();
}

public interface IEatable
{
    void Eat();
}

public interface IMeetingAttendable
{
    void AttendMeeting();
}

public interface IReportWritable
{
    void WriteReport();
}

/// <summary>
/// ✅ 經理需要所有功能，所以實作所有介面。
/// </summary>
public class Manager : IWorkable, IEatable, IMeetingAttendable, IReportWritable
{
    public void Work() => Console.WriteLine("經理正在管理團隊");
    public void Eat() => Console.WriteLine("經理正在吃午餐");
    public void AttendMeeting() => Console.WriteLine("經理正在開會");
    public void WriteReport() => Console.WriteLine("經理正在寫報告");
}

/// <summary>
/// ✅ 實習生只需要實作自己需要的介面。
/// </summary>
public class Intern : IWorkable, IEatable
{
    public void Work() => Console.WriteLine("實習生正在學習");
    public void Eat() => Console.WriteLine("實習生正在吃午餐");
}

/// <summary>
/// ISP 正確範例 — 主程式
///
/// 每個類別只實作自己需要的介面，不會有被迫實作不需要方法的問題。
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        var manager = new Manager();
        var intern = new Intern();

        Console.WriteLine("=== 經理 ===");
        manager.Work();
        manager.AttendMeeting();
        manager.WriteReport();

        Console.WriteLine("\n=== 實習生 ===");
        intern.Work();
        intern.Eat();
        // ✅ 實習生沒有 AttendMeeting()，編譯期就能發現問題
    }
}
