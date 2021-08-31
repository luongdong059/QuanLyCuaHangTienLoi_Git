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
    public partial class frmTrangChu : Form
    {
        NguoiDung_BLLDAL nguoidung = new NguoiDung_BLLDAL();
        PhanQuyen_BLLDAL phanquyen = new PhanQuyen_BLLDAL();
        public string User = "";/*{ get => user; set => user = value; }*/
        public frmTrangChu()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            customizeDesing();
            this.CenterToScreen();

            
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            NGUOIDUNG nd = new NGUOIDUNG();
            
            try
            {
                nd = nguoidung.get_Info(User);
                label1.Text = "NV: " + nd.TEN.ToString();
                Image img = Image.FromFile(Application.StartupPath + "\\img\\"+nd.HINH);
                imgUser.Image = img; //"E:\\Phát triền phần mềm và ứng dụng thông minh\\Đồ án\\QuanLyCuaHangTienLoi\\img\\"+nd.HINH;
            }
            catch (Exception)
            {
                nd = nguoidung.get_Info(User);
                label1.Text = "NV: " + nd.TEN.ToString();
                Image img = Image.FromFile(Application.StartupPath + "\\img\\profile1.png");
            }

            load_phanquyen();
        }
        private void customizeDesing()
        {
            panelTaiKhoanSubmenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panelTaiKhoanSubmenu.Visible == true)
                panelTaiKhoanSubmenu.Visible = false;
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            showSubmenu(panelTaiKhoanSubmenu);
        }

        private void btnThongTinTK_Click(object sender, EventArgs e)
        {
            openChildForm(new View.frmThongTinTaiKhoan());
            hideSubmenu();
        }

        private void btnThayDoiMK_Click(object sender, EventArgs e)
        {
            openChildForm(new View.frmDoiMatKhau());
            hideSubmenu();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            openChildForm(new View.frmSanPham());
            hideSubmenu();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            openChildForm(Program.banhang = new  View.frmBanHang());
            hideSubmenu();
        }

        private void btnQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            openChildForm(new View.frmQuanLyND());
            hideSubmenu();
        }

        private void btnTroGiup_Click(object sender, EventArgs e)
        {
            openChildForm(new View.frmTroGiup());
            hideSubmenu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            hideSubmenu();
        }

        private void frmTrangChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.login.Show();
            if (Program.banhang != null)
            {
                Program.banhang.Close();
            }
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            openChildForm(new View.frmKho());
            hideSubmenu();
        }

        public void load_phanquyen()
        {
            foreach (NGUOIDUNGNHOMNGUOIDUNG item in phanquyen.get_Data_Nhom(User))
            {
                foreach (PHANQUYEN item1 in phanquyen.get_Data_ManHinh(item.ID_NHOM))
                {
                    CheckAllButtonChildVisiable(item1.ID_MANHINH);
                }
            }
        }

        private void CheckAllButtonChildVisiable(int tag)
        {

            foreach (System.Windows.Forms.Control bt in panelSlideMenu.Controls)

            {
                if (bt.GetType().ToString() == "System.Windows.Forms.Button")
                {
                    if (bt.Tag != null)
                    {
                        if (bt.Tag.Equals(tag.ToString()))
                        {
                            bt.Visible = true;
                        }
                    }
                }
            }
        }
    }
}
