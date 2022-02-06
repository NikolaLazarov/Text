using System;
using static System.Console;

namespace Задача_10
{
    class myClass{
        public void csc(int x){
            WriteLine("{0}",Math.Cos(x));
            WriteLine("{0}",Math.Sinh(x));
            WriteLine("{0}",Math.Cosh(x));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myClass obj = new myClass();
            obj.csc(5);
            
            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
