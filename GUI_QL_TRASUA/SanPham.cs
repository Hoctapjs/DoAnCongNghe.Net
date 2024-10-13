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
    public partial class SanPham : Form
    {
        public SanPham() 
        {
            InitializeComponent();
            LoadSanPham();
        }

        private void LoadSanPham()
        {
            BLL bll = new BLL();
            dataGridView_SanPham.DataSource = bll.GetAllSanPham();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            SanPham sp = this;
            sp.Hide();
            Home home = new Home();
            home.ShowDialog();
            sp.Close();
        }
    }
}
