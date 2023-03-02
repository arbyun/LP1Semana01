using System;

namespace TiposVarios
{
    class Program
    {
        #region INT vars

        private static sbyte verysmall = -4;
        private static short smallish = -3006;
        private static int regular = -767675;
        private static long big = -7867857;
        private static ushort smaller = 5435;
        private static uint regularer = 435245;
        private static ulong bigger = 534523654;
        private static sbyte ultrasmall = 1;

        static void PrintINT()
        {
            Console.WriteLine(verysmall);
            Console.WriteLine(smallish);
            Console.WriteLine(regular);
            Console.WriteLine(big);
            Console.WriteLine(ultrasmall);
            Console.WriteLine(smaller);
            Console.WriteLine(regularer);
            Console.WriteLine(bigger);
        }

        #endregion

        static void Main()
        {
            Console.WriteLine("Integral type variables:");
            PrintINT();
        }
    }
}
