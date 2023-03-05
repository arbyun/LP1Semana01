using System;

namespace VariasStrings
{
    class Program
    {
        private static string firststr = "\u2726 Welcome To \nOur Store \u2726";
        private static string secondstr = @"To find your desktop in cmd, write ""cd"" followed by C:\Users\Me\Desktop";
        private static string thirdstr = "\tThis is just a normal string with an escape!";
        
        //more strings:
        private static string concstr = firststr + secondstr;
        private static string interstr = $"{firststr}\nWhat do you wish to buy today?";
        private static string idkstr = String.Format("My third string written was '{0}'", thirdstr);
        
        static void Main(string[] args)
        {
            double xx = 0.12345;
            int ii = 18;
            
            Console.WriteLine(firststr);
            Console.WriteLine(secondstr);
            Console.WriteLine(thirdstr);
            
            Console.WriteLine(concstr);
            Console.WriteLine(interstr);
            Console.WriteLine(idkstr);
            Console.WriteLine(@"My concatenate string is '{0}'", concstr);
            
            Console.WriteLine("xx's first print: {0:0.00}", xx);
            Console.WriteLine("xx's second print: {0:P1}", xx);
            Console.WriteLine("ii's first print: 0x{0:X}", ii);
            Console.WriteLine("ii's second print: {0:C}", ii);
        }
    }
}
