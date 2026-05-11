internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("PRIMO?");

        int n, c = 0;

        Console.Write("Num: ");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                c++;
            }
        }

        if (c == 2)
        {
            Console.WriteLine("Es primo");
        }
        else
        {
            Console.WriteLine("No es");
        }
    }
}