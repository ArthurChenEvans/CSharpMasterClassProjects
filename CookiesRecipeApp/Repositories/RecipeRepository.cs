using System.Text.Json;

namespace MasterClassProjects;

public class RecipeRepository : IRecipeRepository
{
    public void Add(string filePath, Recipe recipe)
    {
        List<Recipe> json = JsonSerializer.Deserialize<List<Recipe>>(File.ReadAllText(filePath));
        json.Add(recipe);
        var updatedJson =  JsonSerializer.Serialize(json);
        File.WriteAllText(filePath, updatedJson);
    }

    public void CreateFile(string filePath, Recipe recipe)
    {
        List<Recipe> newRecipeList = new List<Recipe>();
        newRecipeList.Add(recipe);
        
        File.Create(filePath).Close();
        string json =  JsonSerializer.Serialize(newRecipeList);
        File.WriteAllText(filePath, json);
    }

    public List<Recipe> Get(string filePath)
    {
        if (File.Exists(filePath))
        {
            Console.WriteLine("Existing recipes are:");
            List<Recipe> recipes = JsonSerializer.Deserialize<List<Recipe>>(File.ReadAllText(filePath));

            return recipes;
        }

        return new List<Recipe>();
    }
}