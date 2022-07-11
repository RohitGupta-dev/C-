using System;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        var lib = new List<string>();
      
        //print("Enter 1 for Add Book");
        liabaryService();
void liabaryService()
        {
            print("Enter 1 for Add Book");
            print("Enter 2 for Remove Book");
            print("Enter 3 for Show Book");
            print("Enter 4 for Cancel");
            int j = Convert.ToInt32(Console.ReadLine());
            switch (j)
            {
                case 1:
                    //Console.WriteLine("=====Add Book ===================");                    //Console.WriteLine("=====Add Book ===================");
                    try
                    {
                        Console.WriteLine("============================= Enter Book name ============================");
                        string r = Console.ReadLine();
                        lib.Add(r);

                        Console.WriteLine("=====================================");

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception: {0}", ex.Message);

                    }
                    //add();

                    liabaryService();
                    break;
                case 2:
                    Console.WriteLine("===== Remove Book Course===================");
                    try
                    {
                        Console.WriteLine("number of book ");
                        int r = Convert.ToInt32(Console.ReadLine());
                        lib.RemoveAt(r);

                        Console.WriteLine("=====================================");

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception: {0}", ex.Message);

                    }
                    //remove();
                    liabaryService();
                    break;

                case 3:

                    Console.WriteLine("===== Show All Books ===================");

                    foreach (var item in lib)
                    {

                        Console.WriteLine(item);
                    }
                    Console.WriteLine("==========================================");
                    liabaryService();
                    break;
                case 4:

                    Console.WriteLine("======== Thanks You ================");
                    break;

            }
        }
        void print(string data)
        {
            Console.WriteLine(data);
        }



        void add()
        {
            try
            {
                Console.WriteLine("============================= Enter Book name ============================");
                string r = Console.ReadLine();
                lib.Add(r);

                Console.WriteLine("=====================================");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);

            }
        }

        void remove()
        {
            try
            {
                Console.WriteLine("============================= Enter Serice Book name ============================");
                int r = Convert.ToInt32(Console.ReadLine());
                lib.RemoveAt(r);

                Console.WriteLine("=====================================");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);

            }
        }
    }
}