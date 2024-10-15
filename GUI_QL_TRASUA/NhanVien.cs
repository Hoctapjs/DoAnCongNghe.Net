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
using DOAN_DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI_QL_TRASUA
{
    public partial class NhanVien : Form
    {
        public NhanVien(string username1, string quyen1)
        {
            InitializeComponent();
            username = username1;
            quyen = quyen1;
            LoadNhanVien();
        }

        string username;
        string quyen;

        private void LoadNhanVien()
        {
            BLL bll = new BLL();
            dataGridView_NhanVien.DataSource = bll.GetAllNhanVien();
            lbl_username.Text = username;

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            NhanVien nv = this;
            nv.Hide();
            Home home = new Home(username, quyen);
            home.ShowDialog();
            nv.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            NHANVIENDTO nv = new NHANVIENDTO
            {
                TENNV = txt_tennv.Text,
                QUYEN = txt_quyen.Text,
                USERNAME = txt_username.Text,
                PASSWORD = txt_password.Text
            };
            bool isSuccess = bll.ThemNhanVien(nv);
            if (isSuccess)
            {
                MessageBox.Show("Thành công");
                LoadNhanVien();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();

            int maNV = Convert.ToInt32(txt_manv.Text);
            bool isSuccess = bll.XoaNhanVien(maNV);
            if (isSuccess)
            {
                MessageBox.Show("Thành công");
                LoadNhanVien();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            NHANVIENDTO nv = new NHANVIENDTO
            {
                MANV = Convert.ToInt32(txt_manv.Text),
                TENNV = txt_tennv.Text,
                QUYEN = txt_quyen.Text,
                USERNAME = txt_username.Text,
                PASSWORD = txt_password.Text
            };
            bool isSuccess = bll.SuaNhanVien(nv);
            if (isSuccess)
            {
                MessageBox.Show("Thành công");
                LoadNhanVien();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }
    }
}
