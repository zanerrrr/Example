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



            #endregion






            Console.ReadLine();
        }
    }
}
