package good;

/**
 * ✅ 遵循 DIP：OrderService 依賴抽象介面 Database，而非具體實作。
 * 透過建構子注入（Constructor Injection）來接收依賴。
 */
public class OrderService {
    // ✅ 依賴抽象介面
    private Database database;

    // ✅ 透過建構子注入依賴
    public OrderService(Database database) {
        this.database = database;
    }

    public void createOrder(String orderData) {
        System.out.println("建立訂單: " + orderData);
        database.save(orderData);
    }
}
