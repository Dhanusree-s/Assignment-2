using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2

{
    class ArraySorting
    {
        static void Main(string[] args)
        {
            // Array of integers

            int[] intArray = new int[] {
             9,
             2,
             4,
             3,
             1,
             5
        };

            Console.WriteLine("Original array");
            foreach (int i in intArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            // Sort array in ASCENDING order

            Console.WriteLine("Sorted array in ASCENDING order");
            Array.Sort(intArray);

            foreach (int i in intArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // Sort Array in DESC order

            Console.WriteLine("Sorted array in DESCENDING order");

            Array.Reverse(intArray);
            foreach (int i in intArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadLine();

        }

    }
}



        