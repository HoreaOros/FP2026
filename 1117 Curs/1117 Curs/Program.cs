// RECURSIVITATE

#region Factorial
using System.Numerics;

int n = 15;
Console.WriteLine($"{n}! este: {Factorial(n)}");
Console.WriteLine($"{n}! este: {FactorialRec(n)}");

///<summary>
/// Calculează factorialul unui număr întreg folosind recursivitate.
/// n! = n * (n-1) * (n-2) * ... * 1
/// n! = n * (n-1)!, daca n > 0; n! = 1, dacă n = 0
///</summary>
/// <param name="n">Numărul pentru care se calculează factorialul.</param>
/// <returns>Factorialul numărului n.</returns>
int FactorialRec(int n)
{
    if (n == 0)
        return 1;
    else
        return n * FactorialRec(n - 1);
}

// F(4) = 4 * F(3) = 4 * 3 * F(2) = 4 * 3 * 2 * F(1) = 4 * 3 * 2 * 1 * F(0) = 4 * 3 * 2 * 1 * 1 = 24

///<summary>
/// Calculează factorialul unui număr întreg.
///</summary>
/// <param name="n">Numărul pentru care se calculează factorialul.</param>
/// <returns>Factorialul numărului n.</returns>
int Factorial(int n)
{
    int result = 1;
    for (int i = 2; i <= n; i++)
        result *= i;
    return result;
}
#endregion


#region CMMDC
int a = 17, b = 3; // 75=3*5^2, 105 = 3*5*7
Console.WriteLine($"CMMDC({a}, {b}) = {gcd(a, b)}");
Console.WriteLine($"CMMDC({a}, {b}) = {gcd2(a, b)}");
Console.WriteLine($"CMMDC({a}, {b}) = {gcdRec(a, b)}");
Console.WriteLine($"CMMMC({a}, {b}) = {lcm(a, b)}");

int lcm(int a, int b)
{
    return (a * b) / gcd(a, b);
}

///<summary>
/// Calculează cel mai mare divizor comun (CMMDC) 
/// a două numere întregi folosind recursivitate.
///</summary>
/// <param name="a">Primul număr întreg.</param>
/// <param name="b">Al doilea număr întreg.</param>
/// <returns>Cel mai mare divizor comun al numerelor a și b.</returns>
int gcdRec(int a, int b)
{
    if (b == 0)
        return a;
    else if (a == 0)
        return b;
    else
        return gcdRec(b, a % b);
}

///<summary>
///a     b
///--------
///105   75
///30    75
///30    45
///30    15
///15    15
///</summary>
int gcd2(int a, int b)
{
    if(a == 0)
        return b;
    if (b == 0)
        return a;
    while(a != b)
    {
        if (a > b)
            a -= b;
        else
            b -= a;
    }
    return a;
}

///<summary>
/// Calculează cel mai mare divizor comun (CMMDC) 
/// a două numere întregi folosind algoritmul lui Euclid.
///</summary>
///<params>
/// <param name="a">Primul număr întreg.</param>
/// <param name="b">Al doilea număr întreg.</param>
///</params>
/// <returns>Cel mai mare divizor comun al numerelor a și b.</returns>
/// <example>
/// <code>
/// int result = gcd(105, 75);
/// a   b   r
/// ------- ---
/// 105 75  30
/// 75  30  15
/// 30  15  0
/// 15  0
/// </code>
/// 
/// </example>
int gcd(int a, int b)
{
    if (b == 0)
        return a;
    else if (a == 0)
        return b;

    int r;
    while(b != 0)
    {
        r = a % b;
        a = b;
        b = r;
    }
    return a;
}
#endregion

#region Scor
// In cate moduri se poate ajunge la un scor a-b;
// 3-3;
//                      3 - 3
//              /                  \
//            2 - 3              3 - 2
//           /   \               /   \
//        1 - 3  2 - 2      2 - 2   3 - 1
//        /   \   /   \     /   \   /   \
//       0-3 1-2 1-2 2-1  1-2  2-1 2-1 3-0
//        |   /\
//     0-2   
//      |
//    0-1
//     |
//    0-0
int x = 3, y = 3;
Console.WriteLine($"Numarul de moduri in care se poate ajunge la scorul {x}-{y} este {Scor(x, y )}");

int Scor(int x, int y)
{
    if(x == 0 || y == 0)
        return 1;
    else
        return Scor(x - 1, y) + Scor(x, y - 1); 
}
x = 100; y = 100;
// Memoization
Dictionary<(int, int), BigInteger> memo = new();
for (int s = 1; s <= 100; s++)
    Console.WriteLine($"scor2({s},{s}) = {scor2(s, s)}");

BigInteger scor2(int s1, int s2)
{
    if (memo.ContainsKey((s1, s2)))
        return memo[(s1, s2)];

    if (s1 == 0 || s2 == 0)
    {
        memo[(s1, s2)] = 1;
        return 1;
    }
    else
    {
        memo[(s1, s2)] = scor2(s1 - 1, s2) + scor2(s1, s2 - 1);
        return memo[(s1, s2)];
    }
}
#endregion


#region Steps
// 1 = 1 (1)
// 2 = 11, 2 (2)
// 3 = 111, 12, 21 (3)
// 4 = 1111, 112, 121, 211, 22 (5)
// 5 = 11111, 1112, 1211, 2111, 1121, 221, 212, 122 (8)
// n = ?? 
// n - 2 |.........| 
// n - 1 |..........|
// n     |...........| = |..........1| + |.........2|
n = 10;
Console.WriteLine($"{n} steps ==> {steps(n)}");


// TODO: memoization
int steps(int n)
{
    if (n == 1)
        return 1;
    if (n == 2)
        return 2;
    if (n == 3)
        return 3;
    return steps(n - 1) + steps(n - 2);
}

// 1
// 11, 2
// 12, 111, 21
// 112, 22 | 121, 1111, 211
// 122, 1112, 212, 1121, 221, 1211, 11111, 2111
#endregion


#region Combinatorics
n = 4;
// Generez toate secventele binare de lungime n;
int[] v = new int[n];

gen(v, n, 0);

genPermutation(v, n, 0);

void genPermutation(int[] v, int n, int k)
{
    if (k == n)
        printArray(v);
    else
    {
        for (int i = 1; i <= n; i++)
        {
            v[k] = i;
            bool found = false;
            for (int j = 0; !found && j < k; j++)
                if (v[j] == v[k])
                    found = true;
            if (!found)
                genPermutation(v, n, k + 1);
        }
    }
}

// Generez toate secventele binare de lungime n
void gen(int[] v, int n, int k)
{
    if (k == n)
        printArray(v);
    else
    {
        v[k] = 0;
        gen(v, n, k + 1);

        v[k] = 1;
        gen(v, n, k + 1);
    }
}

void printArray(int[] v)
{
    foreach (var item in v)
        Console.Write(item);
    Console.WriteLine();
}
#endregion