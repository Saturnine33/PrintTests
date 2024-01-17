using System;
using System.Collections.Generic;
using System.Text;

namespace PrintTests.Business.Infrastructure
{
    public class StringBuilderPrinter : IPrinterTarget
    {
        public StringBuilder BuilderInstance = new StringBuilder();
        public void Print(string text)
        {
            BuilderInstance.Append(text);
        }

        public void PrintLine(string text)
        {
            BuilderInstance.AppendLine(text);
        }
    }
}
