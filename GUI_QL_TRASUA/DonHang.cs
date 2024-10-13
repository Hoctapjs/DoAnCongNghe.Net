using DOAN_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QL_TRASUA
{
    public partial class DonHang : Form
    {
        public DonHang()
        {
            InitializeComponent();
            LoadDonHang();
        }

        private void LoadDonHang()
        {
            BLL bll = new BLL();
            dataGridView_DonHang.DataSource = bll.GetAllDonHang();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DonHang dh = this;
            dh.Hide();
            Home home = new Home();
            home.ShowDialog();
            dh.Close();
        }
    }
}
