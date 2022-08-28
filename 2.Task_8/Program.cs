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
            string userInputPasswordToSecretPhrase ="";
            int maxAttempts=3;

            while ((userInputPasswordToSecretPhrase != passwordToSecretPhrase) && maxAttempts>0)
            {
                Console.WriteLine("If you want see secret phrase please input the password\n You have a " + (maxAttempts) + " attempts.");
                userInputPasswordToSecretPhrase = Console.ReadLine();
                maxAttempts--;  
            }
            if (maxAttempts==0)
            {
                Console.WriteLine("attempts is end. Goodbuy");
            }
            else
            {
                Console.WriteLine(secretPhrase);
            }                
        }
    }
}
