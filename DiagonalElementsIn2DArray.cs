using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_2
{
    class DiagonalElementsIn2DArray
    {
        public static void Main()
        {
            int[,] array = { { 1, 6, 3, 2, 5 }, { 2, 7, 2, 8, 7 }, { 3, 8, 1, 6, 4 }, { 4, 9, 0, 5, 0 }, { 5, 4, 7, 3, 9 } };

            int rowlength = array.GetLength(0);
            int columnlength = array.GetLength(1);

            Console.WriteLine("INPUT THE 2D ARRAY");

            for (int row = 0; row < rowlength; row++)
            {
                for (int column = 0; column < columnlength; column++)
                {
                    Console.Write(array[row, column] + " ");

                }
                Console.WriteLine();

            }
            ArrayDiagonal(array, rowlength, columnlength);
        }
        public static void ArrayDiagonal(int[,] array, int rowlength , int columnlength)
        {
            int sum = 0;
            Console.WriteLine("\n\n DIAGONAL ARRAY ELEMENTS :");

            for (int row = 0; row < rowlength; row++)
            {
                for (int column = 0; column < columnlength; column++)
                {
                    Console.WriteLine("  ");
                    if (row == column)
                    {
                        Console.Write(array[row, column] + " ");
                        sum += array[row, column];

                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n DIAGONAL ARRAY ELEMENTS :" + sum);









        }
    }
}
