using System;
using System.Collections.Generic;
using System.Text;

namespace Automat
{
    public class Administrator
    {
        private VendingMachine VendingMachine { get; set; } 
        public Administrator(VendingMachine vm)
        {
            VendingMachine = vm;
        }

        public void AddNewProduct()
        {
            
        }
        public string ChangePrice(int index, int price)
        {
            VendingMachine.productsList[index - 1].Price = price;
            return (VendingMachine.productsList[index-1].Name + "got a new price: " + price);
            
        }
        public string FillStock(int amount, int index)
        {
            VendingMachine.productsList[index-1].Amount = amount; 
            return ("The total amount on" + VendingMachine.productsList[index-1].Name + "is now" + amount);
        }
        public bool AdminPassword(string guess)
        {
            if (guess == "Admin12345")
            {
                return true;
            }
            return false;
        }
        public string FillBalance(int balance)
        {
            VendingMachine.balance += balance;
            return balance+ " kr has been added, total balance in VendingMachine is: "+VendingMachine.balance ;
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
