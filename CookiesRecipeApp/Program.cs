using MasterClassProjects;

string currentDirectoryPath = Directory.GetCurrentDirectory();
string recipeFilePath = currentDirectoryPath + @"\recipes.json";
string ingredientsFilePath = currentDirectoryPath + @"\ingredients.json";

Validator _validator = new Validator();
RecipeService _recipeService = new RecipeService();
IngredientRepository _ingredientRepository = new IngredientRepository();

_recipeService.DisplayAll(recipeFilePath);
List<Ingredient> ingredients = _ingredientRepository.Get(ingredientsFilePath);
Recipe recipe = _recipeService.Create(recipeFilePath,  ingredients);
_recipeService.Save(recipeFilePath, recipe);
