using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem_1
{
    class Program
    {
        static int Get_Total_With_Maths()
        {
            //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
            //Find the sum of all the multiples of 3 or 5 below 1000.
            //We need to check every number between 1 and 1000. If they are multiples of 3, or 5, we add it in our 'total' variable.

            int total = 0;
            for (int n = 0; n < 1000; n++)
            {
                if (n % 3 == 0 || n % 5 == 0)
                {
                    total += n;
                }
            }
            return total;
        }

        static int Get_Total_With_Maths_And_Logic()
        {
            //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
            //Find the sum of all the multiples of 3 or 5 below 1000.
            //We need to check every number between 1 and 1000. If they are multiples of 3, or 5, we add it in our 'total' variable.

            int total = 0;
            for (int n = 0; n < 1000; n++)
            {
                if (n.ToString().EndsWith("0") || n.ToString().EndsWith("5") || n % 3 == 0)
                {
                    total += n;
                }
            }
            return total;
        }

        static void Main(string[] args)
        {
           

            Console.WriteLine("Beginning to calculate the sum of all multiples of 3 or 5 below 1000 with only Maths...");
            Stopwatch sw;

            sw = Stopwatch.StartNew();
            int sum = Get_Total_With_Maths();

            Console.WriteLine($"The sum of all multiples of 3 or 5 below 1000 is {sum}");
            Console.WriteLine($"Time it took to calculate it with only maths : {sw.ElapsedTicks} ticks");
            sw.Stop();


            Console.WriteLine("Beginning to calculate the sum of all multiples of 3 or 5 below 1000 with maths and string conversion...");
            sw = Stopwatch.StartNew();
            sum = Get_Total_With_Maths_And_Logic();

            Console.WriteLine($"The sum of all multiples of 3 or 5 below 1000 is {sum}");
            Console.WriteLine($"Time it took to calculate it with maths and string conversion : {sw.ElapsedTicks} ticks");
            sw.Stop();
            Console.ReadLine();

        }
    }
}
