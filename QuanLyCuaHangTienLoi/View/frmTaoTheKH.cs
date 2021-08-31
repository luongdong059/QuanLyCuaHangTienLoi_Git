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
    public partial class frmTaoTheKH : Form
    {
        BanHang_BLLDAL banhang = new BanHang_BLLDAL();
        public frmTaoTheKH()
        {
            this.CenterToParent();
            InitializeComponent();
            rdoNam.Checked = true;
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.ToString();
            string sdt = txtSDT.Text.ToString();
            string diachi = txtDiaChi.Text.ToString();
            string gioitinh = "Nam";
            if (rdoNam.Checked)
            {
                gioitinh = "Nam";
            }
            else
                gioitinh = "Nữ";

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn!", "Thông báo!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (txtTen.Text.Length != 0 && txtDiaChi.Text.Length != 0 && txtSDT.Text.Length != 0)
                {
                    bool check = banhang.insert_KhachHang(ten, gioitinh, diachi, sdt, 0);
                    if (check)
                    {
                        MessageBox.Show("Thêm thành công!");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Thêm không thành công!");
                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
