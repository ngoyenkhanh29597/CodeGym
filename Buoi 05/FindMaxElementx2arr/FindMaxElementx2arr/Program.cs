namespace FindMaxElementx2arr;
class Program
{
    static void Main(string[] args)
    {
        int row, column;
        int[,] matrix;
        Console.Write("Enter the row of matrix: ");
        row = int.Parse(Console.ReadLine());
        Console.Write("Enter the column of matrix: ");
        column = int.Parse(Console.ReadLine());
        matrix = new int[row, column];
        Console.WriteLine("Enter " + matrix.GetLength(0) + " rows and " + matrix.GetLength(1) + " columns: ");
        for (int _row = 0; _row < matrix.GetLength(0); _row++)
        {
            for (int _column = 0; _column < matrix.GetLength(1); _column++)
            {
                Console.Write("Matrix[" + _row + "][" + _column + "] = ");
                matrix[_row, _column] = int.Parse(Console.ReadLine());
            }
        }
        for (int _row = 0; _row < matrix.GetLength(0); _row++)
        {
            Console.WriteLine("\n");
            for (int _column = 0; _column < matrix.GetLength(1); _column++)
            {
                Console.Write(matrix[_row, _column] + " ");
            }
        }
        int maxElement = 0;
        int i = 0;
        int j = 0;
        for (int _row = 0; _row < matrix.GetLength(0); _row++)
        {
            for (int _column = 0; _column < matrix.GetLength(1); _column++)
            {
                if (maxElement < matrix[_row, _column])
                {
                    maxElement = matrix[_row, _column];
                    i = _row;
                    j = _column;
                }
            }
        }
        Console.WriteLine("\n\nThe largest element in matrix is [" + i + "][" + j + "] = " + maxElement);

        Console.ReadKey();
    }
}

