using System;
using System.Collections.Generic;
using System.Text;

namespace PrintTests.Business.Infrastructure
{
    public interface IPrinterTarget
    {
        void Print(string text);

        void PrintLine(string text);
    }
}
