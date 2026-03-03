namespace Bad;

public class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
}

public class Circle
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }
}

/// <summary>
/// ❌ 違反 OCP：每次新增一種形狀，都必須修改 CalculateArea 方法。
/// </summary>
public class AreaCalculator
{
    public double CalculateArea(object shape)
    {
        if (shape is Rectangle rect)
        {
            return rect.Width * rect.Height;
        }
        else if (shape is Circle circle)
        {
            return Math.PI * circle.Radius * circle.Radius;
        }
        // ❌ 每新增一種形狀就要改這裡
        return 0;
    }
}

/// <summary>
/// OCP 違反範例 — 主程式
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        var calculator = new AreaCalculator();

        var rect = new Rectangle(5, 10);
        var circle = new Circle(7);

        Console.WriteLine($"長方形面積: {calculator.CalculateArea(rect)}");
        Console.WriteLine($"圓形面積: {calculator.CalculateArea(circle)}");
    }
}
