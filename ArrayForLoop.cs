using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class _ArrayForLoop
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            for( int i=0; i<array.Length; i++)
            {
                Console.WriteLine(array[i]);

            }
            Console.WriteLine(" PRESS ANY KEY TO EXIT.....");
            Console.ReadLine();


        }
    }
}
