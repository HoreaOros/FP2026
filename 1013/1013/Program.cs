using System.Numerics;

namespace _1013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variabile, Tipuri de date fundamentale, operatori, expresii
            int n; // 32 biti [-2^31, 2^31 - 1]
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            n = 0x12;
            Console.WriteLine(n);


            do
            {
                string line = Console.ReadLine();

                try
                {
                    n = int.Parse(line);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                break;
            } while (true);
            
            Console.WriteLine($"Numarul introdus este: {n}");
            Console.WriteLine("Numarul introdus este: {0}, n*n={1}", n, n*n);

            BigInteger b = new BigInteger(150000);
            Console.WriteLine(b * b);


            // int - 32 biti
            // uint - 32 biti, [0, 2^32 - 1]
            // byte - 8 biti, intreg fara semn [0, 255]
            // sbyte - 8 biti, intreg cu semn [-128, 127]
            // short - 16 biti, intreg cu semn [-2^15, 2^15 - 1]
            // ushort - 16 biti, intreg fara semn [0, 2^16 - 1]
            // long - 64 biti, intreg cu semn, [-2^63, 2^63-1]
            // ulong - 64 biti, intreg fara semn, [0, 2^64 - 1]
            // decimal
        }
    }
}
