namespace Good;

/// <summary>
/// ✅ 遵循 DIP：定義抽象介面，高階和低階模組都依賴這個抽象。
/// </summary>
public interface IDatabase
{
    void Save(string data);
}

public class MySqlDatabase : IDatabase
{
    public void Save(string data)
    {
        Console.WriteLine($"儲存到 MySQL: {data}");
    }
}

public class MongoDatabase : IDatabase
{
    public void Save(string data)
    {
        Console.WriteLine($"儲存到 MongoDB: {data}");
    }
}

/// <summary>
/// ✅ 遵循 DIP：OrderService 依賴抽象介面 IDatabase，而非具體實作。
/// 透過建構子注入（Constructor Injection）來接收依賴。
/// </summary>
public class OrderService
{
    // ✅ 依賴抽象介面
    private readonly IDatabase _database;

    // ✅ 透過建構子注入依賴
    public OrderService(IDatabase database)
    {
        _database = database;
    }

    public void CreateOrder(string orderData)
    {
        Console.WriteLine($"建立訂單: {orderData}");
        _database.Save(orderData);
    }
}

/// <summary>
/// DIP 正確範例 — 主程式
///
/// OrderService 依賴 IDatabase 介面，可以輕鬆替換不同的資料庫實作。
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        // 使用 MySQL
        IDatabase mysql = new MySqlDatabase();
        var orderService1 = new OrderService(mysql);
        orderService1.CreateOrder("訂單 #001 - 筆記型電腦 x1");

        Console.WriteLine();

        // ✅ 輕鬆切換到 MongoDB，不需要改 OrderService！
        IDatabase mongo = new MongoDatabase();
        var orderService2 = new OrderService(mongo);
        orderService2.CreateOrder("訂單 #002 - 鍵盤 x2");
    }
}
