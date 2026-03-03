package good;

/**
 * ✅ 實習生只需要實作自己需要的介面，不會被迫實作不相關的方法。
 */
public class Intern implements Workable, Eatable {
    @Override
    public void work() {
        System.out.println("實習生正在學習");
    }

    @Override
    public void eat() {
        System.out.println("實習生正在吃午餐");
    }
}
