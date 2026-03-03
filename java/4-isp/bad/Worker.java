package bad;

/**
 * ❌ 違反 ISP：一個大而全的介面，強迫所有實作者實作所有方法。
 * 不是每種員工都需要所有這些功能。
 */
public interface Worker {
    void work();
    void eat();
    void attendMeeting();
    void writeReport();
}
