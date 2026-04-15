using System;

class Program
{
    static void Main()
    {
        double n1, n2, n3, n4, n5, promedio;

        Console.WriteLine("Ingrese 5 notas:");
        n1 = double.Parse(Console.ReadLine());
        n2 = double.Parse(Console.ReadLine());
        n3 = double.Parse(Console.ReadLine());
        n4 = double.Parse(Console.ReadLine());
        n5 = double.Parse(Console.ReadLine());

        promedio = (n1 + n2 + n3 + n4 + n5) / 5;

        if (promedio >= 60)
            Console.WriteLine("Aprueba");
        else
            Console.WriteLine("Reprueba");
    }
}