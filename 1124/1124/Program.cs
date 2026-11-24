/// <summary>
/// Să se scrie o funcție C# recursivă care primind ca parametru 
/// un număr natural n returnează 1 dacă singurii factori primi 
/// sunt 2 și 3, sau returnează 0 dacă n mai are și alți factori.
/// </summary>
int F23(int n)
{
    if (n == 2 || n == 3)
        return 1;

    if(n % 2 == 0)
        return F23(n / 2);

    if(n % 3 == 0)
        return F23(n / 3);

    return 0;
}

Console.WriteLine($"12 ==> {F23(12)}");
Console.WriteLine($"12 ==> {F23(12)}");
Console.WriteLine($"14 ==> {F23(14)}");
Console.WriteLine($"18 ==> {F23(18)}");
Console.WriteLine($"2 ==> {F23(2)}");
Console.WriteLine($"3 ==> {F23(3)}");
Console.WriteLine($"170 ==> {F23(170)}");


/* ***************************************************** */

/// <summary>
/// Să se scrie o funcție C# recursivă care primind ca 
/// parametru un număr natural n returnează 0 dacă numărul 
/// de cifre pare este egal cu numărul de cifre impare, 
/// sau returnează o valoare nenulă în caz contrar.
/// </summary>
/// <example>
/// <code>
/// FPareImpare(12345) // returns 0 (cifre pare: 2, 4; cifre impare: 1, 3, 5)
/// FPareImpare(1234) // returns 1 (cifre pare: 2, 4; cifre impare: 1, 3)
/// </code>
/// </example>
int FPareImpare(int n)
{
    if(n < 10)
        return (n % 2 == 0) ? 1 : -1;

    return FPareImpare(n / 10) + (n % 2 == 0 ? 1 : -1);
}

Console.WriteLine($"FPareImpare(12345) = {FPareImpare(12345)}");
Console.WriteLine($"FPareImpare(1234) = {FPareImpare(1234)}");

/* ***************************************************** */
/// <summary>
/// Scrieţi definiția completă a subprogramului recursiv
/// care primeşte prin parametrul a un tablou unidimensional 
/// de elemente numere naturale, iar prin parametrul n numărul 
/// efectiv de elemente din a. Subprogramul returnează 1 dacă 
/// elementele pare alternează cu cele impare, sau returnează 
/// 0 dacă există cel puțin două elemente alăturate de aceeași 
/// paritate.
/// </summary>
int FAlternant(int[] a, int n)
{
    if(n == 1)
        return 1;
    
    if((a[n - 1] % 2) == (a[n - 2] % 2))
        return 0;

    return FAlternant(a, n - 1);
}

Console.WriteLine($"FAlternant([1, 2, 3, 4]) = {FAlternant(new int[] { 1, 2, 3, 4 }, 4)}");
Console.WriteLine($"FAlternant([1, 3, 5, 7]) = {FAlternant(new int[] { 1, 3, 5, 7 }, 4)}");


/* ***************************************************** */
///<summary>
///Să se scrie o funcție C# recursivă care să returneze numărul cifrelor divizibile cu 3 ale
///unui număr natural n transmis ca parametru.
/// </summary>
/// 
int CifDiv3Rec(int n)
{
    if (n < 10)
        return (n % 3 == 0) ? 1 : 0;

    return CifDiv3Rec(n / 10) + ((n % 10) % 3 == 0 ? 1 : 0);
}

Console.WriteLine($"CifDiv3Rec(123) = {CifDiv3Rec(123)}");
Console.WriteLine($"CifDiv3Rec(2001369) = {CifDiv3Rec(2001369)}");

/* ***************************************************** */
/// <summary>
/// Să se scrie o funcție C# recursivă care să returneze 1 dacă 
/// există cel puțin o cifră impară în compunerea unui număr 
/// natural n transmis ca parametru, sau 0 în caz contrar.
/// </summary>
/// <param name="n">Numărul natural de analizat</param>
/// <returns>1 dacă există cel puțin o cifră impară, 0 în caz contrar</returns>
int ExistaImpareRec(int n)
{
    if (n < 10)
        return (n % 2 == 1) ? 1 : 0;

    if(n % 2 == 1)
        return 1;

    return ExistaImpareRec(n / 10);
}

Console.WriteLine($"ExistaImpareRec(123) = {ExistaImpareRec(123)}");
Console.WriteLine($"ExistaImpareRec(246) = {ExistaImpareRec(246)}");

/* ***************************************************** */
/// <summary>
/// Un fierăstrău de gradul n este format din două fierăstraie 
/// de gradul n-1, între care se află un dinte de mărime n. 
/// Un fierăstrău de gradul 1 are un singur dinte, de mărime 1.
// Afișați un fierăstrău de grad n.
/// </summary>
F(5);
Console.WriteLine();
void F(int n)
{
    if(n == 0)
        return;

    F(n - 1);
    Console.Write($"{n} ");
    F(n - 1);
}

/* ***************************************************** */
///<summary>
/// Să se calculeze suma elementelor din vector care formează 
/// perechi egal depărtate de capetele 
/// vectorului și care sunt prime între ele.
/// </summary>
//int n = int.Parse(Console.ReadLine());
//int[] v = new int[n];
//citire(v, n);

//Console.WriteLine($"Suma elementelor simetrice pentru {string.Join(", ", v)}: {suma_sim(v)}");
void citire(int[] v, int n)
{
    if (n == 0)
        return;
    citire(v, n - 1);
    v[n - 1] = int.Parse(Console.ReadLine());
}
int cmmdc(int a, int b)
{
    if (b == 0)
        return a;
    return cmmdc(b, a % b);
}
int suma_sim(int[] v)
{
    return suma_sim_helper(v, 0, v.Length - 1);
}

int suma_sim_helper(int[] v, int left, int right)
{
    if(left >= right)
        return 0;   
    return (cmmdc(v[left], v[right]) == 1 ? v[left] + v[right] : 0) 
                    + suma_sim_helper(v, left + 1, right - 1);
}

/* ***************************************************** */
int n = 10;
Console.WriteLine($"turnuri({n}) = {turnuri2(n)}");

int turnuri(int n)
{
    if (n == 1)
        return 1;
    else
        return 1 + 2 * turnuri(n - 1);
}

// 000000....000001 << 3
// 000000....001000 = 1*2^3
// n = 00001....0010101010 << 3 (n * 2^3)
int turnuri2(int n)
{
    return (1 << n) - 1;
}