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

        private void btn_them_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            DONHANGDTO dh = new DONHANGDTO
            {
                MAKH = Convert.ToInt32(txt_makh.Text),
                NGAYLAP = (txt_ngaylap.Text),
                TONGGIA = decimal.Parse(txt_tonggia.Text)
            };
            bool isSuccess = bll.ThemDonHang(dh);
            if (isSuccess)
            {
                MessageBox.Show("Thành công");
                LoadDonHang();
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
            bool isSuccess = bll.XoaDonHang(maDH);
            if (isSuccess)
            {
                MessageBox.Show("Thành công");
                LoadDonHang();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();

            DONHANGDTO dh = new DONHANGDTO
            {
                MADH = Convert.ToInt32(txt_madh.Text),
                MAKH = Convert.ToInt32(txt_makh.Text),
                NGAYLAP = (txt_ngaylap.Text),
                TONGGIA = decimal.Parse(txt_tonggia.Text)
            };
            bool isSuccess = bll.SuaDonHang(dh);
            if (isSuccess)
            {
                MessageBox.Show("Thành công");
                LoadDonHang();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }

        }
    }
}
