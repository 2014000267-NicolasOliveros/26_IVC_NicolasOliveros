internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("==PROMEDIO DE CALIFICACIÓN==");
        string materia;
        int n1, n2, n3, n4, n5;
        double prom;
        Console.WriteLine("Digite la Materia: ");
        materia = Console.ReadLine();
        Console.WriteLine("Dime 5 notas: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        n2 = Convert.ToInt32(Console.ReadLine());
        n3 = Convert.ToInt32(Console.ReadLine());
        n4 = Convert.ToInt32(Console.ReadLine());
        n5 = Convert.ToInt32(Console.ReadLine());

        prom = (n1 + n2 + n3 + n4 + n5) / 5;

        if (prom >= 70)
        Console.WriteLine("El estudiante aprobó "+materia+" con: "+prom);
        else
            Console.WriteLine("El estudiante reprobó " + materia + " con: " + prom);
    }
}