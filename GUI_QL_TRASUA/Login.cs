using DOAN_BLL;
using DOAN_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI_QL_TRASUA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool dangnhap = false;
            string username = txt_username.Text;
            string password = txt_password.Text;
            BLL bll = new BLL();
            NHANVIENDTO nhanVien = bll.KiemTraDangNhap(username, password);

            if (nhanVien != null)
            {
                dangnhap = true;
            }

            username = nhanVien.USERNAME;
            string quyen = nhanVien.QUYEN;

            if (dangnhap)
            {
                MessageBox.Show("Đăng Nhập Thành Công");
                Login login = this;
                login.Hide();
                Home home = new Home(username, quyen);
                home.ShowDialog();
                login.Close();
            }
            else
            {
                MessageBox.Show("Đăng Nhập Thất Bại");
                txt_username.Clear();
                txt_password.Clear();
                txt_username.Focus();
            }
        }
    }
}
;