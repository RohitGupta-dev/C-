Console.WriteLine("Enter First Number");
string First_Number = Console.ReadLine();
int First = check(First_Number);
Console.WriteLine("Enter Second Number");
string Second_Number = Console.ReadLine();
int Second = check(Second_Number);



int check(string Input)

{
    string p = Input;
    int j;
    while (!int.TryParse(p, out j))
    {
        Console.WriteLine("please enter again");
        p = Console.ReadLine();
    }
    return j;

}

for(int i = First; i <= Second; i++)
{
    for (int j = 1; j <=10; j++)
    {
        Console.WriteLine($"{i} X {j} = {i * j}");
    }
    Console.WriteLine("-------------------------------------");
}