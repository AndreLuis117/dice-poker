using System;

namespace dice_poker.Classes
{
    public class Game
    {
        public DiceResultEnum GameRound(){
            Dice diceObj = new Dice();
            string result = "";
            var bot = new Bot();

            var playerDices = diceObj.CreateSetOfDices();
            var botDices = diceObj.CreateSetOfDices();

            bool gamerOver = false;
            while (true)
            {
                Console.WriteLine(Printer.PrintNewRoundMessage());


                while (result != "1")
                {
                    Console.WriteLine(Printer.PrintStarGameMessage());
                    result = Console.ReadLine().Trim();
                }
                result = "";

                while (gamerOver == false)
                {

                    //Jogador começa
                    Console.WriteLine(Printer.PrintPlayerThrowDicesMessage());
                    result = Console.ReadLine();

                    while (result != "1")
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

                    while (result != "1" && result != "2")
                    {
                        Console.WriteLine(Printer.PrintPlayerRethrowDicesDecisionMessage());
                        result = Console.ReadLine().Trim();
                    }

                    if (result == "1")
                    {
                        result = "";

                        while (string.IsNullOrEmpty(result))
                        {
                            Console.WriteLine(Printer.PrintRethrowDicesMessage());
                            result = Console.ReadLine().Trim();
                        }

                        playerDices = diceObj.RethrowDices(playerDices, result);

                        Console.WriteLine(Printer.PrintPlayerDicesRevealMessage());
                        Console.WriteLine(Printer.PrintDices(playerDices));

                    }

                    if(bot.AnalyzeRethrow(playerDices, botDices))
                    {
                        Console.WriteLine(Printer.PrintBotRetrowDicesMessage());

                        var botChoices = bot.AnalyzeDicesToRethrow(playerDices, botDices);

                        botDices = diceObj.RethrowDices(botDices, botChoices);

                        Console.WriteLine(Printer.PrintBotDicesRevealMessage());
                        Console.WriteLine(Printer.PrintDices(botDices));
                    }

                    var botResult = Tools.GetResultCombination(botDices);

                    var playerResult = Tools.GetResultCombination(playerDices);

                    var roundResult = Tools.GetResultOfRound(playerResult, botResult);

                    if(roundResult.Id == DiceResultEnum.PlayerWin.Id)
                    {
                        Console.WriteLine(Printer.PrintPlayerRoundVictory());
                    }else if(roundResult.Id == DiceResultEnum.BotWin.Id)
                    {
                        Console.WriteLine(Printer.PrintBotRoundVictory());
                    }else if(roundResult.Id == DiceResultEnum.Tie.Id)
                    {
                        Console.WriteLine(Printer.PrintRoundTie());
                    }

                    return roundResult;
                }
            }
        }
    }
}