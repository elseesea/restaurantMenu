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
            menuItems.Add(aMenuItem);
            this.dateUpdated = DateTime.Today;
        }

        public void DisplayMenu()
        {
            Console.WriteLine("============= M E N U ================");
            foreach (MenuItem menuItem in menuItems)
            {
                if (DateTime.Compare(menuItem.DateAdded, DateTime.Today.AddMonths(-3)) > 0)
                {
                    Console.WriteLine(menuItem.Name + " (NEW!) ... " + menuItem.Price + " ... " + menuItem.Description);
                }
                else
                {
                    Console.WriteLine(menuItem.Name + " ... " + menuItem.Price + " ... " + menuItem.Description);
                }
            }
            Console.WriteLine("\nMenu last updated " + this.dateUpdated.ToShortDateString());
        }
    }
}
