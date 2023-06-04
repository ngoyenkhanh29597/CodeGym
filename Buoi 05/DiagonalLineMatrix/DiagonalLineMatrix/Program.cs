namespace DiagonalLineMatrix;
class Program
{
    static void Main(string[] args)
    {
        int row, column;
        int[,] matrix;
        do //Check if the matrix is square (row = column)
        {
            Console.Write("Enter the row of matrix: ");
            row = int.Parse(Console.ReadLine());
            Console.Write("Enter the column of matrix: ");
            column = int.Parse(Console.ReadLine());
        } while (row != column);

        //Enter elements in the matrix
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

        //Print the matrix on screen
        for (int _row = 0; _row < matrix.GetLength(0); _row++)
        {
            Console.WriteLine("\n");
            for (int _column = 0; _column < matrix.GetLength(1); _column++)
            {
                Console.Write(matrix[_row, _column] + " ");
            }
        }

        //Find the diagonal line
        int sumDiagonal = 0;
        for (int _row = 0; _row < matrix.GetLength(0); _row++)
        {
            for (int _column = 0; _column < matrix.GetLength(1); _column++)
            {
                if (_row == _column) //the diagonal line of square matrix is arranged by elments which have row = column in their position
                    sumDiagonal = sumDiagonal + matrix[_row, _row];
                else continue;
            }
        }
        Console.WriteLine("\n\nThe diagonal line value in matrix is: " + sumDiagonal);

        Console.ReadKey();
    }
}

