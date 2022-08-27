using System;


namespace _2.Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int phraseRepeat;
            int repeatCounter;
            string userPhrase;
            Console.WriteLine("Hello!");
            Console.WriteLine("What phrase will be write on screen?");
            userPhrase = Console.ReadLine();
            Console.WriteLine("How much time?");
            phraseRepeat = Convert.ToInt32(Console.ReadLine());
            for (repeatCounter = 0; repeatCounter < phraseRepeat; repeatCounter++ )
                {
                Console.WriteLine(userPhrase);
                }
        }
    }
}
