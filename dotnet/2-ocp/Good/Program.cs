namespace Good;

/// <summary>
/// ✅ 遵循 OCP：定義 IShape 介面，讓每種形狀自行實作面積計算。
/// 新增形狀時不需要修改任何現有程式碼。
/// </summary>
public interface IShape
{
    double CalculateArea();
}

public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double CalculateArea() => Width * Height;
}

public class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea() => Math.PI * Radius * Radius;
}

/// <summary>
/// ✅ 新增三角形完全不需要修改既有程式碼！
/// </summary>
public class Triangle : IShape
{
    public double Base { get; set; }
    public double Height { get; set; }

    public Triangle(double @base, double height)
    {
        Base = @base;
        Height = height;
    }

    public double CalculateArea() => 0.5 * Base * Height;
}

/// <summary>
/// ✅ AreaCalculator 不需要知道具體的形狀類型。
/// </summary>
public class AreaCalculator
{
    public double CalculateTotalArea(IEnumerable<IShape> shapes)
    {
        return shapes.Sum(s => s.CalculateArea());
    }
}

/// <summary>
/// OCP 正確範例 — 主程式
///
/// 新增 Triangle 完全不需要修改 AreaCalculator 或其他形狀類別。
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        var shapes = new List<IShape>
        {
            new Rectangle(5, 10),
            new Circle(7),
            new Triangle(6, 8)  // 新增三角形，不用改任何舊程式碼！
        };

        var calculator = new AreaCalculator();

        foreach (var shape in shapes)
        {
            Console.WriteLine($"{shape.GetType().Name} 面積: {shape.CalculateArea()}");
        }

        Console.WriteLine($"總面積: {calculator.CalculateTotalArea(shapes)}");
    }
}
