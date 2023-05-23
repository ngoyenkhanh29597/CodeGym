namespace SumofArray;
class Program
{
    static void Main(string[] args)
    {
        TinhTongCacPhanTuMang();
    }

    private static void TinhTongCacPhanTuManglist()
    {
        List<int> a = new List<int>();
        Console.Write("So luong phan tu can nhap: ");

    }

    private static void TinhTongCacPhanTuMang()
    {
        ////Cach 1: dung for nhap vao mang
        //Khai bao mang
        int[] a = new int[10];
        Console.Write("So luong phan tu can nhap: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhap gia tri cac phan tu: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write("Phan tu thu [" + i + "]=");

            //Phan tu thu [0] = ???
            Console.Write("Phan tu thu [" + i + "]=");
            //Luu gia tri vo mang
            a[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        Console.WriteLine("Xuat du lieu vua nhap:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();
        int tong = 0;
        for (int i = 0; i < n; i++)
            tong += a[i];
                Console.WriteLine("Tong gia tri cua mang la: " + tong);
        Console.ReadKey();
            
    }
}
        

