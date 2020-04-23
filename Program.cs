using System;
using System.Collections.Generic;
using dice_poker.Classes;

namespace dice_poker
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            var round1 = game.GameRound();

            var round2 = game.GameRound();

            var round3 = game.GameRound();
        }
    }
}
