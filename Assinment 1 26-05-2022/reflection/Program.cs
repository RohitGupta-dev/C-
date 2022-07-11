using System;
using System.Reflection;

namespace reflection
{
    class program
    {

        public static object Singlemethod { get; private set; }
        public static void reflection()
        {
            Assembly Asm = Assembly.LoadFile(@"C:\Users\Local User\Desktop\C#\Assinment 1 26-05-2022\ClassLibrary1\bin\Debug\net6.0\ClassLibrary1.dll");
            Type[] types = Asm.GetTypes();
            foreach(var items in types)
            {
                //Console.WriteLine(items.Name);
                MethodInfo[] mis = items.GetMethods();
                foreach(var method in mis)
                {

                    Console.WriteLine(method.GetType);
                  //if (method != null)
                  //{
                  //    ParameterInfo[] prm = method.GetParameters();
                  //    foreach(var p in prm)
                  //    {
                  //        Console.WriteLine(p);
                  //    }

                  //    object objs = Activator.CreateInstance(items, null);
                  //    Console.WriteLine(objs);

                  //    if (prm.Length == 0)
                  //    {
                  //        method.Invoke(objs, null);
                  //    }
                  //}

                }
            }
            
        }
        public static void Main()
        {
            try
            {
                reflection();
            }
            catch(Exception e)
            {
                Console.WriteLine("\n \t system Error");
                Console.WriteLine(e.Message);
            }
            
        }
    }
}