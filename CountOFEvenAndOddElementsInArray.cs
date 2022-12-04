using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class CountOFEvenAndOddElementsInArray
    {
        
            static void Main(string[] args)
            {
                

                int size, even, odd;
                int[] arr;

                
                Console.Write("Enter size of the array: ");
                size = Convert.ToInt32(Console.ReadLine());

                
                Console.WriteLine("Enter {0} elements in array:", size);

                arr = new int[size];
                for (int i = 0; i < size; i++)
                {
                    Console.Write("Number({0}) :", i + 1);
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                 
                even = 0;
                odd = 0;
                for (int i = 0; i < size; i++)
                {
                    //If the current element of array is even then increment even count 
                    if (arr[i] % 2 == 0)
                    {
                        even++;
                    }
                    else
                    {
                        odd++;
                    }
                }
            
            Console.Write("Total even elements: {0}\n", even);
            Console.Write("Total odd elements: {0}", odd);
 
            Console.ReadLine();
            }
    }


}
