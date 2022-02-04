using System;
using static System.Console;

namespace Задача_3
{
    class Program
    {
        static bool Meth(string a, string b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i]) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            String a = "The quick brown fox jumps over the lazy dog.";
            String b = "The quick brown fox jumps over the lazy dog.";
            String c = "The quick brown fox jumps over the lazy cat.";

            WriteLine("a = b: {0}", Meth(a, b));
            WriteLine("a = c: {0}", Meth(a, c));
            WriteLine("b = c: {0}", Meth(b, c));

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
