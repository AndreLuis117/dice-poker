namespace dice_poker.Classes
{
    public class DiceResultEnum : Enumeration
    {
        public DiceResultEnum(int id, string name)
        : base(id, name)
    {

    }
    public static readonly DiceResultEnum PlayerWin = new DiceResultEnum(1, "Vitória do jogador!");
    public static readonly DiceResultEnum BotWin = new DiceResultEnum(2, "Vitória do Bot!");
    public static readonly DiceResultEnum Tie = new DiceResultEnum(3, "Empate!");
    }
}