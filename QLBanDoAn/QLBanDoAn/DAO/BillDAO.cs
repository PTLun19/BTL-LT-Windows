using QLBanDoAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanDoAn.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }
        private BillDAO() { }
        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select *from Bill where ID_Table = " + id + " and Status = 0");
            if(data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }

        internal int GetUncheckBillIDByTableID(object id)
        {
            throw new NotImplementedException();
        }
    }
}
