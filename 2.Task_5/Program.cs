using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float userRub;
            float userUsd;
            float userCny;
            float amountToConvert;
            int errorCommandCounter = 5;
            int userSelectedForExchange;
            int userSelectedForRecieve;
            string infoSelectedForExchange;
            string infoSelectedForRecieve;
            int rubToUsd = 64;
            int rubToCny = 10;
            int usdToCny = 15;
            Console.WriteLine("Добро пожаловать в обменник. Здесь мы меняем валюту.");
            Console.WriteLine("Подскажите, сколько у вас рублей?");
            userRub = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Подскажите, сколько у вас долларов?");
            userUsd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Подскажите, сколько у вас юаней?");
            userCny = Convert.ToInt32(Console.ReadLine());

            if (userCny == 0 && userRub == 0 && userUsd == 0)
            {
                Console.WriteLine("Видимо вы нищеброд. Пожалуйста, идите заработайте денег прежде чем пользоваться обменником");
            }
            else
            {
                Console.WriteLine("Что будем обменивать?");
                Console.WriteLine("1 - рубли, 2 - доллары, 3 - юани");
                userSelectedForExchange = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("На что будем обменивать?");
                Console.WriteLine("1 - рубли, 2 - доллары, 3 - юани");
                userSelectedForRecieve = Convert.ToInt32(Console.ReadLine());

                if (userSelectedForExchange == 1 & userSelectedForRecieve == 1)
                {
                    Console.WriteLine("Обмениваем рубли на рубли? Вы в своём уме??? Убирайтесь!!!");
                }

                if (userSelectedForExchange == 2 & userSelectedForRecieve == 2)
                {
                    Console.WriteLine("Обмениваем доллары на доллары? Вы в своём уме??? Убирайтесь!!!");
                }

                if (userSelectedForExchange == 3 & userSelectedForRecieve == 3)
                {
                    Console.WriteLine("Обмениваем юани на юани? Вы в своём уме??? Убирайтесь!!!");
                }

                if (userSelectedForExchange == 1 & userSelectedForRecieve == 2)
                {
                    Console.WriteLine("Обмениваем рубли на доллары? Хорошо! Сколько рублей обмениваем?");
                    amountToConvert = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Принято! Обменяли " + amountToConvert + " рублей на доллары");
                    userRub -= amountToConvert;
                    userUsd += amountToConvert / rubToUsd;
                    Console.WriteLine("Теперь у вас на балансе: \n" + userRub + "рублей, \n" + userUsd + " долларов,\n" + userCny + " юаней");
                }

                if (userSelectedForExchange == 1 & userSelectedForRecieve == 3)
                {
                    Console.WriteLine("Обмениваем рубли на юани? Хорошо! Сколько рублей обмениваем?");
                    amountToConvert = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Принято! Обменяли " + amountToConvert + " рублей на юани");
                    userRub -= amountToConvert;
                    userCny += amountToConvert / rubToCny;
                    Console.WriteLine("Теперь у вас на балансе: \n" + userRub + "рублей, \n" + userUsd + " долларов,\n" + userCny + " юаней");
                }

                if (userSelectedForExchange == 2 & userSelectedForRecieve == 1)
                {
                    Console.WriteLine("Обмениваем доллары на рубли? Хорошо! Сколько долларов обмениваем?");
                    amountToConvert = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Принято! Обменяли " + amountToConvert + " долларов на рубли");
                    userUsd -= amountToConvert;
                    userRub += amountToConvert * rubToUsd;
                    Console.WriteLine("Теперь у вас на балансе: \n" + userRub + "рублей, \n" + userUsd + " долларов,\n" + userCny + " юаней");
                }

                if (userSelectedForExchange == 2 & userSelectedForRecieve == 3)
                {
                    Console.WriteLine("Обмениваем доллары на юани? Хорошо! Сколько долларов обмениваем?");
                    amountToConvert = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Принято! Обменяли " + amountToConvert + " долларов на юани");
                    userUsd -= amountToConvert;
                    userCny += amountToConvert * usdToCny;
                    Console.WriteLine("Теперь у вас на балансе: \n" + userRub + "рублей, \n" + userUsd + " долларов,\n" + userCny + " юаней");
                }
                
                if (userSelectedForExchange == 3 & userSelectedForRecieve == 1)
                {
                    Console.WriteLine("Обмениваем юани на рубли? Хорошо! Сколько юаней обмениваем?");
                    amountToConvert = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Принято! Обменяли " + amountToConvert + " юаней на рубли");
                    userCny -= amountToConvert;
                    userRub += amountToConvert * rubToCny;
                    Console.WriteLine("Теперь у вас на балансе: \n" + userRub + "рублей, \n" + userUsd + " долларов,\n" + userCny + " юаней");
                }
                
                if (userSelectedForExchange == 1 & userSelectedForRecieve == 3)
                {
                    Console.WriteLine("Обмениваем юани на доллары? Хорошо! Сколько юаней обмениваем?");
                    amountToConvert = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Принято! Обменяли " + amountToConvert + " юаней на доллары");
                    userCny -= amountToConvert;
                    userUsd += amountToConvert / usdToCny;
                    Console.WriteLine("Теперь у вас на балансе: \n" + userRub + "рублей, \n" + userUsd + " долларов,\n" + userCny + " юаней");
                }
            }
        }
    }
}
