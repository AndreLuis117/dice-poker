using System;
using System.Collections.Generic;

namespace dice_poker.Classes
{
    public class Dice
    {
        public int Face { get; set; }


        public List<Dice> CreateSetOfDices()
        {
            List<Dice>  dices = new List<Dice>();
        
            for (int i = 0; i < 5; i++)
            {
                Dice dice = new Dice();

                dices.Add(dice);
            }

            return dices;
        }

        public List<Dice> ThrowDices(List<Dice> dices)
        {

            foreach (var dice in dices)
            {
                dice.Face = ThrowSingleDice(dice).Face;
            }

            return dices;
        }

        public List<Dice> RethrowDices(List<Dice> dices, string playerChoices)
        {
            var listOfPlayerChoices = playerChoices.Trim().Split(',');

            foreach (var index in listOfPlayerChoices)
            {
                dices[Convert.ToInt32(index)-1] = ThrowSingleDice(new Dice());
            }

            return dices;
        }

        public Dice ThrowSingleDice(Dice dice)
        {
            Random randNum = new Random();
            var num = randNum.Next(1,6);

            dice.Face = num;

            return dice;
        }
    }

    
}