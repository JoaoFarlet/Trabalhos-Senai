using System;
using enum_2.Entities;

namespace enum_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carros = new Carro();

            Console.WriteLine("Insira a Cor do Veiculo: ");
            carros.Ccor =(Console.ReadLine());


            Console.WriteLine("Insira a marca do Veiculo: ");
            int imarca = int.Parse(Console.ReadLine());
            carros.Cmarca = (Emarca)imarca;

            Console.WriteLine("Insira o tipo de cambio do Veiculo: ");
            int icambio = int.Parse(Console.ReadLine());
            carros.Ccambio = (Etcambio)icambio;

            Console.WriteLine("Insira o tipo de combustivel do Veiculo: ");
            int icombust = int.Parse(Console.ReadLine());
            carros.CtCumbustivel = (Etcombust)icombust;

            Console.WriteLine("Insira o modelo do Veiculo: ");
            carros.Cmodelo = (Console.ReadLine());

            Console.WriteLine("Insira o ano do Veiculo: ");
            carros.ANO = int.Parse(Console.ReadLine());

            Console.WriteLine(carros);
        }
    }
}
