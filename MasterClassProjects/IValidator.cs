namespace MasterClassProjects;

public interface IValidator {
    bool isANumber(string input);
    bool doesIdExist(int id, List<Ingredient> list);
}