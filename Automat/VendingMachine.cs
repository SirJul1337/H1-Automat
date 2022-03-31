using System;
using System.Collections.Generic;
using System.Text;

namespace Automat
{
    public class VendingMachine
    {
        public int balance = 125;
        private Administrator admin { get; set; }
        private Customer customer { get; set; }

        public List<Product> productsList = new List<Product>();
        public List<Product> pickedProducts = new List<Product>();
        public List<string> logsList = new List<string>();
        public VendingMachine()
        {
            admin = new Administrator(this);
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


        //Customer

        //Method to display products
        public string DisplayProducts()
        {
            int i = 0;
            string products = "";
            foreach (Product product in productsList)
            {
                if(product.Amount != 0)//If the product amount isnt empty, then show the item
                {
                    i++;
                    products += i + ". " + product.Name + " " + product.Price + " kr\n" ;

                }
            }
            return products;
        }


        //method to display the amount of the product there is left
        public string DisplayProductsAmount()
        {
            int i = 0;
            string products = "";
            foreach (Product product in productsList)
            {
                i++;
                products += i + ". " + product.Name + " " + product.Amount + " stk\n";
            }
            return products;
        }

        //Method that points to customer productpick
        public string PickedItem(int index, int money)
        {
            return customer.ProductPick(index,money);

        }



        //Admin
        public bool AdminPassword(string login)
        {
            return admin.AdminPassword(login);
        }

        //Method to call admin FillStock()
        public string FillStock(int amount, int index)
        {
            return admin.FillStock(amount, index); //Fix
        }

        //Method to call admin.ChangePrice()
        public string ChangePrice(int index, int price)
        {
            return admin.ChangePrice(index, price); //Fix
        }

        //Method to call admin.Balance()
        public string SeeBalance()
        {
            return admin.SeeBalance();
        }

        //Method if they want to withdraw, admin.WithdrawBalance() will be called
        public string WithdrawBalance(string withdraw)
        {
            if(withdraw.ToLower() == "y")
            {
                return admin.WithdrawBalance();
            }
            return "";
        }

        //method to call admin.logs()
        public string Logs()
        {
            return admin.Logs();
        }
        
    }
}
