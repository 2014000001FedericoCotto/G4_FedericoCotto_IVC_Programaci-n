class Program
{
    static void Main()
    {
        int s = 0;

        Console.WriteLine("Primos:");

        for (int x = 2; x <= 22; x++)
        {
            if (EsP(x))
            {
                Console.WriteLine(x);
                s += x;
            }
        }

        Console.WriteLine("\nTotal: " + s);
    }

    static bool EsP(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}