using System;
namespace StudentForm
{
    class Pro
    {
        class Student
        {
            public Student()
            {
                ////int StudentID;
                ////int RefID =20200001;
                ////string ID= Console.ReadLine();
                ////StudentID=CheckINteger(ID);
                ////string Name = Console.ReadLine();
                ////Empty(Name);
                ////string Address =Console.ReadLine();

                ////Empty(Name);
                ////string MobileNo = Console.ReadLine();
                ////Empty(MobileNo);
                ////lengthMobile(MobileNo);
                ////string CourseName = Console.ReadLine();
                ////Empty(CourseName);
                ////lengthcourse(CourseName);

                ////string Amount = Console.ReadLine();
                ////float price=CheckFloat(Amount);

            }




            //Write a program for Fee Collecting Payment System For Student.

            //Display Output:

            //----Inputs----------------
            //input with validation with options like exit
            //----Result---------------
            //Fee submitted successfully
            //Payment Date: 02-06-2022
            //RefID: (auto generate) 20200001
            //StudentID:20201
            //Name: rahul
            //Address: 23, Phase 2
            //Mobile No: 9834783473
            //Course Name: BCA
            //Amount Payed: 15500.00


            //Thanks for Using our service

            //Note:
            //Mobile No not grater and less then 10
            //Price in between 1000.00 to 10000.00
            //No any field empty
            //RefID auto generate
            //Date show in current date of submitted
            //Course name not more than 6 alphabets
            //also given exit option for closing without this program not be closed.


        }
        public static void Main(String[] arg)
        {
            int StudentID;
            int RefID = 202000;
            Console.Write("Enter ID");
            string ID = Console.ReadLine();
            StudentID = CheckINteger(ID);
            Console.Write("Enter Name ");
            string Name = Console.ReadLine();
            Empty(Name);
            Console.Write(" Enter  Address");
            string Address = Console.ReadLine();

            Empty(Address);
            Console.Write(" Enter MobileNo ");

            string MobileNo = Console.ReadLine();
            Empty(MobileNo);
            lengthMobile(MobileNo);

            Console.Write(" Enter  CourseName");
            string CourseName = Console.ReadLine();
            Empty(CourseName);
            lengthcourse(CourseName);
            Console.Write(" Enter  Amount ");

            string Amount = Console.ReadLine();
            float price = CheckFloat(Amount);
            checkAmount(price);

            //DateTime aDate = DateTime.Now;
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("RefID  " + RefID);
            Console.WriteLine("StudentID  " + StudentID);
            Console.WriteLine("Name  " + Name);
            Console.WriteLine("Address  " + Address);
            Console.WriteLine("MobileNo  " + MobileNo);
            Console.WriteLine("CourseName  " + CourseName);
            Console.WriteLine("Amount  " + price);
            Console.WriteLine("----------------------------------------------");

            
            static void checkAmount(float n)
            {
                if (n >= 1000 && n <= 10000)
                {

                }
                else
                {
                    Console.Write(" Enter  correct Amount ");
                    string p = Console.ReadLine();
                    float price = CheckFloat(p);

                    checkAmount(price);
                }
            }

            static void lengthMobile(string n)
            {
                if (n.Length == 10)
                {

                }
                else
                {
                    Console.WriteLine("Enter correct Mobile nUmber Must Contain 10 Digit");
                    n = Console.ReadLine();
                    lengthMobile(n);
                }
            }
            static void lengthcourse(string n)
            {
                if (n.Length <= 6)
                {

                }
                else
                {
                    Console.WriteLine("Enter correct course ");
                    n = Console.ReadLine();
                    lengthcourse(n);
                }
            }
            static int CheckINteger(string n)
            {

                int i;
                while (!int.TryParse(n, out i))
                {
                    Console.WriteLine("enter valid value");
                    n = Console.ReadLine();
                }
                return i;

            }
            static float CheckFloat(string n)
            {
                float i;
                while (!float.TryParse(n, out i))
                {
                    Console.WriteLine("enter valid value");
                    n = Console.ReadLine();
                }
                return i;
            }
            static void Empty(string userName)
            {
                if (string.IsNullOrEmpty(userName))
                {
                    Console.WriteLine("Name can't be empty! Input your name once more");
                    userName = Console.ReadLine();
                }
            }


        }


    }
}