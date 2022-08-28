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

            Console.WriteLine("Whats your name?");
            userName = Console.ReadLine();
            Console.WriteLine("Please, input liked symbol");
            pictureSybmol = Console.ReadLine();
            lengthSymbolRow = userName.Length + 2;

            for (int i = 0; i < lengthSymbolRow; i++)
            {
                Console.Write(pictureSybmol);
            }

            Console.WriteLine("");
            Console.Write(pictureSybmol + userName + pictureSybmol + "\n");
            
            for (int i = 0; i < lengthSymbolRow; i++)
            {
                Console.Write(pictureSybmol);
            }

            Console.WriteLine("\n");
        }
    }
}
