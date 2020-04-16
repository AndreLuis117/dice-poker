using System;
using System.Collections.Generic;
using dice_poker.Model;

namespace dice_poker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dice> playerDices = new List<Dice>();
            List<Dice> botDices = new List<Dice>();

            bool gamerOver = false;
            while (true)
            {
                Console.WriteLine("Bem vindo ao game DICE POKER!");

                Console.WriteLine("Digite 1 para começar a jogar...");

                var result = Console.ReadLine();

                if (result.Trim() == "1")
                {
                    while (gamerOver == false)
                    {
                        if(Tools.IsPlayerGoingStart()){
                            Tools.PrintPlayerThrowDicesMessage();
                            result = Console.ReadLine();

                            while(result != "1"){
                                Tools.PrintPlayerThrowDicesMessage();
                                result = Console.ReadLine();
                            }

                            playerDices = Tools.ThrowDices(playerDices);  
                            Console.WriteLine(Tools.PrintDices(playerDices));
                            
                            

                            botDices = Tools.ThrowDices(botDices);   
                        }else
                        {
                            botDices = Tools.ThrowDices(botDices);
                            Console.WriteLine(Tools.PrintDices(botDices));

                            playerDices = Tools.ThrowDices(playerDices);

                        }
                    }
                }
                
            }
        }
    }
}
