package good;

/**
 * ISP 正確範例 — 主程式
 *
 * 每個類別只實作自己需要的介面：
 * - Manager 實作 Workable, Eatable, MeetingAttendable, ReportWritable
 * - Intern 只實作 Workable, Eatable
 *
 * 不會有被迫實作不需要方法的問題。
 */
public class Main {
    public static void main(String[] args) {
        Manager manager = new Manager();
        Intern intern = new Intern();

        System.out.println("=== 經理 ===");
        manager.work();
        manager.attendMeeting();
        manager.writeReport();

        System.out.println("\n=== 實習生 ===");
        intern.work();
        intern.eat();
        // ✅ 實習生沒有 attendMeeting()，編譯期就能發現問題
    }
}
