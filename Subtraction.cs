using System;

namespace Calculadora
{
    class Subtraction
    {
        private double a;
        private double b;
        private double r;
        public  Subtraction(double pa, double pb)
        {
            a = pa;
            b = pb;
          
        }
        public double R
        {
            get { return r; }
        }
        public void operactionSubtra()
        {
            r= a - b;
        }    
    }
}
