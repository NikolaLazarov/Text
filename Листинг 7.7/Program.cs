using System;
using static System.Console;

namespace Листинг_7._7
{
    class myClass
    {
        public int num;
        public char symb;
        public myClass(int n, char s)
        {
            num = n;
            symb = s;
            WriteLine("Създаден е нов обект\n" + this);
        }
        public override string ToString()
        {
            String txt = "Частно поле: " + num;
            txt += "\nСимволно поле: " + symb;
            return txt;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myClass obj = new myClass(100, 'A');
            obj.num = 200;
            obj.symb = 'B';
            WriteLine("Нови стойности на полетата на обекта");
            WriteLine(obj);

            String[] str = obj.ToString().Split('\n');
            for (int i = 0; i < str.Length; i++)
            {
                WriteLine("[* " + str[i] + " *]");
            }


            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
