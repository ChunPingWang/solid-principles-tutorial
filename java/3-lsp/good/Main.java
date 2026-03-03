package good;

/**
 * LSP 正確範例 — 主程式
 *
 * 所有 Bird 子類別都可以安全地替換 Bird 使用。
 * 「飛」和「游泳」的能力透過介面分離，不會強迫子類別實作不合理的行為。
 */
public class Main {
    public static void main(String[] args) {
        Bird[] birds = { new Sparrow(), new Penguin() };

        // ✅ 所有鳥都可以安全地呼叫 makeSound()
        for (Bird bird : birds) {
            System.out.print(bird.getName() + ": ");
            bird.makeSound();
        }

        System.out.println();

        // 只對會飛的鳥呼叫 fly()
        Sparrow sparrow = new Sparrow();
        sparrow.fly();

        // 只對會游泳的鳥呼叫 swim()
        Penguin penguin = new Penguin();
        penguin.swim();
    }
}
