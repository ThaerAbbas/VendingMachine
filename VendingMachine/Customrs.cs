using System.Collections.Generic;

namespace VendingMachine
{
    internal class Customer
    {
        private decimal money = 0;
        public decimal Money { get { return money; } set { money = value; } }

        public List<VendingMachine> customerInventoryList = new List<VendingMachine>();


    }
}


