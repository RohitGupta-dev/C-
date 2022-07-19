using System;
using System.Collections;
namespace RegularExpression
{
    class BankAccount
    {
        ArrayList AccNumbers = new ArrayList();
        ArrayList Depositor = new ArrayList();
        ArrayList AccountType = new ArrayList();
        ArrayList Ammount = new ArrayList();
        int userAccountNumber;
        string userDepositor;
        string userAccountType;
        double userAmmount;


        public void IntializedMenbers(int acc, string des, string Acctype,double ammount)
        {
            this.userAccountNumber = acc;
            this.userDepositor = des;
            this.userAccountType = Acctype;
            this.userAmmount = ammount;
           

        }

        public  void save()
        {
            AccNumbers.Add(userAccountNumber);
            AccountType.Add(userDepositor);
            Depositor.Add(userAccountType);
            Ammount.Add(userAmmount);
        }
        public void DepostAmount(double Amm)
        {
          
            this.userAmmount+= Amm;
            

        }

        public void withrawAmmount(double WAmm)
        {
            userAmmount-= WAmm;
        }
        public void showDetails()
        {

            foreach(var i in AccNumbers)
            {
            Console.Write(" Account Numbers ");
                Console.WriteLine(i);
            }

            foreach (var i in Depositor)
            {
            Console.Write("Depositor ");
                Console.WriteLine(i);
            }

            foreach (var i in AccountType)
            {
            Console.Write("AccountType ");
                Console.WriteLine(i);
            }

            foreach (var i in Ammount)
            {
            Console.Write("Ammount ");
                Console.WriteLine(i);
            }
        }

    }

    class program
    {
      

        public static int check(string v)
        {
            int i;
            while (!int.TryParse(v, out i))
            {
                Console.WriteLine("Enter correct integer ");
                Console.ReadLine();

            }
            return i;
        }

        public static double checkDouble(string j)
        {
            double k;
            while (!double.TryParse(j, out k))
            {
                Console.WriteLine("Enter correct Double value ");
                Console.ReadLine();

            }
            return k;
        }

        public static void print(string data)
        {
            Console.WriteLine(data);
        }
        public static void Main()
        {
           
            BankAccount bank = new BankAccount();

            print("enter y for add users");
            string user = Console.ReadLine();
            while (user =="Y"|| user == "y")
            {

            print("enter Account Number ");
            string acc = Console.ReadLine();
                int accNo = check(acc);
            print("enter Account Type ");
            string AccType = Console.ReadLine();
             
            print("enter Depositor name ");
            string Dep= Console.ReadLine();
               
     
            print("enter Ammount Number ");
            string amm = Console.ReadLine();
            double ammount = checkDouble(amm);
              
                bank.IntializedMenbers(accNo,AccType,Dep,ammount);
               // bank.showDetails();
                print("enter 1 for deposite");
                print("enter 2 for widhraw");
                print("enter 3 for show");
                string choose = Console.ReadLine();
                int ch = check(choose);
                switch (ch)
                {
                    case 1:

                        string choose1 = Console.ReadLine();
                        double ch1 = checkDouble(choose1);
                        bank.DepostAmount(ch1);
                        bank.save();
                        bank.showDetails();

                        break;
                    case 2:

                        string choose2 = Console.ReadLine();
                        double ch2 = checkDouble(choose2);
                        bank.withrawAmmount(ch2);
                        bank.save();
                        bank.showDetails();

                        break;
                    case 3:
                        bank.save();
                        bank.showDetails();
                        break;
                    default:

                        print("enter wrong value");
                        break;
                }
            }

        }
    }
}