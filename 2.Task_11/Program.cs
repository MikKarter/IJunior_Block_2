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

            int counterUserStringDeep = 0;
            int counterSymbolsDifference = 0;
            char userSymbolOne = '(';
            char userSymbolTwo = ')';

            foreach (var everyTextSymbol in userSymbolString)
            {
                if (counterSymbolsDifference >= 0)
                {
                    if (everyTextSymbol == userSymbolOne)
                    {
                        counterSymbolsDifference++;
                    }

                    else if (everyTextSymbol == userSymbolTwo)
                    {
                        if (counterUserStringDeep < counterSymbolsDifference)
                        {
                            counterUserStringDeep = counterSymbolsDifference;
                        }
                        
                        counterSymbolsDifference--;
                    }
                }
            }

            if (counterSymbolsDifference < 0)
            {
                Console.WriteLine("String is uncorrect");
            }

            if (counterSymbolsDifference > 0)
            {
                Console.WriteLine("String is uncorrect");
            }

            if (counterSymbolsDifference == 0)
            {
                Console.WriteLine("Deep of user symbols is " + counterUserStringDeep);
            }
        }
    }
}
