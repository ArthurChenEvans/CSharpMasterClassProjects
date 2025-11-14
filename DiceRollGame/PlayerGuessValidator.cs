namespace DiceRollGame;
public class PlayerGuessValidator
{
    public bool IsNotANumber(string playerGuess) => !int.TryParse(playerGuess, out int playerGuessAsInt);
    public bool IsNotInRange(int playerGuess) => !(playerGuess > 0 && playerGuess < 7);
}
