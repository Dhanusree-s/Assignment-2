using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2

{
    class NegativeElements
    {
    
        static void Main(string[] args)
        {
          int limit = 0;
          int[] num = new int[25];
          int[] oddNum = new int[25];

          Console.WriteLine(" store all negative elements in an array to another array :");

          Console.WriteLine(" Enter the limit :");
          limit = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("Enter the elements:");
          for (int i = 1; i <= limit; i++)
          {
              num[i] = Convert.ToInt32(Console.ReadLine());
          }
          Console.WriteLine("The negative elements in the array are:");

          for (int i = 1; i <= num.Length; i++)
          {
              if (num[i] < 0)
              {
                oddNum[i] = num[i];
                Console.WriteLine(" " + oddNum[i]);
              }
          }
          Console.ReadKey();
        }
    }
 }



