using System;
using System.Collections.Generic;

namespace Pessoas_Fisicas_e_Juridicas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t### Programa para Cadastro de P.F. e P.J.###\n");

            string repetir;
            List<Fisiquis> PF = new List<Fisiquis>();
            List<Juridiquis> PJ = new List<Juridiquis>();

            do
            {
                Console.WriteLine("Gostaria de adcionar CPF ou CNPJ?");
                string Tcadastr = Console.ReadLine();
                Tcadastr.ToLower();

                

                if (Tcadastr == "cpf")
                {
                    Console.WriteLine("insira o número de Registro Geral (R.G.): ");
                    string Rg = Console.ReadLine();

                    Console.WriteLine("insira a Data de Nascimento (DD/MM/AAAA): ");
                    string Niver = Console.ReadLine();

                    Console.WriteLine("insira o número de Cadastro de Pessoa Física (C.P.F.): ");
                    string Cpf = Console.ReadLine();

                    PF.Add(new Fisiquis(Rg,Niver,Cpf));
                }
                else if (Tcadastr== "cnpj")
                {
                    Console.WriteLine("insira o número de CNPJ: ");
                    string CNPJ = Console.ReadLine();

                    Console.WriteLine("insira O NUMERO DE INSCRIÇÃO ESTADUAL: ");
                    string inscriEsta = Console.ReadLine();

                    Console.WriteLine("insira o ENDEREÇO: ");
                    string Ender = Console.ReadLine();


                    PJ.Add(new Juridiquis(CNPJ, inscriEsta, Ender));
                }
                repetir = Console.ReadLine();
                repetir.ToLower();
            } while (repetir == "s");

            Console.WriteLine("-----------------------------------------------");

            foreach (Fisiquis obj in PF)
            {
                Console.WriteLine(obj);
            }
            foreach (Juridiquis obj in PJ)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("--------------------------------------------");
        }
    }
}
