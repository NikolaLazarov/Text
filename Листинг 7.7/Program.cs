using System;
using static System.Console;

namespace Листинг_7._7
{
    //defining new class
    class myClass
    {
        //creating an int and a character variables
        public int num;
        public char symb;
        //defining a constructor with two arguments
        public myClass(int n, char s)
        {
            //the variables get their values from the constructors arguments
            num = n;
            symb = s;
            //displaying the object with a reference to the function toString
            WriteLine("Създаден е нов обект\n" + this);
        }
        //pre-defining a toString function
        public override string ToString()
        {
            //creating a String variable and assigning its value
            String txt = "Частно поле: " + num;
            txt += "\nСимволно поле: " + symb;
            //returning the variables value
            return txt;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //creating a new object
            //with reference to a constructor
            myClass obj = new myClass(100, 'A');
            //changing the objects variables values
            obj.num = 200;
            obj.symb = 'B';
            //displaying the new values of the variables
            WriteLine("Нови стойности на полетата на обекта");
            WriteLine(obj);

            //creating a String arrays containing the string variable contents
            //spliting it in the places where there is a new line
            String[] str = obj.ToString().Split('\n');
            
            //displaying the arrays
            for (int i = 0; i < str.Length; i++)
            {
                WriteLine("[* " + str[i] + " *]");
            }

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
