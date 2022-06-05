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
                
                 
            string fileLocation = @"C:\Users\...\Samples\shoppingList";
            string fileName = @"\\myShoppingList.txt";
            
            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myShoppingList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to write a shopping list? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter your wish:");
                    string userWish = Console.ReadLine();
                    myShoppingList.Add(userWish);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Ok, lets do it on another time! Take care!");
                }

            }

            foreach (string wish in myShoppingList)
            {
                Console.WriteLine($"You would like to buy: {wish}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", myShoppingList);


        }
    }
}
