using System;
using static System.Console;

namespace Листинг_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //defining a charater array with several elements and we display it on the console
            char[] symbs = { 'Е', 'З', 'И', 'К', ' ', 'C', '#' };
            WriteLine("Simvolen masilv: ");
            WriteLine(symbs);

            //displaying the array in quotes
            String A = new String(symbs);
            WriteLine("A: \"{0}\"", A);

            //displaying the array in quotes beginning from the second element
            String B = new String(symbs, 1, 6);
            WriteLine("B: \"{0}\"", B);

            //displaying one symbol seven times;
            String C = new String('И', 7);
            WriteLine("C: \"{0}\"", C);

            //assigning the function ((getText) with 2 references) to A and displaying it
            A = getText('A', 'H');
            WriteLine("A: \"{0}\"", A);

            //assinging the function ((getText) with 2 references) to B and displaying it
            B = getText('H', 'A');
            WriteLine("B: \"{0}\"", B);

            //assigning the function ((getText) with 1 reference) to C and displaying
            C = getText(symbs);
            WriteLine("C: \"{0}\"", C);

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
        //displays the array
        static String getText(char[] symbs)
        {
            String text = " ";
            for (int i = 0; i < symbs.Length; i++)
            {
                text += symbs[i];
            }
            return text;
        }
        //displays the charaters between the symbols
        static String getText(char a, char b)
        {
            String text = "";
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
