using System.Diagnostics;
using System.Net.NetworkInformation;

Stopwatch sw = Stopwatch.StartNew();
P1(100000);
sw.Stop();
Console.WriteLine(sw.ElapsedTicks);

sw = Stopwatch.StartNew();
P2(100000);
sw.Stop();
Console.WriteLine(sw.ElapsedTicks);


sw = Stopwatch.StartNew();
P3(100000);
sw.Stop();
Console.WriteLine(sw.ElapsedTicks);


P4(1259);


void P4(int n) // O(log n)
{
    int cnt = 0;
    while (n > 0)
    {
        n /= 2;
        cnt++;
    }
    Console.WriteLine(cnt);
}

/// <summary>
/// Functia P1 calculeaza suma numerelor de la 1 la n
/// </summary>
/// <param name="n">Numarul pana la care se calculeaza suma</param>
void P1(int n) // O(n)
{
    int suma = 0;
    for(int i = 1; i <= n; i++)
    {
        suma += i;
    }
    Console.WriteLine(suma);
}

void P2(int n) // O(1)
{
    int suma = n * (n + 1) / 2;
    Console.WriteLine(suma);
}

void P3(int n) // O(n^2)
{
    int suma = 0;
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= n; j++)
        {
            suma += (i + j) % 10;
        }
    }
    Console.WriteLine(suma);
}



