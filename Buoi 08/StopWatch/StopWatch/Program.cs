namespace StopWatch;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Current Date and Time is : ");
        DateTime now = DateTime.Now;
        Console.WriteLine(now.ToString("dd/MM/yyyy HH:mm:ss.fffffff"));
        Console.ReadLine();`
    }
}

