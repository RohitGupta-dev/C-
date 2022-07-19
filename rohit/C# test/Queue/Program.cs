using System;
using System.Collections;
namespace Queue
{
    class queue
    {
        public static int check(string a)
        {
            int i;
            while (!int.TryParse(a, out i))
            {
                Console.WriteLine("Enter Correct number");
                Console.ReadLine();
            }
            return i;
        }


       
        public static void Main()
        {
            {
                Queue<int> arr = new Queue<int>();

                string num = Console.ReadLine();
                int number = check(num);

                for (int j = 0; j < number; j++)
                {
                    string num1 = Console.ReadLine();
                    int number1 = check(num1);
                    arr.Enqueue(number1);
                }


                    if(arr.Count > 0)
                    {
                    arr.Dequeue();

                    }
 
                    foreach (var i in arr)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }

