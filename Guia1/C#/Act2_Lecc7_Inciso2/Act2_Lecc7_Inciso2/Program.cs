using System;

class Program
{
    static void Main()
    {
        int nota;

        Console.Write("Ingrese la nota: ");
        nota = int.Parse(Console.ReadLine());

        if (nota < 60)
            Console.WriteLine("Deficiente");
        else
        {
            if (nota < 70)
                Console.WriteLine("Regular");
            else
            {
                if (nota < 80)
                    Console.WriteLine("Bien");
                else
                {
                    if (nota < 90)
                        Console.WriteLine("Muy bien");
                    else
                        Console.WriteLine("Excelente");
                }
            }
        }
    }
}