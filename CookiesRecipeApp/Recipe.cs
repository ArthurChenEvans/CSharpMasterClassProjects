namespace MasterClassProjects;

public class Recipe
{
    public int ID { get; set; }
    public List<Ingredient> Ingredients { get; set; }
  
    public Recipe(int id) {
        ID = id;
        Ingredients = new List<Ingredient>();
    }
}