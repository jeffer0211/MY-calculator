using System;

namespace Calculadora
{
    class Square_root
    {
        private double a;
        
        private double r;
        public  Square_root(double pa)
        {
            a = pa;
            
          
        }
        public double R
        {
            get { return r; }
        }
        public void operactionRoot()
        {
            r= Math.Sqrt(a);
        }    
        
    }
}
