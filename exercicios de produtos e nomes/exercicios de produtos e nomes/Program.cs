using System;

namespace exercicios_de_produtos_e_nomes
{
    class Program
    {
        static void Main(string[] args)
        {
            DadosPessoais dados1;
            dados1 = new DadosPessoais();

            double saldoatual;
            
                Console.WriteLine("insira os dados pedidos: ");
                dados1.nome = Console.ReadLine();

                Console.WriteLine("insira a idade do dono da conta: ");
                dados1.idade = int.Parse(Console.ReadLine());

                Console.WriteLine("insira o número da conta:");
                dados1.nmrConta = int.Parse(Console.ReadLine());

                Console.WriteLine("insira o saldo inicial da conta");
                dados1.saldo = double.Parse(Console.ReadLine());


            Console.WriteLine("deseja fazer um saque ou depósito?");
            string mod = Console.ReadLine();

            if (mod =="s"|| mod == "S")
            {
                Console.WriteLine("Insira o valor do saque:");
                double saque = double.Parse(Console.ReadLine());
                saldoatual = SaqueDinheiro(dados1.saldo,saque);
                Console.WriteLine("seu saldo atual é de: " + saldoatual);
            }
            else if (mod == "d" || mod == "D")
            {
                Console.WriteLine("Insira o valor do Depósito:");
                double Deposit = double.Parse(Console.ReadLine());
                saldoatual = DepositDinheiro(dados1.saldo, Deposit);
                Console.WriteLine("seu saldo atual é de: " + saldoatual);
            }
            else
            {
                Console.WriteLine("transferencia inválida:");
            }
        }
        static double SaqueDinheiro (double saldo, double saque)
        {
            return saldo - saque;
        }
        static double DepositDinheiro(double saldo, double Deposit)
        {
            return saldo + Deposit;
        }

    }
}
