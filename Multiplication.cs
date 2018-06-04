using System;

namespace Calculadora
{
    class Multiplication
    {
        private double a;
        private double b;
        private double r;
        public  Multiplication(double pa, double pb)
        {
            a = pa;
            b = pb;
          
        }
        public double R
        {
            get { return r; }
        }
        public void operactionMulti()
        {
            r= a * b;
        }    
    
    }
}
 