using System;
using static System.Console;

namespace Задача_6
{
    class Program
    {
        static void Meth(string a){
            String s = a;
            s = s.Replace("'","");
            s = s.Replace(" ","");
            s = s.Replace(".","");
            s = s.Replace("?","");
            s = s.Replace(",","");
            s = s.Replace("!","");
            s = s.Replace("?","");
            s = s.ToLower();
            char[] letters = s.ToCharArray();
            Array.Sort(letters);
            for(int i = 0; i < letters.Length; i++){
                Write(letters[i]+"");
            }
            WriteLine();
        }
        static void Main(string[] args)
        {
            String text = "The quick brown fox jumps over the lazy dog.'?!,";
            Meth(text);

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
