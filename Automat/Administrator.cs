using System;
using System.Collections.Generic;
using System.Text;

namespace Automat
{
    public class Administrator
    {
        private VendingMachine VendingMachine { get; set; } 
        private List<Product> productList { get; set; }
        private int adminBalance;
        public Administrator(VendingMachine vm)
        {
            VendingMachine = vm;
            productList = VendingMachine.productsList;
        }

        public string FillStock(int amount, int index)
        {
            productList[index-1].Amount = amount; 
            return ("\nThe total amount on " + productList[index-1].Name + " is now " + amount);
        }

        public string ChangePrice(int index, int price)
        {
            productList[index - 1].Price = price;
            return (productList[index-1].Name + " got a new price: " + price);
            
        }
        public bool AdminPassword(string guess)
        {
            if (guess == "Admin12345")
            {
                return true;
            }
            return false;
        }
        public string SeeBalance()
        {

            return "There is a total of: "+VendingMachine.balance+" kr in the vending mahchine" ;
        }
        public string WithdrawBalance()
        {
            adminBalance = VendingMachine.balance;
            VendingMachine.balance = 0;
            return "Vending machine is now empty, you withdrawed "+adminBalance+" kr";
        }
        public string Logs()
        {
            string logs = "";
            foreach(string log in VendingMachine.logsList)
            {
                logs += log+"\n";
            }
            return logs;
        }
    }
}
