using System;
using System.Linq;

namespace Bezopasna_obrabotka_masiv
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string command = cmd[0];
                if (command == "END")
                {
                    break;
                }
                switch (command)
                {
                    case "Reverse": input = input.Reverse().ToArray(); break;
                    case "Distinct": input = input.Distinct().ToArray(); break;
                    case "Replace":
                        int index = int.Parse(cmd[1]);
                        string newString = cmd[2];
                        if (index >= 0 && index < input.Length)
                        {
                            input[index] = newString;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
