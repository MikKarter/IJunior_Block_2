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
            int userSelectedForExchange;
            int userSelectedForRecieve;
            string infoSelectedForExchange;
            string infoSelectedForRecieve;
            int rubToUsd = 64;
            int rubToCny = 10;
            float usdToCny = 0.15f;
            bool finishedTheUseConverter = false;
            int userContinueChoice;

            Console.WriteLine("Добро пожаловать в обменник. Здесь мы меняем валюту.");
            Console.WriteLine("Подскажите, сколько у вас рублей?");
            userRub = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Подскажите, сколько у вас долларов?");
            userUsd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Подскажите, сколько у вас юаней?");
            userCny = Convert.ToInt32(Console.ReadLine());

            while (finishedTheUseConverter == false)
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

                else if (userSelectedForExchange == 2 & userSelectedForRecieve == 2)
                {
                    Console.WriteLine("Обмениваем доллары на доллары? Вы в своём уме??? Убирайтесь!!!");
                }

                else if (userSelectedForExchange == 3 & userSelectedForRecieve == 3)
                {
                    Console.WriteLine("Обмениваем юани на юани? Вы в своём уме??? Убирайтесь!!!");
                }

                else if (userSelectedForExchange == 1 & userSelectedForRecieve == 2)
                {
                    Console.WriteLine("Обмениваем рубли на доллары? Хорошо! Сколько рублей обмениваем?");
                    amountToConvert = Convert.ToInt32(Console.ReadLine());

                    if ((userRub - amountToConvert) < 0)
                    {
                        Console.WriteLine("Недостаточно валюты для обмена");
                    }
                    else
                    {
                        userRub -= amountToConvert;
                        userUsd += amountToConvert / rubToUsd;
                        Console.WriteLine("Принято! Обменяли " + amountToConvert + " рублей на доллары");
                        Console.WriteLine("Теперь у вас на балансе: \n" + userRub + "рублей, \n" + userUsd + " долларов,\n" + userCny + " юаней");
                    }
                }

                else if (userSelectedForExchange == 1 & userSelectedForRecieve == 3)
                {
                    Console.WriteLine("Обмениваем рубли на юани? Хорошо! Сколько рублей обмениваем?");
                    amountToConvert = Convert.ToInt32(Console.ReadLine());


                    if ((userRub - amountToConvert) < 0)
                    {
                        Console.WriteLine("Недостаточно валюты для обмена");
                    }
                    else
                    {
                        Console.WriteLine("Принято! Обменяли " + amountToConvert + " рублей на юани");
                        userRub -= amountToConvert;
                        userCny += amountToConvert / rubToCny;
                        Console.WriteLine("Теперь у вас на балансе: \n" + userRub + "рублей, \n" + userUsd + " долларов,\n" + userCny + " юаней");
                    }
                }

                else if (userSelectedForExchange == 2 & userSelectedForRecieve == 1)
                {
                    Console.WriteLine("Обмениваем доллары на рубли? Хорошо! Сколько долларов обмениваем?");
                    amountToConvert = Convert.ToInt32(Console.ReadLine());

                    if ((userUsd - amountToConvert) < 0)
                    {
                        Console.WriteLine("Недостаточно валюты для обмена");
                    }
                    else
                    {
                        Console.WriteLine("Принято! Обменяли " + amountToConvert + " долларов на рубли");
                        userUsd -= amountToConvert;
                        userRub += rubToUsd / amountToConvert;
                        Console.WriteLine("Теперь у вас на балансе: \n" + userRub + "рублей, \n" + userUsd + " долларов,\n" + userCny + " юаней");
                    }
                }

                else if (userSelectedForExchange == 2 & userSelectedForRecieve == 3)
                {
                    Console.WriteLine("Обмениваем доллары на юани? Хорошо! Сколько долларов обмениваем?");
                    amountToConvert = Convert.ToInt32(Console.ReadLine());

                    if ((userUsd - amountToConvert) < 0)
                    {
                        Console.WriteLine("Недостаточно валюты для обмена");
                    }
                    else
                    {
                        Console.WriteLine("Принято! Обменяли " + amountToConvert + " долларов на юани");
                        userUsd -= amountToConvert;
                        userCny += usdToCny / amountToConvert;
                        Console.WriteLine("Теперь у вас на балансе: \n" + userRub + "рублей, \n" + userUsd + " долларов,\n" + userCny + " юаней");
                    }
                }

                else if (userSelectedForExchange == 3 & userSelectedForRecieve == 1)
                {
                    Console.WriteLine("Обмениваем юани на рубли? Хорошо! Сколько юаней обмениваем?");
                    amountToConvert = Convert.ToInt32(Console.ReadLine());
                    if ((userCny - amountToConvert) < 0)
                    {
                        Console.WriteLine("Недостаточно валюты для обмена");
                    }
                    else
                    {
                        Console.WriteLine("Принято! Обменяли " + amountToConvert + " юаней на рубли");
                        userCny -= amountToConvert;
                        userRub += rubToCny / amountToConvert;
                        Console.WriteLine("Теперь у вас на балансе: \n" + userRub + "рублей, \n" + userUsd + " долларов,\n" + userCny + " юаней");
                    }
                }

                else if (userSelectedForExchange == 3 & userSelectedForRecieve == 2)
                {
                    Console.WriteLine("Обмениваем юани на доллары? Хорошо! Сколько юаней обмениваем?");
                    amountToConvert = Convert.ToInt32(Console.ReadLine());
                    if ((userCny - amountToConvert) < 0)
                    {
                        Console.WriteLine("Недостаточно валюты для обмена");
                    }
                    else
                    {
                        Console.WriteLine("Принято! Обменяли " + amountToConvert + " юаней на доллары");
                        userCny -= amountToConvert;
                        userUsd += usdToCny/amountToConvert;
                        Console.WriteLine("Теперь у вас на балансе: \n" + userRub + "рублей, \n" + userUsd + " долларов,\n" + userCny + " юаней");
                    }
                }

                Console.WriteLine("Будем обменивать что то ещё?");
                Console.WriteLine("1 - да, 2 - нет");
                userContinueChoice = Convert.ToInt32(Console.ReadLine());

                switch (userContinueChoice)
                {
                    case 1:
                        finishedTheUseConverter = false;
                        break;
                    case 2:
                        Console.WriteLine("Всего доброго");
                        finishedTheUseConverter = true;
                        break;
                    default:
                        Console.WriteLine("Я не знаю такой команды. Будем считать что вы решили пользоваться обменником дальше");
                        break;
                }
            }
        }
    }
}



