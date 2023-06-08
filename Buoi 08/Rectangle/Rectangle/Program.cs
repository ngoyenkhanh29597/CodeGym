namespace Rectangle;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the width: ");
        double width = Double.Parse(Console.ReadLine());
        Console.Write("Enter the height: ");
        double height = Double.Parse(Console.ReadLine());
        Rectangle rectangle = new Rectangle(width, height);
        Console.WriteLine("Rectangle dimension: " + rectangle.Display());
        Console.WriteLine("Perimeter: " + rectangle.GetPerimeter());
        Console.WriteLine("Area: " + rectangle.GetArea());
    }
}

