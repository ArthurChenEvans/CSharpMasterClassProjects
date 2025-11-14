// See https://aka.ms/new-console-template for more information

string userResponse;
var todos = new List<string>();

Console.WriteLine("Hello!");
do
{
    Console.WriteLine("What do you want to do?" 
                      + "\n[S]ee all TODOs" 
                      + "\n[A]dd a TODO" 
                      + "\n[R]emove a TODO" 
                      + $"\n[E]xit");
    userResponse = Console.ReadLine().ToUpper();

    if (userResponse != "S" && userResponse != "A" && userResponse != "R" && userResponse != "E")
    {
        Console.WriteLine($"Invalid input: {userResponse}");
    }
    
    if (userResponse == "A")
    {
        while (true)
        {
            Console.WriteLine("Enter a non-empty and unique TODO: ");
            string todo = Console.ReadLine();
            
            if (isStringEmpty(todo))
                Console.WriteLine("TODO must not be empty!");
            else if (doesTodoAlreadyExist(todo))
                Console.WriteLine("TODO already exists in the TODO list!");
            else
            {
                todos.Add(todo);
                break;
            }
        }

    }

    if (userResponse == "R")
    {
        if (todos.Count <= 0) 
            Console.WriteLine("TODO list is empty.");
        else
            while (true)
            {
                listTODOS();
            
                Console.WriteLine("Which todo would you like to remove (enter the index): ");
                string index = Console.ReadLine();
                
                if(isStringEmpty(index)) 
                    Console.WriteLine("Index must not be empty!");
                else if(isIndexNotANumber(index)) 
                    Console.WriteLine("Index must be a number!");
                else if(isIndexOutOfRange(int.Parse(index)))
                    Console.WriteLine($"Index must be greater than 0 or less than {todos.Count}!");
                else
                {
                    todos.RemoveAt(int.Parse(index));
                    break;
                }
            }
    }

    if (userResponse == "S")
        if (todos.Count <= 0)
            Console.WriteLine("TODO list is empty.");
        else
            listTODOS();
} while (userResponse != "E");

bool isStringEmpty(string inputString)
{
    if (String.IsNullOrWhiteSpace(inputString)) return true;
    
    return false;
}

bool doesTodoAlreadyExist(string todo)
{
    if (todos.Contains(todo)) return true;
    
    return false;
}

bool isIndexNotANumber(string index)
{
    return !int.TryParse(index, out int number);
}

bool isIndexOutOfRange(int index)
{
    if (index < 0 || index >= todos.Count) 
        return true;

    return false;
}

void listTODOS()
{
    for (int i = 0; i < todos.Count; i++)
    {
        Console.WriteLine($"[{i}] - {todos[i]}");
    }
}

    
                                       