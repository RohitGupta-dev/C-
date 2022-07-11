class ab
{
    int cout = 0;
    int[] tra = new int[10];
    long cN;
    int cp;
    string crnum, cpin;
    int Ammount = 20000;
  public  void getuserINPUT()
    {
        Console.WriteLine("enter credit card number");
        crnum = Console.ReadLine();
        this.cN=checkCreditcardNumber(crnum);
        Console.WriteLine("enter credit card pin");
        cpin = Console.ReadLine();
        this.cp = checkCreditcardpin(cpin);


        if (this.cp == 1234)
        {
            atmService();
        }
        else
        {
            Console.WriteLine("enter again pin");
            cpin = Console.ReadLine();
            this.cp = checkCreditcardpin(cpin);
            if (this.cp == 1234)
            {
                atmService();
            }
            else
            {
                Console.WriteLine("Soorry try after some time");

            }
        }

    }
    long checkCreditcardNumber(string s)
    {
        long c;
        while(!long.TryParse(s,out c))
        {
            Console.WriteLine("enter card Number  Correct number");

            crnum = Console.ReadLine();
           
        }
        while (s.Length >= 15 && s.Length < 15)
        {
            Console.WriteLine("enter Correct card Number lenth NUmber");
            crnum = Console.ReadLine();
                  }

        return c;

    }
    int checkCreditcardpin(string s)
    {
        int c;
        while (!int.TryParse(s, out c))
        {
            Console.WriteLine("enter pin Correct number");

            cpin= Console.ReadLine();
          
        }
        while (s.Length == 3)
        {
            Console.WriteLine("enter Correct pin lenth NUmber");
            cpin = Console.ReadLine();
         
        }
        return c;

    }
    int checkintegere(string s)
    {
        int c;
        while (!int.TryParse(s, out c))
        {
            Console.WriteLine("enter Correct integer number");

            s= Console.ReadLine();
          
        }
        return c;
    }
        void atmService()
    {
       

        Console.WriteLine("===============   Atm Service   =====================");
        Console.WriteLine($"credit card number {this.cN}");    
        Console.WriteLine($"credit card number {this.cp}");

        Console.WriteLine("Press 1 Cash availability");
        Console.WriteLine("Press 2 Previous five transactions");
        Console.WriteLine("Press 3 Cash withdrawal");
        Console.WriteLine("Press 4 Fast Withdrawal");
        Console.WriteLine("Press 5 Cancel");

        string s= Console.ReadLine();
        int r=checkintegere(s);
        switch (r)
        {
            //cash avalibility
            case 1:
                Console.WriteLine($"Your Current Ammount is {this.Ammount}");
                atmService();
          break;
            case 2:

                for (int i = 0; i < tra.Length; i++)
                {
                    if (tra[i] != 0)
                    {
                        Console.WriteLine($"Your previous Transction    {tra[i]} ");
                    }
                }

                atmService();
                break;
            case 3:
                Console.WriteLine($"!!!!!!!!!!!!!!!!!!!!!!!!!!! cash WithDrawal  !!!!!!!!!!!!!!!!!!!!! ");
                Console.WriteLine($"Your Ammount cash WithDrawal  ");
                string amm = Console.ReadLine();
                int balance = checkintegere(amm);
                
                int trans = tra.Length;
                //Console.WriteLine(trans);
                tra[cout] = balance;
                cout++;
                Ammount = Ammount - balance;
                if(balance > Ammount)
                {
                    Console.WriteLine("inseficent balance");
                }
                    atmService();
                break;
            case 4:
                Console.WriteLine($"Your FastWithDrawal  ");
                Console.WriteLine($"press 1 Your FastWithDrawal 500  ");
                Console.WriteLine($"press 2 Your FastWithDrawal 1000 ");
                Console.WriteLine($"press 3 Your FastWithDrawal  2000");
                string op = Console.ReadLine();
                int b = checkintegere(op);
                switch (b)
                {
                    case 1:
                        Console.WriteLine($"Your FastWithDrawal  {500} ");
                        Ammount = Ammount - 500;
                        tra[cout] = 500;
                        cout++;
                        break;
                    case 2:
                        Console.WriteLine($"Your FastWithDrawal  {1000} ");
                        this.Ammount = Ammount - 1000;
                        tra[cout] = 1000;
                        cout++;
                        break;
                    case 3:
                        Console.WriteLine($"Your FastWithDrawal  {2000} ");
                        this.Ammount = Ammount - 2000;
                        tra[cout] = 2000;
                        cout++;

                        break;
                }


                atmService();
                break;
            case 5:
                Console.WriteLine($"!!!!!!!!!!!!!!!!!!!! BYE !!!!!!!!!!!!!!!!!!!");
               
                break;


        }


    }

}
class program
{
    public static void Main()
    {
        ab a = new ab();
        a.getuserINPUT();
    }
}