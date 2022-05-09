using System;

namespace Trabalho_Assincrono_4._05._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcular operador1, termo1, termo2;

            operador1 = new Calcular();
            termo1 = new Calcular();
            termo2 = new Calcular();

            double resultadoOp;

            Console.WriteLine("########### Programa que calcula dois Termos Matematicos ###########");

            Console.WriteLine("Insira o tipo de calculo a ser feito pelo programa:");
            operador1.operador = Console.ReadLine();

            Console.WriteLine("Insira os valores a serem calculados:");

            Console.WriteLine("Primeiro Valor:");
                termo1.primeiro = double.Parse(Console.ReadLine());
            Console.WriteLine("Primeiro Valor:");
                termo2.segundo = double.Parse(Console.ReadLine());

                if(operador1.operador == "M"|| operador1.operador =="m")
                {
                    resultadoOp = Multiplica(termo1.primeiro, termo2.segundo);
                Console.WriteLine("o Resultado do calculo foi: " + resultadoOp);
                }
                else if (operador1.operador == "S" || operador1.operador == "s")
                {
                    resultadoOp = Somat(termo1.primeiro, termo2.segundo);
                Console.WriteLine("o Resultado do calculo foi: " + resultadoOp);
                }

                else if (operador1.operador == "D" || operador1.operador == "d")
                {
                resultadoOp = Divisa(termo1.primeiro, termo2.segundo);
                Console.WriteLine("o Resultado do calculo foi: " + resultadoOp);
                }
                else if (operador1.operador == "Sub" || operador1.operador == "sub")
                {
                resultadoOp = Subtra(termo1.primeiro, termo2.segundo);
                Console.WriteLine("o Resultado do calculo foi: " + resultadoOp);
                }
                else
                {
                Console.WriteLine("Operação não identificada. Tente novamente!");
                }

            
             

            //defino as funções das operações
            static double Multiplica(double A, double B)
            {
                return A * B;
            }
            static double Somat(double A, double B)
            {
                return A + B;
            }
            static double Subtra(double A, double B)
            {
                return A - B;
            }
            static double Divisa(double A, double B)
            {
                return A / B;
            }
        
        }
    }
}
