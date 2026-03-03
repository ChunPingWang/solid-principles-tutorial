package good;

/**
 * ✅ 麻雀是鳥，也會飛。
 */
public class Sparrow extends Bird implements Flyable {
    public Sparrow() {
        super("麻雀");
    }

    @Override
    public void makeSound() {
        System.out.println("嘰嘰喳喳!");
    }

    @Override
    public void fly() {
        System.out.println(getName() + " 正在飛翔!");
    }
}
