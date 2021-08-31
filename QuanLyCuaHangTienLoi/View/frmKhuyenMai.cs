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
    public partial class frmKhuyenMai : Form
    {
        BanHang_BLLDAL banhang = new BanHang_BLLDAL();
        public frmKhuyenMai()
        {
            InitializeComponent();
            load();
            enable_false();
        }

        public void load()
        {
            dgvKM.DataSource = banhang.get_DataKM();
        }

        public void enable_true()
        {
            txtTenKM.Enabled = true;
            txtChuThich.Enabled = true;
            dtpNgayBd.Enabled = true;
            dtpNgayKt.Enabled = true;
            btnChon.Enabled = false;
            btnLuu.Enabled = true;
        }

        public void enable_false()
        {
            txtTenKM.Enabled = false;
            txtChuThich.Enabled = false;
            dtpNgayBd.Enabled = false;
            dtpNgayKt.Enabled = false;
            btnChon.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void dgvKM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            enable_false();
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (txtTenKM.Text.Length != 0 && dtpNgayBd.Text.Length != 0 && dtpNgayKt.Text.Length != 0)
            {
                try
                {
                    bool check = banhang.insert_KhuyenMai(txtTenKM.Text, dtpNgayBd.Value, dtpNgayKt.Value, txtChuThich.Text);
                    if (check)
                    {
                        MessageBox.Show("Thêm thành công!");
                    }
                    else
                        MessageBox.Show("Thêm không thành công!");
                }
                catch (Exception)
                {

                    MessageBox.Show("Thêm không thành công!");
                    return;
                }
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            enable_true();
        }

        private void btnChon_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(dgvKM.CurrentRow.Cells[0].Value.ToString().Trim());
            if (id > 0)
            {
                Program.banhang.id_km = id;
                MessageBox.Show("Mã khuyến mãi đã được lựa chọn: " + id);
                this.Close();
            }
            else
                MessageBox.Show("Vui lòng chọn 1 mã khuyến mãi!");
        }
    }
}
