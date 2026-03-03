namespace Bad;

/// <summary>
/// ❌ 違反 LSP：假設所有鳥都會飛。
/// 但企鵝是鳥卻不會飛，導致子類別無法正確替換父類別。
/// </summary>
public class Bird
{
    public string Name { get; set; }

    public Bird(string name)
    {
        Name = name;
    }

    // ❌ 假設所有鳥都會飛
    public virtual void Fly()
    {
        Console.WriteLine($"{Name} 正在飛翔!");
    }
}

public class Sparrow : Bird
{
    public Sparrow() : base("麻雀") { }
    // 麻雀會飛，沒問題
}

/// <summary>
/// ❌ 企鵝繼承了 Bird 的 Fly() 方法，但企鵝不會飛！
/// </summary>
public class Penguin : Bird
{
    public Penguin() : base("企鵝") { }

    public override void Fly()
    {
        // ❌ 只能丟例外或什麼都不做
        throw new InvalidOperationException("企鵝不會飛!");
    }
}

/// <summary>
/// LSP 違反範例 — 主程式
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        Bird[] birds = { new Sparrow(), new Penguin() };

        foreach (var bird in birds)
        {
            Console.Write($"{bird.Name}: ");
            try
            {
                bird.Fly();  // ❌ 企鵝會丟出例外！
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"錯誤 - {e.Message}");
            }
        }
    }
}
