namespace Array;
class Program
{
    static void Main(string[] args)
    {
        int[] b = { 8, 9, 4, 10, 6 };
        //[0; len-1]
        for (int i = 0; i < b.Length; i++)
            Console.Write(b[i] + " ");
        Console.WriteLine();

        Console.WriteLine("Dung lenh for each");
        foreach (int i in b) //nhanh hon rat nhieu so voi for
            Console.Write(i + " ");
        Console.WriteLine();

        Console.WriteLine("Viet gon hon:");
        Console.WriteLine(string.Join(" | ",b));


        Console.ReadKey();

        /***
        int[] a = new int[5];
        int[] b = { 8, 9, 4 };
		//int c  = new int[5] { 5, 2, 4 };
		int[] d  = new int[5] { 5, 2, 4, 7, 1 };
		int[] e  = new int[] { 3, 4, 7 };
        Console.ReadKey();
        //Check phần tử đầu tiên a[0] = 0, b[0],..,         b[0] = 8
        //Check phần tử thứ 5 a[5] = error, b[5] = error,   b[5] = error
        //Check phần tử thứ 7 a[7] = errpr. b[7] = error,   b[7] = error
        ***/
    }
}

