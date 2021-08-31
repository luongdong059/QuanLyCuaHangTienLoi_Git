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
    public partial class frmThemNCC : Form
    {
        Kho_BLLDAL kho = new Kho_BLLDAL();
        public frmThemNCC()
        {
            InitializeComponent();
            enable_false();
            load();
        }


        public void load()
        {
            Kho_BLLDAL kho = new Kho_BLLDAL();
            SanPham_BLLDAL sanpham = new SanPham_BLLDAL();

            if (kho.get_DataNCC() != null)
            {
                dgvDanhSachNCC.DataSource = kho.get_DataNCC();
            }

            if (sanpham.get_DataSP() != null)
            {
                cbxSanPham.DataSource = sanpham.get_DataSP();
                cbxSanPham.DisplayMember = "TenSP";
                cbxSanPham.ValueMember = "ID_SP";
            }
        }

        public void enable_true()
        {
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
            txtTenNCC.Enabled = true;
            btnLuu.Enabled = true;
        }

        public void enable_false()
        {
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;
            txtTenNCC.Enabled = false;
            btnLuu.Enabled = false;
        }
        private void btnDMSP_Click(object sender, EventArgs e)
        {
            getSP_NCC();

        }

        public void getSP_NCC()
        {
            dgvDMSP.Rows.Clear();
            dgvDMSP.Refresh();
            int a = Convert.ToInt32(dgvDanhSachNCC.CurrentRow.Cells[0].Value);
            SanPham_BLLDAL sanpham1 = new SanPham_BLLDAL();
            string ten = "";

            foreach (DANHMUCSANPHAM item in kho.get_DataSP_NCC(a))
            {
                foreach (SANPHAM i in sanpham1.get_DataSP())
                {
                    if (item.ID_SP == i.ID_SP)
                    {
                        ten = i.TENSP;
                        dgvDMSP.Rows.Add(item.ID_SP, ten, item.GiaBan);
                    }
                }



            }
        }

        private void dgvDanhSachNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                enable_false();
                txtTenNCC.Text = dgvDanhSachNCC.CurrentRow.Cells[1].Value.ToString();
                txtDiaChi.Text = dgvDanhSachNCC.CurrentRow.Cells[2].Value.ToString();
                txtSDT.Text = dgvDanhSachNCC.CurrentRow.Cells[3].Value.ToString();
                getSP_NCC();
            }
            catch (Exception)
            {
                enable_false();
                throw;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            enable_true();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtTenNCC.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenNCC.Text.Length != 0 && txtSDT.Text.Length != 0 && txtDiaChi.Text.Length != 0)
            {
                bool check = kho.insert_NCC(txtTenNCC.Text, txtDiaChi.Text, txtSDT.Text);
                if (check)
                {
                    MessageBox.Show("Thêm thành công!");
                }
                else
                    MessageBox.Show("Thêm không thành công!");
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
        }

        private void dgvDMSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cbxSanPham.SelectedValue = dgvDMSP.CurrentRow.Cells[0].Value;
                txtGiaBan.Text = dgvDMSP.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception)
            {
                enable_false();
                throw;
            }
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            enable_false();
            int a = Convert.ToInt32(dgvDanhSachNCC.CurrentRow.Cells[0].Value);

            if (a >= 0)
            {
                if (txtGiaBan.Text.Length != 0 && cbxSanPham.SelectedIndex >= 0)
                {
                    bool check = kho.insert_SP_NCC(a, Convert.ToInt32(cbxSanPham.SelectedValue),Convert.ToInt32(txtGiaBan.Text));
                    if (check)
                    {
                        MessageBox.Show("Thêm thành công!");
                        getSP_NCC();
                    }
                    else
                        MessageBox.Show("Thêm không thành công!");
                }
                else
                    MessageBox.Show("Vui lòng chọn sản phẩm và giá bán!");
            }
            else
                MessageBox.Show("Vui lòng chọn nhà cung cấp!");

        }
    }
}
