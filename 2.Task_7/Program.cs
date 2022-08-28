using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string pictureSybmol;
            int lengthSymbolRow;
            int addLeght = 2;
            string symbolString = "";

            Console.WriteLine("Whats your name?");
            userName = Console.ReadLine();
            Console.WriteLine("Please, input liked symbol");
            pictureSybmol = Console.ReadLine();
            lengthSymbolRow = userName.Length + addLeght;

            for (int i = 0; i < lengthSymbolRow; i++)
            {
                symbolString += pictureSybmol;
            }

            Console.WriteLine(symbolString);
            Console.WriteLine(pictureSybmol + userName + pictureSybmol);
            Console.WriteLine(symbolString);
            Console.WriteLine("\n");
        }
    }
}
