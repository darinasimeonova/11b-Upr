using System;
using System.Collections.Generic;
using System.Linq;


namespace zad1
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
             int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 100)
                {
                    sum = sum + arr[i];
                }
            }

            Console.WriteLine("sum" + sum);
            Console.WriteLine(String.Join("=>",arr));
        }
    }
}
