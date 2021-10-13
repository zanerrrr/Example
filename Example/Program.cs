using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyStrings
            string nameVariable = "Zane";
            string surnameVariable = "Rubene";
            string greetingsVariable = "classmates and teacher!";
            Console.WriteLine("Hello World! ");
            Console.WriteLine(@$"And my fellow {greetingsVariable}");
            Console.WriteLine(@$"My name is {nameVariable} and my surname is {surnameVariable}.");
            #endregion

            #region IntNumbers and concatenation
            int number1 = 25;
            int number2 = 1;
            int resultAge = number1 + number2;
            int number3 = 1354647;
            int number4 = 515383;
            int resultOf = number3 / number4;

            Console.WriteLine(@$"Last week was my birthday and I turned {resultAge}.");
            Console.Write($"Do you know what's the result of 1354647 / 515383? " +
                $"My computer knows - {resultOf}.");
            #endregion

            #region Strings and concatination and using \
            string newParagraph = Environment.NewLine;
            string newLine = @"And I thought that it is really cool. " + Environment.NewLine + "Since then I wanted to know more about coding. ";
            Console.WriteLine(newParagraph);
            Console.WriteLine("Once I had to create JSGF generative " +
                "grammar in Latvian language. \n" +
                "After that I had to generate" +
                " bundles of different texts " +
                "using \"Python\". ") ;
            Console.WriteLine(newLine);

            #endregion

            #region Goodbye
            Console.WriteLine(Environment.NewLine);
            string goobye = "Have a great day!";
            Console.WriteLine(goobye.Contains("bad day"));
            Console.WriteLine(goobye.Contains("great day"));

            #endregion

            #region Casting from int to string
            Console.WriteLine(Environment.NewLine);

            string stringVariable = "100";
            int intVariable = 1;

            string result = stringVariable + intVariable.ToString();
            Console.WriteLine($"I just learned how to cast from int to string: {result}");
            #endregion

            #region 
            Console.WriteLine(Environment.NewLine);
            int numVal = Int32.Parse("-105");
            Console.WriteLine(numVal);

            Console.WriteLine(Environment.NewLine);
            decimal decimalVal = 0;
            decimalVal = Convert.ToDecimal(decimalVal);
            Console.WriteLine($"The string as a decimal is {decimalVal}.");
           
            Console.WriteLine(Environment.NewLine);
            int num = 2147483647;
            long bigNum = num;
            Console.WriteLine($"The result is {num}");
            
            Console.WriteLine(Environment.NewLine);
            double x = 1234.7;
            int a;
            a = (int)x;
            Console.WriteLine(a);

            Console.WriteLine(Environment.NewLine);

            #endregion

            Console.ReadLine();
        }
    }
}
