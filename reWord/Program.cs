using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reWord
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Введите строку");

            string word = Console.ReadLine();

            int length = word.Length;

            string reword = "";

            for (int i = length; i >= 1; i--)

            {
              reword += word[i - 1];
            }

            Console.WriteLine(reword);
           



         /* используя массив

            Console.Write("Введите строку: ");

            string word = Console.ReadLine(); 

            char[] reword = word.ToCharArray(); 

            int last = word.Length - 1; 

            for (int n = last; n >= 0; n--) Console.Write(word[n]); 
         */

            Console.ReadLine();

        }
    }
}
