namespace MasterClassProjects;

public interface IIngredientRepository
{
    List<Ingredient> Get(string filePath);
}