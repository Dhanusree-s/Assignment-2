using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class SubString
    {
        static void Main(string[] args)
        {
            string str1, str2;
            bool m;
            Console.WriteLine(" \n Check whether the given substring is present is in the given string:\n ");

            Console.WriteLine("Input the string: ");
            str1 = Console.ReadLine();

            Console.WriteLine(" Input the substring to be searched: ");
            str2 = Console.ReadLine();

            m = str1.Contains(str2);

           if(m)
            {
                Console.WriteLine("The substring exists in the given string \n\n");

            }

            else
            {
                Console.WriteLine(" The substring doesn't exists in the given string \n\n");
            }

        }
    
    }
}
