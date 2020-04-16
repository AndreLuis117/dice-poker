using System;
using System.Collections.Generic;
using System.Text;

namespace dice_poker.Model
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

        public static List<Dice> ThrowDices(List<Dice> dices){

            foreach (var dice in dices)
            {
                Random randNum = new Random();
                var num = randNum.Next(0,6);

                dice.Face = num;

            }

            return dices;
        }

        public static string PrintDices(List<Dice> dices){

            StringBuilder stringDices = new StringBuilder();

            stringDices.AppendJoin('-', dices);

            return stringDices.ToString();
        }

        public static string PrintPlayerThrowDicesMessage(){
            return "Digite 1 para lançar os dados!";
        }
    }
}