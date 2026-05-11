class Program
{
    static void Main()
    {
        Console.Write("Num 1: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Num 2: ");
        int b = int.Parse(Console.ReadLine());

        int min = Math.Min(a, b);
        int max = Math.Max(a, b);
        int s = 0;

        for (int i = min; i <= max; i++)
        {
            s += i;
        }

        Console.WriteLine($"\nSuma del " + min + " al " + max + ": " + s);
    }
}