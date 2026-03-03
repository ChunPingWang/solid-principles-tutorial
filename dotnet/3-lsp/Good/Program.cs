namespace Good;

/// <summary>
/// ✅ 遵循 LSP：Bird 基底類別只包含所有鳥共同的行為。
/// </summary>
public abstract class Bird
{
    public string Name { get; set; }

    protected Bird(string name)
    {
        Name = name;
    }

    // 所有鳥都會發出聲音
    public abstract void MakeSound();
}

/// <summary>
/// ✅ 將「飛」的能力獨立成介面。
/// </summary>
public interface IFlyable
{
    void Fly();
}

/// <summary>
/// ✅ 將「游泳」的能力獨立成介面。
/// </summary>
public interface ISwimmable
{
    void Swim();
}

/// <summary>
/// ✅ 麻雀是鳥，也會飛。
/// </summary>
public class Sparrow : Bird, IFlyable
{
    public Sparrow() : base("麻雀") { }

    public override void MakeSound()
    {
        Console.WriteLine("嘰嘰喳喳!");
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} 正在飛翔!");
    }
}

/// <summary>
/// ✅ 企鵝是鳥，會游泳但不會飛。不需要實作 IFlyable。
/// </summary>
public class Penguin : Bird, ISwimmable
{
    public Penguin() : base("企鵝") { }

    public override void MakeSound()
    {
        Console.WriteLine("嘎嘎!");
    }

    public void Swim()
    {
        Console.WriteLine($"{Name} 正在游泳!");
    }
}

/// <summary>
/// LSP 正確範例 — 主程式
///
/// 所有 Bird 子類別都可以安全地替換 Bird 使用。
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        Bird[] birds = { new Sparrow(), new Penguin() };

        // ✅ 所有鳥都可以安全地呼叫 MakeSound()
        foreach (var bird in birds)
        {
            Console.Write($"{bird.Name}: ");
            bird.MakeSound();
        }

        Console.WriteLine();

        // 只對會飛的鳥呼叫 Fly()
        var sparrow = new Sparrow();
        sparrow.Fly();

        // 只對會游泳的鳥呼叫 Swim()
        var penguin = new Penguin();
        penguin.Swim();
    }
}
