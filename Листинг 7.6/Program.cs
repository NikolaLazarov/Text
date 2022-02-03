using System;
using static System.Console;

namespace Листинг_7._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a String type variable and assigning it
            String txt = "Пътят ще укрепи ходeщия";
            //displaying the variable
            WriteLine(txt);

            //creating a String type variable without assigning it
            String str;
            //assinging the variables value to the variable "txt" in upper case
            str = txt.ToUpper();
            //displaying the variable
            WriteLine(str);

            //assigning the variables value to the variable "txt" in lower case
            str = txt.ToLower();
            //displaying the variable
            WriteLine(str);

            //creating a String type array with no contents
            String[] words;
            //assigning the arrays contents to each word in the variable "txt"
            words = txt.Split();

            //displaying the array
            for (int i = 0; i < words.Length; i++)
            {
                WriteLine((i + 1) + ": " + words[i]);
            }
            WriteLine();

            //assinging the arrays contents to each word in the variable "txt"
            //split in the places where the two arguments are present
            words = txt.Split('ъ', 'и');
            //displaying the array
            for (int i = 0; i < words.Length; i++)
            {
                WriteLine((i + 1) + ": " + words[i]);
            }
            WriteLine();

            //assigning the arrays contents to each word in the variable "txt"
            //split in 3 places where the the new arrays contets are present
            words = txt.Split(new char[] { 'ъ', 'и' }, 3);
            //displaying the array
            for (int i = 0; i < words.Length; i++)
            {
                WriteLine((i + 1) + ": " + words[i]);
            }
            WriteLine();

            //creating a new array
            char[] symbs;
            //assigning its contents to each charater in the variable "txt"
            symbs = txt.ToCharArray();
            //displaying the array
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
