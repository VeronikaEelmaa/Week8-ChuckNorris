using System;
using System.IO;

namespace ShoppingFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\...\Samples";
            Console.WriteLine("Lets create you a shopping list and lets call it 'shoppingList'. Please enter folder name:");
            string newDirectory = Console.ReadLine();
            Console.WriteLine("Call your list 'myShoppingList.txt'. Enter file name:");
            string fileName = Console.ReadLine();

            Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
            File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");
        }
    }
}
