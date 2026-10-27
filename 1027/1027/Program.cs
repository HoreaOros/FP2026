using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1027
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Maxime si minime
            //P1();
            //P2();
            //P3();
            //P4();

            // Cifrele unui numar
            //P5();
            //P6();
            //P7();
            //P8();
            //P9();
            P10();
        }

        private static void P10()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] tokens = line.Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);
                int a = int.Parse(tokens[0]);
                int b = int.Parse(tokens[1]);
                // a/b 15 / 20 ==> 3 / 4

                int d = cmmdc2(a, b);
                a = a / d;
                b = b / d;

                // a / b = a * (1 / b)
                // neperiodica daca b = 2^x*5^y
                // periodica simpla daca b nu are ca divizori pe 2 sau 5
                // periodica mixta daca b are ca divizor pe 2 si/sau 5 + alti divizori primi diferiti de 2 si 5

                if(b == 1)
                {
                    Console.WriteLine("fractie finita");
                    continue;
                }

                bool d25 = false;
                if (b % 2 == 0 || b % 5 == 0)
                    d25 = true;


                if(d25 == false)
                {
                    Console.WriteLine("fractie periodica simpla");
                    continue;
                }

                while (b % 2 == 0)
                    b = b / 2;
                while (b % 5 == 0)
                    b /= 5;


                if(b == 1)
                    Console.WriteLine("fractie finita");
                else
                    Console.WriteLine("fractie periodica mixta");
            }
        }

        private static int cmmdc2(int a, int b)
        {
            int r;
            while(b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        private static int cmmdc(int a, int b)
        {
            while(a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }


        private static void P9()
        {
            string input = "";
            string line;
            while((line = Console.ReadLine()) != null)
            {
                input += line;
                input += " ";
            }
            
            string[] nums = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int maxim = int.MinValue;
            int ap = 0;
            bool exista = false;
            for(int i = 0; i < nums.Length - 1; i++)
            {
                int nr = int.Parse(nums[i]);
                if(Palindrom(nr))
                {
                    exista = true;
                    if(nr > maxim) 
                    {
                        maxim = nr;
                        ap = 1;
                    }
                    else if(nr == maxim)
                        ap++;
                }
            }
            if(exista)
                Console.WriteLine($"{maxim} {ap}");
            else
                Console.WriteLine("NU EXISTA");
        }

        private static bool Palindrom(int nr)
        {
            return nr == Oglindit(nr);
        }

        private static int Oglindit(int nr)
        {
            int result = 0;
            while(nr > 0)
            {
                result = result * 10 + nr % 10;
                nr /= 10;
            }
            return result;
        }

        /// <summary>
        /// Se dă un număr natural n. Să se verifice dacă este sau nu alternant.
        /// Un număr natural este alternant dacă cifrele pare alternează cu cele impare.
        /// </summary>
        private static void P8()
        {
            long n = long.Parse(Console.ReadLine());
            // 1234567
            long c1, c2;
            c1 = n % 10;
            n = n / 10;
            bool ok = true; // presupun ca numarul este alternant
            while(n > 0)
            {
                c2 = n % 10;
                n = n / 10;

                if(c1 % 2 == c2 % 2)
                { 
                    Console.WriteLine("nu");
                    ok = false;
                    break;
                }
                c1 = c2;
            }
            if(ok)
                Console.WriteLine("da");
        }

        /// <summary>
        /// Un număr semioglindit se obţine dintr-un număr cu 
        /// număr par de cifre, prin interschimbarea 
        /// în acesta a numărului format din cifrele din prima 
        /// jumătate cu cel format din cifrele din a doua jumătate.
        /// </summary>
        /// <example>
        /// Din numărul 106432 se obţine numărul semioglindit 432106
        /// </example>
        /// <exception cref="NotImplementedException"></exception>
        private static void P7()
        {
            StringBuilder sb = new StringBuilder();
            string line;
            while((line = Console.ReadLine()) != null)
            {
                sb.Append(line);
                sb.Append(" ");

            }
            string input = sb.ToString();

            Regex r = new Regex(@"\d+");
            MatchCollection result = r.Matches(input);

            int n = int.Parse(result[0].ToString());
            bool exista = false;
            for(int i = 1; i <= n; i++)
            {
                int nr = int.Parse(result[i].ToString());
                if(NumarCifre(nr) % 2 == 0)
                {
                    Console.Write($"{SemiOglinditStr(nr.ToString())} ");
                    exista = true;
                }
            }

            if(!exista)
                Console.WriteLine("NU EXISTA");
        }

        private static string SemiOglinditStr(string s)
        {
            int len = s.Length;
            // 102003
            string result = s.Substring(len / 2) + s.Substring(0, len / 2);
            result = result.TrimStart('0');
            return result;
        }

        private static int SemiOglindit(int nr)
        {
            int cifre = NumarCifre(nr);
            // 102456 => 102, 456; 10^3

            int p = 1;
            for (int i = 1; i <= cifre / 2; i++)
                p *= 10;


            int ps = nr / p;
            int pd = nr % p;
            return pd * p + ps;
        }

        private static int NumarCifre(int nr)
        {
            if (nr < 10)
                return 1;
            int cifre = 0;
            while(nr > 0)
            {
                cifre++;
                nr /= 10;
            }
            return cifre;
        }

        /// <summary>
        /// Scrieți un program care citește un număr natural nenul n 
        /// și care calculează suma S tuturor numerelor distincte 
        /// prefixe pentru n.
        /// </summary>
        private static void P6()
        {
            int n = int.Parse(Console.ReadLine());
            long suma = 0;
            while(n > 0)
            {
                suma += n;
                n /= 10;
            }
            Console.WriteLine(suma);
        }

        /// <summary>
        /// Se da un numar natural. Calculaţi suma cifrelor numărului dat.
        /// </summary>
        private static void P5()
        {
            int n = int.Parse(Console.ReadLine());

            int suma = 0;

            while(n > 0)
            {
                int c = n % 10;
                n /= 10;
                suma += c;
            }

            Console.WriteLine(suma);
        }

        /// <summary>
        /// Se dau n numere naturale. Determinaţi cele mai mici 
        /// trei numere dintre cele date.
        /// </summary>
        private static void P4()
        {
            int n = int.Parse(Console.ReadLine());

            int minim1 = int.MaxValue;
            int minim2 = int.MaxValue;
            int minim3 = int.MaxValue;

            for(int i = 1; i <= n; i++)
            {
                int nr = int.Parse(Console.ReadLine());
                if (nr <= minim1)
                {
                    minim3 = minim2;
                    minim2 = minim1;
                    minim1 = nr;
                }
                else if (nr <= minim2)
                {
                    minim3 = minim2;
                    minim2 = nr;
                }
                else if (nr < minim3)
                    minim3 = nr;
            }

            Console.WriteLine($"{minim3} {minim2} {minim1}");
        }

        /// <summary>
        /// Să se scrie un program care citește un șir de n numere naturale 
        /// şi determină valoarea maximă din șir și de câte ori apare.
        /// </summary>
        private static void P3()
        {
            int n = int.Parse(Console.ReadLine());
            int nr;
            int maxim = int.Parse(Console.ReadLine());
            int ap = 1;
            for(int i = 2; i <= n; i++)
            {
                nr = int.Parse(Console.ReadLine());
                if (nr > maxim)
                {
                    maxim = nr;
                    ap = 1;
                }
                else if (nr == maxim)
                    ap++;
            }
            Console.WriteLine($"{maxim} {ap}");
        }

        /// <summary>
        /// Se citesc de la tastatură numere naturale până la apariția lui zero. 
        /// Să se determine cea mai mare valoare care poate obține înmulțind două 
        /// valori diferite dintre cele citite.
        /// </summary>
        /// <example>
        /// 5
        /// 6
        /// 4
        /// 6
        /// 0
        /// Rezultatul este 56
        /// 4 4 4 0
        /// </example>
        private static void P2()
        {
            int max1 = int.MinValue;
            int max2 = int.MinValue;

            int nr;
            do
            {
                nr = int.Parse(Console.ReadLine());
                if (nr == 0)
                    break;

                if (nr > max1)
                {
                    max2 = max1;
                    max1 = nr;
                }
                else if (nr == max1)
                    ;
                else if (nr > max2)
                    max2 = nr;
            } while (true);
            
            if(max1 != int.MinValue && max2 != int.MinValue)
                Console.WriteLine((long)max1 * max2);
            else
                Console.WriteLine("NU EXISTA");

        }

        /// <summary>
        /// Se dau n numere întregi. Calculați cel mai mare dintre cele n numere date.
        /// </summary>
        private static void P1()
        {
            int n;
            n = int.Parse(Console.ReadLine());

            int maxim = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int nr = int.Parse(Console.ReadLine());
                if (nr > maxim)
                    maxim = nr;
            }

            Console.WriteLine(maxim);
        }
    }
}
