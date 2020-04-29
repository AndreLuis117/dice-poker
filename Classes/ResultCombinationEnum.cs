namespace dice_poker.Classes
{
    public class ResultCombinationEnum : Enumeration
    {

    public ResultCombinationEnum(int id, string name)
        : base(id, name)
    {

    }
    public static readonly ResultCombinationEnum OnePair = new ResultCombinationEnum(1, "One pair – 1 par mostrando mesmo valor");
    public static readonly ResultCombinationEnum TwoPair = new ResultCombinationEnum(2, "Two pairs – 2 pares de dados com o mesmo valor");
    public static readonly ResultCombinationEnum ThreeOfAkind = new ResultCombinationEnum(3, "Three-of-a-kind – 3 dados mostrando o mesmo valor");
    public static readonly ResultCombinationEnum FiveHighStraight = new ResultCombinationEnum(4, "Five-high straight – dados mostrando a sequência I, II, III, IV e V");
    public static readonly ResultCombinationEnum SixHighStraight = new ResultCombinationEnum(5, "Six-high straight – dados mostrando a sequência II, III, IV, V e VI");
    public static readonly ResultCombinationEnum FullHouse = new ResultCombinationEnum(6, "Full House – um par de mesmo valor e uma trinca de mesmo valor");
    public static readonly ResultCombinationEnum FourOfAKind = new ResultCombinationEnum(7, "Four-of-a-kind – 4 dados mostrando o mesmo valor");
    public static readonly ResultCombinationEnum FiveOfAkind = new ResultCombinationEnum(8, "Five-of-a-kind – 5 dados mostrando o mesmo valor");


    
    }
}
