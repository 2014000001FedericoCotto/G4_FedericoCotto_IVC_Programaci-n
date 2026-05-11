class Program
{
    static void Main()
    {
        int cp = 0;
        int sp = 0;

        for (int i = 1; i <= 100; i++)
        {
            if (EsP(i))
            {
                cp++;
                sp += i;
            }
        }

        Console.WriteLine("Cant. Primos: " + cp);
        Console.WriteLine("Suma: " + sp);
    }

    static bool EsP(int n)
    {
        if (n < 2) return false;
        for (int x = 2; x * x <= n; x++)
        {
            if (n % x == 0) return false;
        }
        return true;
    }
}