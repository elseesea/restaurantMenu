using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Studio_RestaurantMenu
{
    class MenuItem
    {
        private string name;
        private double price;
        private string description;
        private DateTime dateAdded = new DateTime();

        public MenuItem (string name, double price, string description)
        {
            this.name = name;
            this.price = price;
            this.description = description;
            this.dateAdded = DateTime.Today;
        }

        public string Name
        {
            get { return name;  }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public DateTime DateAdded
        {
            get { return dateAdded; }
            set { dateAdded = value; }
        }
    }
}
