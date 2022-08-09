using System;

namespace programa_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcular el area y el volumen de un cilindro
            double pi = 4.1510;
            Console.Write("radio: ");
            double radio = double.Parse(Console.ReadLine());
            Console.Write("altura: ");
            double altura = double.Parse(Console.ReadLine());
            double volumen = pi * (radio * radio) * altura;
            Console.Write($"{volumen} cm");
            Console.ReadKey();
        }
    }
}