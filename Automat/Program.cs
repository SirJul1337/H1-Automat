using System;
using System.Collections.Generic;

namespace Automat
{
    public class Program
    {

        static VendingMachine vendingMachine {get;set;}
        static Customer customer {get;set;}
        static Administrator administrator {get;set;}
        static void Main(string[] args)
        {
            vendingMachine = new VendingMachine();
            int menu = 0;
            int admin = 0;





            
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
                    case 1:
                        Console.Clear();
                        Console.WriteLine(customer.DisplayProducts());
                        Console.WriteLine("\n0. Back to menu " + "3. Exit Program");
                        menu = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Put in the admin password");
                        string guess = Console.ReadLine();
                        if (administrator.AdminPassword(guess))
                        {
                            menu = 3;
                            admin = 1;
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
            } while (menu != 3 || admin != 1);


            //Admin menu to fill, change products and see logs
            do
            {
                switch (admin)
                {
                    case 1:
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
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\n0. Back to menu " + "5. Exit Program");
                        admin = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("\n0. Back to menu " + "5. Exit Program");
                        admin= int.Parse(Console.ReadLine());
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("\n0. Back to menu " + "5. Exit Program");
                        admin = int.Parse(Console.ReadLine());
                        break;
                    case 5:
                        Console.Clear();
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
