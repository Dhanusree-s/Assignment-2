using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Vowels
    {

        static void Main(string[] args)
        {
            string str;
            int i, len, vowel_count, cons_count;

            vowel_count = 0;
            cons_count = 0;
            str = "Dhanusree";
            len = str.Length;

            for (i = 0; i < len; i++)
            {
                if (str[i] == 'a' || str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    vowel_count++;
                }

                else
                {
                    cons_count++;
                }



            }
            Console.WriteLine("\n COUNT OF VOWELS IN THE STRING : {0} \n", vowel_count);
            Console.WriteLine("\n COUNT OF CONSONANTS IN THE STRING : {0} \n", cons_count);

        }


    }
}

