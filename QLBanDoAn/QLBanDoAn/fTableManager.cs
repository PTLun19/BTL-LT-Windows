using QLBanDoAn.DAO;
using QLBanDoAn.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace QLBanDoAn
{
    public partial class fTableManager : Form
    {
        public object Enviroment { get; private set; }

        public fTableManager()
        {
            InitializeComponent();
            LoadTable();
        }
        #region Method
        void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine  + item.Status;
                btn.Click += Btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;

                }
                flpTable.Controls.Add(btn);
            }
        }
        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<QLBanDoAn.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            foreach (QLBanDoAn.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Amount.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());

                lsvBill.Items.Add(lsvItem);

            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            ShowBill(tableID);
        }
        #endregion

        private void fTableManager_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile();
            f.ShowDialog(); 
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog(); 
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lsvBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
