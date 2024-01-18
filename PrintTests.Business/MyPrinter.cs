using PrintTests.Business.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrintTests.Business
{
    public class MyPrinter : ITestPrinter
    {
        readonly IPrinterTarget PrintTarget;

        public MyPrinter(IPrinterTarget target) {
            PrintTarget = target;
        }

        public void PrintHelloWorld()
        {
            PrintTarget.Print("Hello World");
        }

        public void PrintHelloWorldTimes3()
        {
            throw new NotImplementedException();
        }
    }
}
