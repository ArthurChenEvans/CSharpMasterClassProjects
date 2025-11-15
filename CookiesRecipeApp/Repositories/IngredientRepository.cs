using System.Text.Json;

namespace MasterClassProjects;

public class IngredientRepository : IIngredientRepository
{
    public List<Ingredient> Get(string filePath)
    {
        if (File.Exists(filePath))
        {
          List<Ingredient> ingredients = JsonSerializer.Deserialize<List<Ingredient>>(File.ReadAllText(filePath));
          return ingredients;
        }
        
        return new List<Ingredient>();
    }
}