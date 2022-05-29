using System;
using System.Collections.Generic;
using System.Text;

namespace banco_Encapsulamento
{
    class Conta
    {
        public string Nome { get; set; }
        public int NumerCont { get; set; }
        public int Saldo { get; private set; }


        public Conta(string nome, int numero, int saldo)
        {
            Nome = nome;
            NumerCont = numero;
        }

        public Conta()
        {
        }

        public void Sacar(double valor)
        {
            valor -= Saldo;
        }

        public void deposit(double valor)
        {
            valor += Saldo;
        }



    }
}
