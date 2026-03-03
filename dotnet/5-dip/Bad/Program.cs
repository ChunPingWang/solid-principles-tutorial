namespace Bad;

public class MySqlDatabase
{
    public void Save(string data)
    {
        Console.WriteLine($"儲存到 MySQL: {data}");
    }
}

/// <summary>
/// ❌ 違反 DIP：高階模組 OrderService 直接依賴低階模組 MySqlDatabase。
/// 如果未來要改用 PostgreSQL 或 MongoDB，就必須修改 OrderService。
/// </summary>
public class OrderService
{
    // ❌ 直接依賴具體實作
    private readonly MySqlDatabase _database = new();

    public void CreateOrder(string orderData)
    {
        Console.WriteLine($"建立訂單: {orderData}");
        _database.Save(orderData);  // ❌ 綁死在 MySQL
    }
}

/// <summary>
/// DIP 違反範例 — 主程式
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        var orderService = new OrderService();
        orderService.CreateOrder("訂單 #001 - 筆記型電腦 x1");
        // 如果要改用 MongoDB，就得修改 OrderService 的程式碼...
    }
}
