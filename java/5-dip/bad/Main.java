package bad;

/**
 * DIP 違反範例 — 主程式
 *
 * OrderService 直接依賴 MySQLDatabase，
 * 無法輕易替換成其他資料庫。
 */
public class Main {
    public static void main(String[] args) {
        OrderService orderService = new OrderService();
        orderService.createOrder("訂單 #001 - 筆記型電腦 x1");
        // 如果要改用 MongoDB，就得修改 OrderService 的程式碼...
    }
}
