using System;
using static System.Console;

namespace Листинг_7._5
{
    class Program
    {
        static void Main(string[] args)
        {
            String txt = "Ние изучаваме C#";
            WriteLine(txt);

            String str;
            str = txt.Insert(14, "езика ");
            WriteLine(str);

            str = str.Insert(4, "не ").Replace("C#", "JavaScript");
            WriteLine(str);

            str = str.Replace(" ", "_");
            WriteLine(str);

            str = str.Substring(3, 14);
            WriteLine(str);

            str = str.Substring(4);
            WriteLine(str);

            WriteLine(txt);

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
