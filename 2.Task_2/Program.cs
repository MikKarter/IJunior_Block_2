using System;

namespace _2.Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в какое то место");
            Console.WriteLine("Будем пытаться выйти из него по кодовому слову");
            string codePhrase = "Exit";
            string userPhrase;
            bool starsWaitingCodePhrase = true;
            while (starsWaitingCodePhrase = true)
            {
                Console.Write("Чтобы закончить с этим введите кодовое слово:");
                userPhrase = Console.ReadLine();
                if (userPhrase == codePhrase)
                {
                    Console.WriteLine("Моё почтение, вы угадали. До свидания.");
                    break;
                }
                else
                {
                    Console.WriteLine("Увы, не-а. Давайте попробуем ещё раз.");
                    Console.WriteLine("Попробуйте снова ввести кодовое слово:");
                }
            }    
        }
    }
}
