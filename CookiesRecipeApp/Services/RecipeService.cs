namespace MasterClassProjects;

public class RecipeService : IRecipeService
{
    private RecipeRepository _recipeRepository = new RecipeRepository();
    private Validator _validator = new Validator();

    public Recipe Create(string filePath, List<Ingredient> ingredients)
    {
        Console.WriteLine("Create a new cookie recipe! Available ingredients are:");
        ingredients.ForEach(x => Console.WriteLine($"{x.ID} - {x.Name}"));

        int idToSet = GetNumberOfRecipes(filePath);
        Recipe recipe = new Recipe(idToSet);
        
        while (true)
        {
            Console.WriteLine("Add an ingredient by its ID or type anything else if finished.");
            string? response = Console.ReadLine();
    
            if (_validator.isNotANumber(response))
            {
                break;
            } 
    
            if (_validator.doesIdExist(int.Parse(response), ingredients))
            {
                recipe.Ingredients.Add(ingredients.Where(x => x.ID == int.Parse(response)).First());
            }
            else
            {
                Console.WriteLine("No ingredient added. Invalid input.");
            }
        }
        
        return recipe;
    }
    
    public void Save(string filePath, Recipe recipe)
    {
        if (_validator.isListEmpty(recipe.Ingredients))
        {
            Console.WriteLine("No ingredients have been selected. Recipe will not be saved.");
        }
        else
        {
            Console.WriteLine("Recipe added:");
            recipe.Ingredients.ForEach(x => Console.WriteLine($"{x.Name}. {x.PreparationInstructions}"));

            if (!File.Exists(filePath))
            {
                _recipeRepository.CreateFile(filePath, recipe);
            }
            else
            {
                _recipeRepository.Add(filePath, recipe);
            }
        }
    }

    public void DisplayAll(string filePath)
    {
        List<Recipe> recipes = _recipeRepository.Get(filePath);
        
        foreach (Recipe recipe in recipes)
        {
            Console.WriteLine($"****{recipe.ID}*****");
            foreach (Ingredient ingredient in recipe.Ingredients)
            {
                Console.WriteLine($"{ingredient.Name}. {ingredient.PreparationInstructions}");
            }
        }
    }

    private int GetNumberOfRecipes(string filePath)
    {
        List<Recipe> recipes = _recipeRepository.Get(filePath);
        return recipes.Count;   
    }
}