using System;
using System.Collections.Generic;

namespace Automat
{
    public class Program
    {

        static VendingMachine vendingMachine {get;set;}
        static void Main(string[] args)
        {
            vendingMachine = new VendingMachine();
            int menu = 0;
            int admin = 0;
            MainMenu();





            
            //Main menu for the vending machine
        void MainMenu()
            {
                do
                {
                    switch (menu)
                    {
                        case 0://Main menu
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Clear();
                            Console.WriteLine
                            (
                            "|============================================|\n" +
                            "|               Vending Machine              |\n" +
                            "|============================================|\n" +
                            "|1. Order Item                               |" +
                            "\n|2. Admin                                    |" +
                            "\n|3. Exit                                     |" +
                            "\n|Enter your choice                           |"+
                            "\n|____________________________________________|" 
                            );
                            menu = int.Parse(Console.ReadLine());
                            break;
                        case 1: //Order Item
                            Console.Clear();
                            Console.WriteLine(vendingMachine.DisplayProducts());
                            Console.WriteLine("\nPut in your money");
                            int money = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the number of the product you want");
                            int index = int.Parse(Console.ReadLine());
                            Console.WriteLine("Are you sure you want to buy this product? y/n");
                            string confirm = Console.ReadLine();
                            if(confirm.ToLower() == "y")
                            {
                                Console.WriteLine(vendingMachine.PickedItem(index, money)); 
                            }
                            Console.WriteLine("\n0. Back to menu " + "3. Exit Program");
                            menu = int.Parse(Console.ReadLine());
                            break;
                        case 2://Admin menu
                            Console.Clear();
                            Console.WriteLine("Put in the admin password");
                            string login = Console.ReadLine();
                            if (vendingMachine.AdminPassword(login))
                            {
                                menu = 3;
                                admin = 0;
                                AdminMenu();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Password is wrong");
                                Console.WriteLine("\n0. Back to menu " + "3. Exit Program");
                                menu = int.Parse(Console.ReadLine());
                                break;
                            }

                    }
                } while (menu != 3 || admin != 0);

            }


            //Admin menu to fill, change products and see logs
            void AdminMenu()
            {

                do
                {
                    switch (admin)
                    {
                        case 0://Admin menu
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                            Console.WriteLine
                            (
                            "|============================================|\n" +
                            "|               Vending Machine              |\n" +
                            "|============================================|\n" +
                            "|1. Fill stock                               |" +
                            "\n|2. Change price                             |" +
                            "\n|3. See balance                              |"+
                            "\n|4. Logs                                     |" +
                            "\n|5. Back                                     |"+
                            "\n|Enter your choice                           |"+
                            "\n|____________________________________________|"
                            );
                            admin = int.Parse(Console.ReadLine());
                            break;
                        case 1://Fill stock menu
                            Console.Clear();
                            Console.WriteLine(vendingMachine.DisplayProductsAmount());
                            Console.WriteLine("What item do you want to restock? ");
                            int index = int.Parse(Console.ReadLine());
                            Console.WriteLine("How many do you want to fill?");
                            int amount = int.Parse(Console.ReadLine());
                            Console.WriteLine(vendingMachine.FillStock(amount, index)); 
                            Console.WriteLine("\n0. Back to menu " + "6. Exit Program");
                            admin = int.Parse(Console.ReadLine());
                            break;
                        case 2://Change price menu
                            Console.Clear();
                            Console.WriteLine(vendingMachine.DisplayProducts()); 
                            Console.WriteLine("What item do you want to change the price on? ");
                            index = int.Parse(Console.ReadLine());
                            Console.WriteLine("What should the price on the item be? ");
                            int price = int.Parse(Console.ReadLine());
                            Console.WriteLine(vendingMachine.ChangePrice(index, price)); 
                            Console.WriteLine("\n0. Back to menu " + "6. Exit Program");
                            admin= int.Parse(Console.ReadLine());
                            break;
                        case 3://See balance menu
                            Console.Clear();
                            Console.WriteLine(vendingMachine.SeeBalance());
                            Console.WriteLine("Do you want to withdraw the money from the vending machine? y/n");
                            string withdraw = Console.ReadLine();
                            Console.WriteLine(vendingMachine.WithdrawBalance(withdraw));
                            Console.WriteLine("\n0. Back to menu " + "6. Exit Program");
                            admin = int.Parse(Console.ReadLine());
                            break;
                        case 4://See logs menu
                            Console.Clear();
                            Console.WriteLine(vendingMachine.Logs());
                            Console.WriteLine("\n0. Back to menu " + "6. Exit Program");
                            admin = int.Parse(Console.ReadLine());
                            break;
                        case 5:
                            menu = 0;
                            admin = 7;
                            MainMenu();
                            break;
                        case 6:
                            admin = 7;
                            break;


                    }
                } while (admin != 7|| menu != 0);
            }
            Console.Clear();
            Console.WriteLine("Thanks for using this vending machine!");
            Console.ReadKey();

        }
    }
}
