using System.Collections.Generic;

namespace VendingMachine
{

    internal class Snack : VendingMachine
    {
        public static Snack Hotdog = new Snack { Name = "Hotdog", Price = 16M, ID = 1 };
        public static Snack Cookies = new Snack { Name = "Cookies", Price = 21M, ID = 2 };

        public static List<Snack> snackMenu = new List<Snack>
        {
            Hotdog,
            Cookies,

        };
    }
}


