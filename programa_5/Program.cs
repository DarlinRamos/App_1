using System;

namespace programa_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el nombre del paciente");
            String nom = Console.ReadLine();

            Console.WriteLine("Escriba el peso del Paciente:");
            double peso = int.Parse(Console.ReadLine());

            Console.Write("Escriba la edad del paciente:");
            double edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba la altura del paciente:");
            double altura = int.Parse(Console.ReadLine());

            Console.Write("Escriba el tipo de sangre del paciente:");
            String sangre = Console.ReadLine();

            Console.ReadKey();
        }
    }
}
