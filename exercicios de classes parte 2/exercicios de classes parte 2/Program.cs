using System;

namespace exercicios_de_classes_parte_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto Produto1, Produto2, Produto3;

            Produto1 = new Produto();

            Console.WriteLine("Insira o nome do produto:");
            Produto1.Nome = Console.ReadLine();
            Console.WriteLine("insira o custo de produção:");
            Produto1.PrecoCusto = double.Parse(Console.ReadLine());
            Console.WriteLine("insira o custo de venda:");
            Produto1.PrecoVenda = double.Parse(Console.ReadLine());

            Console.WriteLine("estes foram os valores inseridos:" + Produto1.Nome + Produto1.PrecoVenda + Produto1.PrecoCusto );
        }
    }
}
