using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanDoAn.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int status)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
        }
        public Bill(DataRow row)
        {
            this.ID = (int)row["ID_Bill"];
            DateCheckIn = (DateTime?)row["DateCheckIn"];
            var dateCheckOutTemp = row["DateCheckOut"];
            if(dateCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;
            this.DateCheckOut = (DateTime?)row["DateCheckOut"];
            this.Status = (int)row["Status"];
        }
        private int status;
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        private DateTime? dateCheckOut;
        public DateTime? DateCheckOut
        {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
        }
        private DateTime? dateCheckIn;
        public DateTime? DateCheckIn
        {
            get { return dateCheckIn; } 
            set { dateCheckIn = value; }
        }
        
        private int iD;
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
