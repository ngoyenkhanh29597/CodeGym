namespace PrimeNumber;
class Program
{
    static void Main(string[] args)
    {
        int num;
        int count = 0;
        Console.WriteLine("Indentify Prime number program: ");
        Console.Write("Enter a number: ");
        num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                count++;
            {
                if (count > 2)
                {
                    Console.WriteLine(num + " is not a prime number");
                    break;
                }
            }
        }
        if (count <= 2) Console.WriteLine(num + " is a prime number");
        Console.ReadKey();
    }
}

