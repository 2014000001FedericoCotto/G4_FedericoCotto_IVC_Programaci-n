internal class Program
{
    private static void Main(string[] args)
    {
        int s = 0;

        for (int i = 1; i <= 50; i++)
        {
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
                s += i;
            }
        }

        Console.WriteLine("Suma primos: " + s);
    }
}