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
    public partial class frmLuuHD : Form
    {
        BanHang_BLLDAL banhang = new BanHang_BLLDAL();
        public List<Ado.GioHang> giohang = new List<Ado.GioHang>();
        public int maKM;
        public int maKH;
        public int tongtien;
        public string id_NV;
        public frmLuuHD()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int dem = 0;
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn!", "Thông báo!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool check = banhang.insert_HoaDon(dtpNgayLap.Value, id_NV, maKH, maKM, tongtien);
                if (check)
                {
                    if (maKH != 0)
                    {
                        banhang.update_KhachHang(maKH, tongtien / 10000);
                    }
                    foreach (Ado.GioHang item in giohang)
                    {
                        bool check1 = banhang.insert_CTHoaDon(Convert.ToInt32(txtID.Text), item.Id, item.Soluong, item.Dongia, item.Thanhtien);
                        if (check1)
                        {
                            banhang.update_SanPham(item.Id, item.Soluong);
                            dem++;
                        }
                    }
                }
                if (dem == giohang.Count)
                {
                    MessageBox.Show("Thêm thành công!");
                }
                else
                    MessageBox.Show("Thêm không thành công!");
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void frmLuuHD_Load(object sender, EventArgs e)
        {
            load();
        }

        public void load()
        {
            txtTongTien.Text = tongtien.ToString();
            if (maKH > 0)
            {
                txtIDKM.Text = maKM.ToString();
            }

            if (maKH > 0)
            {
                txtIDKH.Text = maKH.ToString();
            }

            txtIDNV.Text = id_NV.ToString();

            txtID.Enabled = false;
            txtTongTien.Enabled = false;
            txtIDKM.Enabled = false;
            txtIDKH.Enabled = false;
            dtpNgayLap.Enabled = false;
            txtIDNV.Enabled = false;

            HOADON hd = new HOADON();
            hd = banhang.get_DataHDCuoi();
            txtID.Text = (hd.ID_HD + 1).ToString();

            dgvSP.DataSource = giohang;
        }
    }
}
