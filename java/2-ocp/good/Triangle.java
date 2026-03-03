package good;

/**
 * ✅ 新增三角形完全不需要修改既有程式碼！只要實作 Shape 介面即可。
 */
public class Triangle implements Shape {
    private double base;
    private double height;

    public Triangle(double base, double height) {
        this.base = base;
        this.height = height;
    }

    @Override
    public double calculateArea() {
        return 0.5 * base * height;
    }
}
