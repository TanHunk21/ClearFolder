using System;
using System.IO;

namespace CreateFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //CreateNewFile();
            Console.WriteLine("enter the file name");
            string userInput = Console.ReadLine();
            //CreateUserFile(userInput);
            CreateFileWithEntension(userInput);



        }

        public static void CreateNewFile()
        {
            string rootPath = @"C:\Users\opilane\samples\PlayerOne";
            string filename = "Balls.txt";
            File.Create(Path.Combine(rootPath, filename));
        }


        public static void CreateUserFile(string filename)
        {
            string rootPath = @"C:\Users\opilane\samples\PlayerTwo";
            File.Create(Path.Combine(rootPath, filename));
        }
        public static void CreateFileWithEntension(string filename)
        {
            string rootPath = @"C:\Users\opilane\samples\playerTwo";
            string fullfilename = $"{filename}.txt";
            File.Create(Path.Combine(rootPath, fullfilename));
        }
    }
}
