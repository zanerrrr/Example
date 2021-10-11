using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            string nameVariable = "Zane";
            string surnameVariable = "Rubene";
            string greetingsVariable = "classmates and teacher!";
            Console.WriteLine("Hello World! ");
            Console.WriteLine(@$"And my fellow {greetingsVariable}");
            Console.WriteLine($@"My name is {nameVariable} and my surname is {surnameVariable}.");
            #endregion

            #region
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

            #region
            string newParagraph = Environment.NewLine;
            Console.WriteLine(newParagraph);
            Console.WriteLine("Once I had to create JSGF generative " +
                "grammar in Latvian language. " +
                @"After that I had to generate" +
                " bundles of different texts " +
                "using \"Python\". ");
            string newLine = @"And I thought that it is really cool. " + Environment.NewLine + "Since then I wanted to know more about coding. ";
            Console.WriteLine(newLine);

            #endregion






            Console.ReadLine();
        }
    }
}
