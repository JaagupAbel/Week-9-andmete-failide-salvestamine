using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShoppingList2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\jaagu\samples\shoppingList";
            string fileName = @"\\myshoppingList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myWishList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add more items to your shopping list? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter your shopping item:");
                    string userWish = Console.ReadLine();
                    myWishList.Add(userWish);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }
            }
            Console.Clear();

            foreach (string wish in myWishList)
            {
                Console.WriteLine($"Your shopping item:{wish}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", myWishList);

        }
    }
}
