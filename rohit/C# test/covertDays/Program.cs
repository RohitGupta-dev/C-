using System;
namespace convertNumberIntoDays
{
    class convert
    {
        public static void Main()
        {
            int num = 0;
            int years = 0;
            int month = 0;
            int weeks = 0;
            int days = 0;


            Console.Write("Enter number of days: ");
            num = Convert.ToInt32(Console.ReadLine());

            years = num / 365;
            month = num / 30;
            weeks = (num % 365) / 7;
            days = (num % 365) % 7;

            Console.WriteLine("Years : " + years);
            Console.WriteLine("month: " + month);
            Console.WriteLine("Weeks : " + weeks);
            Console.WriteLine("Days  : " + days);
        }
    }
}