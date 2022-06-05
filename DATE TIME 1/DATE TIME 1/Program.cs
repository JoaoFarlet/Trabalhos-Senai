using System;

namespace DATE_TIME_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira sua data de nascimento: (aaaa/mm/dd)");
            var nascimento = DateTime.Parse(Console.ReadLine());
            var atual = DateTime.Now;
            var idade = nascimento - atual;

            Console.WriteLine("Sua idade é de " + idade);
        }
    }
}
