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
                if (command == "Reverse")
                {
                    input = input.Reverse().ToArray();
                }
                else if (command == "Distinct")
                {
                    input = input.Distinct().ToArray();
                }
                else if (command == "Replace")
                {
                    int index = int.Parse(cmd[1]);
                    string strForReplace = cmd[2];
                    input[index] = strForReplace;
                }
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
