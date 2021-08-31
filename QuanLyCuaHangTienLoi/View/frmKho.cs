using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;

namespace QuanLyCuaHangTienLoi.View
{
    public partial class frmKho : Form
    {
        Kho_BLLDAL kho = new Kho_BLLDAL();
        SanPham_BLLDAL sanpham = new SanPham_BLLDAL();
        NguoiDung_BLLDAL nguoidung = new NguoiDung_BLLDAL();
        public frmKho()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            load_dgv();
            dgvPhieuDat.AllowUserToAddRows = false;
        }

        public void load_dgv()
        {
            dgvPhieuDat.Rows.Clear();
            dgvPhieuDat.Refresh();

            foreach (PHIEUDAT item in kho.get_DataDatHang())
            {
                string tenncc = "";
                string nhanvien = "";
                int x = 0;

                foreach (NHACUNGCAP item1 in kho.get_DataNCC())
                {
                    if (item.ID_NCC == item1.ID_NCC)
                    {
                        tenncc = item1.TENNCC.ToString();
                        x = item1.ID_NCC;
                    }
                }

                foreach (NGUOIDUNG item1 in nguoidung.get_DanhMucND())
                {
                    if (item.ID_DN == item1.ID_DN)
                    {
                        nhanvien = item1.TEN.ToString();
                    }
                }
                dgvPhieuDat.Rows.Add(item.ID_PD, x, tenncc, nhanvien, item.NGAYLAP, item.TONGTIEN, item.TINHTRANG);
            }
        }


        private void btnDatHang_Click(object sender, EventArgs e)
        {
            frmDatHang dathang = new frmDatHang();
            dathang.ShowDialog();
        }

        private void btnXemThongTin_Click_1(object sender, EventArgs e)
        {
            SanPham_BLLDAL sanpham1 = new SanPham_BLLDAL();
            dgvChiTiet.Rows.Clear();
            dgvChiTiet.Refresh();
            int id = int.Parse(dgvPhieuDat.CurrentRow.Cells[0].Value.ToString().Trim());

            foreach (CHITIETPHIEUDAT item in kho.get_DataSP_CTPD(id))
            {
                string ten = "";
                foreach (SANPHAM item1 in sanpham1.get_DataSP())
                {

                    if (item.ID_SP == item1.ID_SP)
                    {
                        ten = item1.TENSP.ToString();
                    }
                }
                dgvChiTiet.Rows.Add(item.ID_SP, ten, item.SOLUONG, item.THANHTIEN);
            }
        }

        private void btnThemLSP_Click(object sender, EventArgs e)
        {
            frmThemLoaiSP them = new frmThemLoaiSP();
            them.ShowDialog();
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            frmThemNCC them = new frmThemNCC();
            them.ShowDialog();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            if ((Boolean)dgvPhieuDat.CurrentRow.Cells[6].Value == false)
            {
                frmNhapHang nhap = new frmNhapHang();
                nhap.idncc_g = Convert.ToInt32(dgvPhieuDat.CurrentRow.Cells[1].Value);
                nhap.idpd_g = Convert.ToInt32(dgvPhieuDat.CurrentRow.Cells[0].Value);

                nhap.ShowDialog();
            }
            else
                MessageBox.Show("Nhà cung cấp đã giao hàng!");
            
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            if ((Boolean)dgvPhieuDat.CurrentRow.Cells[6].Value == false)
            {
                frmNo no= new frmNo();
                no.idpd_g = Convert.ToInt32(dgvPhieuDat.CurrentRow.Cells[0].Value);
                no.ShowDialog();
            }
            else
                MessageBox.Show("Nhà cung cấp đã giao hàng!");
        }
    }
}
