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
    public partial class frmDatHang : Form
    {
        Kho_BLLDAL kho = new Kho_BLLDAL();
        SanPham_BLLDAL sanpham = new SanPham_BLLDAL();
        NguoiDung_BLLDAL nguoidung = new NguoiDung_BLLDAL();
        public frmDatHang()
        {
            InitializeComponent();
            this.CenterToScreen();
            load();
            get_IdPD();
        }

        public void load()
        {
            load_CbxNguoiDung();
            load_CbxNCC();
            load_SP();
        }

        public void load_CbxNguoiDung()
        {
            cbxNhanVien.DataSource = nguoidung.get_DanhMucND();
            cbxNhanVien.DisplayMember = "Ten";
            cbxNhanVien.ValueMember = "ID_DN";
            cbxNhanVien.SelectedValue = Program.mainForm.User;
        }

        public void load_CbxNCC()
        {
            cbxNCC.DataSource = kho.get_DataNCC();
            cbxNCC.DisplayMember = "TenNCC";
            cbxNCC.ValueMember = "ID_NCC";
            cbxNCC.SelectedIndex = 0;
        }

        public void load_SP()
        {
            SanPham_BLLDAL sanpham1 = new SanPham_BLLDAL();
            dgvSanPham.Rows.Clear();
            dgvSanPham.Refresh();
            //string link_img = "E:\\Phát triền phần mềm và ứng dụng thông minh\\Đồ án\\QuanLyCuaHangTienLoi\\img\\img_sp\\";
            Image img = null;

            if (cbxNCC.SelectedValue == null)
            {
                foreach (SANPHAM item in sanpham1.get_DataSP())
                {

                    try
                    {
                        if (item.HINHANH != null)
                        {
                            img = Image.FromFile(Application.StartupPath + "\\img\\img_sp\\" + item.HINHANH);
                        }
                        else
                            img = Image.FromFile(Application.StartupPath + "\\img\\img_sp\\product.png");
                    }
                    catch (Exception)
                    {

                        img = Image.FromFile(Application.StartupPath + "\\img\\img_sp\\product.png");
                    }


                    dgvSanPham.Rows.Add(item.ID_SP, item.TENSP, "", img);
                }
            }

            else
            {
                foreach (DANHMUCSANPHAM item in kho.get_DataSP_NCC(Convert.ToInt32(cbxNCC.SelectedValue)))
                {
                    string ten = "";
                    foreach (SANPHAM item1 in sanpham1.get_DataSP())
                    {

                        if (item.ID_SP == item1.ID_SP)
                        {

                            try
                            {
                                if (item1.HINHANH != null)
                                {
                                    img = Image.FromFile(Application.StartupPath + "\\img\\img_sp\\" + item1.HINHANH);
                                }
                                else
                                    img = Image.FromFile(Application.StartupPath + "\\img\\img_sp\\product.png");
                            }
                            catch (Exception)
                            {

                                img = Image.FromFile(Application.StartupPath + "\\img\\img_sp\\product.png");
                            }
                            ten = item1.TENSP.ToString();
                        }
                    }
                    dgvSanPham.Rows.Add(item.ID_SP, ten, item.GiaBan, img);
                }
            }
        }

        public void get_IdPD()
        {
            Kho_BLLDAL kho1 = new Kho_BLLDAL();
            PHIEUDAT pd = kho1.get_DataPDCuoi();
            txtIDPD.Text = (pd.ID_PD + 1).ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lammoi();
        }

        public void lammoi()
        {
            lblTongSP.Text = "...";
            lblTongTien.Text = "...";
            txtSoLuong.Clear();
            get_IdPD();
            dgvGioHang.Rows.Clear();
            dgvGioHang.Refresh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (this.dgvSanPham.SelectedRows.Count > 0)
            {
                add_giohang(Convert.ToInt32(dgvSanPham.CurrentRow.Cells[0].Value));
                txtSoLuong.Clear();
            }
            else
                MessageBox.Show("Vui lòng chọn sản phẩm!");
        }

        public void add_giohang(int id)
        {
            try
            {
                int soluong = 1;
                if (txtSoLuong.Text.Length != 0)
                {
                    soluong = Convert.ToInt32(txtSoLuong.Text.ToString());
                }
                SanPham_BLLDAL sanpham1 = new SanPham_BLLDAL();
                foreach (SANPHAM item in sanpham1.get_DataSP())
                {
                    if (item.ID_SP == id)
                    {
                        int giab = Convert.ToInt32(dgvSanPham.CurrentRow.Cells[2].Value);
                        dgvGioHang.Rows.Add(item.ID_SP, item.TENSP, soluong, giab, soluong * giab);
                    }
                }

                dgvGioHang.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Sản phẩm không tồn tại");
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (this.dgvGioHang.SelectedRows.Count > 0)
            {
                dgvGioHang.Rows.RemoveAt(this.dgvGioHang.SelectedRows[0].Index);
                tongtien();
            }
        }

        private void dgvSanPham_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            add_giohang(Convert.ToInt32(dgvSanPham.CurrentRow.Cells[0].Value));
        }

        private void dgvGioHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            capnhat();
            tongtien();
        }

        public void capnhat()
        {
            for (int i = 0; i < dgvGioHang.RowCount; i++)
            {
                dgvGioHang.Rows[i].Cells[4].Value = Convert.ToInt32(dgvGioHang.Rows[i].Cells[2].Value) * Convert.ToInt32(dgvGioHang.Rows[i].Cells[3].Value);
            }
        }

        public void tongtien()
        {
            int sum = 0;
            int dem = 0;
            for (int i = 0; i < dgvGioHang.Rows.Count; i++)
            {
                dem++;
                sum += Convert.ToInt32(dgvGioHang.Rows[i].Cells[4].Value);

            }
            lblTongTien.Text = sum.ToString();
            lblTongSP.Text = dem.ToString();
        }

        private void dgvGioHang_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            tongtien();
        }

        private void dgvGioHang_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            tongtien();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int dem = 0;
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn!", "Thông báo!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (dgvGioHang.RowCount > 0)
                {
                    bool check = kho.insert_PhieuDat(Convert.ToInt32(cbxNCC.SelectedValue), cbxNhanVien.SelectedValue.ToString(), dtpNgayDat.Value, Convert.ToInt32(lblTongTien.Text));
                    if (check)
                    {
                        foreach (Ado.GioHang item in get_DataGioHang())
                        {

                            int a = Convert.ToInt32(txtIDPD.Text);
                            int b = item.Id;
                            int c = item.Soluong;
                            int d = Convert.ToInt32(item.Thanhtien);
                            bool check1 = kho.insert_CTPD(a, b, c, d);
                            if (check1)
                            {
                                dem++;
                            }
                        }
                    }
                    if (dem == get_DataGioHang().Count)
                    {
                        MessageBox.Show("Thêm thành công!");
                    }
                    else
                        MessageBox.Show("Thêm không thành công!");
                }
                else
                    MessageBox.Show("Giỏ hàng rỗng!");
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        public List<Ado.GioHang> get_DataGioHang()
        {

            List<Ado.GioHang> lst = new List<Ado.GioHang>();

            foreach (DataGridViewRow row in dgvGioHang.Rows)
            {
                bool check = false;
                Ado.GioHang gh = new Ado.GioHang();
                gh.Id = Convert.ToInt32(row.Cells["id"].Value);
                gh.Soluong = Convert.ToInt32(row.Cells["soluong"].Value);
                gh.Thanhtien = float.Parse(row.Cells["thanhtien"].Value.ToString());
                foreach (Ado.GioHang item in lst)
                {
                    if (item.Id == gh.Id)
                    {
                        item.Soluong += gh.Soluong;
                        item.Thanhtien += float.Parse(row.Cells["thanhtien"].Value.ToString());
                        check = true;
                    }
                }

                if (!check)
                {
                    lst.Add(gh);
                }
                //More code here
            }
            return lst;
        }

        private void cbxNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            SanPham_BLLDAL sanpham1 = new SanPham_BLLDAL();
            dgvSanPham.Rows.Clear();
            dgvSanPham.Refresh();
            //string link_img = "E:\\Phát triền phần mềm và ứng dụng thông minh\\Đồ án\\QuanLyCuaHangTienLoi\\img\\img_sp\\";
            Image img = null;
            NHACUNGCAP a = (NHACUNGCAP)cbxNCC.SelectedItem;
            int x = a.ID_NCC;
            foreach (DANHMUCSANPHAM item in kho.get_DataSP_NCC(x))
            {
                string ten = "";
                foreach (SANPHAM item1 in sanpham1.get_DataSP())
                {

                    if (item.ID_SP == item1.ID_SP)
                    {

                        try
                        {
                            if (item1.HINHANH != null)
                            {
                                img = Image.FromFile(Application.StartupPath + "\\img\\img_sp\\" + item1.HINHANH);
                            }
                            else
                                img = Image.FromFile(Application.StartupPath + "\\img\\img_sp\\product.png");
                        }
                        catch (Exception)
                        {

                            img = Image.FromFile(Application.StartupPath + "\\img\\img_sp\\product.png");
                        }
                        ten = item1.TENSP.ToString();
                    }
                }
                dgvSanPham.Rows.Add(item.ID_SP, ten, item.GiaBan, img);
            }
        }

        private void cbxNCC_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.RowCount > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dgvGioHang.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dgvGioHang.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvGioHang.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvGioHang.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgvGioHang.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
    }
}
