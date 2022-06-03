using QLBanDoAn.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanDoAn
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadAccountList();
        }
        void LoadFoodList()
        {

            string query = "Select *from Food";

            dtgvFood.DataSource = DataProvider.Instance.ExecuteQuery(query);


        }
        void LoadAccountList()
        {

            string query = "Exec USP_GetAccountByUserName @userName";
            
            dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[]{"NV01"});

        }
        private void fAdmin_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txbFoodName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
