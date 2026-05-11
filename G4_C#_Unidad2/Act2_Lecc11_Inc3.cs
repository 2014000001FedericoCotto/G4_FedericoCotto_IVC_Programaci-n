internal class Program
{
    private static void Main(string[] args)
    {
        int conteoTickets = 0;
        double ingresosCaja = 0;
        int eleccionMenu = -1;

        Console.WriteLine("--- Terminal de Ventas: Cinema Paradiso ---");

        while (eleccionMenu != 0)
        {
            Console.WriteLine("\nMenú de transacciones:");
            Console.WriteLine("1. Ticket Función Estándar ($20)");
            Console.WriteLine("2. Ticket Función Infantil ($12)");
            Console.WriteLine("0. Cerrar caja y ver resumen");

            if (int.TryParse(Console.ReadLine(), out eleccionMenu))
            {
                switch (eleccionMenu)
                {
                    case 1:
                        conteoTickets++;
                        ingresosCaja += 20;
                        Console.WriteLine("Entrada estándar procesada.");
                        break;
                    case 2:
                        conteoTickets++;
                        ingresosCaja += 12;
                        Console.WriteLine(" Entrada infantil procesada.");
                        break;
                    case 0:
                        Console.WriteLine("Calculando balance de cierre...");
                        break;
                    default:
                        Console.WriteLine(" Selección no válida.");
                        break;
                }

                if (eleccionMenu != 0)
                {
                    Console.WriteLine("ESTADO: " + conteoTickets + " tickets emitidos, En Caja: $" + ingresosCaja);
                }
            }
        }

        Console.WriteLine("\n**************************************");
        Console.WriteLine("CANTIDAD DE TICKETS PROCESADOS: " + conteoTickets);
        Console.WriteLine("MONTO TOTAL ACUMULADO: $" + ingresosCaja);
        Console.WriteLine("**************************************");
    }
}