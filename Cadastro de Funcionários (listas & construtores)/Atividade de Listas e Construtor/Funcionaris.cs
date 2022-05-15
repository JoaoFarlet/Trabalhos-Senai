using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_de_Listas_e_Construtor
{
    class Funcionaris
    {
        public string Nomis;
        public int Idadis;
        public string Emailis;
        public string Departamentis;
        public int Salaris;


        public Funcionaris(string nome, int salario, int idade, string email, string departamento)
        {
            Nomis = nome;
            Salaris = salario;
            Idadis = idade;
            Emailis = email;
            Departamentis = departamento;
        }

        public override string ToString()
        {
            return "Nome: " + Nomis
                + "\nIdade: " + Idadis
                + "\nEmai: " + Emailis
                + "\nDepartamento: " + Departamentis
                + "\nSalario: " + Salaris;
        }
    }
}
