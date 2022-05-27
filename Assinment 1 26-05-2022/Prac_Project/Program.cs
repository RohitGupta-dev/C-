Console.WriteLine("!!!!!!!!! Hello   !!!!!!!!!");
Console.Write(" Enter name:");

string userName = Console.ReadLine();
if (string.IsNullOrEmpty(userName))
{
    Console.WriteLine("Name can't be empty! Input your name once more");
    userName = Console.ReadLine();
}
Console.Write("Enter Class:");
string class_name = Console.ReadLine();
Console.Write("Enter Rollno:");

int Rollno =Convert.ToInt32(Console.ReadLine());

Console.Write("Print Data Press Y||y||YES||yes");

string userInput = Console.ReadLine();
void Show() // No Parameter  
{
    if (userInput == "y" || userInput == "Y" || userInput == "yes" || userInput == "Yes")
    {

        Console.WriteLine($"Username is  {userName}");
        Console.WriteLine($"class_name is {class_name}");

        Console.WriteLine($"Rollno is {Rollno}");
    }
    else if (userInput == "N" || userInput == "n" || userInput == "no" || userInput == "NO")
    {
        Console.WriteLine("thank You");
    }
    else
    {
        Console.WriteLine("Try Again");
        Console.Write("Print Data Press Y||y||YES||yes||no||NO||n||n");

        userInput = Console.ReadLine();
        Show();
    }
}

Show();
