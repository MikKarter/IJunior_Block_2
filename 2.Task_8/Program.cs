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
            string userInputPasswordToSecretPhrase;
            int maxNumberOfAttempts = 3;
                       
            for (int i=0; i<maxNumberOfAttempts; i++)
            {
                Console.WriteLine("If you want see secret phrase please input the password\n You have a " + (maxNumberOfAttempts-i) + " attempts" );
                userInputPasswordToSecretPhrase = Console.ReadLine();
                
                if (i==maxNumberOfAttempts-1)
                {
                    Console.WriteLine("Incorrect password. Last attempt");
                }

                else if (userInputPasswordToSecretPhrase == passwordToSecretPhrase)
                {
                    Console.WriteLine(secretPhrase);
                }
                else
                {
                    Console.WriteLine("Incorrect password. Last attempt");
                }
            }
        }
    }
}
