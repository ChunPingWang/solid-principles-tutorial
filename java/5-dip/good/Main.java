package good;

/**
 * DIP 正確範例 — 主程式
 *
 * OrderService 依賴 Database 介面，可以輕鬆替換不同的資料庫實作。
 * 不需要修改 OrderService 的任何程式碼！
 */
public class Main {
    public static void main(String[] args) {
        // 使用 MySQL
        Database mysql = new MySQLDatabase();
        OrderService orderService1 = new OrderService(mysql);
        orderService1.createOrder("訂單 #001 - 筆記型電腦 x1");

        System.out.println();

        // ✅ 輕鬆切換到 MongoDB，不需要改 OrderService！
        Database mongo = new MongoDatabase();
        OrderService orderService2 = new OrderService(mongo);
        orderService2.createOrder("訂單 #002 - 鍵盤 x2");
    }
}
