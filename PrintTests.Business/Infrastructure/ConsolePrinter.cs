using System;
using System.Collections.Generic;
using System.Text;

namespace PrintTests.Business.Infrastructure
{
    public class ConsolePrinter : IPrinterTarget
    {
        public void Print(string text)
        {
            Console.Write(text);
        }

        public void PrintLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
