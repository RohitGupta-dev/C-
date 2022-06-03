using System;
namespace ValidDataTypeCheckMethod
{
    class Program
    {
        class Rohit
        {
            static void CheckINteger(string n)
            {
                bool a;
                int i;
                a = int.TryParse(n, out i);
                if (a)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(n);
                }
            }
            static void CheckFloat(string n)
            {
                bool a;
                float i;
                a = float.TryParse(n, out i);
                if (a)
                {
                    Console.WriteLine(i);
                    Console.WriteLine(i.GetType);

                }
                else
                {
                    Console.WriteLine(a);
                }
            }



            static void CheckString(string n)
            {
               
            }
        public static void Main(string[] arg)
        {
        string data=Console.ReadLine();
            //CheckINteger(data);
            
            CheckFloat(data);

        }


        }
    }
}