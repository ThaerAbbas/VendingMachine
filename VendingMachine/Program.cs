using System;

namespace VendingMachine
{
    internal class Program
    {
        public static Customer customer = new Customer();

        public static decimal addMoney(decimal money)
        {
            Console.WriteLine("insert money");
            Console.WriteLine("Press 1 for 1Kr");
            Console.WriteLine("Press 2 for 5Kr");
            Console.WriteLine("Press 3 for 10Kr");
            Console.WriteLine("Press 4 for 50Kr");
            Console.WriteLine("Press 5 for 500Kr");
            Console.WriteLine("Press 6 for 1000Kr");

             money = Convert.ToDecimal(Console.ReadLine());

            switch (money)
            {
                case 1:
                    customer.Money = 1;
                    Console.WriteLine($"\nYour  saldo is ({customer.Money})");
                    break;

                case 2:
                    customer.Money = 5;
                    Console.WriteLine($"\nYour  saldo is ({customer.Money})");
                    break;

                case 3:
                    customer.Money = 10;
                    Console.WriteLine($"\nYour  saldo is ({customer.Money})");
                    break;

                case 4:
                    customer.Money = 50;
                    Console.WriteLine($"\nYour  saldo is ({customer.Money})");
                    break;

                case 5:
                    customer.Money = 500;
                    Console.WriteLine($"\nYour  saldo is ({customer.Money})");
                    break;

                case 6:
                    customer.Money = 1000;
                    Console.WriteLine($"\nYour  saldo is ({customer.Money})");
                    break;
                default:
                    Console.WriteLine("Please chose numbers from 1 to 6 to add money..");
                    break;
            }

            return money;
        }



        public static void seeProduct()
        {

            Console.WriteLine();
            Console.WriteLine("Beverages...");
          
            foreach (Beverage beverages in Beverage.beverageMenu)
            {
                Console.WriteLine($"{beverages.ID}: {beverages.Name} ({beverages.Price:c})");
            }

            Console.WriteLine();
            Console.WriteLine("Candy...");
          
            foreach (Candy candys in Candy.candyMenu)
            {
                Console.WriteLine($"{candys.ID}: {candys.Name} ({candys.Price:c})");
            }

            Console.WriteLine();
            Console.WriteLine("Snack...");
           
            foreach (Snack snack in Snack.snackMenu)
            {
                Console.WriteLine($"{snack.ID}: {snack.Name} ({snack.Price:c})");
            }

        }
       

        static void Main(string[] args)
        {
            decimal money = 0;
            char itemType = ' ';
            


            Console.WriteLine("Chose 1 to insert money or chose 2 to see all the product");
            int choess = Convert.ToInt32(Console.ReadLine());

          
            switch (choess)
            {
                case 1:
                    Program.addMoney(money);
                    break;

                case 2:
                    Program.seeProduct();
                    break;

            }




            Console.WriteLine("Press 'B' for Beverages and 'C' for Candy 'S' for Snack. 'I' to view inventory. Any other key to quit: ");
             itemType = Console.ReadKey().KeyChar;
            Console.WriteLine();

            while (itemType != 'q')
            {

                switch (itemType)
                {
                    case 'b':
                        Console.WriteLine("\nPress the corresponding buttons to choose a vending machine item. Any other button to go back <--.");
                        foreach (Beverage beverages in Beverage.beverageMenu)
                        {
                            Console.WriteLine($"{beverages.ID}: {beverages.Name} ({beverages.Price:c})");
                        }
                        char customerItem = Console.ReadKey().KeyChar;

                        if (customer.Money == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Please add money..");
                            Program.addMoney(money);
                        }
                       

                            switch (customerItem)
                            {
                                case '1':
                                    customer.customerInventoryList.Add(Beverage.CocaCola);
                                    customer.Money -= Beverage.CocaCola.Price;
                                    Console.WriteLine($"\nYou bought a {Beverage.CocaCola.Name}");
                                    break;
                                case '2':
                                    customer.customerInventoryList.Add(Beverage.PepsiMax);
                                    customer.Money -= Beverage.PepsiMax.Price;
                                    Console.WriteLine($"\nYou bought a {Beverage.PepsiMax.Name}");
                                    break;
                                case '3':
                                    customer.customerInventoryList.Add(Beverage.Fanta);
                                    customer.Money -= Beverage.Fanta.Price;
                                    Console.WriteLine($"\nYou bought a {Beverage.Fanta.Name}");
                                    break;
                                case '4':
                                    customer.customerInventoryList.Add(Beverage.Sprite);
                                    customer.Money -= Beverage.Sprite.Price;
                                    Console.WriteLine($"\nYou bought a {Beverage.Sprite.Name}");
                                    break;
                            }
                        
                        break;


                    case 'c':
                        Console.WriteLine("\nPress the corresponding buttons to choose a vending machine item. Any other button to go back <--.");
                        foreach (Candy candys in Candy.candyMenu)
                        {
                            Console.WriteLine($"{candys.ID}: {candys.Name} ({candys.Price:c})");
                        }
                        customerItem = Console.ReadKey().KeyChar;

                        if (customer.Money == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Please add money..");
                            Program.addMoney(money);
                        }

                        switch (customerItem)
                        {
                            case '1':
                                customer.customerInventoryList.Add(Candy.ChocolateBar);
                                customer.Money -= Candy.ChocolateBar.Price;
                                Console.WriteLine($"\nYou bought a {Candy.ChocolateBar.Name} for {Candy.ChocolateBar.Price:c}.");
                                break;
                            case '2':
                                customer.customerInventoryList.Add(Candy.Chips);
                                customer.Money -= Candy.Chips.Price;
                                Console.WriteLine($"\nYou bought a {Candy.Chips.Name} for {Candy.Chips.Price:c}.");
                                break;
                        }
                        break;

                    case 's':
                        Console.WriteLine("\nPress the corresponding buttons to choose a vending machine item. Any other button to go back <--.");
                        foreach (Snack snack in Snack.snackMenu)
                        {
                            Console.WriteLine($"{snack.ID}: {snack.Name} ({snack.Price:c})");
                        }
                        customerItem = Console.ReadKey().KeyChar;

                        if (customer.Money == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Please add money..");
                            Program.addMoney(money);
                        }

                        switch (customerItem)
                        {
                            case '1':
                                customer.customerInventoryList.Add(Snack.Hotdog);
                                customer.Money -= Snack.Hotdog.Price;
                                Console.WriteLine($"\nYou bought a {Snack.Hotdog.Name} for {Snack.Hotdog.Price:c}.");
                                break;
                            case '2':
                                customer.customerInventoryList.Add(Snack.Cookies);
                                customer.Money -= Snack.Cookies.Price;
                                Console.WriteLine($"\nYou bought a {Snack.Cookies.Name} for {Snack.Cookies.Price:c}.");
                                break;
                        }
                        break;

                    case 'i':
                        Console.WriteLine($"\nCustomer money: {customer.Money:c}.");
                        Console.WriteLine($"Customer inventory:");
                        foreach (VendingMachine customerItemInventory in customer.customerInventoryList)
                        {
                            Console.WriteLine(customerItemInventory.Name);
                        }
                        break;


                    default:
                        return;
                }
                Console.WriteLine("\n\nPress 'B' for Beverages and 'C' for Candy. 'I' to view inventory. Any other key to quit: ");
                itemType = Console.ReadKey().KeyChar;

                Console.ReadLine();
            }
                  
           


        }
    }
}
    

