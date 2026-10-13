using System;

namespace OreMinute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h1, m1, x;
            string line = Console.ReadLine();
            string[] tokens = line.Split(" ");
            h1 = int.Parse(tokens[0]);
            m1 = int.Parse(tokens[1]);
            x = int.Parse(tokens[2]);

            int h2, m2;
            m2 = (m1 + x) % 60;
            h2 = h1 + (m1 + x) / 60;
            h2 = h2 % 24;

            Console.WriteLine($"{h2} {m2}");
        }
    }
}
