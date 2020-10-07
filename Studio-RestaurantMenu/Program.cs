using System;

namespace Studio_RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu myMenu = new Menu();
            string itemName;

            do
            {
                Console.Write("\nItem Name to add (Blank to quit): ");
                itemName = Console.ReadLine();
                if (!itemName.Trim().Equals("")) {
                    Console.Write("Item price: ");
                    string itemPrice = Console.ReadLine();
                    Console.Write("Item description: ");
                    string itemDesc = Console.ReadLine();
                    myMenu.AddMenuItem(itemName, Double.Parse(itemPrice), itemDesc);
                }
            } while (!itemName.Trim().Equals(""));

            myMenu.DisplayMenu();
        }
    }
}

// Menu class
// Field / Data Type / Access Level

  // dateLastUpdated / DateTime / private
  // items / List / private

  // Constructors:
  // 1. Empty

// MenuItem class
  // Field / Data Type / Access Level

  // name / string / private
  // price / double / private
  // description / string / private
  // dateAdded / DateTime / private

  // Constructors:
  // 1. Require name, price, and description. Automatically dateAdded