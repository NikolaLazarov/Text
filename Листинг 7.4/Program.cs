using System;
using static System.Console;

namespace Листинг_7._4
{
    class Program
    {
        static void Main(string[] args)
        {
            String txt = "И така, две плюс две, умножено на две прави шест";
            WriteLine("Изходен текст:");
            WriteLine("\"{0}\"", txt);

            String str = "две";

            WriteLine("Низ за търсене:");
            WriteLine("\"{0}\"", str);

            int index;
            index = txt.IndexOf(str);
            WriteLine("Първо съвпадение :{0}", index);

            index = txt.IndexOf(str, index + 1);
            WriteLine("Второ съвпадение: {0}", index);

            index = txt.LastIndexOf(str);
            WriteLine("Последно съвпадение: {0}", index);

            int a = 9, b = 10;
            WriteLine("Търсене от {0}-я индекс до {1} символа", a, b);

            index = txt.IndexOf(str, a, b);
            WriteLine("Съвпадение на индекс: {0}", index);

            b += 3;
            WriteLine("Търсене от {0}-я индекс до {1} символа:", a, b);
            index = txt.IndexOf(str, a, b);
            WriteLine("Съвпадение на индекс: {0}", index);

            char symb = 'е';
            WriteLine("Сега търсим буква \'{0}\'", symb);

            index = txt.IndexOf(symb);
            WriteLine("Първо съвпадение: {0}", index);

            index = txt.IndexOf(symb, index + 1);
            WriteLine("Второ съпадение: {0}", index);

            index = txt.LastIndexOf(symb);
            WriteLine("Последно съвпадение: {0}", index);

            index = txt.LastIndexOf(symb, index - 1);
            WriteLine("Пресдоследното съвпадение: {0}", index);

            index = txt.IndexOf(symb, a, b);
            WriteLine("Търсене в интервала от индексите от {0} до {1}", a, a + b - 1);
            WriteLine("Първото съвпадение в интервала: {0}", index);

            index = txt.LastIndexOf(symb, b, b + 1);
            WriteLine("Търсене до индекс {0}", b);
            WriteLine("Последно съвпадение в интервала: {0}", index);

            symb = 'я';
            WriteLine("Търсим буква \'{0}\'", symb);

            index = txt.IndexOf(symb);
            WriteLine("Първо съвпадение: {0}", index);

            char[] s = { 'я', 'е', 'с' };
            Write("Търсим буква \'{0}\'", s[0]);
            for (int i = 0; i < s.Length - 1; i++)
            {
                Write(",\'" + s[i] + "\'");
            }
            WriteLine(" или \'" + s[s.Length - 1] + "\':");

            index = txt.IndexOfAny(s);
            WriteLine("Първо съвпадение: {0}", index);

            index = txt.IndexOfAny(s, index + 1);
            WriteLine("Второ съвпадение: {0}", index);

            index = txt.LastIndexOfAny(s);
            WriteLine("Последно съвпадение: {0}", index);
            WriteLine("Търсене в интервала от индексите от {0} до {1}", a, a + b - 1);

            index = txt.IndexOfAny(s, a, b);
            WriteLine("Първо съвпадение в интервала: {0}", index);

            index = txt.LastIndexOfAny(s, a + b - 1, b);
            WriteLine("Последно съвпадение в интервала: {0}", index);

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
