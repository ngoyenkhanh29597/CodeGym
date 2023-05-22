namespace Menu;
class Program
{
    static void Main(string[] args)
    {
        int option;
        do
        {
            Console.WriteLine("Drawing Menu");
            Console.WriteLine("1. Draw the triangle");
            Console.WriteLine("2. Draw the square");
            Console.WriteLine("3. Draw the rectangle");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Write("\n");
                    Console.WriteLine("Draw the triangle");
                    Console.WriteLine("******");
                    Console.WriteLine("*****");
                    Console.WriteLine("****");
                    Console.WriteLine("***");
                    Console.WriteLine("**");
                    Console.WriteLine("*");
                    Console.Write("\n");
                    break;
                case 2:
                    Console.Write("\n");
                    Console.WriteLine("Draw the square");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.Write("\n");
                    break;
                case 3:
                    Console.Write("\n");
                    Console.WriteLine("Draw the rectangle");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.Write("\n");
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("No choice!");
                    break;
            }
        } while (option != 0);
        Console.ReadKey();
    }
}

