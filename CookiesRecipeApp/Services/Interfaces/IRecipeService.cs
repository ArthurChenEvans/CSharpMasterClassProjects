namespace MasterClassProjects;

public interface IRecipeService
{
    Recipe Create(string filePath, List<Ingredient> ingredients);
    void Save(string filePath, Recipe recipe);
    void DisplayAll(string filePath);
}