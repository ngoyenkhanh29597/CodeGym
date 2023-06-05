namespace CountRepeatString;
class Program
{
    static void Main(string[] args)
    {
        string input;
        Console.Write("Enter a string: ");
        input = Console.ReadLine();
        Console.WriteLine("The input string: " + input);

        Console.Write("Enter the letter that need to search: ");
        //char letter = Console.ReadKey().KeyChar;
        char letter = char.Parse(Console.ReadLine());

        Console.WriteLine("Number of repeatitions of the letter " + letter + " in string " + input + " is " + countinString(input, letter));


        Console.ReadKey();
    }
    static int countinString(string inputString, char letter)
    {
        int count = 0;
        foreach (char letter_for in inputString)
        {
            if (letter_for == letter)
            {
                count++;
            }
        }
        return count;
    }
}

