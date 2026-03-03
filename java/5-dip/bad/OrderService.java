package bad;

/**
 * ❌ 違反 DIP：高階模組 OrderService 直接依賴低階模組 MySQLDatabase。
 * 如果未來要改用 PostgreSQL 或 MongoDB，就必須修改 OrderService。
 */
public class OrderService {
    // ❌ 直接依賴具體實作
    private MySQLDatabase database = new MySQLDatabase();

    public void createOrder(String orderData) {
        System.out.println("建立訂單: " + orderData);
        database.save(orderData);  // ❌ 綁死在 MySQL
    }
}
