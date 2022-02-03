using System;
using static System.Console;

namespace Листинг_7._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a String variable and displaying it
            String txt = "Ние изучаваме C#";
            WriteLine(txt);

            //creating a String variable with no value
            String str;
            //assigning the variables value to the string value + a word at the 14th position
            str = txt.Insert(14, "езика ");
            //diplating it
            WriteLine(str);

            //assigning the variables value to the string value + adding a word at the 4th position
            //replacing a word with another one
            str = str.Insert(4, "не ").Replace("C#", "JavaScript");
            //displaying it
            WriteLine(str);

            //replacing the spaces with underscores
            str = str.Replace(" ", "_");
            //displaying the variable
            WriteLine(str);

            //extracting the charaters form the 3dr to the 14th index
            str = str.Substring(3, 14);
            //displaying the variable
            WriteLine(str);

            //extracting the characters form the 4th index
            str = str.Substring(4);
            //displaying the variable
            WriteLine(str);

            //displaying the original string
            WriteLine(txt);

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
