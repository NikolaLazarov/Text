using System;
using static System.Console;

namespace Листинг_7._3
{

    class Program
    {
        static void Main(string[] args)
        {
            //checking if the strings are identical in length and contents
            static bool StrCmp(String X, String Y)
            {
                if (X.Length != Y.Length) return false;
                for (int i = 0; i < X.Length; i++)
                {
                    if (X[i] != Y[i]) return false;
                }
                return true;
            }
            //creating a character array
            char[] smb = { 'Е', 'з', 'и', 'к', ' ', 'C', '#' };
            //creating and assinging the array to a String object
            String A = "Език C#";
            //displaying the object
            WriteLine("A: \"{0}\"", A);

            //creating a object with the array as an argument
            String B = new String(smb);
            //displaying the object
            WriteLine("B: \"{0}\"", B);

            //creating and assinging the string to a String object
            String C = "ЕЗИК C#";
            //displaying the object
            WriteLine("C: \"{0}\"", C);

            //displaying the objects and comparing them
            WriteLine("Сравняване на низове");
            WriteLine("A==B: {0}", A == B);
            //calling a function with 2 objects as arguments
            WriteLine("StrCmp(A,B): {0}", StrCmp(A, B));

            //displaying and comparing the objects
            WriteLine("A==C: {0}", A == C);
            //calling a function with 2 objects as arguments
            WriteLine("StrCmp(A,C): {0}", StrCmp(A, C));

            //displaying and comparing the objects
            WriteLine("B!=C: {0}", B != C);
            //calling a function with 2 objects as arguments
            WriteLine("StrCmp(A,\"C#\"): {0}", StrCmp(A, "C#"));

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
