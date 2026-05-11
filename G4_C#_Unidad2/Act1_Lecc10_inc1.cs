internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("CUPONERA DE CORTES");

        int sellos = 0;

        while (sellos < 8)
        {
            Console.WriteLine("+1 sello");

            sellos = sellos + 1;

            Console.WriteLine("Sellos acumulados: " + sellos);
            Console.WriteLine();
        }

        Console.WriteLine("Has ganado un corte ¡¡¡¡GRATIS!!!!");
    }
}