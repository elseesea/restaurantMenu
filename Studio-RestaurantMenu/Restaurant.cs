using System;
using System.Collections.Generic;
using System.Text;

namespace Studio_RestaurantMenu
{
    class Restaurant
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            // Create several items and add them to a menu.

            MenuItem[] menuItems = {
                new MenuItem("Burger", 5.99, "Best burger ever"),
                new MenuItem("Cheese Burger", 6.99, "Best cheeseburger ever"),
                new MenuItem("Cheese Pizza", 9.99, "Eight heavenly slices"),
                new MenuItem("Burrito", 5.99, "Beans & meat all wrapped up"),
                new MenuItem("Turkey Sub", 5.99, "Sliced turkey sandwich")
            };

            foreach (MenuItem mItem in menuItems)
            {
                menu.AddMenuItem(mItem);
            }

            // Print the entire, updated menu to the screen.
            menu.DisplayMenu();

            // Print an individual menu item to the screen.
            menu.DisplayOneMenuItem("Burrito");

            // Delete an item from a menu, then reprint the menu.
            menu.RemoveMenuItem("Burger");
            menu.DisplayMenu();

            // Interactive mode, just for fun
            Menu myMenu = new Menu();
            string itemName;
            Console.WriteLine("\n\nCreate your custom menu");
            Console.WriteLine("=======================");

            do
            {
                Console.Write("\nItem Name to add (Blank to quit): ");
                itemName = Console.ReadLine();
                if (!itemName.Trim().Equals(""))
                {
                    MenuItem anItem = myMenu.HasItem(itemName);
                    if (anItem == null)
                    {
                        Console.Write("Item price: ");
                        string itemPrice = Console.ReadLine();
                        Console.Write("Item description: ");
                        string itemDesc = Console.ReadLine();
                        myMenu.AddMenuItem(itemName, Double.Parse(itemPrice), itemDesc);
                    }
                    else
                    {
                        Console.WriteLine("Item " + itemName + " already exists.");
                    }
                }
            } while (!itemName.Trim().Equals(""));

            myMenu.DisplayMenu();
        }
    }
}
