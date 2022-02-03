using System;
using static System.Console;

namespace Листинг_7._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //creation of a String class object
            String txt = "И така, две плюс две, умножено на две прави шест";
            //displaying the object
            WriteLine("Изходен текст:");
            WriteLine("\"{0}\"", txt);

            //creating a String class object
            String str = "две";

            //displaying the object
            WriteLine("Низ за търсене:");
            WriteLine("\"{0}\"", str);

            //creating an int variable and assigning its value with the index of first appearance of the object
            int index;
            index = txt.IndexOf(str);
            //displaying it
            WriteLine("Първо съвпадение :{0}", index);

            //assigning the variables value to index of the second appearance of the object
            index = txt.IndexOf(str, index + 1);
            //displaying it
            WriteLine("Второ съвпадение: {0}", index);

            //assigning the variables value to the index of the last appearance of the object
            index = txt.LastIndexOf(str);
            //displaying it
            WriteLine("Последно съвпадение: {0}", index);

            //creating 2 int variables
            int a = 9, b = 10;
            //displaying form which index and for how many charecters the function will be searching for the object
            WriteLine("Търсене от {0}-я индекс до {1} символа", a, b);

            //assigning the variable to the index of the object between the 9th and 18th element 
            index = txt.IndexOf(str, a, b);
            //displaying it
            WriteLine("Съвпадение на индекс: {0}", index);

            //adding 3 to the value of the variable b
            b += 3;
            //displaying form which index and for how many charecters the function will be searching for the object
            WriteLine("Търсене от {0}-я индекс до {1} символа:", a, b);
            //assigning the variable to the index of the object between the 9th and 21th element
            index = txt.IndexOf(str, a, b);
            //displaying it
            WriteLine("Съвпадение на индекс: {0}", index);

            //creating a charater variable, assigning it and displaying what letter will be searched for
            char symb = 'е';
            WriteLine("Сега търсим буква \'{0}\'", symb);

            //assigning the variable to the index of the first appearance of the letter
            index = txt.IndexOf(symb);
            //displaying it
            WriteLine("Първо съвпадение: {0}", index);

            //assigning the variable to the index of the second appearance of the of the letter
            index = txt.IndexOf(symb, index + 1);
            //displaying it
            WriteLine("Второ съпадение: {0}", index);

            //assigning the variable to the index of the last appearance of the letter
            index = txt.LastIndexOf(symb);
            //displaying it
            WriteLine("Последно съвпадение: {0}", index);

            //assigning the variable to the index of the appearance of the letter before the last 
            index = txt.LastIndexOf(symb, index - 1);
            //displaying it
            WriteLine("Пресдоследното съвпадение: {0}", index);

            //assigning the variable to the index of the appearance of the letter between the 9th and 21th
            index = txt.IndexOf(symb, a, b);
            //displaying it
            WriteLine("Търсене в интервала от индексите от {0} до {1}", a, a + b - 1);
            WriteLine("Първото съвпадение в интервала: {0}", index);

            //assigning the variable to the index of the last appearance of the letter
            index = txt.LastIndexOf(symb, b, b + 1);
            //displaying it
            WriteLine("Търсене до индекс {0}", b);
            WriteLine("Последно съвпадение в интервала: {0}", index);

            //the letter is replaced by another one
            symb = 'я';
            //displaying the letter
            WriteLine("Търсим буква \'{0}\'", symb);

            //assigning the variable to the index of the first appearance of the letter
            index = txt.IndexOf(symb);
            //displaying it
            WriteLine("Първо съвпадение: {0}", index);

            //creating a charater array and displaying its contents
            char[] s = { 'я', 'е', 'с' };
            Write("Търсим буква \'{0}\'", s[0]);
            for (int i = 1; i < s.Length - 1; i++)
            {
                Write(",\'" + s[i] + "\'");
            }
            WriteLine(" или \'" + s[s.Length - 1] + "\':");

            //assigning the variable to the index of the first appearance of one of the letters in the array
            index = txt.IndexOfAny(s);
            //displaying it
            WriteLine("Първо съвпадение: {0}", index);

            //assigning the variable to the index of the second appearance of one of the letters in the array
            index = txt.IndexOfAny(s, index + 1);
            //displaying it
            WriteLine("Второ съвпадение: {0}", index);

            //assigning the variable to the index of the last appearance of one of the letters in the array
            index = txt.LastIndexOfAny(s);
            //displaying it
            WriteLine("Последно съвпадение: {0}", index);
            
            //displaying the interval from which the index will be searched
            WriteLine("Търсене в интервала от индексите от {0} до {1}", a, a + b - 1);
            //assigning the variable to the index of the first appearance of one of the letters in the interval in the array
            index = txt.IndexOfAny(s, a, b);
            //displaying it
            WriteLine("Първо съвпадение в интервала: {0}", index);

            //assigning the variable to the index of the last appearance of one of the letters in the interval in the array
            index = txt.LastIndexOfAny(s, a + b - 1, b);
            //displaying it
            WriteLine("Последно съвпадение в интервала: {0}", index);

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
