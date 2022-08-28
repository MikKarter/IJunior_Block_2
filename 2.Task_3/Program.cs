using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lastNumber = 96;
            int firstNumber = 5;
            int increaseByThisNumber = 7;
            int numberForInputOnScreen;
            numberForInputOnScreen = firstNumber;

            for (int i = firstNumber; i <= lastNumber; i +=increaseByThisNumber)
            {
                Console.WriteLine(i);
            }
        }
    }
}
