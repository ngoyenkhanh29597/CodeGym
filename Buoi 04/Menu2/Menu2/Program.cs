namespace Menu2;
class Program
{
    static void Main(string[] args)
    {
        int option;
        do
        { 
        Console.WriteLine("Menu");
        Console.WriteLine("1. Print the rectangle");
        Console.WriteLine("2. Print the square triangle");
        Console.WriteLine("3. Print isosceles triangle");
        Console.WriteLine("4. Exit");
        Console.Write("Choose: ");
        option = int.Parse(Console.ReadLine());
        
            switch (option)
            {
                case 1:
                    Console.Write("\n");
                    int width, length;
                    Console.WriteLine("Enter the dimension of the rectangle:");
                    Console.Write("Length = ");
                    length = int.Parse(Console.ReadLine());
                    Console.Write("Width = ");
                    width = int.Parse(Console.ReadLine());
                    for (int i = 0; i < width; i++)
                    {
                        for (int j = 0; j < length; j++)
                        {
                            Console.Write("*");
                        }
                        Console.Write("\n");
                    }
                    Console.Write("\n");
                    break;

                case 2:
                    Console.Write("\n");
                    int edge_1;
                    Console.WriteLine("Enter edge 1 of the triangle");
                    Console.Write("Edge = ");
                    edge_1 = int.Parse(Console.ReadLine());
                    int corner;
                    Console.WriteLine("1. Top-left");
                    Console.WriteLine("2. Top-right");
                    Console.WriteLine("3. Bottom-left");
                    Console.WriteLine("4. Bottom-right");
                    Console.Write("Which square angle do you want to draw: ");
                    corner = int.Parse(Console.ReadLine());
                    switch (corner)
                    {
                        case 1:
                            Console.WriteLine("Square angle at Top-left");
                            for (int i = 0; i < edge_1; i++)
                            {
                                for (int j = 0; j < edge_1 - i; j++)
                                {
                                    Console.Write("*");
                                }

                                Console.Write("\n");
                            }
                            break;

                        case 2:
                            Console.WriteLine("Square angle at Top-right");
                            for (int i = 0; i < edge_1; i++)
                            {
                                for (int k = 0; k < i + 1; k++)
                                {
                                    Console.Write(" ");
                                }
                                for (int j = 0; j < edge_1 - i; j++)
                                {
                                    Console.Write("*");
                                }

                                Console.Write("\n");
                            }
                            break;

                        case 3:
                            Console.WriteLine("Square angle at Bottom-left");
                            for (int i = 0; i < edge_1; i++)
                            {
                                for (int j = 0; j < i + 1; j++)
                                {
                                    Console.Write("*");
                                }

                                Console.Write("\n");
                            }
                            break;

                        case 4:
                            Console.WriteLine("Square angle at Bottom-right");
                            for (int i = 0; i < edge_1; i++)
                            {
                                for (int k = 0; k < edge_1 - i ; k++)
                                {
                                    Console.Write(" ");
                                }
                                for (int j = 0; j < i + 1; j++)
                                {
                                    Console.Write("*");
                                }

                                Console.Write("\n");
                            }
                            break;


                    }
                
                    Console.Write("\n");
                    break;

                case 3:
                    int height;
                    Console.Write("\n");
                    Console.Write("Enter height of the isosceles triangle: ");
                    height = int.Parse(Console.ReadLine());
                    for (int i = 0; i < height; i++) //Print rows according to the total height
                    {
                        for (int j = 0; j < height - i - 1; j++) //Print space " " to shift the top of triangle to center
                        {
                            Console.Write(" ");
                        }
                        for (int k = 0; k < 2 * i + 1; k++) //Print * to draw the triangle
                        {
                            Console.Write("*");
                        }
                        Console.Write("\n");
                    }
                    Console.Write("\n");
                    break;

                case 4:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("No Choice");
                    break;
            }
        } while (option != 0);
        Console.ReadKey();  
    }
}



