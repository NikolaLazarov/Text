using System;
using static System.Console;

namespace Листинг_7._6
{
    class Program
    {
        static void Main(string[] args)
        {
            String txt = "Пътят ще укрепи ходящия";
            WriteLine(txt);

            String str;
            str = txt.ToUpper();
            WriteLine(str);

            str = txt.ToLower();
            WriteLine(str);

            String[] words;
            words = txt.Split();

            for (int i = 0; i < words.Length; i++)
            {
                WriteLine((i + 1) + ": " + words[i]);
            }
            WriteLine();

            words = txt.Split('ъ', 'и');
            for (int i = 0; i < words.Length; i++)
            {
                WriteLine((i + 1) + ": " + words[i]);
            }
            WriteLine();

            words = txt.Split(new char[] { 'ъ', 'и' }, 3);
            for (int i = 0; i < words.Length; i++)
            {
                WriteLine((i + 1) + ": " + words[i]);
            }
            WriteLine();

            char[] symbs;
            symbs = txt.ToCharArray();
            for (int i = 0; i < symbs.Length; i++)
            {
                Write(symbs[i] + " ");
            }
            WriteLine();


            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
