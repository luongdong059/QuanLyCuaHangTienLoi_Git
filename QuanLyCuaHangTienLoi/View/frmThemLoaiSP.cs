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
    public partial class frmThemLoaiSP : Form
    {
        
        Kho_BLLDAL kho = new Kho_BLLDAL();
        public frmThemLoaiSP()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            SanPham_BLLDAL sanpham = new SanPham_BLLDAL();
            if ((sanpham.get_DataLSP()) != null)
            {
                dgvNhomSP.DataSource = sanpham.get_DataLSP();
                btnLuu.Enabled = false;
                txtTenNhom.Enabled = false;
            }
            else
                MessageBox.Show("Nhóm sản phẩm rỗng");

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            txtTenNhom.Enabled = true;
            txtTenNhom.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenNhom.Text.Length != 0)
            {
                try
                {
                    bool check = kho.insert_LoaiSP(txtTenNhom.Text.ToString());
                    if (check)
                    {
                        MessageBox.Show("Thêm thành công");
                        load();
                        txtTenNhom.Clear();
                    }
                    else
                        MessageBox.Show("Thêm không thành công");
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm thành công");
                    return;
                    throw;
                }
            }
        }

        private void dgvNhomSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvNhomSP.RowCount != 0)
                {
                    SanPham_BLLDAL sanpham = new SanPham_BLLDAL();
                    btnLuu.Enabled = false;
                    txtTenNhom.Enabled = false;
                    txtTenNhom.Text = dgvNhomSP.CurrentRow.Cells[1].Value.ToString();
                    int a = 0;
                    foreach (SANPHAM item in sanpham.get_DataSP_LSP(Convert.ToInt32(dgvNhomSP.CurrentRow.Cells[0].Value)))
                    {
                        a++;
                    }
                    if (a != 0)
                    {
                        lblTong.Text = a.ToString();
                    }
                    else
                        lblTong.Text = "...";
                }
                else MessageBox.Show("Danh sách nhóm sản phẩm rỗng");
            }
            catch (Exception)
            {
                btnLuu.Enabled = false;
                txtTenNhom.Enabled = false;
                throw;
            }
        }
    }
}
