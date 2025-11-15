namespace MasterClassProjects;

public interface IRecipeRepository
{
    void Add(string filePath, Recipe recipe);
    void CreateFile(string filePath, Recipe recipe);
    List<Recipe> Get(string filePath);
}