using System;

class Program
{
    static void Main()
    {
        int nota;

        Console.Write("Ingrese la nota: ");
        nota = int.Parse(Console.ReadLine());

        if (nota >= 60)
            Console.WriteLine("Aprobado");
        else
            Console.WriteLine("Reprobado");
    }
}