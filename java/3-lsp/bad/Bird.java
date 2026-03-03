package bad;

/**
 * ❌ 違反 LSP：假設所有鳥都會飛。
 * 但企鵝是鳥卻不會飛，導致子類別無法正確替換父類別。
 */
public class Bird {
    private String name;

    public Bird(String name) {
        this.name = name;
    }

    public String getName() {
        return name;
    }

    // ❌ 假設所有鳥都會飛
    public void fly() {
        System.out.println(name + " 正在飛翔!");
    }
}
