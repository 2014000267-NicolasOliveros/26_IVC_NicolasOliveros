using System;

class Program
{
    static void Main()
    {
        int dia;

        Console.Write("Ingrese un número del 1 al 7: ");
        dia = int.Parse(Console.ReadLine());

        if (dia == 6 || dia == 7)
            Console.WriteLine("Fin de semana");
        else
        {
            if (dia >= 1 && dia <= 5)
                Console.WriteLine("Entre semana");
            else
                Console.WriteLine("Número inválido");
        }
    }
}