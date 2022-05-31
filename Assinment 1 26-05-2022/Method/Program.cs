using System;
namespace Method
{
    class Program
    {


        static void userInput()
        {

            print("Enter 1 For Integer Value");
            print("Enter 2 For Float Value");
            print("Enter 3 For String Value");
            string n = Console.ReadLine();
            int uInput = checkInteger(n);
            switch (uInput)
            {
                case 1:
                    print("Enter First Value");
                    string ne = Console.ReadLine();
                    int n1 = checkInteger(ne);
                    print("Enter Second Value");
                    ne = Console.ReadLine();
                    int n2 = checkInteger(ne);
                    print("Enter 1 for sum");
                    print("Enter 2 for min");
                    print("Enter 3 for multiple");
                    print("Enter 4 for Div");
                    print("Enter 5 for find min value");
                    print("Enter 6 for find min value");
                    print("Enter 7 for table");
                    print("Enter 8 for Prime NUmber");
                    print("Enter 9 Swap  Two Number");
                    print("Enter 10 for exit");

                    ne = Console.ReadLine();
                    int des = checkInteger(ne);
                    switch (des)
                    {
                        case 1:
                            Console.WriteLine(sum(n1, n2));
                            break;
                        case 2:
                            Console.WriteLine(min(n1, n2));
                            break;
                        case 3:
                            Console.WriteLine(mul(n1, n2));
                            break;
                        case 4:
                            Console.WriteLine(Div(n1, n2));
                            break;
                        case 5:
                            Console.WriteLine(minValue(n1, n2));
                            break;
                        case 6:
                            Console.WriteLine(maxVAlue(n1, n2));
                            break;
                        case 7:
                            table(n1, n2);
                            break;
                            case 8:
                            swap(n1, n2);
                            break;
                        case 10:
                            Environment.Exit(0);
                            break;
                    }

                    //print(sum(n1, n2));
                    break;
            }
        }
        static void swap(int n1,int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = n1;
            Console.WriteLine($"after saping values a{n1} ans b{n2}");
        }
        static void table(int n1, int n2)
        {
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            if (n1 <n2)
            {
                for (int i = n1; i <= n2; i++)
                {
                    for (int j = 1; j < 11; j++)
                    {
                        Console.WriteLine($"{i} * {j} = {i * j}");
                    }
                    print("----------------------------------");
                }
            }
            else if (n1 > n2)
            {
                for (int i = n2; i >= n1; i--)
                {
                    for (int j = 1; j <= 11; j++)
                    {
                        Console.WriteLine($"{i} * {j} = {i * j}");
                    }
                    print("----------------------------------");
                }
            }
            else
            {
                Console.WriteLine("Enter Both Value Are Same");
            }
        }
        static int sum(int n1, int n2)
        {
            return n1 + n2;
        }
        static int min(int n1, int n2)
        {
            return n1 - n2;
        }
        static int mul(int n1, int n2)
        {
            return n1 * n2;
        }
        static int Div(int n1, int n2)
        {
            return n1 / n2;
        }
        static int minValue(int n1, int n2)
        {
            if (n1 < n2) return n2;
            else if (n1 > n2) return n1;
            else return -1;
        }
        static int maxVAlue(int n1, int n2)
        {
            if (n1 > n2) return n1;
            else if (n2 > n1) return n2;
            else return -1;
        }
        //static int swap(int n1, int n2)
        //{
        // int   
        //}

        static void print(string value)
        {
            Console.WriteLine(value);
        }
        //static int print(int value)
        //{
        //  return value;
        //}

        static int checkInteger(string n)
        {
            int value;
            while (!int.TryParse(n, out value))
            {
                print("Please Enter Correct Value");
                n = Console.ReadLine();
            }
            return value;
        }

        static void Main(string[] arg)
        {
            print("----------------------Welcome!!!------------------------------");
            userInput();
        }
    }
}