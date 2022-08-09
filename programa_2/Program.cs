using System;

namespace programa_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcular el angulo de un triangulo
            Console.Write("Ingresar la base del triangulo: ");
            int base_t = int.Parse(Console.ReadLine());
            Console.Write("Ingresar la altura del triangulo: ");
            int altura = int.Parse(Console.ReadLine());
            double area = (base_t * altura) / 2;
            Console.Write("El area del triangulo es: " + area + " cm");
            Console.ReadKey();
        }
    }
}