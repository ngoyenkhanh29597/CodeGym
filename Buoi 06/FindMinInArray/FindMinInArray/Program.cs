namespace FindMinInArray;
class Program
{
    public static int minElement(int[] array)
    {
        int minvalue = 0;
        for (int j = 0; j < array.Length; j++)
        {
            if (minvalue < array[j]) minvalue = array[j];
            else continue;
        }
        return minvalue;
    }

    static void Main(string[] args)
    {
        int size;
        int[] array;

        //INITIAL ARRAY
        Console.Write("Enter size of the array: ");
        size = int.Parse(Console.ReadLine());

        //Enter the value of intial array
        array = new int[size];
        int i = 0;
        while (i < size)
        {
            Console.Write("Enter element [" + (i + 1) + "]: ");
            array[i] = int.Parse(Console.ReadLine());
            i++;
        }
        //Print the entered array on the screen
        Console.WriteLine("Array list: ");
        for (int j = 0; j < array.Length; j++)
        {
            Console.Write(array[j] + " ");
        }

        //Use function to display the min value in the array
        Console.WriteLine("\nMinimum element in the array is: " + minElement(array));
        Console.ReadKey();
    }
}

