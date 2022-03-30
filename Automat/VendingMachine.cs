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
        public string DisplayProducts()
        {
            return customer.DisplayProducts();
        }
        public string PickedItem(int index, int money)
        {
            return customer.ProductPick(index,money);

        }



        //Admin
        public bool AdminPassword(string login)
        {
            return admin.AdminPassword(login);
        }
        public void AddNewProduct(string productName, string name, int price, int amount)
        {
            admin.AddNewProduct(); //Fix

        }
        public void FillStock(int amount, int index)
        {
            admin.FillStock(amount, index); //Fix
        }
        public void ChangePrice(int index, int price)
        {
            admin.ChangePrice(price, index); //Fix
        }

        public string FillBalance(int balance)
        {
            return admin.FillBalance(balance);
        }
        public string Logs()
        {
            return admin.Logs();
        }
        
    }
}
