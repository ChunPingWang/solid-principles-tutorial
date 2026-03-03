package bad;

/**
 * 經理需要所有功能，看起來還好。
 */
public class Manager implements Worker {
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
