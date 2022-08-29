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
           Random randomForNumberN= new Random();
           
            int numberN = randomForNumberN.Next(1,28);
            int counterNumbersMultiplesN = 0;
            int summNumberN = 0;
            int lowerRangeLimit = 100;
            int upperRangeLimit = 999;

            Console.WriteLine(numberN);
            
            for (int i = lowerRangeLimit;lowerRangeLimit<=i&i<=upperRangeLimit; i+=numberN)
            {
                    counterNumbersMultiplesN++;
            }
            
            Console.WriteLine(counterNumbersMultiplesN);
        }
    }
}
