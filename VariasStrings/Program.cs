using System;

namespace VariasStrings
{
    class Program
    {

        private static string firststr = "\u2726 Welcome To \nOur Store \u2726";
        private static string secondstr = @"To find your desktop in cmd, write ""cd"" followed by C:\Users\Me\Desktop";
        private static string thirdstr = "\tThis is just a normal string with an escape!";
        
        static void Main(string[] args)
        {
            Console.WriteLine(firststr);
            Console.WriteLine(secondstr);
            Console.WriteLine(thirdstr);
        }
    }
}
