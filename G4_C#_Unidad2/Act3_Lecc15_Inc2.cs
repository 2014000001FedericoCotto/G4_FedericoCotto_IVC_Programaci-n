internal class Program
{
    private static void Main(string[] args)
    {
        int p = 0;
        int s = 0;

        for (int i = 300; i >= 1; i--)
        {
            // Suma de pares
            if (i % 2 == 0)
            {
                s += i;
            }

            // Lógica de primos
            bool ok = true;
            if (i <= 1)
            {
                ok = false;
            }
            else
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        ok = false;
                        break;
                    }
                }
            }

            if (ok)
            {
                p++;
            }
        }

        Console.WriteLine("Primos: " + p);
        Console.WriteLine("Suma: " + s);
    }
}