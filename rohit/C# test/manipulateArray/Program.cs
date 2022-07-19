using System;
namespace manipulateArray
{
    class array
    {
      public static int check(string a)
        {
            int i;
            while(!int.TryParse(a,out i))
            {
                Console.WriteLine("pls Enter valid Number");
                Console.ReadLine();
            }

            return i;
        }


        public static void Main()
        {
            int sum = 0;
            int mul = 1;
            Console.WriteLine("ENTER lenth of ARRAY");
            string input = Console.ReadLine();
            int n = check(input);
            int[] arr = new int[n];

            for(int j = 0; j < n; j++)
            {
                Console.WriteLine("ENTER ITEM of ARRAY");
                string arrayData = Console.ReadLine();
                int data = check(arrayData);
                arr[j] = data;
                sum += data;
                mul *= data;
            }
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("Array ${j} is " + arr[j]);
            }
            Console.WriteLine("sum of Array is "+ sum);
            Console.WriteLine("mul of Array is "+mul);
        }
    }


}