using System;
namespace Exercises
{
    class SumOfDiagonals
    {
        static void Main(string[] args)
        {
            int MaxRow, MaxCol, Sum = 0;
            int[,] Matrix;
            Console.WriteLine("\n---------- SUM OF DIAGONAL OF A MATRIX ----------\n");
            Console.Write("\nEnter the number of rows: ");
            MaxRow = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the number of columns: ");
            MaxCol = Convert.ToInt32(Console.ReadLine());
            if (MaxRow != MaxCol)
            {
                Console.WriteLine("\nThe Dimensions entered are not of Square Matrix.");
                Console.WriteLine("\nExiting the Program..");
                return;
            }
            Matrix = new int[MaxRow, MaxCol];
            for (int i = 0; i < MaxRow; i++)
            {
                for (int j = 0; j < MaxCol; j++)
                {
                    Console.Write("\nEnter the ({0},{1})th element of the matrix: ", (i + 1), (j + 1));
                    Matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nThe entered Matrix is: ");
            for (int i = 0; i < MaxRow; i++)
            {
                for (int j = 0; j < MaxCol; j++)
                {
                    Console.Write(" " + Matrix[i, j]);
                    if (i == j)
                    {
                    Sum += Matrix[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nThe Sum of Diagonal is " + Sum);
        }
    }
}