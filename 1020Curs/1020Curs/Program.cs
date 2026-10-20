

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
            P4();
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
