using System;
using static System.Console;

namespace Задача_8
{
    class myClass
    {
        public String text;
        private int a;
        private string b;
        public void Meth(int a, string b)
        {
            this.a = a;
            this.b = b;
            WriteLine("The new string:\n{0}", this);
        }
        public override string ToString()
        {
            text = text.Insert(a, b);
            return text;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myClass obj = new myClass();
            obj.text = "The quick brown fox jumps over the lazy dog.";
            WriteLine("The original text:\n{0}", obj.text);
            obj.Meth(20, "maybe ");

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
