// Tablouri
#region Arrays
using System.Globalization;

int[] v;
v = new int[10];

PrintArray(v);

int[] v2 = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
PrintArray(v2);

int[] v3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
PrintArray(v3);
#endregion


#region Sorting
int[] v4 = InitRandomArray(1000);
//Array.Sort(v4);
//PrintArray(v4);

Console.WriteLine("Sorting...");
CountingSort(v4, 100);
Console.WriteLine("Done.");

#endregion




/****************************
 * SORTING 
 */
// (1, "abc"),  (2, "def"),  (1, "xyz") ===> (1, "abc"),  (1, "xyz"),  (2, "def")
// 
#region BubbleSort

int[] arr = InitRandomArray(10, 1000);
Console.WriteLine("Bubble Sort");
PrintArray(arr);
BubbleSort(arr);
PrintArray(arr);


// BubbleSort
//for i = 1:n,
//    swapped = false
//    for j = n:i + 1,
//        if a[j] < a[j - 1],
//            swap a[j, j - 1]
//            swapped = true
//    → invariant: a[1..i] in final position
//    break if not swapped
//end
void BubbleSort(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        bool swapped = false;
        for(int j = arr.Length - 1; j > i; j--)
            if (arr[j] < arr[j - 1])
            {
                (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                swapped = true;
            }
        if (!swapped)
            break;
    }
}
#endregion


#region SelectionSort
Console.WriteLine("Selection Sort");
arr = InitRandomArray(10, 1000);
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
// Selection Sort
//for i = 1:n,
//    k = i
//    for j = i + 1:n, if a[j] < a[k], k = j
//    → invariant: a[k] smallest of a[i..n]
//    swap a[i, k]
//    → invariant: a[1..i] in final position
//end

void SelectionSort(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        int k = i;
        for (int j = i + 1; j < arr.Length; j++)
            if (arr[j] < arr[k])
                k = j;
        (arr[i], arr[k]) = (arr[k], arr[i]);
    }
}

#endregion

#region InsertionSort
Console.WriteLine("Insertion Sort");
arr = InitRandomArray(10, 1000);
PrintArray(arr);
InsertionSort(arr);
PrintArray(arr);
//for i = 2:n,
//    for (k = i; k > 1 and a[k] < a[k - 1]; k--)
//    swap a[k, k - 1]
//    → invariant: a[1..i] is sorted
//end
void InsertionSort(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
        for (int k = i; k > 0 && arr[k] < arr[k - 1]; k--)
            (arr[k], arr[k - 1]) = (arr[k - 1], arr[k]);
}

#endregion

#region MaXDifference

// Se da un vector de n numere naturale - a
// se cere sa se determina cea mai mare diferenta
// a[i] - a[j], 0 <= i < j < n
// Exemplu: 0 5 9 8 1 4 6 3 2 - rezultatul este 8 = 9 - 1
//int[] a = { 0, 5, 9, 8, 1, 4, 6, 3, 2 };
//      M =   0  5  9  9  9  9  9  9  9       
//      m =   0  1  1  1  1  2  2  2  2
//int[] a = InitRandomArray(100000, 1000000);
//Console.WriteLine($"Solving...");
//Console.WriteLine($"Cea mai mare diferenta este: {MaxDifference(a)}");
//Console.WriteLine($"Cea mai mare diferenta este: {MaxDifferenceFast(a)}");
//Console.WriteLine($"Done");
int MaxDifferenceFast(int[] a)
{
    int[] M = new int[a.Length];
    int[] m = new int[a.Length];
    M[0] = a[0];
    int maxim = a[0];
    for(int i = 1; i < a.Length; i++)
    {
        maxim = Math.Max(maxim, a[i]);
        M[i] = maxim;
    }
    m[m.Length - 1] = a[a.Length - 1];
    int minim = a[a.Length - 1];
    for(int i = a.Length - 2; i >= 0; i--)
    {
        minim = Math.Min(minim, a[i]);
        m[i] = minim;
    }
    int difMax = int.MinValue;
    for (int i = 0; i < M.Length - 1; i++)
        difMax = Math.Max(difMax, M[i] - m[i + 1]);
    return difMax;
}


int MaxDifference(int[] a)
{
    int percent = 0;
    int maxDiff = int.MinValue;
    Console.CursorVisible = false;
    for (int i = 0; i < a.Length; i++)
    {
        if (i % (a.Length / 100) == 0)
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write($"{percent++} ");
        }
        for (int j = i + 1; j < a.Length; j++)
        {
            int diff = a[i] - a[j];
            if (diff > maxDiff)
                maxDiff = diff;
        }
    }
    Console.WriteLine();
    return maxDiff;
    Console.CursorVisible = true;
}
#endregion




void CountingSort(int[] v, int max)
{
    int[] frequency = Frequency(v, max);
    int index = 0;
    for(int i = 0; i < frequency.Length; i++)
    {
        for (int j = 0; j < frequency[i]; j++)
        {
            v[index++] = i;
        }
    }
}



//int[] frequency = Frequency(v4, 100);
//PrintArrayWithIndex(frequency);



void PrintArrayWithIndex(int[] frequency)
{
    for (int i = 0; i < frequency.Length; i++)
    {
        Console.WriteLine($"{i} -> {frequency[i]}");
    }
}

int[] Frequency(int[] v, int max)
{
    int[] freq = new int[max];
    for (int i = 0; i < v.Length; i++)
    {
        freq[v[i]]++;
    }
    return freq;
}

int[] InitRandomArray(int size, int maxValue = 100)
{
    int[] v = new int[size];
    Random r = Random.Shared;
    for (int i = 0; i < v.Length; i++)
    {
        v[i] = r.Next(maxValue);
    }
    return v;
}



void PrintArray(int[] v)
{
    for (int i = 0; i < v.Length; i++)
    {
        Console.Write(v[i] + " ");
    }
    Console.WriteLine();
}