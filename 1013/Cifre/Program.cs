namespace Cifre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] tokens = line.Split(" ");

            int n = int.Parse(tokens[0]);
            int m = int.Parse(tokens[1]);

            int z1 = n / 10;
            int u1 = n % 10;
            int z2 = m / 10;
            int u2 = m % 10;

            if(z1 == z2 || z1 == u2 || u1 == z2 || u1 == u2)
                Console.WriteLine("da");
            else
                Console.WriteLine("nu");
        }
    }
}
