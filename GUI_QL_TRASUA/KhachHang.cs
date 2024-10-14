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
