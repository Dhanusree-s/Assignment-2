using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class TotalNoOfWords
    {

        static void Main(string[] args)
        {
            string str;
            int  word, l;

            Console.WriteLine("\n\n Count The Total No: Of Words In A String:\n");
            Console.WriteLine("   \n");
            Console.WriteLine(" INPUT THE STRING:");
            str = Console.ReadLine();


            l = 0;
            word = 1;


            while ( l <= str.Length - 1 )
            {
                if( str[l] == ' ' || str[l] == '\n'  || str[l] == '\t' )
                {
                    word++;
                }
                l++;
            }
          

            Console.WriteLine(" Total No: Of Words In A String Is :{0}\n", word);


        }
    }
}
