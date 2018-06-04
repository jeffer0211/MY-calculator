using System;

namespace Calculadora
{
    class Division
    {
        private double a;
        private double b;
        private double r;
        public Division(double pa, double pb)
        {
            a = pa;
            b = pb;
          
        }
        public double R
        {
            get { return r; }
        }
        public void operactionDivi()
        {
            r= a / b;
        }    
    }
}
