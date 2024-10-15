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
    public partial class KhachHang : Form
    {
        public KhachHang(string username1, string quyen1)
        {
            InitializeComponent();
            username = username1;
            quyen = quyen1;
            LoadKhachHang();
        }

        string username;
        string quyen;

        private void LoadKhachHang()
        {
            BLL bll = new BLL();
            dataGridView_KhachHang.DataSource = bll.GetAllKhachHang();
            lbl_username.Text = username;

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            KhachHang khach = this;
            khach.Hide();
            Home home = new Home(username, quyen);
            home.ShowDialog();
            khach.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            KHACHHANGDTO kh = new KHACHHANGDTO
            {
                TENKH = txt_tenkh.Text,
                SODT = txt_sodt.Text,
                DIACHI = txt_diachi.Text
            };
            bool isSuccess = bll.ThemKhachHang(kh);
            if (isSuccess)
            {
                MessageBox.Show("Thành công");
                LoadKhachHang();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            int maKH = Convert.ToInt32(txt_makh.Text);
            bool isSuccess = bll.XoaKhachHang(maKH);
            if (isSuccess)
            {
                MessageBox.Show("Thành công");
                LoadKhachHang();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            KHACHHANGDTO kh = new KHACHHANGDTO
            {
                MAKH = Convert.ToInt32(txt_makh.Text),
                TENKH = txt_tenkh.Text,
                SODT = txt_sodt.Text,
                DIACHI = txt_diachi.Text
            };
            bool isSuccess = bll.SuaKhachHang(kh);
            if (isSuccess)
            {
                MessageBox.Show("Thành công");
                LoadKhachHang();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }

        }
    }
}
