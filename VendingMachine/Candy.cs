using System.Collections.Generic;

namespace VendingMachine
{
    internal class Candy : VendingMachine
    {
        public static Candy ChocolateBar = new Candy { Name = "Chocolate-Bar", Price = 16M, ID = 1 };
        public static Candy Chips = new Candy { Name = "Bag of Chips", Price = 21M, ID = 2 };

        public static List<Candy> candyMenu = new List<Candy>
        {
            ChocolateBar,
            Chips,

        };
    }
}
