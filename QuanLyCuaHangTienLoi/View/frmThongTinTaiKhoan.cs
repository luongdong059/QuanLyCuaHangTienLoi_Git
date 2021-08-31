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
    public partial class frmThongTinTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        private string user = "";
        NguoiDung_BLLDAL nguoidung = new NguoiDung_BLLDAL();
        public frmThongTinTaiKhoan()
        {
            InitializeComponent();
            
            btnLuu.Enabled = false;
        }

        public void getData()
        {
            Enable_false();
            NGUOIDUNG nd = nguoidung.get_Info(user);
            txtTenDangNhap.Text = user;
            txtDiaChi.Text = nd.DIACHI.ToString();
            txtHoTen.Text = nd.TEN.ToString();
            txtSDT.Text = nd.SDT.ToString();
            dtpNgaySinh.Value = (DateTime)nd.NGAYSINH;
            lblTinhTrang.Text = nd.TINHTRANG.ToString();
            Image img = null;
            if (nd.HINH == null)
            {
                
                img = Image.FromFile(Application.StartupPath + "\\img\\profile1.png");
            }
            else
                img = Image.FromFile(Application.StartupPath + "\\img\\" + nd.HINH.ToString());

            imgUser.Image = img;

            if (String.Compare(nd.GIOITINH.ToString(), "NAM", true) == 0)
            {
                rdoNam.Checked = true;
            }
            else
                rdoNu.Checked = true;

        }

        public void Enable_false()
        {
            rdoNam.Checked = true;
            txtTenDangNhap.Enabled = false;
            txtDiaChi.Enabled = false;
            txtHoTen.Enabled = false;
            txtSDT.Enabled = false;
            dtpNgaySinh.Enabled = false;
        }

        public void Enable_true()
        {
            rdoNam.Checked = true;
            txtTenDangNhap.Enabled = false;
            txtDiaChi.Enabled = true;
            txtHoTen.Enabled = true;
            txtSDT.Enabled = true;
            dtpNgaySinh.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            Enable_true();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ten = txtHoTen.Text.ToString();
            string sdt = txtSDT.Text.ToString();
            DateTime ngaysinh = dtpNgaySinh.Value;
            string diachi = txtDiaChi.Text.ToString();
            string gioitinh = "Nam";
            if (rdoNam.Checked)
            {
                gioitinh = "Nam";
            }
            else
                gioitinh = "Nữ";


            DialogResult dialogResult = MessageBox.Show("Thông báo", "Bạn có chắc chắn!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (txtTenDangNhap.Text.Length != 0)
                {
                    if (txtHoTen.Text.Length != 0 && txtDiaChi.Text.Length != 0 && txtSDT.Text.Length != 0)
                    {
                        bool check = nguoidung.update_Info(user, ten, sdt, diachi, ngaysinh, gioitinh);
                        if (check)
                        {
                            MessageBox.Show("Cập nhật thành công!");
                        }
                        else
                            MessageBox.Show("Cập nhật không thành công!");
                    }
                }
                else
                    MessageBox.Show("Lỗi cập nhật!");
            }

           
        }

        private void frmThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            user = Program.mainForm.User;
            getData();
        }
    }
}
