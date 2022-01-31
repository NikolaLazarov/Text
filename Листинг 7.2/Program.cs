using System;
using static System.Console;

namespace Листинг_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (char s in "Текст")
            {
                Write(s + " ");
            }
            WriteLine();

            for (int i = 0; i < "Тескт".Length; i++)
            {
                Write("Текст"[i] + "_");
            }
            WriteLine();

            String A = "Изучаваме C#";
            for (int i = 0; i < A.Length; i++)
            {
                Write(A[i]);
            }
            WriteLine();

            showReversed(A);
            WriteLine(A);
            String B = getReversed(A);
            WriteLine(B);

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
        static String getReversed(String text)
        {
            String str = "";
            foreach (char s in text)
            {
                str = s + str;
            }
            return str;
        }
        static void showReversed(String text)
        {
            for (int i = text.Length - 1; i >= 0; i--)
            {
                Write(text[i]);
            }
            WriteLine();
        }
    }
}
