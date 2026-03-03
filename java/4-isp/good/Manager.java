package good;

/**
 * ✅ 經理需要所有功能，所以實作所有介面。
 */
public class Manager implements Workable, Eatable, MeetingAttendable, ReportWritable {
    @Override
    public void work() {
        System.out.println("經理正在管理團隊");
    }

    @Override
    public void eat() {
        System.out.println("經理正在吃午餐");
    }

    @Override
    public void attendMeeting() {
        System.out.println("經理正在開會");
    }

    @Override
    public void writeReport() {
        System.out.println("經理正在寫報告");
    }
}
