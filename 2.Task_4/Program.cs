using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int number = randomNumber.Next(-100, 101);
            int summNumbers = 0;
            int divisorOne = 3;
            int divisorTwo = 5; 
            Console.WriteLine(number);

            for (int currentNumber = 0; currentNumber <= number; currentNumber++)
            {
                if (currentNumber % divisorOne == 0 | currentNumber % divisorTwo == 0)
                {
                    Console.WriteLine(currentNumber + "  является кратным 3 или 5");
                    summNumbers += currentNumber;
                }
            }
            Console.WriteLine("Сумма всех положительных чисел меньше " + number + ", кратных 3 или 5 равна " + summNumbers);
        }
    }
}
