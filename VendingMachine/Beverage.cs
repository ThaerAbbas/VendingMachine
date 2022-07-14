using System.Collections.Generic;

namespace VendingMachine
{
    internal class Beverage : VendingMachine
    {
        public static Beverage CocaCola = new Beverage { Name = "Coca-Cola", Price = 10M, ID = 1 };
        public static Beverage PepsiMax = new Beverage { Name = "Pepsi Max", Price = 14M, ID = 2 };
        public static Beverage Fanta = new Beverage { Name = "Fanta", Price = 10M, ID = 3 };
        public static Beverage Sprite = new Beverage { Name = "Sprite", Price = 10M, ID = 4 };

        public static List<Beverage> beverageMenu = new List<Beverage>
        {
            CocaCola,
            PepsiMax,
            Fanta,
            Sprite,
        };
    }
}