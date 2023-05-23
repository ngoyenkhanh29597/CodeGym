namespace FindElementInArray;
class Program
{
    static void Main(string[] args)
    {
        string[] players = { "Keylor Navas", "Iker Casillas", "Dani Carvajal", "Pepe", "Cristiano Ronaldo", "Karim Benzema", "Marcelo", "Luka Modric", "Toni Kroos", "Casemiro", "Gareth Bale", "Angel Di Maria", "Isco", "James Rodriguez", "Lucas Vasquez", "Nacho Fernandez" };
        Console.WriteLine("Enter a name’s player:");
        string input_name = Console.ReadLine();

        bool isExist = false;
        for (int i = 0; i < players.Length; i++)
        {
            if (players[i].Equals(input_name))
            {
                Console.WriteLine("Position of player " + input_name + " in the list is: " + (i + 1));
                isExist = true;
                break;
            }
        }
        if (!isExist)
        {
            Console.WriteLine("Not found" + input_name + " in the list.");
        }
        Console.ReadKey();
    }
}

