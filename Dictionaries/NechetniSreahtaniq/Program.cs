using System;
using System.Collections.Generic;
using System.Linq;

namespace NechetniSreahtaniq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            var counts = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                   // counts.Add(word, 1);
                }
            }
            List<string> list = new List<string>();
            foreach (var pair in counts)
            {
                if (pair.Value%2!=0)
                {
                    list.Add(pair.Key);
                }
            }

            Console.WriteLine(string.Join(",", list));
        }
    }
}
