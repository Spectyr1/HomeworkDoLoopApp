

string name;

do
{
    Console.Write("Please enter your first name, type 'EXIT' to leave: ");
    name = Console.ReadLine();

    if (name.ToLower() == "tim")
    {
        Console.WriteLine("Welcome professor!");
    }
    else
    {
        Console.WriteLine("Welcome student.");
    }

} while (name.ToLower() != "exit");