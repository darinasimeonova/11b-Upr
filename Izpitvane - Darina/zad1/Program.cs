
using System;
using System.Linq;
using System.Collections.Generic;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int input = int.Parse(Console.ReadLine());
            
            if (input <= 10 )
            {
                Console.WriteLine(string.Join(" ", input));
            }
            else if ()
            {

            }
            

            Console.WriteLine(String.Join("-", input));

        }
    }
}
