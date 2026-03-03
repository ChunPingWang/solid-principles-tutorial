package good;

import java.util.List;

/**
 * ✅ 遵循 OCP：AreaCalculator 不需要知道具體的形狀類型。
 * 新增形狀時完全不需要修改此類別。
 */
public class AreaCalculator {
    public double calculateTotalArea(List<Shape> shapes) {
        double total = 0;
        for (Shape shape : shapes) {
            total += shape.calculateArea();
        }
        return total;
    }
}
