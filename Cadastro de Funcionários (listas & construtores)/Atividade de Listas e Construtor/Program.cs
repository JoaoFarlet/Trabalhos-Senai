using System;
using System.Collections.Generic;

namespace Atividade_de_Listas_e_Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionaris> Trabalhadoris = new List<Funcionaris>();

            string opcao;

            do
            {
                Console.WriteLine("###Programa para Cadastro de novos Funcinarios###  \n");
                Console.Write("Insira o nome do funcionario: ");
                string nome = Console.ReadLine();

                Console.Write("Insira o salario do funcionario: ");
                int salario = int.Parse(Console.ReadLine());

                Console.Write("Insira a idade do funcionario: ");
                int idade = int.Parse(Console.ReadLine());

                Console.Write("Insira o  com o e-mail do funcionario: ");
                string email = Console.ReadLine();

                Console.Write("Insira o  o departamento do funcionario: ");
                string departamento = Console.ReadLine();
                departamento.ToLower();

                Trabalhadoris.Add(new Funcionaris(nome, salario, idade, email, departamento));

                Console.Write("Deseja cadastrar novo funcionario?");
                opcao = (Console.ReadLine());
            } while (opcao == "S" || opcao == "s");

            Console.WriteLine("###################################################################");

            foreach (Funcionaris obj in Trabalhadoris)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("###################################################################");

            int contadorRh = 0;
            if (Trabalhadoris.Exists(x => x.Departamentis == "rh"))
            {
                foreach (Funcionaris obj in Trabalhadoris)
                {
                    contadorRh++;
                }
                Console.WriteLine("Rh:"+contadorRh);
            }

            int contadorDesing = 0;
            if (Trabalhadoris.Exists(x => x.Departamentis == "desing"))
            {
                foreach (Funcionaris obj in Trabalhadoris)
                {
                    contadorDesing++;
                }
                Console.WriteLine("Desing:"+contadorDesing);
            }


            int contadorTI = 0;
            if (Trabalhadoris.Exists(x => x.Departamentis == "ti"))
            {
                foreach (Funcionaris obj in Trabalhadoris)
                {
                    contadorTI++;
                }
                Console.WriteLine("TI:"+contadorTI);
            }
        }
    }
}

