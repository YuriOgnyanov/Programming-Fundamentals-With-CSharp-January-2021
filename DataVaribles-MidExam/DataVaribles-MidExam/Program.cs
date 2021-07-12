using System;

namespace DataVaribles_MidExam
{
    class Program
    {
        static void Main(string[] args)
        {

            double priceWithoutTaxes = 0;
            double priceTaxes = 0;
            double taxes = 0;
            double totalPrice = 0;
            

            while (true)
            {
                string specialOrRegular = Console.ReadLine();
                if (specialOrRegular == "special")
                {
                    // do something
                    totalPrice = totalPrice - totalPrice * 0.10;
                    break;
                }
                else if (specialOrRegular == "regular")
                {
                    // do something
                    break;
                }

                double price = double.Parse(specialOrRegular);

                if (price > 0)
                {
                    priceWithoutTaxes += price;
                    priceTaxes = priceWithoutTaxes - priceWithoutTaxes * 0.20;
                    taxes = priceWithoutTaxes - priceTaxes;
                    totalPrice = taxes + priceWithoutTaxes;

                }
                else
                {
                    Console.WriteLine("Invalid price!");
                }
            }

            if (totalPrice  == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {priceWithoutTaxes:F2}$");
                Console.WriteLine($"Taxes: {taxes:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice:F2}$");
            }

            


            
           
        }
    }
}
