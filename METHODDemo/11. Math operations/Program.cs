using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double result = 0;

            switch (symbol)
            {
                case '/':
                    result = GetDivisionResult(firstNumber, secondNumber);
                    break;
                case '*':
                    result = GetMultiplicationResult(firstNumber, secondNumber);
                    break;
                case '+':
                    result = GetSumResult(firstNumber, secondNumber);
                    break;
                case '-':
                    result = GetSubtractionResult(firstNumber, secondNumber);
                    break;
            }
            
            Console.WriteLine(result);
        }

        //Division
        static double GetDivisionResult(double firstNumber,double secondNumber)
        {
            double result = firstNumber / secondNumber;
            return result;
        }

        //Multiplication
        static double GetMultiplicationResult(double firstNumber, double secondNumber)
        {
            double result = firstNumber * secondNumber;
            return result;
        }

        //Sum
        static double GetSumResult(double firstNumber, double secondNumber)
        {
            double result = firstNumber + secondNumber;
            return result;
        }

        //Subtraction
        static double GetSubtractionResult(double firstNumber, double secondNumber)
        {
            double result = firstNumber - secondNumber;
            return result;
        }




    }
}
