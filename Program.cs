using AccessModifiers.Models;

Console.Write("How many notebooks do you want to add to the system?: ");
int count = Convert.ToInt32(Console.ReadLine());

Notebook[] Database = new Notebook[count];

for (int i = 0; i < count; i++)
{
    Database[i] = GetNotebookFromUser();
}

PrintNotebookDB(Database);

Notebook GetNotebookFromUser()
{

    int Count = PromptAndGetInt("Please enter the count: ");
    decimal Price = PromptAndGetDec("Please enter the price: ");
    string Model = PromptAndGetString("Please enter the model: ");

    var Notebook = new Notebook(Count, Price, Model);
    Notebook.Brand = PromptAndGetString("Please enter the brand name: ");
    Notebook.Storage = PromptAndGetInt("Please enter the storage capacity: ");
    Notebook.Ram = PromptAndGetInt("Please enter the RAM capacity: ");

    return Notebook;
}


    string PromptAndGetString(string prompt)
{
    Console.Write(prompt);
    return Console.ReadLine();
}
int PromptAndGetInt(string prompt)
{
    Console.Write(prompt);
    return Convert.ToInt32(Console.ReadLine());
}
decimal PromptAndGetDec(string prompt)
{
    Console.Write(prompt);
    return Convert.ToDecimal(Console.ReadLine());
}

void PrintNotebookDB(Notebook[] DB)
{
    Console.WriteLine();
    foreach (Notebook notebook in DB)
    {
        Console.WriteLine(notebook);
    }
}