using System;
internal class Program
{
    private static void Main()
    {
        //P1();
        //P2();
        //P3();
        P4();
    }

    private static void P4()
    {
        int n = int.Parse(Console.ReadLine());
        int result = 0, maxDiv = 0;
        for(int nr = 1; nr <= n; nr++)
        {
            int nd = NumarDivizori2(nr); 
            if (nd > maxDiv)
            {
                maxDiv = nd;
                result = nr;
            }
        }

        Console.WriteLine(result);
    }

    private static int NumarDivizori2(int nr)
    {
        if (nr == 1)
            return 1;
        int cnt = 2;
        for(int d = 2; d * d <= nr; d++)
        {
            if(nr % d == 0)
            {
                cnt++;
                if (d != nr / d)
                    cnt++;
            }
        }
        return cnt;
    }

    private static int NumarDivizori1(int nr)
    {
        int cnt = 0;
        for (int i = 1; i <= nr; i++)
        {
            if (nr % i == 0)
            {
                cnt++;
            }
        }
        return cnt;
    }

    /// <summary>
    /// Se citește un număr natural n. Să se determine suma divizorilor săi.
    /// </summary>
    private static void P3()
    {
        int n = int.Parse(Console.ReadLine());
        //Console.WriteLine(SumaDivizori1(n));
        //Console.WriteLine(SumaDivizori2(n));
        Console.WriteLine(SumaDivizori3((uint)n));
    }

    private static uint SumaDivizori3(uint n)
    {
        uint suma = 0;
        if(n == 1)
            return 1;

        for(uint d = 1; d * d <= n; d++)
        {
            if(n % d == 0)
            {
                suma = suma + d;
                if(d != n / d)
                {
                    suma = suma + n / d;
                }   
            }
        }

        return suma;
    }

    private static int SumaDivizori2(int n)
    {
        if (n == 1)
            return 1;

        int suma = n + 1;
        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0)
            {
                suma += i;
            }
        }
        return suma;
    }

    private static int SumaDivizori1(int n)
    {
        int suma = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                suma += i;
            }
        }
        return suma;
    }

    /// <summary>
    /// Se dă un număr natural n. Să se afle câte dintre numerele 
    /// obținute din n prin ștergerea unei cifre, sunt divizibile cu 3.
    /// </summary>
    private static void P2()
    {
        int n = int.Parse(Console.ReadLine());
        int cnt = 0;
        int sumaCifre = SumaCifre(n);
        //int sumaCifre = SumaCifreRec(n);

        while (n > 0)
        {
            int cifra = n % 10;
            n = n / 10;
            if((sumaCifre - cifra) % 3 == 0)
            {
                cnt++;
            }
        }
        Console.WriteLine(cnt);
    }
    // SC(123) = 3 + SC(12)
    private static int SumaCifreRec(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        return (n % 10) + SumaCifreRec(n / 10);
    }

    private static int SumaCifre(int n)
    {
        int suma = 0;
        while (n > 0)
        {
            suma += n % 10;
            n /= 10;
        }
        return suma;
    }

    /// <summary>
    /// Se dă un șir cu n elemente, numere naturale. 
    /// Să se determine câte elemente ale șirului au număr impar de cifre.
    /// </summary>
    private static void P1()
    {
        int n, nr, cnt = 0;

        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            nr = int.Parse(Console.ReadLine());
            if (NumarCifre(nr) % 2 == 1)
            {
                cnt++;
            }
        }
        Console.WriteLine(cnt);
    }

    private static int NumarCifre(int nr)
    {
        int cnt = 0;
        if (nr == 0)
        {
            return 1;
        }
        while (nr > 0)
        {
            cnt++;
            nr /= 10;
        }
        return cnt;
    }
}