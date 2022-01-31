using System;
using static System.Console;

namespace Листинг_7
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] symbs = { 'E', 'Z', 'I', 'K', ' ', 'C', '#' };
            WriteLine("Simvolen masilv: ");
            WriteLine(symbs);

            String A = new String(symbs);
            WriteLine("A: \"{0}\"", A);

            String B = new String(symbs, 1, 5);
            WriteLine("B: \"{0}\"", B);

            String C = new String('i', 7);
            WriteLine("C: \"{0}\"", C);

            A = getText('A', 'H');
            WriteLine("A: \"{0}\"", A);

            B = getText('H', 'A');
            WriteLine("B: \"{0}\"", B);

            C = getText(symbs);
            WriteLine("C: \"{0}\"", C);

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
        static String getText(char[] symbs)
        {
            String text = " ";
            for (int i = 0; i < symbs.Length; i++)
            {
                text += symbs[i];
            }
            return text;
        }
        static String getText(char a, char b)
        {
            String text = " ";
            char s = a;
            while (s <= b)
            {
                text += s;
                s++;
            }
            return text;
        }
    }
}
