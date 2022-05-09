using System;

namespace exercicios_de_classes_parte_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Animais animais1;
            animais1 = new Animais();
            
            Console.WriteLine("insira o nome do animal");
            animais1.nome = Console.ReadLine();
            Console.WriteLine("Insira quantas patas o animal possui:");
            animais1.patas = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a especie em questão");
            animais1.especie = Console.ReadLine();

            Console.WriteLine("os valores inseridos foram:" +
                animais1.nome+
                " "+
                animais1.patas+
                " "+
                animais1.especie);
        }
    }
}
