namespace Function;
class Program
{
    static void Main(string[] args)
    {
        #region BaiTapNhap3So
        ////Viet chuong trinh tinh tong 3 so
        //int a, b, c;
        //Nhap3So(out a, out b, out c);

        //Console.WriteLine("Tong cua 3 so vua nhap = " + TinhTong3So(a, b, c));
        //Console.WriteLine("Tong cua 3 so vua nhap = " + TinhTich3So(a, b, c));
        #endregion

        int x, y;
        Console.Write("Nhap gia tri 2 so nguyen: ");
        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());
        Swap2(ref x, ref y);
        Console.ReadKey();
    }

    private static void Nhap3So(out int a, out int b, out int c)
    {
        Console.Write("Nhap gia tri 3 so nguyen: ");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
    }

    private static int TinhTong3So(int a, int b, int c)
    { 
        
        return (a + b + c);
    }

    private static int TinhTich3So(int a, int b, int c)
    {
        return (a * b * c);
    }

    private static void Swap(ref int x, ref int y)
    {
        Console.WriteLine("So vua nhap: " + x + y);
        int tam = 0;
        tam = x;
        x = y;
        y = tam;
        Console.WriteLine("So sau khi hoan vi: " + x + y);
    }

    private static void Swap2(ref int x, ref int y)
    {
        Console.WriteLine("So vua nhap: " + x + y);
        x = x + y;
        y = x - y; 
        x = x - y; 
        Console.WriteLine("So sau khi hoan vi: " + x + y);
    }
}

