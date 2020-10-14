using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Studio_RestaurantMenu
{
    class Menu
    {
        private DateTime dateUpdated = new DateTime();
        private List<MenuItem> menuItems = new List<MenuItem> { };

        public Menu ()
        {
            this.dateUpdated = DateTime.Today;
        }

        public void AddMenuItem(string name, double price, string description)
        {
            MenuItem aMenuItem = new MenuItem(name, price, description);
            if (!HasItem(aMenuItem))
            {
                menuItems.Add(aMenuItem);
                this.dateUpdated = DateTime.Today;
            }
        }

        public void AddMenuItem(MenuItem menuItem)
        {
            menuItems.Add(menuItem);
            this.dateUpdated = DateTime.Today;
        }

        public void RemoveMenuItem(string name)
        {
            foreach (MenuItem anItem in menuItems)
            {
                if (anItem.Name.Equals(name))
                {
                    menuItems.Remove(anItem);
                    break;
                }
            }
            this.dateUpdated = DateTime.Today;
        }

        private string BuildSpacesString(int numSpaces)
        {
            string dots = " ";

            for (int i=0; i<numSpaces; i++)
            {
                dots += ".";
            }
            return dots + " ";
        }

        private void DisplayItem(MenuItem menuItem)
        {
            // Display a menu item. If the item was added in last 3 months, add the NEW! indicator.

            int paddingSpaces2 = 8 - menuItem.Price.ToString().Length;

            if (DateTime.Compare(menuItem.DateAdded, DateTime.Today.AddMonths(-3)) > 0)
            {
                int paddingSpaces1 = 16 - menuItem.Name.Length;

                Console.WriteLine(menuItem.Name + " (NEW!)" + BuildSpacesString(paddingSpaces1) + menuItem.Price
                     + BuildSpacesString(paddingSpaces2) + menuItem.Description);
            }
            else
            {
                int paddingSpaces1 = 22 - menuItem.Name.Length;

                Console.WriteLine(menuItem.Name + BuildSpacesString(paddingSpaces1) + menuItem.Price + BuildSpacesString(paddingSpaces2) + menuItem.Description);
            }
        }

        public void DisplayMenu()
        {
            Console.WriteLine("\n   =============== M E N U ================\n");
            foreach (MenuItem menuItem in menuItems)
            {
                DisplayItem(menuItem);
            }
            Console.WriteLine("\n       Menu last updated " + this.dateUpdated.ToShortDateString());
        } // DisplayMenu

        public void DisplayOneMenuItem(string itemName)
        {
            MenuItem anItem = HasItem(itemName);
            if (anItem != null)
            {
                Console.WriteLine("\nMenu item " + itemName + ":");
                DisplayItem(anItem);
                Console.WriteLine("\n");
            }
        }

        public MenuItem HasItem(string itemName)
        {
            foreach (MenuItem menuItem in menuItems)
            {
                if (menuItem.Name.Equals(itemName))
                {
                    return menuItem;
                }
            }
            return null;
        }

        public bool HasItem(MenuItem menuItem)
        {
            foreach (MenuItem anItem in menuItems)
            {
                if (menuItem.Equals(anItem))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
