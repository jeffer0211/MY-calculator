using System;

namespace Calculadora
{
    class Sum
    {
        private double a;
        private double b;
        private double r;
        public  Sum(double pa, double pb)
        {
            a = pa;
            b = pb;
          
        }
        public double R
        {
            get { return r; }
        }
        public void operaction()
        {
            r= a + b;
        }

    }
}
