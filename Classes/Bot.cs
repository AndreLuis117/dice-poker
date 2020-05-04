using System.Collections.Generic;
using System.Linq;

namespace dice_poker.Classes
{
    public class Bot
    {
        public bool AnalyzeRethrow(List<Dice> playerDices, List<Dice> botDices){

            if(Tools.GetResultCombination(botDices).Id > Tools.GetResultCombination(playerDices).Id)
                return false;
            return true;
        }

        public string AnalyzeDicesToRethrow(List<Dice> playerDices, List<Dice> botDices){
            List<int> botChoices = new List<int>();

            var auxList = botDices.Select(x => x.Face).Distinct();

            foreach (var item in auxList)
            {
                if(botDices.Where(x => x.Face == item).Count() == 1)
                {
                    var auxObject = botDices.Where(x => x.Face == item).FirstOrDefault();

                    botChoices.Add(botDices.IndexOf(auxObject) + 1);
                }
            }

            var botChoicesStr = string.Join(',', botChoices);

            return botChoicesStr;
        }
    }
}