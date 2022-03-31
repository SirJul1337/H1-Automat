using System;
using System.Collections.Generic;
using System.Text;

namespace Automat
{
    public class Customer
    {
        private VendingMachine VendingMachine { get; set; }
        private List<Product> productList { get; set; }
        private DateTime now;
        public Customer(VendingMachine vm)
        {
            VendingMachine = vm;
            now = DateTime.Now;
            productList = VendingMachine.productsList;
        }

        //Product pick, substracts price of item, from users money
        public string ProductPick(int index, int money)
        {
            if (productList[index - 1].Price<money)
            {
                int rest = money-VendingMachine.productsList[index-1].Price;
                VendingMachine.balance +=productList[index-1].Price;
                //stock decrement
                VendingMachine.logsList.Add(now.ToString("f") +" "+productList[index - 1].Name+" "+ productList[index - 1].Price);
                return "you have "+rest+" kr left";

            }
            return "Not enough money";
        }
    }
}
