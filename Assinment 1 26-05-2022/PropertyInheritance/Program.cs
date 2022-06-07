
using System;
namespace InheritanceAssinment
{


    class Program
    {
        public static void Main(string[] arg)
        {

            Teacher1 t1 = new Teacher1();
            Console.Write("Enter Name of Teacher  ");
            t1.Name = Console.ReadLine();
            if (t1.Name.Length < 3)
            {
                Console.Write("Enter Name of Teacher  ");
                t1.Name = Console.ReadLine();
            }


            Console.Write("Enter Education of Teacher  ");
            t1.Education = Console.ReadLine();
            Console.Write("Enter Age of Teacher ");
            t1.Age = Console.ReadLine();
            int a;
            while (!int.TryParse(t1.Age, out a))
            {
                Console.WriteLine("Enter Coorect Age of Teacher");
                t1.Age = Console.ReadLine();
            }
            Console.Write("Enter Experience of Teacher  ");
            t1.Experience = Console.ReadLine();
            float b;
            while (!float.TryParse(t1.Experience, out b))
            {
                Console.WriteLine("Enter Experience Age of Teacher");
                t1.Experience = Console.ReadLine();
            }
            

            Console.Write("Enter Appoint of Teacher ");

            t1.App = Console.ReadLine();
            int c;
            while (!int.TryParse(t1.App, out c))
            {
                Console.WriteLine("Enter Coorect Appoint class  of Teacher");
                t1.App = Console.ReadLine();
            }
            t1.Appoint = t1.App;

            t1.Show();
            //Console.WriteLine("Teacher    " + t1.Name);
            //Console.WriteLine("Education  " + t1.Education);
            //Console.WriteLine("Age        " + t1.Age);
            //Console.WriteLine("Experience " + t1.Experience);
            //Console.WriteLine("Appoint    " + t1.Appoint + " Class ");
            //Console.WriteLine("Appoint  Teacher " + t1.Name  + " for " + t1.Appoint + " Class ");
          

        }
    }
}

public class Teacher
{

   public string Name {get;set;}
   public string Education {get;set;}
   public string Age {get;set;}
   public string Experience {get;set;}
   public string Appoint { get; set; }


    //this.Name = Name;
    //this.Education = Education;
    //this.Age = Age;
    //this.Experience = Experience;
    //this.Appoint = Appoint;




    public void Show()
    {
        Console.WriteLine("Name       " + Name);
        Console.WriteLine("Education  " + Education);
        Console.WriteLine("Age        " + Age);
        Console.WriteLine("Experience " + Experience);
        Console.WriteLine("Appoint    " + Appoint);
    }

}
class Teacher1 : Teacher
{
    public string App { get; set; }

}
