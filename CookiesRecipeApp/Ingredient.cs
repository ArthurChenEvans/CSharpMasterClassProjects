namespace MasterClassProjects;

public class Ingredient {
    public int ID { get; set; }
    public string Name { get; set; }
    public string PreparationInstructions { get; set; }
  
    public Ingredient(int id, string name, string preparationInstructions)
    {
        ID = id;
        Name = name;
        PreparationInstructions = preparationInstructions;
    }
}