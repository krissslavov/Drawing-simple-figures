using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_of_10_x_10_Stars
{
   public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //top frame
            Console.Write("+ ");
            for(int i=0; i<n-2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");

            for(int row=1; row<=n-2; row++)
            {
                Console.Write("| ");
                for (int col = 1; col <= n-2; col++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("|");
            }

            //bottom frame
            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");

        }
    }
}
