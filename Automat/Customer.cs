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
            string products = "";
            foreach (Product product in VendingMachine.productsList)
            {
                products += "\n"+product.Name + " "+ product.Price +" kr";
            }
            return products;
        }
        public void ProductPick(int balance)
        {
         
        }
    }
}
