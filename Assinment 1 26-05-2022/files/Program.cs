using System;
using System.IO;  // include the System.IO namespace

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "C:/Users/Local User/Desktop/C#/Assinment 1 26-05-2022/files/text.txt";
            string DestfileName = "C:/Users/Local User/Desktop/C#/Assinment 1 26-05-2022/files/text1.txt";
            //string writeText = "Hello Rohit!  \n Helloooooo";  
            //File.WriteAllText(fileName, writeText);//writteen text in file
            //File.AppendAllText(fileName,"Rohit ");//Apppend data at last
            //File.Copy(fileName, DestfileName);//copy file
            File.Delete(DestfileName);//Delete file
            Console.WriteLine(File.Exists(fileName) ? "File exists." : "File does not exist.");
            string readText = File.ReadAllText(fileName);//Read File
            Console.WriteLine(readText); // data comes on consoel
        }
    }
}
