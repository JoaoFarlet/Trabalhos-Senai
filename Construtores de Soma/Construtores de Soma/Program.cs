using System;

namespace Construtores_de_Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadores calc = new Calculadores() { A = 13.50, C = 50.1 };

            Console.WriteLine(calc.Somartor());

        }
    }
}

