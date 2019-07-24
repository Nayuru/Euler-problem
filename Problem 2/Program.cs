using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem_2
{
    class Program
    {
        //We first create a function to generate all Fibonnaci number.
        static List<int> GenerateFibonnaci()
        {
            List<int> fibonnaciNumbers = new List<int>();
            fibonnaciNumbers.Add(1);
            fibonnaciNumbers.Add(2);
            while (fibonnaciNumbers.Last() < 4000000)
            {
                int last_index = fibonnaciNumbers.Count - 1;
                int before_last_index = fibonnaciNumbers.Count - 2;
                fibonnaciNumbers.Add(fibonnaciNumbers.ElementAt(last_index) + (fibonnaciNumbers.ElementAt(before_last_index)));
            }

            //We remove the last element, greater than 4.000.000. We could do a filtering on the list, and remove all elements greater than 4.000.000 too.
            fibonnaciNumbers.RemoveAt(fibonnaciNumbers.Count - 1);

            return fibonnaciNumbers;
        }

        //Here, we just filter the list and creating a new one, minus the odd numbers.
        static List<int> RemoveAllOddsFromList(List<int> list)
        {
            return list.Where(number => number % 2 == 0).ToList();

        }

        //Display list method.
        static void DisplayList(List<int> list)
        {
            Console.Write("| ");
            foreach (int element in list)
            {
                Console.Write($"{element} | ");
            }
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            //Sugar.
            List<int> result = GenerateFibonnaci();
            Console.WriteLine("Displaying all Fibonnaci suite's numbers before 4.000.000");
            DisplayList(result);
            Console.WriteLine("");
            Console.WriteLine("After filtering, we only want odds.");

            List<int> only_evens = RemoveAllOddsFromList(result);
            DisplayList(only_evens);

            Console.WriteLine("");
            Console.WriteLine("The sum of all even Fibonnaci suite's number before 4.000.000 is : ");
            Console.WriteLine(only_evens.Sum());
            Console.ReadLine();
        }
    }
}
