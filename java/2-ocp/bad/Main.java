package bad;

/**
 * OCP 違反範例 — 主程式
 *
 * 問題：如果要新增「三角形」，必須修改 AreaCalculator 的程式碼。
 */
public class Main {
    public static void main(String[] args) {
        AreaCalculator calculator = new AreaCalculator();

        Rectangle rect = new Rectangle(5, 10);
        Circle circle = new Circle(7);

        System.out.println("長方形面積: " + calculator.calculateArea(rect));
        System.out.println("圓形面積: " + calculator.calculateArea(circle));
        // 如果要新增三角形，就得改 AreaCalculator...
    }
}
