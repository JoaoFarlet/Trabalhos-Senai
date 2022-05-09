using System;

namespace exercicios_de_classes
{
    class Program
    { 
        static void Main(string[] args)
        {
            pessoas pessoas1, pessoas2, pessoas3;
            pessoas1 = new pessoas();
            pessoas2 = new pessoas();
            pessoas3 = new pessoas();

            
            Console.WriteLine("Insira o nome da pessoa:");
            pessoas1.Nome = Console.ReadLine();
            Console.WriteLine("Insira o peso da pessoa:");
            pessoas1.Peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a altura da pessoa:");
            pessoas1.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a idade da pessoa:");
            pessoas1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o nome da pessoa:");
            pessoas2.Nome = Console.ReadLine();
            Console.WriteLine("Insira o peso da pessoa:");
            pessoas2.Peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a altura da pessoa:");
            pessoas2.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a idade da pessoa:");
            pessoas2.idade = int.Parse(Console.ReadLine());


            Console.WriteLine("Insira o nome da pessoa:");
            pessoas3.Nome = Console.ReadLine();
            Console.WriteLine("Insira o peso da pessoa:");
            pessoas3.Peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a altura da pessoa:");
            pessoas3.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a idade da pessoa:");
            pessoas3.idade = int.Parse(Console.ReadLine());

            double PessoaPeso = ComparaPeso(pessoas1.Peso, pessoas2.Peso, pessoas3.Peso);
            int PessoaIdade = ComparaIdade(pessoas1.idade, pessoas2.idade,pessoas3.idade);
            Console.WriteLine("A pessoa com maior peso apresentado foi: " + PessoaPeso);
            Console.WriteLine("A pessoa com maior Idade apresentada foi: " + PessoaIdade);

        }
        static double ComparaPeso(double a, double b, double c)
        {
            if (a > b && b > c)
            {
                return a;
            }
            else if (b > a && c < b)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        static int ComparaIdade(int a, int b, int c)
        {
            if (a > b && b > c)
            {
                return a;
            }
            else if (b > a && a >c)
            {
                return b;
            }
            else
            {
                return c;
            }
        
                    
        
        }



    }
}
