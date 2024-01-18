using PrintTests.Business;
using PrintTests.Business.Infrastructure;
using System.Text;

namespace PrintTestsxTests
{
    public class UnitTest1
    {
        StringBuilderPrinter printer;
        ITestPrinter MyPrinterInstance;

        public UnitTest1()
        {
            printer = new StringBuilderPrinter();
            MyPrinterInstance = new MyPrinter(printer);
        }

        [Fact]
        public void PrintHelloWorldTest()
        {
            MyPrinterInstance.PrintHelloWorld();
            Assert.Equal("Hello World", printer.BuilderInstance.ToString());
        }


        [Fact]
        public void PrintHelloWorldTimes3Test()
        {
            var expectedResult = @"Hello World
Hello World
Hello World
";

            MyPrinterInstance.PrintHelloWorldTimes3();
            Assert.Equal(expectedResult, printer.BuilderInstance.ToString());
        }
    }
}