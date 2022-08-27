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
            Random rand = new Random();
            int number = rand.Next(-5, 101);
            int summNumbers = 0, divisor3 = 3, divisor5 = 5; 
            Console.WriteLine(number);

            for (int currentNumber = 0; currentNumber <= number; currentNumber++)
            {
                if (currentNumber % divisor3 == 0 | currentNumber % divisor5 == 0)
                {
                    Console.WriteLine(currentNumber + "  является кратным 3 или 5");
                    summNumbers = summNumbers + currentNumber;
                }
            }
            Console.WriteLine("Сумма всех положительных чисел меньше " + number + ", кратных 3 или 5 равна " + summNumbers);
        }
    }
}
