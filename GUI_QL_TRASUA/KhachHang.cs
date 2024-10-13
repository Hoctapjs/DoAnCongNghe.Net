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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
            LoadKhachHang();
        }

        private void LoadKhachHang()
        {
            BLL bll = new BLL();
            dataGridView_KhachHang.DataSource = bll.GetAllKhachHang();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            KhachHang khach = this;
            khach.Hide();
            Home home = new Home();
            home.ShowDialog();
            khach.Close();
        }
    }
}
