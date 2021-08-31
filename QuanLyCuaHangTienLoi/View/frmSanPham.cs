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
    public partial class frmSanPham : Form
    {

        SanPham_BLLDAL sanpham = new SanPham_BLLDAL();
        //Khởi thạo đọc dữ liệu từ máy
        OpenFileDialog opf = new OpenFileDialog();
        public frmSanPham()
        {
            InitializeComponent();
            Enable_False();
            btnSua.Enabled = false;
            load();
            dgvSanPham.AllowUserToAddRows = false;
            txtTimKiem.Focus();
        }

        #region Sự kiện
        private void btnLoad_Click(object sender, EventArgs e)
        {

            opf.Filter = "Choose Image(*.jpg; *.png;*.gif)|*.jpg; *.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void cbxLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxloaisp_select();
        }
       
        private void btnXoa_Click(object sender, EventArgs e)
        {
            dgvSanPham.Rows.Clear();
            dgvSanPham.Refresh();
            Enable_False();
            txtTenSP.Clear();
            txtDVT.Clear();
            txtTimKiem.Clear();
            txtDonGia.Clear();
            pictureBox1.Image = null;
            btnSua.Enabled = false;
            load_SP();
        }     

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTenSP.Clear();
            txtDVT.Clear();
            txtDonGia.Clear();
            Enable_True();
            btnSua.Enabled = false;
            pictureBox1.Image = null;
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtTenSP.DataBindings.Clear();

                DataGridViewRow row = this.dgvSanPham.Rows[e.RowIndex];
                if (row.Cells["TenSP"].Value == null || row.Cells["dvt"].Value == null || row.Cells["dongia"].Value == null)
                {
                    txtTenSP.Text = "";
                    txtDVT.Text = "";
                    txtDonGia.Text = "";
                    pictureBox1.Image = null;
                    Enable_False();
                    sua_enable();
                }
                else
                {
                    txtTenSP.Text = row.Cells["TenSP"].Value.ToString().Trim();
                    txtDVT.Text = row.Cells["dvt"].Value.ToString().Trim();
                    txtDonGia.Text = row.Cells["dongia"].Value.ToString().Trim();
                    pictureBox1.Image = (Image)row.Cells["hinhanh"].Value;
                    Enable_False();
                    sua_enable();
                }    
                
            }
            catch (Exception)
            {

                txtTenSP.DataBindings.Clear();


                txtTenSP.Text = "";
                txtDVT.Text = "";
                txtDonGia.Text = "";
                pictureBox1.Image = null;
                Enable_False();
                sua_enable();
            }
        }            

        private void btnLuu_Click(object sender, EventArgs e)
        {
            them_sanpham();
        }
     
        private void btnSua_Click(object sender, EventArgs e)
        {
            sua_sanpham();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tim_sanpham();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            tim_sanpham();
        }

        #endregion

        #region Hàm xử lí
        //Sửa thông tin sản phẩm
        public void sua_sanpham()
        {
            pictureBox1.Image = null;

            LOAISANPHAM a = (LOAISANPHAM)cbxLoaiSP.SelectedItem;
            int idlsp = a.ID_LSP;
            int id = int.Parse(dgvSanPham.CurrentRow.Cells[0].Value.ToString().Trim());
            string img = get_nameIMG();

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin!", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (txtTenSP.Text.Length != 0 && txtDonGia.Text.Length != 0)
                {
                    bool check = sanpham.update_SanPham(id, txtTenSP.Text.ToString(), txtDVT.Text.ToString(), img, Convert.ToInt32(txtDonGia.Text));

                    if (check)
                    {
                        load_SP();
                        opf.FileName = "";
                        MessageBox.Show("Cập nhật thành công!");
                    }
                    else
                        MessageBox.Show("Cập nhật không thành công!");
                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }

        //Tìm kiếm sản phẩm
        public void tim_sanpham()
        {
            string tenloai = "";

            dgvSanPham.Rows.Clear();
            dgvSanPham.Refresh();

            

            //string link_img = "E:\\Phát triền phần mềm và ứng dụng thông minh\\Đồ án\\QuanLyCuaHangTienLoi\\img\\img_sp\\";
            Image img = null;
            int tong = 0;
            foreach (SANPHAM item in sanpham.get_DataSP_Search(txtTimKiem.Text.ToString()))
            {
                tong++;
                //DataGridViewRow row = (DataGridViewRow)dgvSanPham.Rows[0].Clone();
                //row.Cells[0].Value = item.ID_SP;
                //row.Cells[1].Value = item.TENSP;
                //row.Cells[2].Value = item.DVT;                            
                //row.Cells[4].Value = img;

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


                //Lấy tên loại sản phẩm
                foreach (LOAISANPHAM i in sanpham.get_DataLSP())
                {
                    if (item.ID_LSP == i.ID_LSP)
                    {
                        tenloai = i.TENLOAISANPHAM;
                    }
                }

                dgvSanPham.Rows.Add(item.ID_SP, item.TENSP, item.DVT, tenloai,item.SOLUONG,item.DONGIA, img);

            }

            lblTong.Text = tong.ToString();
        }

        //Thêm sản phẩm
        public void them_sanpham()
        {
            string imagepath = null;

            string imagePath = opf.FileName.ToString();
            if (!imagePath.Equals(""))
            {
                imagepath = get_nameIMG();
            }

            LOAISANPHAM a = (LOAISANPHAM)cbxLoaiSP.SelectedItem;
            int id = a.ID_LSP;

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thêm sản phẩm này!", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (txtTenSP.Text.Length != 0 && txtDonGia.Text.Length != 0)
                {
                    if (sanpham.get_TenSP(txtTenSP.Text.ToString()))
                    {
                        bool check = sanpham.insert_SanPham(txtTenSP.Text.ToString(), txtDVT.Text.ToString(), id, imagepath, Convert.ToInt32(txtDonGia.Text));
                        if (check)
                        {
                            opf.FileName = "";
                            load_SP();
                            MessageBox.Show("Thêm thành công!");
                        }
                        else
                            MessageBox.Show("Thêm không thành công!");
                    }
                    else
                        MessageBox.Show("Sản phẩm đã tồn tại!");

                }
                else
                {
                    MessageBox.Show("Vui lòng đầy đủ thông tin sản phẩm!");
                    txtTenSP.Focus();
                }
            }
        }

        //Lấy tên ảnh 
        public string get_nameIMG()
        {
            string imagepath = null;

            string imagePath = opf.FileName.ToString();
            if (!imagePath.Equals(""))
            {
                imagepath = imagePath.ToString();
                imagepath = imagepath.Substring(imagepath.LastIndexOf("\\"));
                imagepath = imagepath.Remove(0, 1);
            }

            return imagepath;
        }

        //Điều khiển button
        public void Enable_True()
        {
            txtTenSP.Enabled = true;
            txtDVT.Enabled = true;
            txtDonGia.Enabled = true;
            btnLuu.Enabled = true;
            btnLoad.Enabled = true;
        }

        public void Enable_False()
        {
            txtTenSP.Enabled = false;
            txtDVT.Enabled = false;
            txtDonGia.Enabled = false;
            btnLuu.Enabled = false;
            btnLoad.Enabled = false;
        }

        public void sua_enable()
        {
            btnSua.Enabled = true;
            txtTenSP.Focus();
            txtTenSP.Enabled = true;
            txtDVT.Enabled = true;
            btnLoad.Enabled = true;
            txtDonGia.Enabled = true;
        }

        //Lọc dữ liệu theo combobox
        public void cbxloaisp_select()
        {
            string tenloai = "";

            dgvSanPham.Rows.Clear();
            dgvSanPham.Refresh();

            //string link_img = "E:\\Phát triền phần mềm và ứng dụng thông minh\\Đồ án\\QuanLyCuaHangTienLoi\\img\\img_sp\\";
            Image img = null;
            int id;
            int tong = 0;

            LOAISANPHAM a = (LOAISANPHAM)cbxLoaiSP.SelectedItem;
            id = a.ID_LSP;

            foreach (SANPHAM item in sanpham.get_DataSP_LSP(id))
            {
                tong++;
                //DataGridViewRow row = (DataGridViewRow)dgvSanPham.Rows[0].Clone();
                //row.Cells[0].Value = item.ID_SP;
                //row.Cells[1].Value = item.TENSP;
                //row.Cells[2].Value = item.DVT;                            
                //row.Cells[4].Value = img;

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
                //Lấy tên loại sản phẩm
                foreach (LOAISANPHAM i in sanpham.get_DataLSP())
                {
                    if (item.ID_LSP == i.ID_LSP)
                    {
                        tenloai = i.TENLOAISANPHAM;
                    }
                }

                dgvSanPham.Rows.Add(item.ID_SP, item.TENSP, item.DVT, tenloai, item.SOLUONG, item.DONGIA, img);

            }
            lblTong.Text = tong.ToString();
        }

        //Load dữ liệu
        public void load()
        {
            load_Cbx_LoaiSP();
            load_SP();
        }

        public void load_SP()
        {
            dgvSanPham.Rows.Clear();
            dgvSanPham.Refresh();
            //loaisp.DataSource = sanpham.get_DataLSP();
            //loaisp.DisplayMember = "TenLoaiSanPham";
            //string link_img = "E:\\Phát triền phần mềm và ứng dụng thông minh\\Đồ án\\QuanLyCuaHangTienLoi\\img\\img_sp\\";
            Image img = null;
            int tong = 0;

            foreach (SANPHAM item in sanpham.get_DataSP())
            {
                string tenloai = "";
                tong++;
                //DataGridViewRow row = (DataGridViewRow)dgvSanPham.Rows[0].Clone();
                //row.Cells[0].Value = item.ID_SP;
                //row.Cells[1].Value = item.TENSP;
                //row.Cells[2].Value = item.DVT;                            
                //row.Cells[4].Value = img;


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

                //Lấy tên loại sản phẩm
                foreach (LOAISANPHAM i in sanpham.get_DataLSP())
                {
                    if (item.ID_LSP == i.ID_LSP)
                    {
                        tenloai = i.TENLOAISANPHAM;
                    }
                }


                dgvSanPham.Rows.Add(item.ID_SP, item.TENSP, item.DVT, tenloai,item.SOLUONG,item.DONGIA, img);
            }

            lblTong.Text = tong.ToString();
        }
        //Load dữ liệu lên combobox
        public void load_Cbx_LoaiSP()
        {
            cbxLoaiSP.DataSource = sanpham.get_DataLSP();
            cbxLoaiSP.ValueMember = "ID_LSP";
            cbxLoaiSP.DisplayMember = "TenLoaiSanPham";
            //cbxLoaiSP.SelectedIndex = 0;
        }

        #endregion

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
