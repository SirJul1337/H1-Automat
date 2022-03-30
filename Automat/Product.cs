using System;
using System.Collections.Generic;
using System.Text;

namespace Automat
{
    public class Product
    {
        private string name;
        private int price;
        private int amount;
        public Product()
        {

        }
        public Product(string name,int price,int amount)
        {
            Name = name;
            Price = price;
            Amount = amount;

        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }


    }


}
