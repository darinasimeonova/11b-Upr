using System;
using System.Collections.Generic;
using System.Linq;

namespace TelefonenUkazatel
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> ukazatel = new Dictionary<string, string>();
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string command = input[0];
                if (command == "END")
                {
                    break;
                }
                else if (command == "A")
                {
                    string name = input[1];
                    string tel = input[2];
                    if (ukazatel.ContainsKey(name))
                    {
                        ukazatel[name] = tel;
                    }
                    else
                    {
                        ukazatel.Add(name, tel);
                    }
                }
                else if (command == "S")
                {
                    string name = input[1];
                    if (ukazatel.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {ukazatel[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
            }
        }
    }
}
