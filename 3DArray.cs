using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class _3DArray
    {
        static void Main(string[] args)
        {
            int[,,] array3D = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };
            Console.WriteLine(" 3D Array Elements Are.....");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int K = 0; K < 2; K++)

                    {
                        Console.WriteLine("a[{0},{1},{2}] = {3}", i, j, K, array3D[i, j, K]);
                    }
                }
            }

            Console.WriteLine(" PRESS ENTER KEY TO EXIT.......");
            Console.ReadKey();


        }
    }
}
