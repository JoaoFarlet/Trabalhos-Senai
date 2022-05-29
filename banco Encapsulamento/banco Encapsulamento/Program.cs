using System;

namespace banco_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();


            Console.WriteLine("Insira o nome do propietário da conta:");
            string nome = Console.ReadLine();

            Console.WriteLine("Insira o numero da conta:");
            string Numeroconta = Console.ReadLine();

            Console.WriteLine("Gostaria de efetuar alguma operação? D/S");
            

            string op = Console.ReadLine();

            string OP = op.ToLower();

            double valor;

            if (OP == "d")
            {
                do
                {
                    Console.WriteLine("Insira o valor do Deposito:");
                    valor = double.Parse(Console.ReadLine());
                } while (valor == 0 || valor < 0);
                
                conta.deposit(valor);
            }

            else if (OP == "s")
            {
                do
                {
                    Console.WriteLine("Insira o valor do Saque:");
                 valor = double.Parse(Console.ReadLine());
                conta.Sacar(valor);
                } while (conta.Saldo == 0 || conta.Saldo < 0);
            }

            Console.WriteLine("As informações inseridas foram:");


            Console.WriteLine(conta.Nome);
            Console.WriteLine(conta.Saldo);
            Console.WriteLine(conta.NumerCont);



        }
    }
}
