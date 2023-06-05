class Program
{
    static void Main()
    {
        // Intial array
        int size, element_num;
        Console.Write("Enter size of the array: ");
        size = int.Parse(Console.ReadLine());

        do //if the number of added element is bigger than the size, enter again 
        {
            Console.Write("Enter the number of element you want to add: ");
            element_num = int.Parse(Console.ReadLine());
        } while (element_num > size);
        
        int[] array = initialArray(size, element_num); //Call function

        Console.WriteLine("Original array: ");
        PrintArray(array);

        //Remove value in the array
        //Enter the removal value
        Console.Write("Enter the value to remove in the array: ");
        int valueToDelete = int.Parse(Console.ReadLine());
        
        int[] finalArray = removeValue(array, valueToDelete); //Call function

        Console.WriteLine("The final array: ");
        PrintArray(finalArray);
    }

    static void PrintArray(int[] arr) //Print array function
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
    static int[] initialArray(int size, int element_num) //Initilize array function
    {
        int[] array;
        array = new int[size];
        int i = 0;
        while (i < element_num)
        {
            Console.Write("Enter element [" + (i + 1) + "]: ");
            array[i] = int.Parse(Console.ReadLine());
            i++;
        }
        return array;
    }
    static int[] removeValue(int[] array, int valueToDelete) //Removing value in the array function
    {
        // Remove values in the array
        int countDeleted = 0;
        List<int> resultList = new List<int>();
        foreach (int num in array)
        {
            if (num == valueToDelete)
            {
                countDeleted++;
            }
            else
            {
                resultList.Add(num);
            }
        }

        int[] newArray = resultList.ToArray();

        // Covert null value to 0
        int newSize = newArray.Length + countDeleted;
        int[] finalArray = new int[newSize];
        for (int j = 0; j < newSize; j++)
        {
            if (j < newArray.Length)
            {
                finalArray[j] = newArray[j];
            }
            else
            {
                finalArray[j] = 0;
            }
        }
        return finalArray;
    }
}