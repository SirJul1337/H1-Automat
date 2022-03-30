using System;
using System.Collections.Generic;
using System.Text;

namespace Automat
{
    public class Customer
    {
        private VendingMachine VendingMachine { get; set; }
        public Customer(VendingMachine vm)
        {
            VendingMachine = vm;
        }
        public string DisplayProducts()
        {
            VendingMachine.DisplayProducts();
            string products = "";
            foreach (Product product in VendingMachine.productsList)
            {
                products += product.Name + ""+ product.Price;
            }
            return products;
        }
        public void ProductPick(int balance)
        {
         
        }
    }
}
