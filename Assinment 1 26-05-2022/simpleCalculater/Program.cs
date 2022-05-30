Console.WriteLine("Enter First Number");
string First_Number = Console.ReadLine();
int First = check(First_Number);
Console.WriteLine("Enter Second Number");
string Second_Number = Console.ReadLine();
int Second = check(Second_Number);
//Console.WriteLine("Enter Third Number");
//string Thrid_Number = Console.ReadLine();
//int Thrid = check(Thrid_Number);


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
Console.WriteLine("Enter Sum for 1:");
Console.WriteLine("Enter Min for 2:");
Console.WriteLine("Enter Mul for 3:");
Console.WriteLine("Enter Div for 4:");

string Thrid_Number = Console.ReadLine();
int value = check(Thrid_Number);
while (!(value == 1 || value == 2 || value == 3 || value == 4))
{
    Console.WriteLine("Enter valid data ");
    Console.WriteLine("Enter Sum for 1:");
    Console.WriteLine("Enter Min for 2:");
    Console.WriteLine("Enter Mul for 3:");
    Console.WriteLine("Enter Div for 4:");
    value = check(Thrid_Number);
}

switch (value)
{
    case 1:
        sum();
        break;
    case 2:
        min();
        break;
    case 3:
        mul();
        break;
    case 4:
        div();
        break;
    default:
        Console.WriteLine("you ENTER wRONG kEY");
        break;
}

void sum()
{
    int sum_Numbers = First + Second;
    //int sum_Numbers =   First + Second + Thrid;
    Console.WriteLine(sum_Numbers);
}
void min()
{
    int min_Numbers = First - Second;
    //int min_Numbers = First - Second - Thrid;
    Console.WriteLine(min_Numbers);
}
void div()
{
    int div_Numbers = First / Second;
    Console.WriteLine(div_Numbers);
}
void mul()
{
    int mul_Numbers = First * Second;
    Console.WriteLine(mul_Numbers);
}