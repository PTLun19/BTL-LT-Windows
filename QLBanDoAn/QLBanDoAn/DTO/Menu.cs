using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanDoAn.DTO
{
    public class Menu
    {
        public Menu(string foodName, int amount, float price, float totalPrice=0)
        {
            this.FoodName = foodName;
            this.Amount = amount;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }
        public Menu(DataRow row)
        {
            this.FoodName = row["Name_Food"].ToString();
            this.Amount = (int)row["Amount"];
            this.Price =(float)Convert.ToDouble(row["Price"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["TotalPrice"].ToString());
        }


        private float totalPrice;
        public float TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
        private float price;
        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        private int amount;
        public int Amount
        {
            get { return amount; }
            set {amount = value; }
        }
        private string foodName;
        public string FoodName
        {
            get { return foodName; }
            set { foodName = value; }
        }

    }
}
