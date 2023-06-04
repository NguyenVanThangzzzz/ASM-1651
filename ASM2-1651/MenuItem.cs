﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2_1651
{
    internal class MenuItem
    {
        private string name;
        private decimal price;

        public MenuItem(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name
        {

            get { return name; }
            set { name = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public void DisplayInfoItem()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("-------------------");
        }
    }
}
