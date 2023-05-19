using System.Globalization;

namespace LinearEquationResolver;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Linear Equation Resolver: ax + b = 0");
        Console.WriteLine("Please!, enter constants: ");
        Console.Write("a = ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("b = ");
        float b = float.Parse(Console.ReadLine());
        if (a == 0)
           Console.WriteLine("The equation has no solution");
        else
        {
            float x = -b/a;
            Console.WriteLine("The slution of the equation x = " +x);
        }

    }
}


