using System;
using System.Collections.Generic;
using System.Text;

namespace Automat
{
    public class VendingMachine
    {
        private Administrator admin { get; set; }
        private Customer customer { get; set; }
        private Product product { get; set; }
        public List<Product> productsList = new List<Product>();
        public VendingMachine()
        {
            admin = new Administrator();
            customer = new Customer(this);

            Product cocaCola = new Product("Coca-Cola", 20,7);
            Product pepsiMax = new Product("Pepsi Max", 18, 10);
            Product snickers = new Product("Snickers", 6, 15);
            Product twix = new Product("Twix", 5, 3);

            productsList.Add(cocaCola);
            productsList.Add(pepsiMax);
            productsList.Add(snickers);
            productsList.Add(twix);
        }
        public void DisplayProducts()
        {

        }
        
    }
}
