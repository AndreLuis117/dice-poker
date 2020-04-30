using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dice_poker.Classes
{
    public static class Tools
    {
        public static bool IsPlayerGoingStart(){
            Random randNum = new Random();
            var num = randNum.Next(100);

            if(num >= 50){
                return true;
            }else{
                return false;
            }
        }

        public static ResultCombinationEnum GetResultCombination(List<Dice> dices)
        {
            var diceRepetition = GetDiceRepetition(dices);

            if(IsOnePair(diceRepetition))
                return ResultCombinationEnum.OnePair;

            if(IsTwoPairs(diceRepetition))
                return ResultCombinationEnum.TwoPair;

            if(IsThreeOfAkind(diceRepetition))
                return ResultCombinationEnum.ThreeOfAkind;

            if(IsFiveHighStraight(diceRepetition))
                return ResultCombinationEnum.FiveHighStraight;
            
            if(IsSixHighStraight(diceRepetition))
                return ResultCombinationEnum.SixHighStraight;
            
            if(IsFullHouse(diceRepetition))
                return ResultCombinationEnum.FullHouse;

            if(IsFourOfAKind(diceRepetition))
                return ResultCombinationEnum.FourOfAKind;
            
            if(IsFiveOfAKind(diceRepetition))
                return ResultCombinationEnum.FourOfAKind;

            return null;
        }


        private static bool IsFiveOfAKind(DiceRepetition diceRepetition){
            return diceRepetition.GetRepetitionList().Any(x => x == 5);
        }

        private static bool IsFourOfAKind(DiceRepetition diceRepetition){
            return diceRepetition.GetRepetitionList().Any(x => x == 4);
        }

        private static bool IsFullHouse(DiceRepetition diceRepetition){

            if(diceRepetition.GetRepetitionList().Any(x => x == 3))
                if(diceRepetition.GetRepetitionList().Any(x => x == 2))
                    return true;
            

            return false;
        }

        private static bool IsSixHighStraight(DiceRepetition diceRepetition){

            if(diceRepetition.Face2 == 1
                && diceRepetition.Face3 == 1
                && diceRepetition.Face4 == 1
                && diceRepetition.Face5 == 1
                && diceRepetition.Face6 == 1)
                    return true;
                
            

            return false;
        }

        private static bool IsFiveHighStraight(DiceRepetition diceRepetition){

            if(diceRepetition.Face2 == 1
                && diceRepetition.Face3 == 1
                && diceRepetition.Face4 == 1
                && diceRepetition.Face5 == 1
                && diceRepetition.Face6 == 1)
                    return true;
                
            

            return false;
        }

        private static bool IsThreeOfAkind(DiceRepetition diceRepetition){

            if(diceRepetition.GetRepetitionList().Any(x => x == 3))
                if(diceRepetition.GetRepetitionList().Count == 3)
                    return true;
            

            return false;
        }

        private static bool IsTwoPairs(DiceRepetition diceRepetition){

            if(diceRepetition.GetRepetitionList().Where(x => x == 2).Count() == 2)
                return true;
            

            return false;
        }         
        private static bool IsOnePair(DiceRepetition diceRepetition)
        {
            bool isOnePair = false;

            if(diceRepetition.GetRepetitionList().Any(x => x == 2))
                if(diceRepetition.GetRepetitionList().Count == 4)
                    return true;

            return isOnePair;
        }

        private static DiceRepetition GetDiceRepetition(List<Dice> dices)
        {
            DiceRepetition diceRepetition = new DiceRepetition();

            foreach (var dice in dices)
            {
                if(dice.Face == 1)
                {
                    diceRepetition.Face1 += 1;
                }else if (dice.Face == 2)
                {
                    diceRepetition.Face2 += 1;
                }else if(dice.Face == 3)
                {
                    diceRepetition.Face3 += 1;
                }else if (dice.Face == 4)
                {
                    diceRepetition.Face4 += 1;     
                }else if(dice.Face == 5)
                {
                    diceRepetition.Face5 += 1;       
                } else if (dice.Face == 6)
                {
                    diceRepetition.Face6 += 1;     
                }
            }

            return diceRepetition;
        }

    }
}