﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;

namespace Task6_StrongNumber
    {
        class Program
        {
            static void Main(string[] args)
            {
                int number = int.Parse(Console.ReadLine());//6921
                string lenght = number.ToString();//Обръщам числото в String  за да взема дължината му. (Числото 6921 съдържа 4 симбола)
                                                  //lenght = 4
                int sum = 0;


                //Тук въртя цикъл, който ще се завърти толкова пъти, колкото е дължината на числото (В случая 4 пъти)
                for (int digitsCount = 0; digitsCount < lenght.Length; digitsCount++)
                {
                    //Тук достъпвам чилото което седи на дадена позиция, като от него вадя 48,понеже в ASCII таблицата 0-та е на 48 позиция
                    int currentFactorial = (int)(lenght.ToString()[digitsCount]) - 48;
                    //На първото завъртане взимам стойността "6" , тъй като тя се намира на нулева позиция (В програмирането се брои от 0)
                    //На второто завъртане взимам стойността "9" , която се намира на 1ва позиция и тн.

                    int currentSum = 1;
                    //Дефинирам, че след всяко завъртане currentSum ще е единица, защото всяко число умножено по 0 е 0;



                    //Тук въртя цикъл, в който за всяко едно число намирам неговият Факториел
                    for (int count = currentFactorial; count >= 1; count--)
                    {
                        //Тук умножавам предходното число по count, където count e намален с 1ца 
                        //Така след като приключа цикъла ще получа факториела на числото
                        currentSum *= count;
                        //Пример: Ако имам числото 6 то факториел от 6 е : (6 * 5 * 4 * 3 * 2 * 1) = 720

                    }

                    //Тук събирам получената до момента сума от факториела
                    sum = sum + currentSum;

                }

                //След завърването на всички цикли аз трябва да проверя дали сумата на факториелите е равна на първоначално даденото число
                if (sum == number)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
        }
    }


}
    }
}
