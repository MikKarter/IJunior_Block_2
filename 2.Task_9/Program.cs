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

            Console.WriteLine(numberN);

            for (int i = 100;100<=i&i<=999; i++)
            {
                while (summNumberN<100)
                {
                    summNumberN += numberN;
                }
                if (summNumberN >= 100 & summNumberN < 1000)
                {
                    counterNumbersMultiplesN++;
                    summNumberN += numberN;
                }
            }
            Console.WriteLine(counterNumbersMultiplesN);
        }
    }
}
