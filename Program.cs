using System;
using System.Collections.Generic;
using dice_poker.Classes;

namespace dice_poker
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice diceObj = new Dice();
            string result = "";

            var playerDices = diceObj.CreateSetOfDices();
            var botDices = diceObj.CreateSetOfDices();

            bool gamerOver = false;
            while (true)
            {
                Console.WriteLine(Printer.PrintWelcomeMessage());

                
                while(result != "1")
                {
                    Console.WriteLine(Printer.PrintStarGameMessage());
                    result = Console.ReadLine().Trim();
                }
                result = "";

                while (gamerOver == false)
                {
                    if(Tools.IsPlayerGoingStart())
                    {
                        //Jogador começa

                        Printer.PrintPlayerThrowDicesMessage();
                        result = Console.ReadLine();

                        while(result != "1")
                        {
                            Console.WriteLine(Printer.PrintPlayerThrowDicesMessage());
                            result = Console.ReadLine().Trim();
                        }
                        result = "";

                        //Jogador lança os dados
                        playerDices = diceObj.ThrowDices(playerDices); 

                        Console.WriteLine(Printer.PrintPlayerDicesRevealMessage()); 
                        Console.WriteLine(Printer.PrintDices(playerDices));
                            
                        //Bot lança os dados   
                        botDices = diceObj.ThrowDices(botDices);

                        Console.WriteLine(Printer.PrintBotDicesRevealMessage()); 
                        Console.WriteLine(Printer.PrintDices(botDices));  
                        
                        while(result != "1" || result != "2")
                        {
                            Console.WriteLine(Printer.PrintPlayerRethrowDicesDecisionMessage());
                            result = Console.ReadLine().Trim();
                        }

                        if(result == "1")
                        {
                            result = "";

                            while(string.IsNullOrEmpty(result))
                            {
                                Console.WriteLine(Printer.PrintRethrowDicesMessage());
                                result = Console.ReadLine().Trim();
                            }

                            playerDices = diceObj.RethrowDices(playerDices, result);

                            Console.WriteLine(Printer.PrintPlayerDicesRevealMessage()); 
                            Console.WriteLine(Printer.PrintDices(playerDices));

                        }
                    }
                    else
                    {
                        //Bot começa 

                        botDices = diceObj.ThrowDices(botDices);
                        Console.WriteLine(Printer.PrintDices(botDices));


                        playerDices = diceObj.ThrowDices(playerDices);

                    }
                }
                
                
            }
        }
    }
}
