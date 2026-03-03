package good;

/**
 * ✅ 遵循 DIP：定義抽象介面，高階和低階模組都依賴這個抽象。
 */
public interface Database {
    void save(String data);
}
