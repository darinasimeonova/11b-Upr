using System;
using System.Linq;

namespace Masiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int br = 0; int sum = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i]>5)
                {
                    br++;
                }
                if (arr[i] % 2 == 0)
                {
                    sum = sum + arr[i];
                }
            }
            Console.WriteLine("count =" + br);
            Console.WriteLine("sum =" + sum);
            Console.WriteLine("average=" + arr.Average());
            Console.WriteLine("count=" + arr.Count(x => x>5));

        }
    }
}
