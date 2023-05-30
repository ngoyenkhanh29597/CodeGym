namespace MaxInArray;
class Program
{
    static void Main(string[] args)
    {
        int size;
        int[] array;

        //Initialize array
        Console.Write("Enter size of array: ");
        size = int.Parse(Console.ReadLine());
        array = new int[size];

        //Enter element of array
        int i = 0;
        while (i < array.Length)
        {
            Console.Write("Enter element [" + (i + 1) + "]: ");
            array[i] = int.Parse(Console.ReadLine());
            i++;
        }

        //Print array
        Console.WriteLine("Array's elements: ");
        for (int j = 0; j < array.Length; j++)
        {
            Console.Write(array[j] + " ");
        }
        Console.WriteLine();

        //Find max element in the array
        int max = 0;
        int maxIndex = 0;
        for (int j = 0; j < array.Length; j++)
        {
            if (max < array[j])
            {
                max = array[j];
                maxIndex = j+1;
            }    
        }
        Console.WriteLine("The max value element in the array is: array[" + maxIndex + "] = " + max);

        Console.ReadKey();
    }
}

