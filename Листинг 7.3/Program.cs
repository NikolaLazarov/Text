using System;
using static System.Console;

namespace Листинг_7._3
{

    class Program
    {
        static void Main(string[] args)
        {
            static bool StrCmp(String X, String Y)
            {
                if (X.Length != Y.Length) return false;
                for (int i = 0; i < X.Length; i++)
                {
                    if (X[i] != Y[i]) return false;
                }
                return true;
            }

            char[] smb = { 'Е', 'з', 'и', 'к', ' ', 'C', '#' };
            String A = "Език C#";
            WriteLine("A: \"{0}\"", A);

            String B = new String(smb);
            WriteLine("B: \"{0}\"", B);

            String C = "ЕЗИК C#";
            WriteLine("C: \"{0}\"", C);

            WriteLine("Сравняване на низове");
            WriteLine("A==B: {0}", A == B);
            WriteLine("StrCmp(A,B): {0}", StrCmp(A, B));

            WriteLine("A==C: {0}", A == C);
            WriteLine("StrCmp(A,C): {0}", StrCmp(A, C));

            WriteLine("B!=C: {0}", B != C);
            WriteLine("StrCmp(A,\"C#\"): {0}", StrCmp(A, "C#"));

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
