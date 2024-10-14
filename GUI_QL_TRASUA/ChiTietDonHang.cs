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

        private void btn_them_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            CHITIETDONHANGDTO ct = new CHITIETDONHANGDTO
            {
                MADH = Convert.ToInt32(txt_madh.Text),
                MASP = Convert.ToInt32(txt_masp.Text),
                SOLUONG = Convert.ToInt32(txt_soluong.Text),
                GIA = decimal.Parse(txt_gia.Text)
            };
            bool isSuccess = bll.ThemChiTietDonHang(ct);
            if (isSuccess)
            {
                MessageBox.Show("Thành công");
                LoadChiTietDonHang();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();

            int maDH = Convert.ToInt32(txt_madh.Text);
            int maSP = Convert.ToInt32(txt_masp.Text);
            bool isSuccess = bll.XoaChiTietDonHang(maDH, maSP);
            if (isSuccess)
            {
                MessageBox.Show("Thành công");
                LoadChiTietDonHang();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();

            CHITIETDONHANGDTO ct = new CHITIETDONHANGDTO
            {
                MADH = Convert.ToInt32(txt_madh.Text),
                MASP = Convert.ToInt32(txt_masp.Text),
                SOLUONG = Convert.ToInt32(txt_soluong.Text),
                GIA = decimal.Parse(txt_gia.Text)
            };
            bool isSuccess = bll.SuaChiTietDonHang(ct);
            if (isSuccess)
            {
                MessageBox.Show("Thành công");
                LoadChiTietDonHang();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }
    }
}
