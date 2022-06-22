namespace elderBrother
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter Age of Elder Brother");
            string First_Number = Console.ReadLine();
            int First = check(First_Number);
            Console.WriteLine("Enter Age of Younger Brother");
            string Second_Number = Console.ReadLine();
            int Second = check(Second_Number);
            while (First < Second)
            {
                Console.WriteLine("please enter Correct Age of Younger Brother");

                Second_Number = Console.ReadLine();
                Second = check(Second_Number);
            }
            while (Second >= 0)
            {
                Console.WriteLine(Second);
                Second--;
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
                return j;

            }



        }
    }
}