using System;
using System.Collections.Generic;
using System.Text;
using enum_2.Entities;


namespace enum_2
{
    class Carro
    {
        public string Ccor { get; set; }
        public Etcambio Ccambio { get; set; }
        public Etcombust CtCumbustivel { get; set; }
        public string Cmodelo { get; set; }
        public Emarca Cmarca  { get; set; }
        public int ANO { get; set; }
        

        public override string ToString()
        {
            return

                "cor " + Ccor +
                "cambio " + Ccambio +
                "Tipo de combustivel " + CtCumbustivel +
                "Modelo " + Cmodelo +
                "Marca " + Cmarca +
                "ano " + ANO;
        }
        
    }
}
