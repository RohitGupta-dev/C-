using System;
namespace Using_interface
{
    enum days
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }
    interface showData
    {
        void showAllData();
    }
    class basic_Details:showData{
        string firstName{ get; set; } 
        string lastName{ get; set; }
        int phoneNumber{ get; set; }
        string email{ get; set; }
        string Gender{ get; set; }
        string city{ get; set; }

       public  basic_Details()
        {
            print("Enter First Name");
           firstName= Console.ReadLine();
            
            print("Enter Last Name");
            lastName = Console.ReadLine();

            print("Enter phoneNumber");
            try
            {

            phoneNumber = Convert.ToInt32(Console.ReadLine());
            }catch(Exception E)
            {
                print(E.Message);


            }

            print("Enter Email");
            email = Console.ReadLine();

            print("Enter Gender");
            Gender = Console.ReadLine();

            print("Enter city");
            city = Console.ReadLine();

        }
        public static void print(string obj)
        {
            Console.WriteLine(obj);
        }
        public static void print(int obj)
        {
            Console.WriteLine(obj);
        }
        public void showAllData()
        {

            print("\n\t======================`==== basic Details  =======================");

            print(firstName);
            print(lastName);
            print(phoneNumber);
            print(email);
            print(Gender);
            print(city);
            print("\n==================================================================== ");
        }

    }
    class Employe : basic_Details { 
    
        string EID { get; set; }
        string Possition { get; set; }

        double salary { get; set; }

     public Employe()
        {
            print("Enter Employee Id");
            EID = Console.ReadLine();

            print("Enter Designation  ");
            Possition = Console.ReadLine();


            print("Enter salary  ");
            try
            {

            salary =Convert.ToDouble(Console.ReadLine());
            }catch(Exception E)
            {
                print(E.Message);
            }
        }

        public void EmployeData()
        {
            print("\b\nEmployes Details");
            print(EID);
            print(Possition);
        }


    }
    class Address : Employe
    {
        string Add{ get; set; }
       public Address()
        {
            print("Enter Address  ");
            Add = Console.ReadLine();
            print("\n\t====================== Address Details ===========================");
            print(Add);
        }
    }
    class Pogram   {
     
        public static  void Main()
        {
            Address e = new Address();
            e.showAllData();
            e.EmployeData();
        }
    }

}