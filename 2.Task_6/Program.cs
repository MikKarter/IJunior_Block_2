using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInputCommand;
            bool waitingFinishedProgramm = false;
            bool waitingInputUserName = true;
            string userName;
            string userPassword = null;
            string userChoiseTextColor;
            string userChoiseBackgroundColor;
            string checkingUserInput;

            Console.WriteLine("Hello! I'm not userfriendly distributive for you.");
            Console.WriteLine("I know and can execute some commands for you");

            while (waitingInputUserName == true)
            {
                Console.WriteLine("PLEASE INPUT USER NAME:\n");
                userName = Console.ReadLine();

                if (string.IsNullOrEmpty(userName))
                {
                    Console.WriteLine("ERROR! Username can't be empty\n");
                }
                else
                {
                    waitingInputUserName = false;

                    Console.WriteLine("Welcome " + userName);

                    while (waitingFinishedProgramm == false)
                    {
                        {
                            Console.WriteLine("WAITING COMMAND\n(you can see all acess command if input /help)");
                            userInputCommand = Console.ReadLine();

                            if (userInputCommand == "/help")
                            {
                                Console.WriteLine("Use next command for:");
                                Console.WriteLine("SET NAME - setup your name in programm");
                                Console.WriteLine("SET PASSWORD - setup you password");
                                Console.WriteLine("CHANGE COLOR - change consol text color");
                                Console.WriteLine("CHANGE BCOLOR - change console background color");
                                Console.Write("SHOW SNAME - show set name "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("(only after setup you password!)"); Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("SHOW SPASSWORD - show set password "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("(only after setup you password!)"); Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("EXIT - exit from programm");
                            }
                            else
                            {
                                switch (userInputCommand)
                                {
                                    case "/help":
                                        Console.WriteLine("Use next command for:");
                                        Console.WriteLine("SET NAME - setup your name in programm");
                                        Console.WriteLine("SET PASSWORD - setup you password");
                                        Console.WriteLine("CHANGE COLOR - change consol text color");
                                        Console.WriteLine("CHANGE BCOLOR - change console background color");
                                        Console.Write("SHOW SNAME - show set name "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("(only after setup you password!)"); Console.ForegroundColor = ConsoleColor.White;
                                        Console.Write("SHOW SPASSWORD - show set password "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("(only after setup you password!)"); Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("EXIT - exit from programm");
                                        break;
                                    case "SET NAME":
                                        Console.WriteLine("Please input user name");
                                        userName = Console.ReadLine();
                                        Console.Write("User name "); Console.ForegroundColor = ConsoleColor.Green; Console.Write(userName); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(" successfully set");
                                        break;
                                    case "SET PASSWORD":

                                        if (string.IsNullOrEmpty(userPassword))
                                        {
                                            Console.WriteLine("Please input user password:\n");
                                            userPassword = Console.ReadLine();
                                            Console.Write("User name "); Console.ForegroundColor = ConsoleColor.Green; Console.Write(userPassword); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(" successfully set");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please confirm user password for set new password:\n");
                                            checkingUserInput = Console.ReadLine();

                                            if (checkingUserInput == userPassword)
                                            {
                                                Console.WriteLine("\nInput a new password:\n");
                                                userPassword = Console.ReadLine();
                                                Console.WriteLine("Password " + userPassword + " successfully set");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Old password incorrect");
                                            }
                                        }
                                        break;
                                    case "CHANGE COLOR":
                                        Console.Write("You can choise ");
                                        Console.ForegroundColor = ConsoleColor.Blue; Console.Write("BLUE ");
                                        Console.ForegroundColor = ConsoleColor.White; Console.Write("or ");
                                        Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("YELLOW ");
                                        Console.ForegroundColor = ConsoleColor.White; Console.Write("or ");
                                        Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("MAGENTA ");
                                        Console.ForegroundColor = ConsoleColor.White; Console.Write("color\n");
                                        Console.WriteLine("Please, give your choise");
                                        userChoiseTextColor = Console.ReadLine();

                                        switch (userChoiseTextColor)
                                        {
                                            case "YELLOW":
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("DONE!");
                                                break;
                                            case "BLUE":
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                Console.WriteLine("DONE!");
                                                break;
                                            case "MAGENTA":
                                                Console.ForegroundColor = ConsoleColor.Magenta;
                                                Console.WriteLine("DONE!");
                                                break;
                                        }
                                        break;
                                    case "CHANGE BCOLOR":
                                        Console.Write("You can choise ");
                                        Console.BackgroundColor = ConsoleColor.Cyan; Console.Write("Cyan");
                                        Console.ResetColor(); Console.Write(" or ");
                                        Console.BackgroundColor = ConsoleColor.DarkGreen; Console.Write("DarkGreen");
                                        Console.ResetColor(); Console.Write(" or ");
                                        Console.BackgroundColor = ConsoleColor.DarkRed; Console.Write("DarkRed");
                                        Console.ResetColor(); Console.Write(" background color \n");
                                        Console.WriteLine("Please, give your choise");
                                        userChoiseBackgroundColor = Console.ReadLine();

                                        switch (userChoiseBackgroundColor)
                                        {
                                            case "Cyan":
                                                Console.BackgroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine("DONE!");
                                                break;
                                            case "DarkGreen":
                                                Console.BackgroundColor = ConsoleColor.DarkGreen;
                                                Console.WriteLine("DONE!");
                                                break;
                                            case "DarkRed":
                                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                                Console.WriteLine("DONE!");
                                                break;
                                        }
                                        break;
                                    case "SHOW NAME":

                                        if (string.IsNullOrEmpty(userPassword))
                                        {
                                            Console.WriteLine("ERROR. Please set user password before show username");
                                        }
                                        else
                                        {
                                            Console.WriteLine(userName);
                                        }
                                        break;
                                    case "SHOW PASSWORD":

                                        if (string.IsNullOrEmpty(userPassword))
                                        {
                                            Console.WriteLine("ERROR. Before set user password");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Input user password: ");
                                            checkingUserInput = Console.ReadLine();
                                            
                                            if (checkingUserInput == userPassword)
                                            {
                                                Console.WriteLine(userPassword);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Error. Password is not correct");
                                            }
                                        }
                                        break;
                                    case "EXIT":
                                        Console.WriteLine("\nEXIT OF PROGRAMM");
                                        waitingFinishedProgramm = true;
                                        break;
                                    default:
                                        Console.WriteLine("Unknow command. Please, try again");
                                        break;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
