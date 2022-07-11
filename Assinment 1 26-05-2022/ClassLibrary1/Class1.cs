namespace ClassLibrary1
{
    public class ClassRohit
    {
        public ClassRohit()
        {
            Console.WriteLine("Constructor Calleed");
        }
   public string name { get; set; }
        public static void print()
        {
            Console.WriteLine("==========================printing ======================== ");
        }
        public static void Display()
        {
                  Console.WriteLine("Rohit here");
        }
        public static void  DisplayTime()
        {
            Console.WriteLine(DateTime.Now.ToString());
        }


    }
    public class sunny
    {
        public static void calling_Rohit()
        {
            Console.WriteLine("==========================printing ======================== ");
        }
        public static void Display_Rohit()
        {
            Console.WriteLine("Rohit here");
        }
        public static void DisplayTime_Rohit()
        {
            Console.WriteLine(DateTime.Now.ToString());
        }
    }
    public class money
    {
        public static void print()
        {
            Console.WriteLine("==========================printing ======================== ");
        }
        public static void Display()
        {
            Console.WriteLine("Rohit here");
        }
        public static void DisplayTime()
        {
            Console.WriteLine(DateTime.Now.ToString());
        }
    }
}