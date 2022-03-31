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
            int admin = 8;





            
            //Main menu for the vending machine
            do
            {
                switch (menu)
                {
                    case 0:
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
                        Console.WriteLine(vendingMachine.PickedItem(index, money)); 
                        Console.WriteLine("\n0. Back to menu " + "3. Exit Program");
                        menu = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Put in the admin password");
                        string login = Console.ReadLine();
                        if (vendingMachine.AdminPassword(login))
                        {
                            menu = 3;
                            admin = 8;
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
            } while (menu != 3 || admin != 8);


            //Admin menu to fill, change products and see logs
            do
            {
                switch (admin)
                {
                    case 8:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine
                        (
                        "|============================================|\n" +
                        "|               Vending Machine              |\n" +
                        "|============================================|\n" +
                        "|1. Add new product                          |"+
                        "\n|2. Fill stock                               |" +
                        "\n|3. Change price                             |" +
                        "\n|4. Fill balance                             |"+
                        "\n|5. Logs                                     |" +
                        "\n|6. Back                                     |"+
                        "\n|Enter your choice                           |"+
                        "\n|____________________________________________|"
                        );
                        admin = int.Parse(Console.ReadLine());
                        break;
                    case 1:
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\n0. Back to menu " + "6. Exit Program");
                        admin = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("What item do you want to change the price on? ");
                        int index = int.Parse(Console.ReadLine());
                        Console.WriteLine("What should the price on the item be? ");
                        int price = int.Parse(Console.ReadLine());
                        Console.WriteLine(vendingMachine.ChangePrice(index, price)); 
                        Console.WriteLine("\n0. Back to menu " + "6. Exit Program");
                        admin= int.Parse(Console.ReadLine());
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("How much cash do you want to add to the balance? ");
                        int balance = int.Parse(Console.ReadLine());
                        Console.WriteLine(vendingMachine.FillBalance(balance));
                        Console.WriteLine("\n0. Back to menu " + "6. Exit Program");
                        admin = int.Parse(Console.ReadLine());
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine(vendingMachine.Logs());
                        break;
                    case 6:
                        menu = 0;
                        break;


                }
            } while (admin != 7|| menu != 0);

            Console.WriteLine("Thanks for using this vending machine!");

        }
    }
}
