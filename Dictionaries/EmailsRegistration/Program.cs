using System;
using System.Linq;
using System.Collections.Generic;

namespace EmailsRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string command = input[0];
                if (command == "Stop")
                {
                break;
                }
                else if (command=="Add")
                {
                    string name = input[1];
                    string email = input[2];
                    if (emails.ContainsKey(name))
                    {
                        emails[name] = email;
                    }
                    else
                    {
                        emails.Add(name, email);
                    }
                }
                else if (command=="Sent")
                {
                    string name = input[1];
                    if (emails.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} {emails[name]}");
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
