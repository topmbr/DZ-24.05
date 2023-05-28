abstract class Shape
{
    public abstract double Area { get; }
    public abstract double Perimeter { get; }
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double Area => Width * Height;
    public override double Perimeter => 2 * (Width + Height);

    public override string ToString()
    {
        return $"Rectangle: Width = {Width}, Height = {Height}, Area = {Area}, Perimeter = {Perimeter}";
    }
}

class Circle : Shape
{
    public double Radius { get; set; }

    public override double Area => Math.PI * Radius * Radius;
    public override double Perimeter => 2 * Math.PI * Radius;

    public override string ToString()
    {
        return $"Circle: Radius = {Radius}, Area = {Area}, Perimeter = {Perimeter}";
    }
}

class Triangle : Shape
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public override double Area
    {
        get
        {
            double p = (SideA + SideB + SideC) / 2; // полупериметр
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC)); // формула Герона
        }
    }

    public override double Perimeter => SideA + SideB + SideC;

    public override string ToString()
    {
        return $"Triangle: SideA = {SideA}, SideB = {SideB}, SideC = {SideC}, Area = {Area}, Perimeter = {Perimeter}";
    }
}

class Fihyra
{
    static void PrintShapesInfo(Shape[] shapes)
    {
        foreach (var shape in shapes)
        {
            Console.WriteLine(shape.ToString());
        }
    }

    static void Main()
    {
        Shape[] shapes = new Shape[3];
        shapes[0] = new Rectangle {Width = 3, Height = 8};
        shapes[1] = new Circle {Radius = 5};
        shapes[2] = new Triangle {SideA = 2,SideB = 4,SideC = 6};

        PrintShapesInfo(shapes);
    }
}
