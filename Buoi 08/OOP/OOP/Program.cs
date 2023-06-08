namespace OOP;
class Program
{
    static void Main(string[] args)
    {
        Person P = new Person("Yen Khanh", 1997, 1);
        P.print();
        //P.name = Console.ReadLine();
        //P.yearofBirth = int.Parse(Console.ReadLine());
        Person P1 = new Person("Han So Hee", 1994, 0);
        P1.print();
        Console.ReadKey();
    }
}

