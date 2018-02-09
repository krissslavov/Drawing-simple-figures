using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                
                Console.Write(new string(' ', n - row));

                for(int row2=0; row2<row; row2++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
               
            }

            for (int row = n - 1; row >= 1; row--)
            {
                
                Console.Write(new string(' ', n - row));
                for(int row2=0; row2<row; row2++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }

       /* static string repeatStr(string str, int count)
        {
            string text = "";

            for (int i = 0; i < count; i++)
            {
                text += str;
            }

            return text;
        }
        */
    }
}
