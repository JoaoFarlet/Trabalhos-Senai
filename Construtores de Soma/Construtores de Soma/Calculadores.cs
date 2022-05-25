using System;
using System.Collections.Generic;
using System.Text;

namespace Construtores_de_Soma
{
    class Calculadores
    {
        
        public double X;
        public double Y;
        public double A;
        public double C;


        public Calculadores()
        {
            
        }
        public Calculadores(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Calculadores(int x, int y, int c) : this(x, y)
        {
            C = c;
        }
        

        public double Somartor()
        {
            return X + Y + A + C;
        }

        public Calculadores(double x, int y)
        {
            X = x;
            Y = y;
        }

        public double Somator2(double x, int y)
        {
            X = x;
            Y = y;
            return X + Y;
        }
    }
}
