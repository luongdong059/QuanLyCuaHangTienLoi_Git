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
    public partial class frmNhapHang : Form
    {
        public int idncc_g, idpd_g;
        public frmNhapHang()
        {
            InitializeComponent();
            load();

        }

        public void load()
        {
            load_CbxNguoiDung();
            load_dgvDat();
            load_thongtin();
        }

        public void load_CbxNguoiDung()
        {
            NguoiDung_BLLDAL nguoidung = new NguoiDung_BLLDAL();
            cbxNhanVien.DataSource = nguoidung.get_DanhMucND();
            cbxNhanVien.DisplayMember = "Ten";
            cbxNhanVien.ValueMember = "ID_DN";
            cbxNhanVien.SelectedValue = Program.mainForm.User;
        }

        public void load_dgvDat()
        {
            

            Kho_BLLDAL kho = new Kho_BLLDAL();
            SanPham_BLLDAL sanpham1 = new SanPham_BLLDAL();
            dgvPhieuDat.Rows.Clear();
            dgvPhieuDat.Refresh();
            foreach (CHITIETPHIEUDAT item in kho.get_DataSP_CTPD(idpd_g))
            {
                int dem = 0;
                foreach (CHITIETPHIEUNHAP x in kho.get_DataSP_CTPN(idpd_g))
                {
                    dem++;
                }
                if (dem == 0)
                {
                    string ten = "";
                    foreach (SANPHAM item2 in sanpham1.get_DataSP())
                    {

                        if (item.ID_SP == item2.ID_SP)
                        {
                            ten = item2.TENSP.ToString();
                        }
                    }
                    dgvPhieuDat.Rows.Add(item.ID_SP, ten, item.SOLUONG, item.THANHTIEN);
                }
                else
                {
                    foreach (CHITIETPHIEUNHAP item1 in kho.get_DataSP_CTPN(idpd_g))
                    {
                        if (item.ID_SP == item1.ID_SP)
                        {

                        }
                        else
                        {
                            string ten = "";
                            foreach (SANPHAM item2 in sanpham1.get_DataSP())
                            {

                                if (item.ID_SP == item2.ID_SP)
                                {
                                    ten = item2.TENSP.ToString();
                                }
                            }
                            dgvPhieuDat.Rows.Add(item.ID_SP, ten, item.SOLUONG, item.THANHTIEN);
                        }
                    }
                }

            }
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            load();
        }

        public void add_giohang()
        {

            

            try
            {
                SanPham_BLLDAL sanpham1 = new SanPham_BLLDAL();
                Kho_BLLDAL kho = new Kho_BLLDAL();
                int id_pd = Convert.ToInt32(dgvPhieuDat.CurrentRow.Cells[0].Value);
                string ten = dgvPhieuDat.CurrentRow.Cells[1].Value.ToString();
                int soluong_pn = Convert.ToInt32(dgvPhieuDat.CurrentRow.Cells[2].Value);
                int tien = Convert.ToInt32(dgvPhieuDat.CurrentRow.Cells[3].Value);
                int dongia_b = 0;
                int dongia_n = 0;
                DateTime date = dtpHSD.Value;

                if (txtSoLuong.Text.Length != 0)
                {
                    soluong_pn = Convert.ToInt32(txtSoLuong.Text.ToString());
                }

                if (txtDonGiaBan.Text.Length != 0)
                {
                    dongia_b = Convert.ToInt32(txtDonGiaBan.Text.ToString());
                }



                foreach (DANHMUCSANPHAM item in kho.get_DataSP_NCC(idncc_g))
                {
                    if (item.ID_SP == id_pd)
                    {
                        dongia_n = Convert.ToInt32(item.GiaBan);
                        tien = Convert.ToInt32(soluong_pn * item.GiaBan);
                        if (dongia_b == 0)
                        {
                            foreach (SANPHAM item1 in sanpham1.get_DataSP())
                            {
                                if (item1.ID_SP == item.ID_SP)
                                {
                                    dongia_b = Convert.ToInt32(item1.DONGIA);
                                }
                            }
                        }
                        dgvPhieuNhap.Rows.Add(item.ID_SP, ten, soluong_pn, dongia_n, dongia_b, date, tien);
                        foreach (DataGridViewCell oneCell in dgvPhieuDat.SelectedCells)
                        {
                            if (oneCell.Selected)
                                dgvPhieuDat.Rows.RemoveAt(oneCell.RowIndex);
                        }
                        txtSoLuong.Clear();
                        txtDonGiaBan.Clear();

                    }
                }

                dgvPhieuNhap.Refresh();
                tongtien();
            }
            catch (Exception)
            {
                MessageBox.Show("Sản phẩm không tồn tại");
                return;
            }
        }

        private void dgvPhieuDat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            add_giohang();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            load();
            dgvPhieuNhap.Rows.Clear();
            dgvPhieuNhap.Refresh();
        }

        public void load_thongtin()
        {
            Kho_BLLDAL kho = new Kho_BLLDAL();
            foreach (NHACUNGCAP item in kho.get_DataNCC())
            {
                if (item.ID_NCC == idncc_g)
                {
                    txtNCC.Text = item.TENNCC.ToString();
                }
            }

            PHIEUNHAP pn = kho.get_DataPNCuoi();
            if (pn != null)
            {
                txtID.Text = (pn.ID_PN + 1).ToString();
            }
            else
                txtID.Text = 1.ToString();
        }

        private void dgvPhieuNhap_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            tongtien();
        }

        private void dgvPhieuNhap_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            tongtien();
        }

        private void dgvPhieuNhap_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            tongtien();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text.Length != 0)
            {
                dgvPhieuNhap.CurrentRow.Cells[2].Value = Convert.ToInt32(txtSoLuong.Text);
                txtSoLuong.Clear();
            }

            if (txtDonGiaBan.Text.Length != 0)
            {
                dgvPhieuNhap.CurrentRow.Cells[4].Value = Convert.ToInt32(txtDonGiaBan.Text);
                txtDonGiaBan.Clear();
            }
            tongtien();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            luu();
        }

        public void tongtien()
        {
            int tong = 0;
            for (int i = 0; i < dgvPhieuNhap.RowCount; i++)
            {
                dgvPhieuNhap.Rows[i].Cells[6].Value = Convert.ToInt32(dgvPhieuNhap.Rows[i].Cells[2].Value) * Convert.ToInt32(dgvPhieuNhap.Rows[i].Cells[3].Value);
                tong += Convert.ToInt32(dgvPhieuNhap.Rows[i].Cells[6].Value);
            }
            txtTongTien.Text = tong.ToString();
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.RowCount > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dgvPhieuNhap.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dgvPhieuNhap.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvPhieuNhap.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvPhieuNhap.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgvPhieuNhap.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }

        public void luu()
        {
            Kho_BLLDAL kho = new Kho_BLLDAL();
            int dem = 0;
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn!", "Thông báo!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool check = kho.insert_PhieuNhap(idncc_g, Program.mainForm.User, dtpNgayLap.Value, Convert.ToInt32(txtTongTien.Text));
                if (check)
                {
                    for (int i = 0; i < dgvPhieuNhap.RowCount; i++)
                    {
                        int pNhap = Convert.ToInt32(txtID.Text);
                        int pSP = Convert.ToInt32(dgvPhieuNhap.Rows[i].Cells[0].Value);
                        int pSL = Convert.ToInt32(dgvPhieuNhap.Rows[i].Cells[2].Value);
                        int pGN = Convert.ToInt32(dgvPhieuNhap.Rows[i].Cells[3].Value);
                        int pGB = Convert.ToInt32(dgvPhieuNhap.Rows[i].Cells[4].Value);
                        DateTime pHSD = (DateTime)dgvPhieuNhap.Rows[i].Cells[5].Value;
                        int pTT = Convert.ToInt32(dgvPhieuNhap.Rows[i].Cells[6].Value);
                        bool check1 = kho.insert_CTPN(pNhap, idpd_g, pSP, pSL, pGN, pGB, pTT);
                        if (check1)
                        {
                            dem++;
                        }
                    }
                }
                if (dem == dgvPhieuNhap.RowCount)
                {
                    MessageBox.Show("Thêm thành công!");
                    if (kho.dem_CTPN(idpd_g) == kho.dem_CTPD(idpd_g))
                    {
                        kho.update_PhieuDat(idpd_g);
                    }
                }
                else
                    MessageBox.Show("Thêm không thành công!");
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}
