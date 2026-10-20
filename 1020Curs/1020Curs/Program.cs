using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
namespace _1020Curs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //P1();
            //P1v2();
            //P2();
            //P3();
            //P4();
            //P5();
            //P6();

            P7();
        }

        private static void P7()
        {
            int n = int.Parse(Console.ReadLine());
            int difMin = int.MaxValue;
            int a, b, x = 0, y = 0, suma = 0;
            a = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                b = int.Parse(Console.ReadLine());

                if(Math.Abs(a - b) < difMin)
                {
                    difMin = Math.Abs(a - b);
                    x = a; y = b;
                    suma = a + b;
                }
                else if(Math.Abs(a - b) == difMin)
                {
                    if(a  +  b < suma)
                    {
                        x = a; y = b;
                    }
                }
                a = b;
            }
            Console.WriteLine($"{x} {y}");
        }

        private static void P6()
        {
            int n = int.Parse(Console.ReadLine());
            int max1 = int.MinValue, max2 = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int nr = int.Parse((Console.ReadLine()));
                if (nr >= max1)
                {
                    max2 = max1;
                    max1 = nr;
                }
                else
                    if (nr > max2)
                        max2 = nr;
            }

            Console.WriteLine($"{max1} {max2}");
        }

        private static void P5()
        {
            int n = int.Parse(Console.ReadLine());
            int nr;
            int maxim = int.MinValue;
            List<int> lst = new List<int>();
            for (int i = 0; i < n; i++)
            {
                nr = int.Parse(Console.ReadLine());
                lst.Add(nr);
            }
            Console.WriteLine(lst.Max());
        }

        /// <summary>
        ///    *
        ///   * *
        ///  *   *
        /// * * * *
        /// </summary> ...o000.....000o....
        ///          \|/
        ///         (o o)
        ///           |
        ///          (-)
        /// ...o000.......000o....
        private static void P4()
        {
            int n = 4;
            // prima linie
            Console.Write(new string(' ', n - 1));
            Console.WriteLine('*');

            for(int i = 2; i < n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.Write('*');
                Console.Write(new string(' ', 2 * i - 3));
                Console.WriteLine('*');
            }

            // ultima linie
            for(int i = 1; i <= n; i++)
                Console.Write("* ");
            Console.WriteLine();

        }

        /// <summary>
        /// *******
        /// *** ***
        /// **   **
        /// *     *
        /// **   **
        /// *** ***
        /// *******
        /// </summary>
        private static void P3()
        {
            int n = 11;
            // linia de sus
            Console.WriteLine(new string('*', 2 * n + 1));
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('*', n - i + 1));
                Console.Write(new string(' ', 2 * i - 1));
                Console.WriteLine(new string('*', n - i + 1));
            }

            for(int i = 2; i <= n; i++)
            {
                Console.Write(new string('*', i));
                Console.Write(new string(' ', 2 * (n - i) + 1));
                Console.WriteLine(new string('*', i));
            }
            // linia de jos
            Console.WriteLine(new string('*', 2 * n + 1));

        }

        /// <summary>
        /// *
        /// **
        /// ***
        /// ****
        ///     ****
        ///      ***
        ///       **
        ///        *
        /// </summary>
        private static void P2()
        {
            int n = 5;
            //Console.ForegroundColor = ConsoleColor.Green;
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('*', i));
            }
            for(int i = n; i >= 1; i--)
            {
                Console.WriteLine(new string(' ', n + n - i) + new string('*', i));
            }
        }

        private static void P1v2()
        {
            int n = 10;
            for (int i = 1; i <= n; i++)
                Console.WriteLine(new string('*', i));
        }

        /// <summary>
        /// *
        /// **
        /// ***
        /// ****
        /// </summary>
        private static void P1()
        {
            int n = 14;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
