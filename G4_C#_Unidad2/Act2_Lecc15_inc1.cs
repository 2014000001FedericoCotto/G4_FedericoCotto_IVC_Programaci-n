class Program
{
    static void Main()
    {
        Console.Write("punto a: ");
        int puntoA = int.Parse(Console.ReadLine());

        Console.Write("punto b: ");
        int puntoB = int.Parse(Console.ReadLine());

        int ssn = Math.Min(puntoA, puntoB);
        int ssf = Math.Max(puntoA, puntoB);

        Console.WriteLine($"\n--- Identificando bloques compatibles (Múltiplos de 4) en: " + ssn + " a " + ssf + " ---");

        for (int k = ssn; k <= ssf; k++)
        {
            // Verificamos la paridad técnica con el divisor 4
            if (k % 4 == 0)
            {
                Console.WriteLine("ab: " + k);
            }
        }
    }
}