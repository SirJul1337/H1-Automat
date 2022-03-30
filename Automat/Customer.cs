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
            int i = 0;
            string products = "";
            foreach (Product product in VendingMachine.productsList)
            {
                i++;
                products += "\n"+i+". "+product.Name + " "+ product.Price +" kr";
            }
            return products;
        }
        public string ProductPick(int index, int money)
        {
            if (VendingMachine.productsList[index - 1].Price<money)
            {
                int rest = money-VendingMachine.productsList[index-1].Price;
                //stock decrement
                VendingMachine.logsList.Add("time"+VendingMachine.productsList[index - 1].Name+ VendingMachine.productsList[index - 1].Price);
                return "you have "+rest+" kr left";

            }
            return "Not enough money";
        }
    }
}
