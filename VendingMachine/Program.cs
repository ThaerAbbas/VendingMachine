using System;

namespace VendingMachine
{
    internal class Program
    {
        public static Customer customer = new Customer();
        static void Main(string[] args)
        {
            Console.WriteLine("Press 'B' for Beverages and 'C' for Candy. 'I' to view inventory. Any other key to quit: ");
            char itemType = Console.ReadKey().KeyChar;
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
            }
        }
    }
}
    }
}
