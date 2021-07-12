using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double result = 0;
            double theBestOfKeg = 0;
            string theBestModel = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                 result = (Math.PI * Math.Pow(radius, 2) * height);

                if (result > theBestOfKeg)
                {
                    theBestOfKeg = result;
                    theBestModel = model;
                }

                
            }
            Console.WriteLine(theBestModel);
        }
    }
}
