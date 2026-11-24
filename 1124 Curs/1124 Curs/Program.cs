// MATRICI
// Input parsing
using System.Numerics;

StreamReader sw = new StreamReader("input.txt");
string input = sw.ReadToEnd();
sw.Close();

string[] t = input.Split(Environment.NewLine+Environment.NewLine);

int[,] m1 = MatrixParsing(t[0]);
PrintMatrix(m1);


int[,] m2 = MatrixParsing(t[1]);
PrintMatrix(m2);


// parcurgerea unei matrici in spirala
Spirala(m1);
Spirala(m2);

Serpuire(m2);

void Serpuire(int[,] m)
{
    int rows = m.GetLength(0);
    int cols = m.GetLength(1);

    int i = 0, j = 0;
    Directie dir = Directie.Jos; 
    int cnt = 0;
    while(cnt != rows * cols)
    {
        Console.Write($"{m[i, j]} ");
        cnt++;

        if(dir == Directie.Jos)
        {
            i++;
            j--;
        }
        else
        {
            i--;
            j++;
        }


        if(dir == Directie.Jos)
        {
            if(j == -1 && i < rows)
            {
                j = 0; dir = Directie.Sus;
            }
            else if(i == rows)
            {
                j += 2;
                i = rows - 1;
                dir = Directie.Sus;
            }
        }
        else if(dir == Directie.Sus)
        {
            if(i == -1 && j < cols)
            {
                i = 0;
                dir = Directie.Jos;
            }
            else if(j == cols)
            {
                j = cols - 1;
                i += 2;
                dir = Directie.Jos;
            }
        }
    }

}

void Spirala(int[,] m)
{
    int rows = m.GetLength(0);
    int cols = m.GetLength(1);
    int i1 = 0, j1 = 0;
    int i2 = rows - 1, j2 = cols - 1;
    int cnt = 0;
    while(true)
    {
        for(int j = j1; j <= j2; j++)
        {
            Console.Write($"{m[i1, j]} ");
            cnt++;
        }
        i1++;
        if (cnt == rows * cols)
            break;

        for(int i = i1; i <= i2; i++)
        {
            Console.Write($"{m[i, j2]} ");
            cnt++;
        }
        j2--;
        if (cnt == rows * cols)
            break;

        for(int j = j2; j >= j1; j--)
        {
            Console.Write($"{m[i2, j]} ");
            cnt++;
        }
        i2--;
        if (cnt == rows * cols)
            break;
        for(int i = i2; i >= i1; i--)
        {
            Console.Write($"{m[i, j1]} ");
            cnt++;
        }
        j1++;
        if (cnt == rows * cols)
            break;
    }
    Console.WriteLine();
}

void PrintMatrix(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write(mat[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//3 3
//1 2 3
//8 9 4
//7 6 5
int[,] MatrixParsing(string s)
{
    string[] lines = s.Split(Environment.NewLine);
    string[] t = lines[0].Split(' ');
    
    int rows = int.Parse(t[0]);
    int cols = int.Parse(t[1]);

    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        string[] numbers = lines[i + 1].Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = int.Parse(numbers[j]);
        }
    }
    return matrix;
}



enum Directie
{
    Jos, Sus
}

// Matrici patratice
// TODO:
// Suma elementelor de pe diagonala principala (i == j)
// Suma elementelor de pe diagonala secundara (i+j == n - 1)
// Suma elementelor de deasupra diagonalei principale (i < j)
// Suma elementelor de sub diagonala principala
// Suma elementelor de deasupra diagonalei secundare
// Suma elementelor de sub diagonala secundare
// Suma elementelor din zona de Nord a matricii
// Suma elementelor din zona de Sud a matricii
// Suma elementelor din zona de Est a matricii
// Suma elementelor din zona de Vest a matricii