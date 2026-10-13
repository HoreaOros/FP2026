using System;
namespace Minim3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = n % 10;
            int b = n / 10 % 10;
            int c = n / 100;

            
            int minim = Math.Min(a, Math.Min(b, c));
            int maxim = Math.Max(a, Math.Max(b, c));

            int mid = a + b + c - (minim + maxim);

            Console.WriteLine($"{mid}");
            


            
        }
    }
}
