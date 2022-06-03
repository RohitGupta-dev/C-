namespace LearnClass_Constructor
{
    class Program
    {


        public static void Main(String[] arg)
        {
            //int i = 1;
            //string id, name, Age, Designation, BloodGroup, MobileNo;
            int n;
            Console.WriteLine("enter a number Of employ ");
            string number = Console.ReadLine();
            while (!int.TryParse(number, out n))
            {
                Console.WriteLine("enter a correct number Of employ ");
                number = Console.ReadLine();
            }
            //string[] main = new string[n];

            Rohit []r1 = new Rohit[n];
            for(int i = 0; i < n; i++)
            {
                r1[i] = new Rohit();

                Console.WriteLine("enter a  ID Of employ ");
                r1[i].id = Console.ReadLine();
               
                //string number= Console.ReadLine();
                // while (!int.TryParse(number, out id))
                // {
                //     Console.WriteLine("enter a correct number Of employ ");
                //     number = Console.ReadLine();
                // }

                Console.WriteLine("enter a  name  Of employ ");
                r1[i].name = Console.ReadLine();
                Console.WriteLine("enter a  Age  Of employ ");
                r1[i].Age = Console.ReadLine();
                
                Console.WriteLine("enter a  Designation  Of employ ");

                r1[i].Designation = Console.ReadLine();
                Console.WriteLine("enter a  BloodGroup  Of employ ");
                r1[i].BloodGroup = Console.ReadLine();
                Console.WriteLine("enter a  MobileNo  Of employ ");
                r1[i].MobileNo = Console.ReadLine();
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine();



            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("id == "+ r1[i].id +"name "+ r1[i].name + "Age = " + r1[i].Age + " Designation  " + r1[i].Designation+ " BloodGroup = " + r1[i].BloodGroup + " MobileNo== " + r1[i].MobileNo);
            }

                //while (i <= n) 


                //Console.WriteLine("enter a  ID Of employ ");
                //id = Console.ReadLine();
                //main[i] = id;
                ////string number= Console.ReadLine();
                //// while (!int.TryParse(number, out id))
                //// {
                ////     Console.WriteLine("enter a correct number Of employ ");
                ////     number = Console.ReadLine();
                //// }

                //Console.WriteLine("enter a  name  Of employ ");
                //name = Console.ReadLine();
                //main[i][1] = name;
                //Console.WriteLine("enter a  Age  Of employ ");
                //Age = Console.ReadLine();
                //main[i][2] = Age;
                //Console.WriteLine("enter a  Designation  Of employ ");

                //main[i][3] = Designation;
                //Designation = Console.ReadLine();
                //Console.WriteLine("enter a  BloodGroup  Of employ ");
                //BloodGroup = Console.ReadLine();
                //main[i][4] = BloodGroup;
                //Console.WriteLine("enter a  MobileNo  Of employ ");
                //MobileNo = Console.ReadLine();
                //main[i][5] = MobileNo;
                //Console.WriteLine("----------------------------------------------------------------------");
                //Console.WriteLine();


                //}

                //Console.WriteLine("enter a  ID Of employ ");
                //id = Console.ReadLine();

                ////string number= Console.ReadLine();
                //// while (!int.TryParse(number, out id))
                //// {
                ////     Console.WriteLine("enter a correct number Of employ ");
                ////     number = Console.ReadLine();
                //// }

                //Console.WriteLine("enter a  name  Of employ ");
                //name = Console.ReadLine();
                //Console.WriteLine("enter a  Age  Of employ ");
                //Age = Console.ReadLine();
                //Console.WriteLine("enter a  Designation  Of employ ");
                //Designation = Console.ReadLine();
                //Console.WriteLine("enter a  BloodGroup  Of employ ");
                //BloodGroup = Console.ReadLine();
                //Console.WriteLine("enter a  MobileNo  Of employ ");
                //MobileNo = Console.ReadLine();
                //Console.WriteLine("----------------------------------------------------------------------");
                //Console.WriteLine();



                //i++;


            }
            //Console.WriteLine(R1);

        }

    }
}
//Example:
//How many employee you want to add: 3
//than user can input 3 employee details like: Name, EmployeeID, Designation, BloodGroup and Mobile no. and in the last entry , display the all employee details
public class Rohit
{
    int n;
    //int [] id=new int[n];
    //string []  name = new string[n];
    //string [] Age = new string[n];
    //string [] Designation = new string[n];
    //string [] BloodGroup = new string[n];
    //string [] MobileNo = new string[n];

    public string id {get;set;}              
   public string name{get;set;}
   public string Age{get;set;}
   public string Designation{get;set;}
   public string BloodGroup{get;set;}
   public string MobileNo { get; set; }


    //public Rohit(int n)
    //{
    //    this.n = n;
    //}
    public void getData()
    {

        //  Console.WriteLine("enter a  ID Of employ ");
        //   id = Console.ReadLine();

        //  //string number= Console.ReadLine();
        //  // while (!int.TryParse(number, out id))
        //  // {
        //  //     Console.WriteLine("enter a correct number Of employ ");
        //  //     number = Console.ReadLine();
        //  // }

        //  Console.WriteLine("enter a  name  Of employ ");
        // name=Console.ReadLine();
        //  Console.WriteLine("enter a  Age  Of employ ");
        //Age = Console.ReadLine();
        //  Console.WriteLine("enter a  Designation  Of employ ");
        //Designation = Console.ReadLine();
        //  Console.WriteLine("enter a  BloodGroup  Of employ ");
        //BloodGroup = Console.ReadLine();
        //  Console.WriteLine("enter a  MobileNo  Of employ ");
        //MobileNo = Console.ReadLine();
        //  Console.WriteLine("----------------------------------------------------------------------");
        //  Console.WriteLine();



    }
    public void setData(int i)
    {

    }

}