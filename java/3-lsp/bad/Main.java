package bad;

/**
 * LSP 違反範例 — 主程式
 *
 * 當我們用 Bird 類型操作所有鳥時，企鵝的 fly() 會丟出例外，
 * 導致程式無法正常運作。這就是違反 LSP 的後果。
 */
public class Main {
    public static void main(String[] args) {
        Bird[] birds = { new Sparrow(), new Penguin() };

        for (Bird bird : birds) {
            System.out.print(bird.getName() + ": ");
            try {
                bird.fly();  // ❌ 企鵝會丟出例外！
            } catch (UnsupportedOperationException e) {
                System.out.println("錯誤 - " + e.getMessage());
            }
        }
    }
}
