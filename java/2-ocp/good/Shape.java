package good;

/**
 * ✅ 遵循 OCP：定義 Shape 介面，讓每種形狀自行實作面積計算。
 * 新增形狀時不需要修改任何現有程式碼，只需新增一個類別。
 */
public interface Shape {
    double calculateArea();
}
