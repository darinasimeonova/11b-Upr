using System;
using System.Linq;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                var command = input[0];
                if (command == "end")
                {
                    Console.WriteLine(string.Join(",", nums));
                }
                else if (command == "statistic")
                {
                    Console.WriteLine("count=" + nums.Count);
                    Console.WriteLine("sum=" + nums.Sum());
                }
                else if (command == "contains")
                {
                    var element = int.Parse(input[1]);

                    if (nums.Contains(element))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        nums.Add(element);
                    }
                }
                else if (command == "remove")
                {
                    var index = int.Parse(input[1]);

                    if (index <0 || index > nums.Count)
                    {
                        Console.WriteLine("Incorrect index");
                    }
                    else
                    {
                        nums.RemoveAt(index);
                    }
                }
            }
        }
    }
}
