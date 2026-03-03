package good;

import java.util.Arrays;
import java.util.List;

/**
 * OCP 正確範例 — 主程式
 *
 * 新增 Triangle 完全不需要修改 AreaCalculator 或其他形狀類別。
 * 這就是「對擴展開放，對修改封閉」。
 */
public class Main {
    public static void main(String[] args) {
        List<Shape> shapes = Arrays.asList(
            new Rectangle(5, 10),
            new Circle(7),
            new Triangle(6, 8)  // 新增三角形，不用改任何舊程式碼！
        );

        AreaCalculator calculator = new AreaCalculator();

        for (Shape shape : shapes) {
            System.out.println(shape.getClass().getSimpleName()
                + " 面積: " + shape.calculateArea());
        }

        System.out.println("總面積: " + calculator.calculateTotalArea(shapes));
    }
}
