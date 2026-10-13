using System;
namespace Bisect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Bisect(n)? "bisect": "nebisect");
        }

        private static bool Bisect(int n)
        {
            return (n % 4 == 0 && n % 100 != 0) || (n % 400 == 0);
        }
    }
}
