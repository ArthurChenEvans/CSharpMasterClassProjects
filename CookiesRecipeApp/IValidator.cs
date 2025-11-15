namespace MasterClassProjects;

public interface IValidator
{
    bool isNotANumber(string input);
    bool doesIdExist(int input, List<Ingredient> ingredients);
    bool isListEmpty(List<Ingredient> ingredients);
}