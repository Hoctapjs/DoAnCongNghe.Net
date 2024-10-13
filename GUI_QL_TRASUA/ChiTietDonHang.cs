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
    public partial class ChiTietDonHang : Form
    {
        public ChiTietDonHang()
        {
            InitializeComponent();
            LoadChiTietDonHang();
        }

        private void LoadChiTietDonHang()
        {
            BLL bll = new BLL();
            dataGridView_ChiTietDonHang.DataSource = bll.GetAllChiTietDonHang();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            ChiTietDonHang ct = this;
            ct.Hide();
            Home home = new Home();
            home.ShowDialog();
            ct.Close();
        }
    }
}
