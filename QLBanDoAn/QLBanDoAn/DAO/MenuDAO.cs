using QLBanDoAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLBanDoAn.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;
        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }
        private MenuDAO() { }
        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();
            string query = "Select f.Name_Food, bi.Amount, f.Price, f.Price*bi.Amount as TotalPrice from Bill as b, BillInfo as bi, Food as f where bi.ID_Bill = b.ID_Bill and bi.ID_Food = f.ID_Food and b.ID_Table = "+id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }
    }
}
