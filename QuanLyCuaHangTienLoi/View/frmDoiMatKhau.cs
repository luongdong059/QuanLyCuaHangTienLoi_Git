﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangTienLoi.View
{
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public string User = "";//{ get => user; set => user = value; }

        public frmDoiMatKhau()
        {
            
            InitializeComponent();
            btnCapNhat.Enabled = false;
            txtMatKhau.UseSystemPasswordChar = true;
            txtNhapLaiMK.UseSystemPasswordChar = true;

        }

        public void ProcessReset()
        {
            if (checkuser() == 0)
            {

            }
            else
            {
                errorProvider1.SetError(txtTenDN, null);
                int check = Ado.QL_DangNhap.Reset_Pass(txtTenDN.Text, txtMatKhau.Text);
                if (check != 0)
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                    MessageBox.Show("Cập nhật không thành công");
            }
        }

        public int checkuser()
        {
            int result;
            result = Ado.QL_DangNhap.Check_User(txtTenDN.Text);

            if (result == 0)
            {
                errorProvider1.SetError(txtTenDN, "Tên đăng nhập không hợp lệ!");
                return 0;
            }
            // Account had been disabled
            else if (result == 1)
            {
                MessageBox.Show("Tài khoản bị khóa");
                btnCapNhat.Enabled = false;
                return 0;
            }
            else
            {
                errorProvider1.SetError(txtTenDN, null);
                return 1;
            }

        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            User = Program.mainForm.User;
            txtTenDN.Text = User;
            txtTenDN.Enabled = false;
        }

        private void txtMatKhau_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar) && !char.IsControl(e.KeyChar) && txtMatKhau.Text.Length >= 6)
            {
                e.Handled = false;
                errorProvider1.SetError(txtMatKhau, null);
            }
            else
            {
                errorProvider1.SetError(txtMatKhau, "Vui long nhap ky tu dac biet va do dai lon hon 6");
            }
        }

        private void txtNhapLaiMK_TextChanged_1(object sender, EventArgs e)
        {
            if (!txtNhapLaiMK.Text.ToString().Equals(txtMatKhau.Text.ToString()))
            {
                errorProvider1.SetError(txtNhapLaiMK, "Mật khẩu nhập lại không chính xác");
                btnCapNhat.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(txtNhapLaiMK, null);
                btnCapNhat.Enabled = true;
            }
        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc thay đổi thông tin", "Thông báo!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ProcessReset();
            }
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
    }
}
