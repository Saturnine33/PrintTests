using System;

namespace PrintTests.Business
{
    public static class PrintMethods
    {
        static void WriteLine(string text)
        {
            Console.WriteLine(text);
        }

        public static void PrintMethodHello()
        {
            WriteLine("Hello World!");
        }

        public static void PrintMethodSimpleVariable()
        {
            string variable1;
            string variable2;

            variable1 = "Hello again";
            variable2 = "Bye";

            WriteLine(variable1);
            WriteLine(variable2);
        }

        public static void PrintMethodFor()
        {
            for (int i = 0; i < 3; i++)
            {
                string variable1;

                variable1 = "Number " + i.ToString();

                WriteLine(variable1);
            }
        }

        public static void PrintMethodArray()
        {
            string[] variableArray;

            variableArray = new string[5];

            for (int i = 0; i < variableArray.Length; i++)
            {
                variableArray[i] = "Blank";
            }

            variableArray[1] = "Note 1";
            variableArray[4] = "Note 4";

            for (int i = 0; i < variableArray.Length; i++)
            {
                string variable1;

                variable1 = i.ToString() + " is " + variableArray[i];

                WriteLine(variable1);
            }
        }
    }
}
