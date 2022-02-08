using System;
using System.Linq;

namespace Obrabotka_masiv
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string command = cmd[0];
                
                switch (command)
                {
                    case "Reverse": input = input.Reverse().ToArray(); break;
                    case "Distinct": input = input.Distinct().ToArray(); break;
                    case "Replace": input[int.Parse(cmd[1])] = cmd[2];break;
                       
                }
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
