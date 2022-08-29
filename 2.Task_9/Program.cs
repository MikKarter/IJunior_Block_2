using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Random randomForNumberN = new Random();

            int loverGivenRange = 1;
            int hiverGivenRange = 28;
            int numberN = randomForNumberN.Next(loverGivenRange,hiverGivenRange);
            int counterNumbersMultiplesN = 0;
            int lowerRangeLimit = 100;
            int upperRangeLimit = 999;

            Console.WriteLine("Random generated number is " +numberN);
            
            for (int i = 0;i<=upperRangeLimit; i+=numberN)
            {
                if (i>=lowerRangeLimit)
                { 
                    counterNumbersMultiplesN++;
                }
            }
            Console.WriteLine("Amount numbers, multiples number " + numberN + "equals " +counterNumbersMultiplesN);
        }
    }
}
