namespace MasterClassProjects;

public class Validator : IValidator {
    public bool isANumber(string input) => int.TryParse(input, out int number);
    public bool doesIdExist(int input, List<Ingredient> ingredients) => ingredients.Exists(x => input == x.ID);
}