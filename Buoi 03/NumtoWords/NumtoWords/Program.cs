using System;

class NumberRead
{
    static string[] ones = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" }; //Declare number below 20

    static string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" }; //Declare array of first numbers in tens

    static string[] scales = { "", "thousand", "million", "billion" }; //Declare array of number scales

    static void Main(string[] args)
    {
        Console.Write("Enter the number: "); //Input
        int number = int.Parse(Console.ReadLine());

        string numberInWords = NumberToWords(number); //Output
        Console.WriteLine("Number {0} in words is: {1}", number, numberInWords);

        Console.ReadKey();
    }

    static string NumberToWords(int number)
    {
        if (number == 0)
            return "Zero";

        if (number < 0)
            return "Negative " + NumberToWords(Math.Abs(number));

        string words = ""; //initialize word form of number

        for (int i = 0; number > 0; i++)
        {
            if (number % 1000 != 0)
            {
                string word = ConvertThreeDigitsToWords(number % 1000);
                words = word + " " + scales[i] + " " + words;
            }

            number /= 1000;
        }

        return words.Trim(); //result of function is words whose space is trimmed 
    }

    static string ConvertThreeDigitsToWords(int number)
    {
        string word = "";

        if (number >= 100)
        {
            word += ones[number / 100] + " hundred ";
            number %= 100;
        }

        if (number >= 20)
        {
            word += tens[number / 10] + " ";
            number %= 10;
        }

        if (number > 0)
        {
            word += ones[number] + " ";
        }

        return word.Trim(); // result of function is words whose space is trimmed
    }
}
