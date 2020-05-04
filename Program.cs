using System;
using System.Collections.Generic;
using dice_poker.Classes;

namespace dice_poker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Printer.PrintWelcomeMessage());

            List<DiceResultEnum> roundsResults = new List<DiceResultEnum>();
            Game game = new Game();

            var round1 = game.GameRound();
            roundsResults.Add(round1);

            var round2 = game.GameRound();
            roundsResults.Add(round2);

            var round3 = game.GameRound();
            roundsResults.Add(round3);

            var result = Tools.GetResultOfGame(roundsResults);

            Console.WriteLine("\n" + result.Name);
        }
    }
}
