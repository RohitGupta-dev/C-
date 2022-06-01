using System;
namespace Method
{
    class Program
    {


        static string userInput()
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
                        //case 10:
                            //Environment.Exit(0);

                            
                    }

                    //print(sum(n1, n2));
                    break;

                //for Float values created case
                case 2:
                    print("Enter First Value");
                    string ne2 = Console.ReadLine();
                    float nn1 = checkfloat(ne2);
                    print("Enter Second Value");
                    ne = Console.ReadLine();
                    float nn2 = checkfloat(ne);
                    print("Enter 1 for sum");
                    print("Enter 2 for min");
                    print("Enter 3 for multiple");
                    print("Enter 4 for Div");
                    print("Enter 5 for find min value");
                    print("Enter 6 for find min value");
                    print("Enter 7 for table");
                    print("Enter 8 for Prime NUmber");
                    print("Enter 9 Swap  Two Number");
                    

                    ne = Console.ReadLine();
                    int desc = checkInteger(ne);
                    switch (desc)
                    {
                        case 1:
                            Console.WriteLine(sum(nn1, nn2));
                            break;
                        case 2:
                            Console.WriteLine(min(nn1, nn2));
                            break;
                        case 3:
                            Console.WriteLine(mul(nn1, nn2));
                            break;
                        case 4:
                            Console.WriteLine(Div(nn1, nn2));
                            break;
                        case 5:
                            Console.WriteLine(minValue(nn1, nn2));
                            break;
                        case 6:
                            Console.WriteLine(maxVAlue(nn1, nn2));
                            break;
                        case 7:
                            table(nn1, nn2);
                            break;
                        case 8:
                            swap(nn1, nn2);
                            break;
                         


                    }

                    break;

                // for string values created case
                case 3:

                    break;


            }
            print("Y for Exit");
            string dataValue = Console.ReadLine();
            return dataValue;
        }
        static void swap(int n1,int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = n1;
            Console.WriteLine($"after saping values a{n1} ans b{n2}");
        }
        static void swap(float n1, float n2)
        {
            float temp = n1;
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
        static void table(float n1, float n2)
        {
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            if (n1 < n2)
            {
                for (float i = n1; i <= n2; i++)
                {
                    for (float j = 1; j < 11; j++)
                    {
                        Console.WriteLine($"{i} * {j} = {i * j}");
                    }
                    print("----------------------------------");
                }
            }
            else if (n1 > n2)
            {
                for (float i = n2; i >= n1; i--)
                {
                    for (float j = 1; j <= 11; j++)
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

        static float sum(float n1, float n2)
        {
            return n1 + n2;
        }
        static float min(float n1, float n2)
        {
            return n1 - n2;
        }
        static float mul(float n1, float n2)
        {
            return n1 * n2;
        }
        static float Div(float n1, float n2)
        {
            return n1 / n2;
        }
        static float minValue(float n1, float n2)
        {
            if (n1 < n2) return n2;
            else if (n1 > n2) return n1;
            else return -1;
        }
        static float maxVAlue(float n1, float n2)
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
        static float checkfloat(string n)
        {
            float value;
            while (!float.TryParse(n, out value))
            {
                print("Please Enter Correct Value");
                n = Console.ReadLine();
            }
            return value;
        }

        static void Main(string[] arg)
        {
            print("----------------------Welcome!!!------------------------------");
            string Input = "Y";
            while (Input == "Y"|| Input == "y") { 
        string    I = userInput();
                if (I == "Y" || I == "y")
                {
                    break;
                }
                //Console.WriteLine(Input);
            }
        }
    } 
}