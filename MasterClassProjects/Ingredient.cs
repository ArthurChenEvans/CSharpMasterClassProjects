namespace MasterClassProjects;

public class Ingredient {
    private static int NumberOfIngredients = 0;
    public int ID { get; set; }
    public string Name { get; set; }
    public List<string> PreparationInstructions { get; set; }
  
    public Ingredient(int id, string name, List<string> preparationInstructions)
    {
        ID = id;
        Name = name;
        PreparationInstructions = preparationInstructions;
        NumberOfIngredients++;
    }
}