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
            if (productList[index-1].Amount != 0)
            {
                if (productList[index - 1].Price<money)
                {
                    int rest = money-VendingMachine.productsList[index-1].Price;//Makes a variable with the new amount of money the customer has left
                    VendingMachine.balance +=productList[index-1].Price; //The money will be put in the vending machine here
                    //stock decrement
                    VendingMachine.logsList.Add(now.ToString("f") +" "+productList[index - 1].Name+" "+ productList[index - 1].Price);//Logs to the logs here
                    return "you got your "+productList[index-1].Name+", you got "+rest+" kr return";

                }
                return "Not enough money";
            }
            return "Product is empty cant be picked";
        }
    }
}
