using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOAN_BLL;

namespace GUI_QL_TRASUA
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
            LoadNhanVien();
        }

        private void LoadNhanVien()
        {
            BLL bll = new BLL();
            dataGridView_NhanVien.DataSource = bll.GetAllNhanVien();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            NhanVien nv = this;
            nv.Hide();
            Home home = new Home();
            home.ShowDialog();
            nv.Close();
        }
    }
}
