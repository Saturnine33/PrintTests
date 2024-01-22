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

        /// <summary>
        /// Print "Number 1" "Number 2" "Number 3" each on a separate line, where the first number is equal to <paramref name="firstNumber"/> and 
        /// the last number is equal to <paramref name="lastNumber"/>.
        /// </summary>
        void PrintNumberMessages(int firstNumber, int lastNumber);
    }
}
