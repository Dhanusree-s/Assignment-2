using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2

{
    class Properties

    {
        static void printarray(int[]arr)
        {
            Console.WriteLine(" \n ELEMENTS OF AN ARRAY IS : \n");
            foreach( int i in arr)
            {
                Console.WriteLine("\t{0}", i);

            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)

        {
            // Initializing and sorting values in array

            int[] arr1 = new int[5] { 43, 25, 33, 14, 5 };
            int[] arr2 = new int[5];
            int len, rank;
            bool fixedsize, read_only;


            // check array length
            len = arr1.Length;
            Console.WriteLine("Length:\t{0}", len);
            

            // check array rank
            rank = arr1.Rank;
            Console.WriteLine("Rank:\t{0}", rank);

            // check whether array is of fizedsize or not 
            fixedsize = arr1.IsFixedSize;
            Console.WriteLine("Fixed Size :\t{0}", fixedsize);


            // check whether the array is read only or not
            read_only = arr1.IsReadOnly;
            Console.WriteLine("ReadOnly :/t{0}", read_only);


            // sort any array
            Array.Sort(arr1);
            printarray(arr1);


            // returning length from specified position 
            Console.WriteLine("Get Length :\t{0}", arr1.GetLength(0));


            // returns value of spectified postion
            Console.WriteLine(" Get Value :\t{0}", arr1.GetValue(2));



            // returns index position of specified value
            Console.WriteLine("Get Index :\t{0} ", Array.IndexOf(arr1, 43));


            // copying arr1's elements to arr2
            Array.Copy(arr1, arr2, 5);
            printarray(arr2);

            // removing elements from array
            Array.Clear(arr1, 0, 2);
            printarray(arr1);

            Console.ReadKey();

        }


    }
}

