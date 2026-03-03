package good;

/**
 * ✅ 企鵝是鳥，會游泳但不會飛。
 * 不需要實作 Flyable 介面，完全符合 LSP。
 */
public class Penguin extends Bird implements Swimmable {
    public Penguin() {
        super("企鵝");
    }

    @Override
    public void makeSound() {
        System.out.println("嘎嘎!");
    }

    @Override
    public void swim() {
        System.out.println(getName() + " 正在游泳!");
    }
}
