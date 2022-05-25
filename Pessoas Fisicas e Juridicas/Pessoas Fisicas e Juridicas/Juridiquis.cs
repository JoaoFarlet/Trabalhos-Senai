using System;
using System.Collections.Generic;
using System.Text;

namespace Pessoas_Fisicas_e_Juridicas
{
    class Juridiquis
    {
        string cnpj;
        string inscrEstadual;
        string endereco;
        public Juridiquis(string CNPJ, string inscriEsta, string Ender)
        {
            cnpj = CNPJ;
            inscrEstadual = inscriEsta;
            endereco = Ender;
        }
    }
}
