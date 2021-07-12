using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double result = SumOfProduct(product, quantity);

            Console.WriteLine($"{result:F2}");
        }

        static double SumOfProduct(string product,double quantity)
        {
            double sumOfProduct = 0;
            switch (product)
            {
                case "coffee":
                    sumOfProduct = quantity * 1.50;
                    break;
                case "water":
                    sumOfProduct = quantity * 1.00;
                    break;
                case "coke":
                    sumOfProduct = quantity * 1.40;
                    break;
                case "snacks":
                    sumOfProduct = quantity * 2.00;
                    break;
                
            }
            return sumOfProduct;
            
        }

    }
}
