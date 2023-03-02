using System;

namespace TiposVarios
{
    class Program
    {
        #region INT vars

        private static sbyte verysmall = -4;
        private static short smallish = -3006;
        private static int regular = -767675;
        private static long big = -7867857L;
        private static ushort smaller = 5435;
        private static uint regularer = 435245U;
        private static ulong bigger = 534523654UL;
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

        #region CHAR vars

        private static char heartsymbol = '\u2665';
        private static char musicnotesymbol = '\u266a';

        static void PrintChars()
        {
            Console.WriteLine(heartsymbol);
            Console.WriteLine(musicnotesymbol);
        }

        #endregion

        #region REAL vars

        private static float floattie = 4.565f;
        private static double doublie = 5.67677;

        static void PrintRealNos()
        {
            Console.WriteLine(floattie);
            Console.WriteLine(doublie);
        }

        #endregion

        static void Main()
        {
            Console.WriteLine("Integral type variables:");
            PrintINT();
            Console.WriteLine("/n");
            Console.WriteLine("Character type variables:");
            PrintChars();
            Console.WriteLine("/n");
            PrintRealNos();
        }
    }
}
