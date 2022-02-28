using System;
using System.Collections.Generic;
using System.Linq;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string command = Console.ReadLine();
                if(command == "end")
                {
                    Console.WriteLine(string.Join(" ", nums));
                    break;
                }

                string[] elements = command.Split();

                switch (elements[0])
                {
                    case "remove":
                        int  indexToRemove = int.Parse(elements[1]);
                        nums.RemoveAt(indexToRemove);
                        break;

                    case "contains":
                        int numberToSearch = int.Parse(elements[1]);
                        Console.WriteLine(nums.IndexOf(numberToSearch));
                        break;

                    case "statistic":
                        nums.Sum();
                        break;
                }
            }
        }
    }
}
