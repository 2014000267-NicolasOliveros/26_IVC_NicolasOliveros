using System;

class Program
{
    static void Main()
    {
        int edad;

        Console.Write("Ingrese su edad: ");
        edad = int.Parse(Console.ReadLine());

        if (edad >= 18)
            Console.WriteLine("Mayor de edad");
        else
            Console.WriteLine("Menor de edad");
    }
}