using System;
using static System.Console;

namespace Задача_1
{
    class Program
    {
        static void Meth(string txt)
        {
            char[] t = txt.ToCharArray();
            for (int i = 0; i < t.Length; i++)
            {
                Write(t[i] + " ");
            }
            WriteLine();
        }
        static void Main(string[] args)
        {
            String txt = "The quick brown fox jumped over the lazy dog.";
            Meth(txt);

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
