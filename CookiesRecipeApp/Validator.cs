namespace MasterClassProjects;

public class Validator : IValidator {
    public bool isNotANumber(string input) => !int.TryParse(input, out _);
    public bool doesIdExist(int input, List<Ingredient> ingredients) => ingredients.Exists(x => input == x.ID);
    public bool isListEmpty(List<Ingredient> ingredients) => ingredients.Count == 0;
}