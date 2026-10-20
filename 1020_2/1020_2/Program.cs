using System;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
namespace _1020_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Rezultatul este {0}", F1(n));

            //F2();
            //F3();

            //F4();

            F5();
        }

        private static void F5()
        {
            long suma = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                suma += Power(i, i);
            }
            Console.WriteLine($"Rezultatul este {suma}");
        }

        private static long Power(long b, long e)
        {
            long result = 1;
            for (long i = 0; i < e; i++)
            {
                result *= b;
            }
            return result;
        }

        public static void F4()
        {
            int n = int.Parse(Console.ReadLine());
            long suma = 0;
            long produs = 1;
            for (int i = 1; i <= n; i++)
            {
                produs = produs * i;
                suma += produs;
            }

            Console.WriteLine($"Rezultatul este {suma}");

        }

        /// <summary>
        /// S=1*n+2*(n-1)+3*(n-2)+...+n*1
        /// </summary>
        private static void F3()
        {
            int n = int.Parse(Console.ReadLine());
            int suma = 0;

            for (int i = 1; i <= n; i++)
            {
                suma = suma + i * (n - i + 1);
            }

            Console.WriteLine($"Rezultatul este {suma}");
        }

        private static void F2()
        {
            string line;
            int suma = 0;
            do
            {
                int nr = int.Parse(Console.ReadLine());
                if (nr == 0)
                {
                    break;
                }
                if(nr >= 100 && nr <= 999)
                    if(nr % 10 == nr / 100)
                    {
                        suma += nr;
                    }
            } while (true);


            Console.WriteLine(suma);
        }

        // Comment pe o singura linie

        /*
         * Comment pe mai multe linii
         * Comment pe mai multe linii
         */

        /// <summary>
        /// S=1*2+2*3+3*4+...+n*(n+1)
        /// </summary>
        /// <param name="n"></param>
        /// <returns>Valoarea sumei</returns>
        private static int F1(int n)
        {
            int s = 0;
            for (int i = 1; i <= n; i++)
            {
                s += i * (i + 1);
            }
            return s;
        }
    }
}
