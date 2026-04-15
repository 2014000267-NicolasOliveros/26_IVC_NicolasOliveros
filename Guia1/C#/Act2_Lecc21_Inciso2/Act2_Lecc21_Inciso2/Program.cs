using System;

class Program
{
    static void Main()
    {
        int opcion;

        Console.WriteLine("1. Ventas");
        Console.WriteLine("2. Recepción");
        Console.WriteLine("3. Dirección");
        Console.WriteLine("4. Compras");
        opcion = int.Parse(Console.ReadLine());

        if (opcion == 1)
        {
            Console.WriteLine("Bienvenido a Ventas");
            Console.WriteLine("Encargado: Juan Perez");
            Console.WriteLine("Correo: ventas@empresa.com");
        }
        else
        {
            if (opcion == 2)
            {
                Console.WriteLine("Bienvenido a Recepción");
                Console.WriteLine("Encargado: Maria Lopez");
                Console.WriteLine("Correo: recepcion@empresa.com");
            }
            else
            {
                if (opcion == 3)
                {
                    Console.WriteLine("Bienvenido a Dirección");
                    Console.WriteLine("Encargado: Carlos Ruiz");
                    Console.WriteLine("Correo: direccion@empresa.com");
                }
                else
                {
                    if (opcion == 4)
                    {
                        Console.WriteLine("Bienvenido a Compras");
                        Console.WriteLine("Encargado: Ana Torres");
                        Console.WriteLine("Correo: compras@empresa.com");
                    }
                    else
                    {
                        Console.WriteLine("Opción inválida");
                    }
                }
            }
        }
    }
}