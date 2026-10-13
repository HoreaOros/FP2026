using System;
namespace Salut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());

            Console.WriteLine((n - 1) * n / 2);
        }
    }
}
