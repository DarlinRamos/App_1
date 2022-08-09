using System;

namespace programa_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Suma, resta, multiplicacion y division
            int n1, n2, s, r, m;
            float di;
            string va;

            Console.WriteLine("Ingrese un numero");
            va = Console.ReadLine();
            n1 = int.Parse(va);
            Console.WriteLine("Ingrese otro numero");
            va = Console.ReadLine();
            n2 = int.Parse(va);

            s = n1 + n2;
            r = n1 - n2;
            m = n1 * n2;
            di = n1 / n2;

            Console.WriteLine("El resultado de la suma es: " + s);
            Console.WriteLine("El resultado de la resta e: " + r);
            Console.WriteLine("El resultado de la multiplicacion es: " + m);
            Console.WriteLine("El resultado de la divion es: " + di);
            Console.ReadKey();
        }
    }
}