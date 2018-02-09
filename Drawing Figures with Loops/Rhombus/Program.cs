using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n <= 2)
            {
                Console.WriteLine(new string('*', n));
            }
            else
            {
                int middleDashes = 0;
                int sideDashes = (n - 2) / 2;
                int topHeight = n / 2;
                if(n%2 == 1)
                {
                    Console.WriteLine("{0}*{0}", new string('-', (n-1)/2));
                    middleDashes = 1;
                }

                for (int row = 0; row < topHeight; row++)
                {
                    Console.WriteLine("{0}*{1}*{0}", 
                        new string('-', sideDashes), 
                        new string('-', middleDashes));

                    sideDashes--;
                    middleDashes += 2;
                }

                sideDashes = 1;
                middleDashes = n - 4;

                for (int row = topHeight-1; row >= 1; row--)
                {
                    Console.WriteLine("{0}*{1}*{0}",
                        new string('-', sideDashes),
                        new string('-', middleDashes));

                    sideDashes++;
                    middleDashes -= 2;

                }

                if(n%2 == 1)
                {
                    Console.WriteLine("{0}*{0}", new string('-', (n - 1) / 2));
                    middleDashes = 1;
                }



            }// end BIG else
        }
    }
}
