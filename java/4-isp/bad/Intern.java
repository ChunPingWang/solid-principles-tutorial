package bad;

/**
 * ❌ 實習生不需要開會和寫報告，但被迫實作這些方法。
 * 只能丟例外或留空，這就是 ISP 違反的典型症狀。
 */
public class Intern implements Worker {
    @Override
    public void work() {
        System.out.println("實習生正在學習");
    }

    @Override
    public void eat() {
        System.out.println("實習生正在吃午餐");
    }

    @Override
    public void attendMeeting() {
        // ❌ 實習生不需要開會，但被迫實作
        throw new UnsupportedOperationException("實習生不需要開會");
    }

    @Override
    public void writeReport() {
        // ❌ 實習生不需要寫報告，但被迫實作
        throw new UnsupportedOperationException("實習生不需要寫報告");
    }
}
