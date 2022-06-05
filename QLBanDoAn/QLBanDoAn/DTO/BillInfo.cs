using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanDoAn.DTO
{
    public class BillInfo
    {
        public BillInfo(int id, int billID, int foodID, int amount)
        {
            this.ID = id;
            this.BillID = billID;
            this.FoodID = foodID;
            this.Amount = amount;
        }
        public BillInfo(DataRow row)
        {
            this.ID = (int)row["ID_BillInfo"];
            this.BillID =(int)row["ID_Bill"];
            this.FoodID = (int)row["ID_Food"];
            this.Amount =(int)row["Amount"];
        }
        private int amount;
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        private int foodID;
        public int FoodID
        {
            get { return foodID; }
            set { foodID = value; }
        }

     

        private int billID;
        public int BillID
        {
            get { return billID; }
            set { billID = value; }
        }
        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
