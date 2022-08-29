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
            int degreeOfNumber = 0;
            int conditionalNumber = 2;
            int conditionalNumberInDegree = 1;

            while (conditionalNumberInDegree < mainRandomNumber)
            {
                conditionalNumberInDegree *= conditionalNumber;
                degreeOfNumber++;
            }

            Console.WriteLine("Random number is " + mainRandomNumber);
            Console.WriteLine("The minimum number (" + conditionalNumber + "^N) that is greater than " + mainRandomNumber + " that " + conditionalNumberInDegree);
            Console.WriteLine("To get this number, you need to raise " + conditionalNumber + " to the degree " + degreeOfNumber);
        }
    }
}
