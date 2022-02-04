using System;
using static System.Console;

namespace Задача_2
{
    class Program
    {
        static string Meth(string txt)
        {
            string text = "";
            for (int i = 0; i < txt.Length; i++)
            {
                text = txt[i] + text;
            }
            return text;
        }
        static void Main(string[] args)
        {
            String txt = "The quick brown fox jumps over the lazy dog.";
            WriteLine("Оригиналното изречение:\n" + txt);
            WriteLine("Изречението в обратен реди:\n" + Meth(txt));

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
