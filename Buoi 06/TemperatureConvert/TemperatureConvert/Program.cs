namespace TemperatureConvert;
class Program
{
    public static double CtoF(double celsius)
    {
        double fahrenheit = (9.0 / 5) * celsius + 32;
        return fahrenheit;
    }

    public static double FtoC(double fahrenheit)
    {

        double celsius = (5.0 / 9) * (fahrenheit - 32);
        return celsius;

    }
    static void Main(string[] args)
    {
        int option;
        do
        {
            Console.WriteLine("1. Celsius to Fahrenheit ");
            Console.WriteLine("2. Fahrenheit to Celsius ");
            Console.WriteLine("3. Exit ");
            Console.Write("Temperature converter: ");
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    double celsius;
                    Console.Write("Enter the temperature in celsius: ");
                    celsius = double.Parse(Console.ReadLine());
                    Console.WriteLine("The temperature of " + celsius + " celsius degree is " + CtoF(32.5) + " fahrenheit");
                    Console.WriteLine();
                    break;
                case 2:
                    double fahrenheit;
                    Console.Write("Enter the temperrature in fahrenheit: ");
                    fahrenheit = double.Parse(Console.ReadLine());
                    Console.WriteLine("The temperature of " + fahrenheit + " celsius degree is " + FtoC(32.5) + " celsius");
                    Console.WriteLine();
                    break;

                case 3:
                    Console.WriteLine("Exit...");
                    Environment.Exit(3);
                    break;
            }

        } while (option != 3) ;
        Console.ReadKey();
        
    }
}

