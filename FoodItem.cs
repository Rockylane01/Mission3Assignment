using System;
using System.Collections.Generic;
using System.Text;

namespace Mission3Assignment
{
    internal class FoodItem
    {
        string name = "";
        string category = "";
        int quantity = 0;
        DateTime expirationDate = DateTime.Now;

        public FoodItem(string name, string category, int quantity, DateTime exp) 
        {
            this.name = name;
            this.category = category;
            this.quantity = quantity;
            this.expirationDate = exp;
        }

        // Print List of Current Food Items

    }
}
