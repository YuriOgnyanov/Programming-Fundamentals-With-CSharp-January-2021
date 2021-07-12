using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double centsSum = 0;



            while (input != "Start")
            {
                double cents = double.Parse(input);

                if (cents == 0.1 || cents == 0.2 || cents == 0.5 || cents == 1 || cents == 2)
                {
                    centsSum += cents;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {cents}");
                }
                input = Console.ReadLine();
            }
            

            double productPrice = 0;
            while (true)
            {
                string product = Console.ReadLine();
                if (product == "End")
                {
                    break;

                }
                
                if (product == "Nuts")
                {
                    productPrice = 2.0;
                    if (centsSum >= productPrice)
                    {
                        centsSum -= productPrice;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Water")
                {
                    productPrice = 0.7;
                    if (centsSum >= productPrice)
                    {
                        centsSum -= productPrice;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Crisps")
                {
                    productPrice = 1.5;
                    if (centsSum >= productPrice)
                    {
                        centsSum -= productPrice;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Soda")
                {
                    productPrice = 0.8;
                    if (centsSum >= productPrice)
                    {
                        centsSum -= productPrice;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Coke")
                {
                    productPrice = 1.0;
                    if (centsSum >= productPrice)
                    {
                        centsSum -= productPrice;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

            }

            Console.WriteLine($"Change: {centsSum:F2}");
        }
    }
}
