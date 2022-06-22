using System;
namespace calculater
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("enter 1 for Integer");
            Console.WriteLine("enter 2 for Float");

            

            string number = Console.ReadLine();
            int validNumber = check(number);
            switch (validNumber)
            {
                case 1:
                    Console.WriteLine("Enter First Number");
                    string First_Number = Console.ReadLine();
                    int First = check(First_Number);
                    Console.WriteLine("Enter Second Number");
                    string Second_Number = Console.ReadLine();
                    int Second = check(Second_Number);
                    Console.WriteLine("enter 1 for +  ");
                    Console.WriteLine("enter 2 for / ");
                    string op= Console.ReadLine();
                    int opertor = check(op);
                   
                    switch (opertor)
                    {
                        case 1:
                            Console.WriteLine("sum of two number is   "+ ( First +Second));
                          break;
                        case 2:
                            Console.WriteLine("sum of two number is   " + (First / Second));
                            break;
                    }


                   
                    break;
                case 2:
                    Console.WriteLine("Enter First Number");
                    string First_NumberFloat = Console.ReadLine();
                    float FirstFloat = checkFloat(First_NumberFloat);
                    Console.WriteLine("Enter Second Number");
                    string Second_NumberFloat = Console.ReadLine();
                    float SecondFloat = checkFloat(Second_NumberFloat);
                    Console.WriteLine("enter 1 for +  ");
                    Console.WriteLine("enter 2 for / ");
                    string oper = Console.ReadLine();
                    int opertorF = check(oper);
                   
                    switch (opertorF)
                    {

                        case 1:
                            Console.WriteLine("sum of two number is   " + (FirstFloat + SecondFloat));
                            break;
                        case 2:
                            Console.WriteLine("sum of two number is   " + (FirstFloat / SecondFloat));
                            break;
                    }



                    break;
            }

            float checkFloat(string Input)

            {
                string p = Input;
                float j;
                while (!float.TryParse(p, out j))
                {
                    Console.WriteLine("please enter Corect Float Value again");
                    p = Console.ReadLine();
                }
                return j;

            }




            int check(string Input)

            {
                string p = Input;
                int j;
                while (!int.TryParse(p, out j))
                {
                    Console.WriteLine("please enter correct Integer again");
                    p = Console.ReadLine();
                }
                return j;

            }
        }
    }
}