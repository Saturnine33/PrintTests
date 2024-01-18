using PrintTests.Business;
using PrintTests.Business.Infrastructure;

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
        public void Test1()
        {
            MyPrinterInstance.PrintHelloWorld();
            Assert.Equal("Hello World", printer.BuilderInstance.ToString());
        }
    }
}