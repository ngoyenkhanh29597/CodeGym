namespace InsertElement;
class Program
{
    static void Main(string[] args)
    {
        int size, element_num, pos, insert_val;
        int[] array;
        int[] array_medium;
        

        //INTIAL ARRAY
        Console.Write("Enter size of the array: ");
        size = int.Parse(Console.ReadLine());

        do //if the number of added element is bigger than the size, enter again 
        {
            Console.Write("Enter the number of element you want to add: ");
            element_num = int.Parse(Console.ReadLine());
        } while (element_num > size);

        //Enter the value of intial array
        array = new int[size];
        array_medium = new int[size]; //Use a medium array to contain value of element so that it does not effect the original array
        int i = 0;
        while (i < element_num)
        {
            Console.Write("Enter element [" + (i + 1) + "]: ");
            array[i] = int.Parse(Console.ReadLine());
            array_medium[i] = array[i];
            i++;
        }
        //Print the entered array on the screen
        Console.WriteLine("Array list: ");
        for (int j = 0; j < array.Length; j++)
        {
            Console.Write(array[j] + " ");
        }

        //INSERT NEW VALUE TO THE ARRAY
        do //Check if the position is out of range of the array
        {
            Console.Write("\nEnter the position you want to insert: ");
            pos = int.Parse(Console.ReadLine());
        } while (pos > size);
        
        Console.Write("Enter the value you want to insert: ");
        insert_val = int.Parse(Console.ReadLine());

        array[pos - 1] = insert_val;
        for (int j = pos - 1; j < array.Length - 1; j++)
        {
            array[j + 1] = array_medium[j];
        }

        Console.WriteLine("New array list: ");
        for (int j = 0; j < array.Length; j++)
        {
            Console.Write(array[j] + " ");
        }

        Console.ReadKey();
    }
}

