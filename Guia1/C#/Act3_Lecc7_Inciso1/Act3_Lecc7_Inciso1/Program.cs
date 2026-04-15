using System;

class Program
{
    static void Main()
    {
        int dia, mes;

        Console.Write("Ingrese día: ");
        dia = int.Parse(Console.ReadLine());

        Console.Write("Ingrese mes: ");
        mes = int.Parse(Console.ReadLine());

        if ((mes == 12 && dia >= 21) || (mes == 1) || (mes == 2) || (mes == 3 && dia < 21))
            Console.WriteLine("Invierno");
        else
        {
            if ((mes == 3 && dia >= 21) || (mes == 4) || (mes == 5) || (mes == 6 && dia < 21))
                Console.WriteLine("Primavera");
            else
            {
                if ((mes == 6 && dia >= 21) || (mes == 7) || (mes == 8) || (mes == 9 && dia < 21))
                    Console.WriteLine("Verano");
                else
                    Console.WriteLine("Otoño");
            }
        }
    }
}