using System;
using System.Collections.Generic;
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
            
            return null;
        }

    }
}