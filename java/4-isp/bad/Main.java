package bad;

/**
 * ISP 違反範例 — 主程式
 *
 * Intern 被迫實作不需要的方法，呼叫時會丟出例外。
 */
public class Main {
    public static void main(String[] args) {
        Worker manager = new Manager();
        Worker intern = new Intern();

        System.out.println("=== 經理 ===");
        manager.work();
        manager.attendMeeting();
        manager.writeReport();

        System.out.println("\n=== 實習生 ===");
        intern.work();
        try {
            intern.attendMeeting();  // ❌ 會丟出例外
        } catch (UnsupportedOperationException e) {
            System.out.println("錯誤: " + e.getMessage());
        }
    }
}
