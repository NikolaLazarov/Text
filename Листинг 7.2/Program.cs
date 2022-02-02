using System;
using static System.Console;

namespace Листинг_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //displaying every character in the string
            foreach (char s in "Текст")
            {
                Write(s + " ");
            }
            WriteLine();

            //displaying every character in the string with underscores in between
            for (int i = 0; i < "Тескт".Length; i++)
            {
                Write("Текст"[i] + "_");
            }
            WriteLine();

            //displaying the string
            String A = "Изучаваме C#";
            for (int i = 0; i < A.Length; i++)
            {
                Write(A[i]);
            }
            WriteLine();

            //calling the function with one argument
            showReversed(A);
            //displaying the original string
            WriteLine(A);
            //assigning the function to B and displaying it
            String B = getReversed(A);
            WriteLine(B);

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
        //displaying the string in reverse
        static String getReversed(String text)
        {
            String str = "";
            foreach (char s in text)
            {
                str = s + str;
            }
            return str;
        }
        //displaying the string in reverse
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
