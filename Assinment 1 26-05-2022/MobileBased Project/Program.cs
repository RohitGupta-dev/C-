using System;
namespace MobileBasedProject
{
    class Program
    {
        //        Write a Program For Mobile based Product company.we can add multiple accessories entry with there details.

        //----Welcome to Our something company---
        //How much Product you want to add: 2

        //---Input Product Details---
        //your input as you want
        //-------------------------

        //Your Entered Following entry:

        //ProductID:
        //Product Name  :
        //Product Color :
        //Product Price :
        //Product Warranty  :
        //Product manufacture Date:


        //You want Exit or Enter New entry : Y /N

        //if Y than Exit And N than Start from input
        //Note: Validation also add for number and empty and date
        //Note: Validation also add for number and empty and date
        public static void Main()
        {
            int input;

            Console.Write("Enter Number To add Product  ");
            string inoo = Console.ReadLine();
            while (!int.TryParse(inoo, out input))
            {
                Console.WriteLine("Enter Correct value");
                inoo = Console.ReadLine();
            }
            //int input = convetInt(inoo);
            string[,] Data = new string[input, 6];
            for (int i = 0; i < input; i++)
            {

                Console.Write("Enter Product Id  ");
                string ProductID = Console.ReadLine();
                while (!VerifyProductID(ProductID))
                {
                    Console.Write("Enter Correct Product  Id ");
                    ProductID = Console.ReadLine();
                }
                Console.Write("Enter Name  ");

                string Name = Console.ReadLine();
                while (!Verifyname(Name))
                {
                    Name = Console.ReadLine();
                }
                //Console.WriteLine(Name);
                Console.Write("Enter Color  ");
                string Color = Console.ReadLine();
                while (!Verifyname(Color))
                {
                    Color = Console.ReadLine();
                }
                Console.Write("Enter Price  ");
                string Price = Console.ReadLine();
                double d;
                bool r = double.TryParse(Price, out d);
                while(!r == true)
                {
                    Console.WriteLine("please Enter VAlid data");
                    Price = Console.ReadLine();

                }
                while (!Verifyname(Price))
                {
                    Price = Console.ReadLine();
                }
                
                Console.Write("Enter Warranty ");

                string Warranty = Console.ReadLine();
                while (!Verifyname(Warranty))
                {
                    Warranty = Console.ReadLine();
                }
                Console.Write("Enter manufactureDate  ");

                string manufactureDate = Console.ReadLine();
                while (!Verifyname(manufactureDate))
                {
                    manufactureDate = Console.ReadLine();
                }



                Data[i, 0] = ProductID;
                Data[i, 1] = Name;
                Data[i, 2] = Color;
                Data[i, 3] = Price;
                Data[i, 4] = Warranty;
                Data[i, 5] = manufactureDate;

                Console.Write("Enter Y for Exit");
                string userInp = Console.ReadLine();
                if (userInp == "y" || userInp == "Y")
                {
                    for (int k = 0; k < i; k++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            Console.WriteLine(Data[k, j]);

                        }
                    }
                    break;
                }



              
            }
            Console.WriteLine("------------------------------Data Start-------------------------------------------------------");
            Console.WriteLine("ID  Name  color Price  Warrenty  Date    ");
            for (int k = 0; k < input; k++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(Data[k, j]+ " ");

                }
                Console.ReadLine();
            }
            Console.WriteLine("-----------------------------Data End--------------------------------------------------------");


        }

        static int convetInt(string n)
        {
            int i;
            while (!int.TryParse(n, out i))
            {
                Console.WriteLine("Enter Correct value");
             
            }
            return i;
        }
        static bool VerifyProductID(string provider)
        {
            bool isvalid = true;
            int i;
            isvalid = int.TryParse(provider, out i);

            return isvalid;
        }
        static bool Verifyname(string userName)
        {
            bool isvalid = true;
            if (string.IsNullOrEmpty(userName))
            {
                Console.WriteLine("Name can't be empty! Input your name once more");

                isvalid = false;
                return false;
            }
            if (userName.Length <= 2)
            {
                Console.WriteLine("Name is too Short");
                isvalid = false;

                return false;
            }
            return isvalid;
        }
    }
}