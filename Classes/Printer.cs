using System;
using System.Collections.Generic;

namespace dice_poker.Classes
{
    public static class Printer
    {
        public static string PrintDices(List<Dice> dices){

            List<int> diceList = new List<int>();

            foreach (var dice in dices)
            {
                diceList.Add(dice.Face);
            }

            var dicesPrinted = String.Join(" | ", diceList);

            return dicesPrinted;
        }

        public static string PrintPlayerThrowDicesMessage(){
            return "\nDigite 1 para lançar os dados!";
        }

        public static string PrintRethrowDicesMessage(){
            return "\nDigite quais dados deseja relançar. \n"
                    + "Instruções: \n"
                    + "- Para relançar digite o indice dos dados que deseja relançar \n" 
                    + "- (Indice 0 - 1 - 2 - 3 - 4 - 5) cada número do indice se refere a um dado da esquerda para direta \n"  
                    + "- Para selecionar mais que um dado utilize vírgulas como separadores Ex: 1,4,5";
        }

        public static string PrintPlayerRethrowDicesDecisionMessage(){

            return "\nDigite 1 se deseja relançar dados, caso deseje ficar com o set atual de dados digite 2";
        }

        public static string PrintWelcomeMessage(){

            return "\nBem vindo ao game DICE POKER!";
        }

        public static string PrintStarGameMessage(){

            return "\nDigite 1 para começar a jogar...";
        }

        public static string PrintPlayerDicesRevealMessage()
        {
            return "\nSeus dados são: ";
        }

        public static string PrintBotDicesRevealMessage(){
            return "\nDados adversário: ";
        }
    }
}