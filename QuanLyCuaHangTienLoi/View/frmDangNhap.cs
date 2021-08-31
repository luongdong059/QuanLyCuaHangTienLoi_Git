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
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        PhanQuyen_BLLDAL phanquyen = new PhanQuyen_BLLDAL();
        public frmDangNhap()
        {
            InitializeComponent();
            this.CenterToScreen();
            txtMatKhau.UseSystemPasswordChar = true;
        }

        Ado.QL_DangNhap dangnhap = new Ado.QL_DangNhap();
        public static frmDoiMatKhau reset = null;

        public void ProcessConfig()
        {
            Program.errorserver = new View.frmError();
            Program.errorserver.Show();
        }
        public void ProcessLogin()
        {

            if (phanquyen.check_dangnhap(txtTenDN.Text, txtMatKhau.Text))
            {
                if (phanquyen.check_hoatdong(txtTenDN.Text))
                {
                    if (Program.mainForm == null || Program.mainForm.IsDisposed)
                    {
                        Program.mainForm = new View.frmTrangChu();
                    }
                    Program.mainForm.User = txtTenDN.Text.ToString();
                    Program.reset.User = txtTenDN.Text.ToString();
                    Program.mainForm.Show();
                    Program.login.Hide();
                }
                else
                    MessageBox.Show("Tài khoản bị khóa");

            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập Hoặc sai mật khẩu");               
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtTenDN.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống Tên đăng nhập");
                this.txtTenDN.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtMatKhau.Text))
            {
                MessageBox.Show("Không được bỏ trống Mật khẩu");
                this.txtMatKhau.Focus();
                return;
            }
            ProcessLogin();
        }

        private void txtTenDN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                errorProvider1.SetError(txtTenDN, "Vui lòng không nhập kí tự đặc biệt");
            }
            else
                errorProvider1.SetError(txtTenDN, null);
        }

        private void chkHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThiMatKhau.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
                txtMatKhau.UseSystemPasswordChar = true;
        }

        private void hplQuenMK_Click(object sender, EventArgs e)
        {
            Program.reset_pass = new View.frmQuenMatKhau();
            Program.reset_pass.ShowDialog();
        }

        private void txtTenDN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click("",e);
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click("", e);
            }
        }
    }
}
