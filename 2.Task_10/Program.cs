using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int mainRandomNumber = randomNumber.Next(0, 100);
            int theDegree = 0;
            int numberTwo = 2;
            int numberTwoInDegree= 1;

            while (numberTwoInDegree < mainRandomNumber)
            {
                numberTwoInDegree = numberTwoInDegree * numberTwo;
                theDegree++;
            }

            Console.WriteLine("Random number is " + mainRandomNumber);
            Console.WriteLine("The minimum number (" +numberTwo + "^N) that is greater than " + mainRandomNumber + " that " + numberTwoInDegree);
            Console.WriteLine("To get this number, you need to raise " +numberTwo +" to the degree " + theDegree);
        }
    }
}
