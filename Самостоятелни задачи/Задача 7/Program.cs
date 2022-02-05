using System;
using static System.Console;

namespace Задача_7
{
    class Program
    {
        static string Meth(string text, int a, int b)
        {
            String ntext = "";
            for (int i = a; i < b; i++)
            {
                ntext += text[i];
            }
            return ntext;
        }
        static string Meth(string text, int a)
        {
            String ntext = "";
            for (int i = a; i < text.Length; i++)
            {
                ntext += text[i];
            }
            return ntext;
        }
        static void Main(string[] args)
        {
            String txt = "The quick brown fox jumps over the lazy dog";
            WriteLine("The original text:\n{0}", txt);
            WriteLine("The text from index 3 to index 17:\n{0}", Meth(txt, 3, 17));
            WriteLine("The text from index 5:\n{0}", Meth(txt, 5));

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
