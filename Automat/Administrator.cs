using System;
using System.Collections.Generic;
using System.Text;

namespace Automat
{
    public class Administrator
    {
        private VendingMachine VendingMachine { get; set; } 
        private List<Product> productList { get; set; } 

        private int adminBalance; //Admin persons balance
        public Administrator(VendingMachine vm)
        {
            VendingMachine = vm;
            productList = VendingMachine.productsList; //Instead of calling vendingMachine.productsList every time, i made a variable called productList
        }

        //Method to fill stock on the selected product
        public string FillStock(int amount, int index)
        {
            productList[index-1].Amount = amount;  //Fill the stock with the fill amount
            return ("\nThe total amount on " + productList[index-1].Name + " is now " + amount);//Tells you the total amount of the item
        }

        //Method to change the price of the slected product
        public string ChangePrice(int index, int price)
        {
            productList[index - 1].Price = price; //Sets a new price on the selcted item
            return (productList[index-1].Name + " got a new price: " + price); //Tells you the new price of the item
            
        }

        //Method to check the admin password,if true then admin menu
        public bool AdminPassword(string guess)
        {
            if (guess == "Admin12345") //Checks if the guess is right
            {
                return true;
            }
            return false;
        }
        //Method to see the balance of vending machine
        public string SeeBalance()
        {

            return "There is a total of: "+VendingMachine.balance+" kr in the vending mahchine" ; //Tells you how much money there is in the vending machine
        }

        //Method to withdraw the balance from the vending machine
        public string WithdrawBalance()
        {
            adminBalance = VendingMachine.balance; //Sets admin persons balance to vending machine balance
            VendingMachine.balance = 0; //Sets vending machine balance to 0
            return "Vending machine is now empty, you withdrawed "+adminBalance+" kr";
        }

        //Method that put every log to a string
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
