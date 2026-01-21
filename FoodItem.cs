using System;
using System.Collections.Generic;
using System.Text;

namespace Mission3Assignment
{
    internal class FoodItem
    {
        private string name = "";
        private string category = "";
        private int quantity = 0;
        private DateTime expirationDate = DateTime.Now;

        public FoodItem(string name, string category, int quantity, DateTime exp) 
        {
            this.name = name;
            this.category = category;
            this.quantity = quantity;
            this.expirationDate = exp;
        }

        public string getName()
        {
            return this.name;
        }

        public string getCategory()
        {
            return this.category;
        }

        public int getQuantity()
        {
            return this.quantity;
        }

        public DateTime getExpirationDate()
        {
            return this.expirationDate;
        }
    }
}
