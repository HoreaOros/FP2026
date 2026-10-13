using System.Numerics;
using System.Globalization;

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
            // float
            // double


            float suma = 0.0f;
            for (int i = 0; i < 1000000; i++)
                suma += 0.001f;
            Console.WriteLine(suma);

            // char - caracter Unicode
            string message = "Hello World!";
            foreach(char c in message)
            { 
                Console.WriteLine(c); 
            }


            int an = 2026;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            // Display current date in the Hebrew calendar (numeric)
            var hebrewCalendar = new HebrewCalendar();
            int hebrewYear = hebrewCalendar.GetYear(dt);
            int hebrewMonth = hebrewCalendar.GetMonth(dt);
            int hebrewDay = hebrewCalendar.GetDayOfMonth(dt);
            Console.WriteLine($"Hebrew calendar date (numeric): {hebrewDay}/{hebrewMonth}/{hebrewYear}");

            // Display using Hebrew culture with the HebrewCalendar for localized month names
            var hebrewCulture = new CultureInfo("he-IL");
            hebrewCulture.DateTimeFormat.Calendar = hebrewCalendar;
            Console.WriteLine("Hebrew calendar (long date): " + dt.ToString("D", hebrewCulture));
            Console.WriteLine("Hebrew calendar (custom): " + dt.ToString("dd MMMM yyyy", hebrewCulture));
        }
    }
}
