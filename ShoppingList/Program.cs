using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string rootDirectory = @"C:\Users\...\samples";
            Console.WriteLine("Enter your shopping directory name:");
            string newDirectory = Console.ReadLine();
            Console.WriteLine("Enter your shoppinglist (.txt) file name:");
            string fileName = Console.ReadLine();

            if (Directory.Exists($"{rootDirectory}\\{newDirectory}") && File.Exists($"{rootDirectory}\\{newDirectory}\\{fileName}"))
            {
                Console.WriteLine("Directory and file exist, please try again.");
            }
            else
            {
                Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");
                Console.WriteLine("Directory and file have been created.");            
            }

        }
    }
}
