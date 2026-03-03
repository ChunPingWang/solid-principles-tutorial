package bad;

/**
 * ❌ 企鵝繼承了 Bird 的 fly() 方法，但企鵝不會飛！
 * 如果呼叫 penguin.fly()，行為就不正確了。
 */
public class Penguin extends Bird {
    public Penguin() {
        super("企鵝");
    }

    @Override
    public void fly() {
        // ❌ 只能丟例外或什麼都不做，這就違反了 LSP
        throw new UnsupportedOperationException("企鵝不會飛!");
    }
}
