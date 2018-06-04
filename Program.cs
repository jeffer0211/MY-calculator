using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("MY calculator");
            
            Console.WriteLine("Numbers to calculate: 100 and  25 ");
            
            Sum micalcula = new Sum(100, 25);
            micalcula.operaction();
            Console.WriteLine("The sum is: {0}",micalcula.R);
            
            Subtraction misubtra =new Subtraction(100, 25);
            misubtra.operactionSubtra();
            Console.WriteLine("The subtraction is: {0}",misubtra.R);

            Multiplication mimult = new Multiplication(100, 25);
            mimult.operactionMulti();
            Console.WriteLine("The Multiplication is: {0}", mimult.R);

            Division midiv = new Division(100, 25);
            midiv.operactionDivi();
            Console.WriteLine("The Division is: {0}", midiv.R);

            Square_root miroot = new Square_root(100);
            miroot.operactionRoot();
            Console.WriteLine("The Square Root is: {0}", miroot.R);
            
        }
    }
}
