using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BirthdayCountdown
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your date of birth: ");
            string birthDay = Console.ReadLine(); //Input.
            string[] arrString = birthDay.Split('/'); //Split string.

            //Console.WriteLine("arrListStr[0] = " + arrString[0]); //Show the string has been splited on screen.
            //Console.WriteLine("arrListStr[1] = " + arrString[1]); //Show the string has been splited on screen.

            int date = int.Parse(arrString[0]); //Convert date from string to int.
            int month = int.Parse(arrString[1]); //Convert month from string to int.
            
            //Calculate number of days to my birthday.
            DateTime now = DateTime.Now; //Get system time.
            DateTime dateCal = new DateTime(now.Year, month, date); //Convert input birthday to DateTime data type.
            TimeSpan diff = dateCal.Subtract(now); //use function to calculate difference between 2 moments.
         
            if (diff.Days < 0) //if the birthday is over.
            {
                int diffDaysNew;
                int diffHoursNew;
                int diffMinutesNew;
                diffHoursNew = diff.Hours + 23;
                diffMinutesNew = diff.Minutes + 59;

                if (DateTime.Now.Year/4==0) //if it is leap year.
                {
                    diffDaysNew = diff.Days + 366; //Leap year is 366 days.
                    Console.WriteLine("{0} days {1} hours {2} minutes to your birthday <3 ", diffDaysNew, diffHoursNew, diffMinutesNew);
                    
                }
                else
                {
                    diffDaysNew = diff.Days + 365; //Non-leap year is 365 days.
                    Console.WriteLine("{0} days {1} hours {2} minutes to your birthday <3 ", diffDaysNew, diffHoursNew, diffMinutesNew);
                }
            }
            if (diff.Days == 0)
            {
                Console.WriteLine("It's today");
            }
            else
            {
                Console.WriteLine("{0} days {1} hours {2} minutes to your birthday <3 ", diff.Days, diff.Hours, diff.Minutes);
            }

            Console.ReadKey();
        }
    }
}


