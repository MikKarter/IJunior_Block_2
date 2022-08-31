﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomTurnToAttack = new Random();

            string playerName = "username";
            string bossName = "Koh-Ra";
            string playerSummonName = "El-Sohra";
            string userPlayerController;

            string activeSpell1Name = "Sohnaroh";
            string activeSpell2Name = "Suffocation";
            string activeSpell3Name = "Summon " + playerSummonName;
            string activeSpell4Name = "Fun of spikes";
            string passiveSpell1Name = "HP regen";

            int bossDamage = 470;
            int playerHandDamage = 25;
            int playerSpellSuffocation = 172;
            int playerSpellFunOfSpikes = 400;
            int playerSummonElSohraDamage = 275;
            int playerSummonCounter = 0;
            int countersSkipPlayerStepsAfterCastSpell4Name = 0;
            int firstTurnToAttack = randomTurnToAttack.Next(1, 3);
            int bossSkipStepCounter = 0;
            int playerSkipStepCounter = 0;

            bool playerSpellSummonElSohra = false;
            bool playerTurnToAttack = false;
            bool bossTurnToAttack = false;

            float bossHealth = 1000;
            float playerHealth = 1000;
            float playerSummonHealth = 250;
            float playerSpellPassiveWaterHealth = 0.04f;

            Console.WriteLine("Welcom to final battle " + playerName + "!");
            Console.WriteLine("Boss - " + bossName + "!");

            //Who turn to attack first?
            if (firstTurnToAttack == 1)
            {
                playerTurnToAttack = true;

            }
            else
            {
                bossTurnToAttack = true;
            }

            Console.WriteLine("You can cast next spell to atack " + bossName);
            Console.WriteLine("1 - " + activeSpell1Name + ". You can scare the " + bossName + " and he can't attack next 2 steps");
            Console.WriteLine("2 - " + activeSpell2Name + ". You can cast suffocation to " + bossName);
            Console.WriteLine("3 - " + activeSpell3Name + ". You can summon you personal mushroom-pet for attack" + bossName + ". WARNING! YOU CAN'T ATTACK NEXT 2 STEPS AFTER SUMMON " + playerSummonName);
            Console.WriteLine("4 - " + activeSpell4Name + ". A lot of power you spell. You can cast this only once from 3 steps and only after summon " + playerSummonName);
            Console.WriteLine("5 - And of cource you can attack " + bossName + " you hands if you want");
            Console.WriteLine("You also have a passive " + passiveSpell1Name + " " + playerSpellPassiveWaterHealth + " each turn");

            while (playerHealth > 0 & bossHealth > 0)
            {
                //Boss attack 
                while (bossTurnToAttack == true)
                {
                    if (bossHealth <= 0)
                    {
                        break;
                    }

                    if (bossSkipStepCounter == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(bossName + " turn to attack!"); Console.ResetColor();
                        Console.WriteLine(bossName + " deals you " + bossDamage + " damage!");
                        playerHealth -= bossDamage;
                        Console.WriteLine("You have " + playerHealth + " health");

                        //if player summon of summon - boss attack the summon
                        if (playerSpellSummonElSohra == true)
                        {
                            Console.WriteLine(bossName + " also deals your " + playerSummonName + " " + bossDamage + " damage!");
                            playerSummonHealth -= bossDamage;
                            Console.WriteLine(playerSummonName + " have " + playerSummonHealth + " health!");
                        }
                    }
                    else if (bossSkipStepCounter > 0)
                    {
                        Console.WriteLine(bossName + " scared and can't attack next " + bossSkipStepCounter + " steps!");
                    }

                    // if boss kill summon lock activeSpell4Name
                    if (playerSummonHealth <= 0)
                    {
                        Console.WriteLine(playerSummonName + " is dead...");
                        playerSpellSummonElSohra = false;
                    }

                    //Boss Skip Steps Counter can't will be more than 0
                    if (bossSkipStepCounter < 0)
                    {
                        bossSkipStepCounter = 0;
                    }

                    //After boss step decrement the bossSkipStepCounter
                    else if (bossSkipStepCounter > 0)
                    {
                        bossSkipStepCounter--;
                    }

                    bossTurnToAttack = false;
                    playerTurnToAttack = true;
                }

                //Player attack 
                while (playerTurnToAttack == true)
                {
                    
                    if (playerHealth <=0)
                    {
                        break;
                    }

                    if (playerSkipStepCounter == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("You turn to attack!"); Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Push the spell number!"); Console.ResetColor();
                        userPlayerController = Console.ReadLine();

                        //Player attack controller
                        switch (userPlayerController)
                        {
                            case "1":
                                bossSkipStepCounter += 2;
                                Console.WriteLine("You scared " + bossName + "!\n" + bossName + " can't attack next " + bossSkipStepCounter + " steps!");
                                break;
                            case "2":
                                Console.WriteLine("You cast " + activeSpell2Name + " to " + bossName);
                                bossHealth -= playerSpellSuffocation;
                                Console.WriteLine(bossName + " have " + bossHealth + " HP");
                                break;
                            case "3":

                                //player can't summone more than playerSummonCounter
                                if (playerSpellSummonElSohra == true)
                                {
                                    Console.WriteLine("You can't summon more " + playerSummonCounter + " summon");
                                }

                                Console.WriteLine("You cast " + activeSpell3Name + " to you help");
                                playerSpellSummonElSohra = true;
                                playerSummonCounter++;
                                playerSkipStepCounter = 2;
                                Console.WriteLine("After " + activeSpell3Name + "you skip next " + playerSkipStepCounter + " steps");
                                Console.WriteLine("ATTENTION! Unlocked spell " + activeSpell4Name);
                                break;
                            case "4":
                                if (playerSpellSummonElSohra == true & countersSkipPlayerStepsAfterCastSpell4Name == 0)
                                {
                                    Console.WriteLine("You cast " + activeSpell4Name + " and deals boss " + playerSpellFunOfSpikes + " damage!");
                                    bossHealth -= playerSpellFunOfSpikes;
                                    Console.WriteLine(bossName + " have " + bossHealth + " HP");
                                    countersSkipPlayerStepsAfterCastSpell4Name = 2;
                                }
                                else if (countersSkipPlayerStepsAfterCastSpell4Name > 0 & playerSpellSummonElSohra == true)
                                {
                                    Console.WriteLine("You can't cast " + activeSpell4Name + " " + countersSkipPlayerStepsAfterCastSpell4Name + " more steps!");
                                    countersSkipPlayerStepsAfterCastSpell4Name--;
                                }
                                break;
                            case "5":
                                Console.WriteLine("Believing in yourself, you hit the boss with your hand right in the face");
                                bossHealth -= playerHandDamage;
                                Console.WriteLine(bossName + " have " + bossHealth + " HP and very surprised");
                                break;
                            default:
                                Console.WriteLine("Please input correct number spells to attack");
                                break;
                        }
                        
                        //Restore player and summon HP with help passive spell water regen;
                        playerHealth = playerSpellPassiveWaterHealth * playerSpellPassiveWaterHealth + playerHealth;
                        
                        if (playerSpellSummonElSohra == true)
                        {
                            playerSummonHealth = playerSpellPassiveWaterHealth * playerSpellPassiveWaterHealth + playerSummonHealth;
                        }

                        playerTurnToAttack = false;
                    }

                    if (playerSkipStepCounter > 0)
                    {
                        Console.WriteLine("You can't attack next " + playerSkipStepCounter + " steps!");
                    }

                    //Player Skip Steps Counter can't will be more than 0
                    if (playerSkipStepCounter < 0)
                    {
                        playerSkipStepCounter = 0;
                    }

                    //After player step decrement the playerSkipStepCounter
                    else if (playerSkipStepCounter > 0)
                    {
                        playerSkipStepCounter--;
                    }

                    bossTurnToAttack = true;
                    playerTurnToAttack = false;
                }

                //Summon atack
                if (playerSpellSummonElSohra == true)
                {
                    Console.WriteLine(playerSummonName + " attack!");
                    bossHealth -= playerSummonElSohraDamage;
                    Console.WriteLine(bossName + " have " + bossHealth + " HP");
                }

                //Check possibility player steps
                if (playerSkipStepCounter > 0)
                {
                    playerSkipStepCounter--;
                    playerTurnToAttack = false;
                }
                else if (playerSkipStepCounter == 0)
                {
                    playerTurnToAttack = true;
                }

                //Check possibility boss steps
                if (bossSkipStepCounter > 0)
                {
                    bossSkipStepCounter--;
                    bossTurnToAttack = false;
                }
                else if (bossSkipStepCounter == 0)
                {
                    bossTurnToAttack = true;
                }

            }

            //Choose the winner
            if (playerHealth <= 0)
            {
                Console.WriteLine(bossName + " wins!");
            }

            if (bossHealth <= 0)
            {
                Console.WriteLine(playerName + " wins!");
            }
        }
    }
}