
using System;
namespace InheritanceAssinment
{


    class Program
    {
        public static void Main(string[] arg)
        {
            Console.WriteLine("Enter y FOR continue......");

            string UserInput = Console.ReadLine();
            Teacher1 t1 = new Teacher1();
            while (UserInput == "Y"|| UserInput == "y")
            {
                t1.GetData();
                Console.WriteLine("Enter y FOR continue......");

                UserInput = Console.ReadLine();
                
            }
        }
    }
}
public class Teacher
{
    string Name;
    string Education;
    string Age;
    string Experience;
    string Appoint;

    public void GetData()
    {
        Console.WriteLine("Enter Name of Teacher");
        Name = Console.ReadLine();



        Console.WriteLine("Enter Education of Teacher");
        Education = Console.ReadLine();
        Console.WriteLine("Enter Age of Teacher");
        Age = Console.ReadLine();
        int a;
        while(!int.TryParse(Age,out a))
        {
            Console.WriteLine("Enter Coorect Age of Teacher");
            Age = Console.ReadLine();
        }
        Console.WriteLine("Enter Experience of Teacher");
        Experience = Console.ReadLine();
        float b;
        while (!float.TryParse(Experience, out b))
        {
            Console.WriteLine("Enter Experience Age of Teacher");
            Experience = Console.ReadLine();
        }

        Console.WriteLine("Enter Appoint of Teacher");

        Appoint = Console.ReadLine();
        int c;
        while (!int.TryParse(Appoint, out c))
        {
            Console.WriteLine("Enter Coorect Appoint class  of Teacher");
            Appoint = Console.ReadLine();
        }
        this.Name = Name;
        this.Education = Education;
        this.Age = Age;
        this.Experience = Experience;
        this.Appoint = Appoint;

        Console.WriteLine("Teacher    " + Name);
        Console.WriteLine("Education  " + Education);
        Console.WriteLine("Age        " + Age);
        Console.WriteLine("Experience " + Experience );
        Console.WriteLine("Appoint    " + Appoint + " Class ");

    }
    //public void Show()
    //{
    //    Console.WriteLine("Name of Teacher" + Name);
    //    Console.WriteLine(" Education" + Education);
    //    Console.WriteLine("Age  " + Age);
    //    Console.WriteLine("Experience " + Experience);
    //    Console.WriteLine("Appoint " + Appoint);
    //}

}
class Teacher1 : Teacher
{

}
