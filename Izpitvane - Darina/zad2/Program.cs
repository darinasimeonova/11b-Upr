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
                if (command == "stop")
                {
                    Console.WriteLine(string.Join(" ", nums));
                }
                else if (command == "statistic")
                {
                    Console.WriteLine("count=" + nums.Count);
                    Console.WriteLine("sum=" + nums.Max());
                }
                else if (command == "contains")
                {
                    var element = int.Parse(input[1]);

                    if (nums.Contains(element))
                    {
                        nums.RemoveAt(element);
                    }
                    else
                    {
                        nums.Add(element);
                    }
                }
                else if (command == "remove")
                {
                    var index = int.Parse(input[1]);

                    if (index < 0 || index > nums.Count)
                    {
                        Console.WriteLine("Incorrect index");
                    }
                    else
                    {
                        nums.RemoveAt(index);
                    }
                }
                else if (command == "find")
                {
                    if (nums.Contains())
                    {
                        Console.WriteLine("Not found");
                    }
                    else
                    {
                        nums.Add();
                    }
                }      
            }
        }
    }
}
