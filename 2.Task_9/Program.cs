using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretPhrase = "SECRET PHRACE";
            string passwordToSecretPhrase = "password";
            string userInput ="";
            int maxAttempts=3;
            int attemptsLeft;

            for (int i = 0; i <= maxAttempts; i++)
            {
                attemptsLeft = maxAttempts - i;

                if (attemptsLeft == 0)
                {
                    Console.WriteLine("attempts is end. Goodbuy");
                }

                else if (userInput == passwordToSecretPhrase)
                {
                    Console.WriteLine(secretPhrase);
                }
                
                else if (userInput != passwordToSecretPhrase)
                {
                    Console.WriteLine("If you want see secret phrase please input the password\n You have a " + (attemptsLeft) + " attempts.");
                    userInput = Console.ReadLine();
                }
            }            
        }
    }
}
