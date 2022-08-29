using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userSymbolString;
            Console.WriteLine("Please input you symbol string. Use only '(' and ')' symbols");
            userSymbolString = Console.ReadLine();
          
            int counterSymbolOne = 0;
            int counterSymbolTwo = 0;

            foreach (var i in userSymbolString)
            {

                if (i=='(')
                {
                    counterSymbolOne++;

                }
                else if (i==')')
                {
                    counterSymbolTwo++;
                }                
            }
            
            if (counterSymbolOne == counterSymbolTwo)
            {
                Console.WriteLine("String is correct");
                Console.WriteLine("Counter of deep - " + counterSymbolTwo);
            }

            else
            {
                Console.WriteLine("String is uncorrect");
            }
        }
    }
}
