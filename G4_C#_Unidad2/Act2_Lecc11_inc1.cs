internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ingrese un numero: ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            if (n < 0)
            {
                Console.WriteLine("Error");
            }
            else
            {

                double factorial = 1;
                int i = 1;

                if (n > 0)
                {
                    do
                    {
                        factorial *= i;
                        i++;
                    } while (i <= n);
                }

                Console.WriteLine("factorial " + n + " es: " + factorial);
            }
        }
        else
        {
            Console.WriteLine("Numero Invalido");
        }
    }
}