namespace LoopStatement;
class Program
{
    static void Main(string[] args)
    {
        int x = 0;
        while (x < 3)
        {
            Console.Write("Nhập vào số nguyên của bạn: ");
            x = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Số nguyên cuối cùng: " + x);
        ////in bảng cửu chương 5
        //int X;
        //Console.Write("Nhập bảng cửu chương: ");
        //X = int.Parse(Console.ReadLine());
        //for(int i = 1; i <= 10; i++)
        //{ 
        //    Console.WriteLine(X + " * " + i + " = " + X*i);
        //}
        Console.ReadKey();
    }
}

