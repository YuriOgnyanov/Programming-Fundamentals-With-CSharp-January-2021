using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger snowballValue = 0;
            BigInteger theBestSnowBall = -1;
            string result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                int snowBallSnow = int.Parse(Console.ReadLine());
                int snowBallTime = int.Parse(Console.ReadLine());
                int snowBallQuality = int.Parse(Console.ReadLine());

                snowballValue = BigInteger.Pow((snowBallSnow / snowBallTime), snowBallQuality);
                if (snowballValue > theBestSnowBall)
                {
                    theBestSnowBall = snowballValue;
                    result = $"{snowBallSnow} : {snowBallTime} = {snowballValue} ({snowBallQuality})";

                }
                
            }
            Console.WriteLine(result);
        }
    }
}
