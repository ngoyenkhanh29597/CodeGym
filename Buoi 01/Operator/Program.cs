using System;
namespace Operator
    {
        class Program
        {
            static void Main(string[] args)
            {
                float width;
                float height; 
                Console.Write("Enter width of rectangle: ");
                width = float.Parse(Console.ReadLine());
                Console.Write("Enter height of rectangle: ");
                height = float.Parse(Console.ReadLine());
                float area = width * height;
                Console.WriteLine("The area is: " + area);
            }
        }
    }
