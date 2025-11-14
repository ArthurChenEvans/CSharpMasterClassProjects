namespace DiceRollGame;

public class DiceGame
{
    private int _diceNumber;
    private int _rounds = 3;
    private int _playerGuess;
    private PlayerGuessValidator _playerGuessValidator = new PlayerGuessValidator();

    public int RollDice() => _diceNumber = Random.Shared.Next(1, 6);

    private bool GetPlayerGuess()
    {
            Console.WriteLine("Enter a number between 1-6 to guess the dice: ");
            string response = Console.ReadLine();

            if (_playerGuessValidator.IsNotANumber(response))
            {
                Console.WriteLine("Must be a valid number.");
                return false;
            } else if (_playerGuessValidator.IsNotInRange(int.Parse(response)))
            {
                Console.WriteLine("Out of range (1-6). You have still lost a round.");
                return false;
            }

            _playerGuess = int.Parse(response);
            return true;
    }

    private void LoopTillValidPlayerGuess()
    {
        while (true)
        {
            if (GetPlayerGuess())
            {
                break;
            }
        }
    }

    public void PlayGame()
    {
        while (_rounds > 0)
        {
            RollDice();
            LoopTillValidPlayerGuess();

            if (_playerGuess == _diceNumber)
            {
                Console.WriteLine("You win!");
                break;
            }
            else
            {
                Console.WriteLine("Wrong Number");
                _rounds--;
            }
        }
        
        if (_rounds == 0) Console.WriteLine("You Lose!");
    }
}
