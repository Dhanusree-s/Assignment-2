using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class _2DArray
    {
        static void Main(string[] args)
        {
            int[,] array2D = new int[3, 2] { { 4, 5 }, { 5, 0 }, { 3, 1 } };
            Console.WriteLine(" 2D Array Elements Are.....");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0},{1}] = {2}", i, j, array2D[i, j]);
                    Console.ReadKey();
                }
            }
        }
    }
}
