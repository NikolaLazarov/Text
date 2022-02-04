using System;
using static System.Console;

namespace Задача_5
{
    class Program
    {
        static void Meth(String a, char b)
        {
            int k = 0;
            int j = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b) { k++; }
            }
            int[] nums = new int[k];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = a.IndexOf(b, j + 1);
                j = nums[i];
                Write(nums[i] + "\n");
            }
            static void Main(string[] args)
            {
                String txt = "A seal is on the beach.";
                char a = 'e';
                Meth(txt, a);

                WriteLine("Press any key to close...");
                ReadKey(true);
            }
        }
    }
}
