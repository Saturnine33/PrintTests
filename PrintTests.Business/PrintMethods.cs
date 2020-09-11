using System;

namespace PrintTests.Business
{
    public static class PrintMethods
    {
        static void WriteLine(string text)
        {
            Console.WriteLine(text);
        }

        public static void PrintMethod1()
        {
            WriteLine("Hello World!");
        }
    }
}
