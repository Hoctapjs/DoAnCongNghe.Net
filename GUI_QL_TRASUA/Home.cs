﻿using DOAN_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace GUI_QL_TRASUA
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            LoadSanPham();
        }

        string username;
        string quyen;

        public string Username { get => username; set => username = value; }
        public string Quyen { get => quyen; set => quyen = value; }

        private void LoadSanPham()
        {
            lbl_username.Text = username;

            BLL bll = new BLL();
            lbl_soluongkh.Text = bll.GetSoKhachHang().ToString();
            lbl_soluongsp.Text = bll.GetSoSanPham().ToString();
            lbl_soluongdh.Text = bll.GetSoDonHang().ToString();
            cbo_ngay.DataSource = bll.GetAllNgayThangNam();
            cbo_ngay.DisplayMember = "NgayThangNam";
            cbo_ngay.ValueMember = "NgayThangNam";
            cbo_thang.DataSource = bll.GetAllThangNam();
            cbo_thang.DisplayMember = "ThangNam";
            cbo_thang.ValueMember = "ThangNam";

            cbo_nam.DataSource= bll.GetAllNam();
            cbo_nam.DisplayMember = "Nam";
            cbo_nam.ValueMember = "Nam";

            dataGridView_NV_QUYEN.DataSource = bll.GetAllNV_TEN_QUYEN();

            //lbl_tongdt_nam.Text = bll.TongDoanhThuTheoNam().ToString();
        }

        private void btn_tongdoanthu_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();

            string ngay = cbo_ngay.SelectedValue.ToString();
            int thang = int.Parse(cbo_thang.SelectedValue.ToString());
            int nam = int.Parse(cbo_nam.SelectedValue.ToString());

            lbl_tongdt_ngay.Text = bll.TongDoanhThuTheoNgay(ngay).ToString();
            lbl_tongdt_thang.Text = bll.TongDoanhThuTheoThang(thang).ToString();
            lbl_tongdt_nam.Text = bll.TongDoanhThuTheoNam(nam).ToString();
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            Home home = this;
            home.Hide();
            SanPham sp = new SanPham();
            sp.ShowDialog();
            home.Close();
        }

        private void btn_donhang_Click(object sender, EventArgs e)
        {
            Home home = this;
            home.Hide();
            DonHang dh = new DonHang();
            dh.ShowDialog();
            home.Close();
        }

        private void btn_chitietdh_Click(object sender, EventArgs e)
        {
            Home home = this;
            home.Hide();
            ChiTietDonHang ct = new ChiTietDonHang();
            ct.ShowDialog();
            home.Close();
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            Home home = this;
            home.Hide();
            NhanVien nv = new NhanVien();
            nv.ShowDialog();
            home.Close();
        }

        private void btn_khach_Click(object sender, EventArgs e)
        {
            Home home = this;
            home.Hide();
            KhachHang khach = new KhachHang();
            khach.ShowDialog();
            home.Close();
        }
    }
}
