package bad;

/**
 * ❌ 違反 OCP：每次新增一種形狀，都必須修改 calculateArea 方法。
 * 例如新增三角形時，就要在 if-else 中再加一個分支。
 */
public class AreaCalculator {

    public double calculateArea(Object shape) {
        if (shape instanceof Rectangle) {
            Rectangle rect = (Rectangle) shape;
            return rect.width * rect.height;
        } else if (shape instanceof Circle) {
            Circle circle = (Circle) shape;
            return Math.PI * circle.radius * circle.radius;
        }
        // ❌ 每新增一種形狀就要改這裡
        return 0;
    }
}
