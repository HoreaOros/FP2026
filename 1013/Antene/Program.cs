using System;
namespace Antene
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, n;
            string line = Console.ReadLine();
            string[] tokens = line.Split(" ");

            x = int.Parse(tokens[0]);
            y = int.Parse(tokens[1]);
            n = int.Parse(tokens[2]);

            int ani = 0, zile = 0, ore = 0;

            int oreAn = x * y;
            ani = n / oreAn;
            ore = n % oreAn;

            zile = ore / y;

            ore = ore % y;

            Console.WriteLine(ani);
            Console.WriteLine(zile);
            Console.WriteLine(ore);
        }
    }
}
