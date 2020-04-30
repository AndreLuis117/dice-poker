using System.Collections.Generic;
using System.Linq;

namespace dice_poker.Classes
{
    public class DiceRepetition
    {
        public int Face1 { get; set; }
        public int Face2 { get; set; }
        public int Face3 { get; set; }
        public int Face4 { get; set; }
        public int Face5 { get; set; }
        public int Face6 { get; set; }


        public List<int> GetRepetitionList(){
            List<int> repetitionList = new List<int>();

            repetitionList.Add(Face1);
            repetitionList.Add(Face2);
            repetitionList.Add(Face3);
            repetitionList.Add(Face4);
            repetitionList.Add(Face5);
            repetitionList.Add(Face6);

            repetitionList = repetitionList.Where(x => x > 0).ToList();

            return repetitionList;
        }
        
    }
}