Console.WriteLine("Enter First Number");
string First_Number = Console.ReadLine();
int First = check(First_Number);
Console.WriteLine("Enter Second Number");
string Second_Number = Console.ReadLine();
int Second = check(Second_Number);
Console.WriteLine("Enter Third Number");
string Thrid_Number = Console.ReadLine();
int Thrid = check(Thrid_Number);

if(First>Second && First > Thrid)
{
    Console.WriteLine($"The Greatest Number is   {First} ");
}
else if(Second > First && Second > Thrid)
{
    Console.WriteLine($"The Greatest Number is  {Second} ");
}
else if(Thrid > First && Thrid > Second )
{
    Console.WriteLine($"The Greatest Number is  {Thrid} ");
}
else
{
    Console.WriteLine("Both Number is Same");
}

if (First < Second && First < Thrid)
{
    Console.WriteLine($"The lowest Number is   {First} ");
}
else if (Second < First && Second < Thrid)
{
    Console.WriteLine($"The lowest Number is  {Second} ");
}
else if (Thrid < First && Thrid < Second)
{
    Console.WriteLine($"The lowest Number is  {Thrid} ");
}
else
{
    Console.WriteLine("Both Number is Same");
}


int check(string Input)

{
    string p = Input;
    int j;
    while (!int.TryParse(p, out j))
    {
        Console.WriteLine("please enter again");
         p = Console.ReadLine();
    }
    return  j;

}