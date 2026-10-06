// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// "3n+1"

//113383
Console.WriteLine("Introduceti un numar: ");
string line = Console.ReadLine();
int nr1 = int.Parse(line);
Console.WriteLine("Introduceti inca un numar: ");
line = Console.ReadLine();
int nr2 = int.Parse(line);


for (int n = nr1; n <= nr2; n++)
{
    Console.WriteLine(n);
    int aux = n;
    while(aux != 1)
    {
        if (aux % 2 == 0)
            aux = aux / 2;
        else
            try
            {
                checked
                {
                    aux = 3 * aux + 1; 
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                break;
            }
        Console.Write($"{aux} ");

    }
}

