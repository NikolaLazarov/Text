using System;
using static System.Console;
using System.Linq;

namespace Задача_9
{
    class myClass
    {
        public static void Meth(params int[] arrNums)
        {
            WriteLine("Най-малкото число: {0}", arrNums.Min());
            WriteLine("Най-голямото число: {0}", arrNums.Max());
            WriteLine("Средно аритметично на чисата: {0}", arrNums.Average());
        }
        public static void Meth(int[] arrNums)
        {
            WriteLine("Най-малкото число: {0}", arrNums.Min());
            WriteLine("Най-голямото число: {0}", arrNums.Max());
            WriteLine("Средно аритметично на чисата: {0}", arrNums.Average());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Meth(6, 4, 5, 3, 2, 4, 9, 2);
            int[] arrNums = { 3, 7, 2, 1, 8, 6, 2, 5 };
            Meth(arrNums);

            WriteLine("Press any key to close...");
            ReadKey(true);
        }
    }
}
