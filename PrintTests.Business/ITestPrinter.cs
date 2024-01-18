using System;
using System.Collections.Generic;
using System.Text;

namespace PrintTests.Business
{
    public interface ITestPrinter
    {
        void PrintHelloWorld();
        /// <summary>
        /// Print "Hello World" on 3 consecutive lines.
        /// </summary>
        void PrintHelloWorldTimes3();
    }
}
