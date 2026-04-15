using System;

class Program
{
    static void Main()
    {
        int a1, a2, a3;

        Console.Write("Ángulo 1: ");
        a1 = int.Parse(Console.ReadLine());
        Console.Write("Ángulo 2: ");
        a2 = int.Parse(Console.ReadLine());
        Console.Write("Ángulo 3: ");
        a3 = int.Parse(Console.ReadLine());

        if (a1 == 60 && a2 == 60 && a3 == 60)
            Console.WriteLine("Equilátero");
        else
        {
            if (a1 == a2 || a1 == a3 || a2 == a3)
                Console.WriteLine("Isósceles");
            else
                Console.WriteLine("Escaleno");
        }
    }
}