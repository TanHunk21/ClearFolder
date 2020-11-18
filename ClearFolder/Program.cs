using System;
using System.IO;

namespace ClearFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DeleteAllFiles();

            string rootPath = @"C:\Users\opilane\samples";
            DirectoryInfo rootDirectory = new DirectoryInfo(rootPath);
            foreach(DirectoryInfo dir in rootDirectory.GetDirectories())
            {
                DeleteAllfolders(dir.FullName, true);

            }
        }
        //
        public static void DeleteAllFiles()
    {
        string rootpath = @"C:\Users\opilane\samples";
        DirectoryInfo directory = new DirectoryInfo(rootpath);


        foreach(FileInfo file in directory.GetFiles())
        {
            file.Delete();

        }
         //a functions to delete all the folders  
    }    public static void DeleteAllfolders(string DirectoryName, bool ifExists)
        {
            if (Directory.Exists(DirectoryName))
            {
                Directory.Delete(DirectoryName, true);
            } else if (ifExists)
            {
                throw new SystemException("No such directory to delete");

            }
        }
    }     
}
