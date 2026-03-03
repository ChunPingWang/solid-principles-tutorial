package good;

/**
 * ✅ 遵循 LSP：Bird 基底類別只包含所有鳥共同的行為。
 */
public abstract class Bird {
    private String name;

    public Bird(String name) {
        this.name = name;
    }

    public String getName() {
        return name;
    }

    // 所有鳥都會發出聲音
    public abstract void makeSound();
}
