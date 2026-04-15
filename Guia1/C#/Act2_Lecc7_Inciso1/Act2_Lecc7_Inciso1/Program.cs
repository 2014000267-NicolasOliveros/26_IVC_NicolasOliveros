// See https://aka.using System;

class Program
{
    static void Main()
    {
        int opcion;

        Console.WriteLine("1. Información");
        Console.WriteLine("2. Soporte");
        Console.WriteLine("3. Ventas");
        Console.WriteLine("4. Operador");
        opcion = int.Parse(Console.ReadLine());

        if (opcion == 1)
            Console.WriteLine("Información");
        else
        {
            if (opcion == 2)
                Console.WriteLine("Soporte");
            else
            {
                if (opcion == 3)
                    Console.WriteLine("Ventas");
                else
                {
                    if (opcion == 4)
                        Console.WriteLine("Operador");
                    else
                        Console.WriteLine("Opción inválida");
                }
            }
        }
    }
}