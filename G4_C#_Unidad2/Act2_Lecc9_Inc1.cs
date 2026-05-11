internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("LVL 5");

        int m;

        Console.WriteLine("Monedas:");
        m = Convert.ToInt32(Console.ReadLine());

        if (m >= 350)
        {
            Console.WriteLine("Entras al lv5");
        }
        else
        {
            Console.WriteLine("Bloqueado, faltan m");
        }
    }
}