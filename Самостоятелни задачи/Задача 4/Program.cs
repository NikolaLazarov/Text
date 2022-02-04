using System;
using static System.Console;

namespace Задача_4
{
    class Program
    {
        static bool Meth(string a, string b){
            if (a.Length != b.Length) return false;
            return true;
        }
        static void Main(string[] args)
        {
            String a = "This sentence is 5 words long";
            String b = "That one is not 67 words long";
            String c = "This one is 5 words long too";
            WriteLine("a = b: {0}", Meth(a, b));
            WriteLine("a = c: {0}", Meth(a, c));
            WriteLine("b = c: {0}", Meth(b, c));

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
