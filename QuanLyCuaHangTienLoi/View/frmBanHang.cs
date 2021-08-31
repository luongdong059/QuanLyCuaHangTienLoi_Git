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
using ZXing;
using AForge.Video;
using AForge.Video.DirectShow;
using Xceed.Words.NET;
using System.Diagnostics;
using System.Xml;

namespace QuanLyCuaHangTienLoi.View
{
    public partial class frmBanHang : Form
    {
        //Xem số cam đang kết nối
        private FilterInfoCollection cameras;
        //Cam cụ thể
        private VideoCaptureDevice cam;

        BanHang_BLLDAL banhang = new BanHang_BLLDAL();
        SanPham_BLLDAL sanpham = new SanPham_BLLDAL();
        NguoiDung_BLLDAL nguoidung = new NguoiDung_BLLDAL();
        List<SANPHAM> giohang = new List<SANPHAM>();

        public int id_km = 0;

        public frmBanHang()
        {
            InitializeComponent();
            dgvSanPham.AllowUserToAddRows = false;
            dgvSP_Khach.AllowUserToAddRows = false;
            txtMaSP.Enabled = false;
            load();
        }


        public void load()
        {
            load_SP();
            load_CbxNguoiDung();
        }
        public void load_SP()
        {
            SanPham_BLLDAL sanpham1 = new SanPham_BLLDAL();
            dgvSanPham.Rows.Clear();
            dgvSanPham.Refresh();
            //string link_img = "E:\\Phát triền phần mềm và ứng dụng thông minh\\Đồ án\\QuanLyCuaHangTienLoi\\img\\img_sp\\";
            Image img = null;

            foreach (SANPHAM item in sanpham1.get_DataSP())
            {
                string tenloai = "";


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
                foreach (LOAISANPHAM i in sanpham1.get_DataLSP())
                {
                    if (item.ID_LSP == i.ID_LSP)
                    {
                        tenloai = i.TENLOAISANPHAM;
                    }
                }


                dgvSanPham.Rows.Add(item.ID_SP, item.TENSP, item.SOLUONG, item.DONGIA, img);
            }

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            tim_sanpham();
        }

        public void tim_sanpham()
        {
            string tenloai = "";

            dgvSanPham.Rows.Clear();
            dgvSanPham.Refresh();

            //string link_img = "E:\\Phát triền phần mềm và ứng dụng thông minh\\Đồ án\\QuanLyCuaHangTienLoi\\img\\img_sp\\";
            Image img = null;
            foreach (SANPHAM item in sanpham.get_DataSP_Search(txtTimKiem.Text.ToString()))
            {


                try
                {
                    if (item.HINHANH != null)
                    {
                        img = Image.FromFile(Application.StartupPath + "\\img\\img_sp\\" + item.HINHANH);
                    }
                    else
                        img = Image.FromFile(Application.StartupPath + "\\img\\img_sp\\product.png");


                    //Lấy tên loại sản phẩm
                    foreach (LOAISANPHAM i in sanpham.get_DataLSP())
                    {
                        if (item.ID_LSP == i.ID_LSP)
                        {
                            tenloai = i.TENLOAISANPHAM;
                        }
                    }

                    dgvSanPham.Rows.Add(item.ID_SP, item.TENSP, item.SOLUONG, item.DONGIA, img);
                }
                catch (Exception)
                {

                    return;
                }

            }
        }

        public void load_CbxNguoiDung()
        {
            cbxNhanVien.DataSource = nguoidung.get_DanhMucND();
            cbxNhanVien.DisplayMember = "Ten";
            cbxNhanVien.ValueMember = "ID_DN";
            cbxNhanVien.SelectedValue = Program.mainForm.User;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load_SP();
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            BanHang_BLLDAL banhang1 = new BanHang_BLLDAL();
            if (txtMaKH.Text.Length != 0)
            {
                try
                {
                    KHACHHANG kh = banhang1.get_DataKH(Convert.ToInt32(txtMaKH.Text));
                    if (kh != null)
                    {
                        lblTenKH.Text = kh.TENKH.ToString();
                        lblSDT.Text = kh.SDT.ToString();
                        lblDiem.Text = kh.DIEM.ToString();
                    }
                    else
                        MessageBox.Show("Không tồn tại khách hàng này!");
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        private void btnTaoThe_Click(object sender, EventArgs e)
        {
            View.frmTaoTheKH the = new frmTaoTheKH();
            the.ShowDialog();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTienKhach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTienHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvSP_Khach_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            tongtien();
        }

        private void dgvSanPham_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            add_giohang(Convert.ToInt32(dgvSanPham.CurrentRow.Cells[0].Value));
        }

        public void add_giohang(int id)
        {
            try
            {
                SanPham_BLLDAL sanpham1 = new SanPham_BLLDAL();
                int soluong = 1;
                if (txtSoLuong.Text.Length != 0)
                {
                    soluong = Convert.ToInt32(txtSoLuong.Text.ToString());
                }

                string donvitinh = "";
                int? gia = 0;
                foreach (SANPHAM item in sanpham1.get_DataSP())
                {
                    if (item.ID_SP == id)
                    {
                        if (soluong <= item.SOLUONG)
                        {
                            donvitinh = item.DVT.ToString();
                            gia = item.DONGIA;
                            dgvSP_Khach.Rows.Add(item.ID_SP, item.TENSP, donvitinh, soluong, gia, soluong * gia);
                            txtSoLuong.Clear();
                        }
                        else if (item.SOLUONG <= 0 || item.SOLUONG == null)
                        {
                            MessageBox.Show("Sản phẩm đã hết!");
                        }
                        else
                            MessageBox.Show("Sản phẩm không đủ số lượng!");

                    }
                }

                dgvSP_Khach.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Sản phẩm không tồn tại");
                return;
            }
        }

        private void dgvSP_Khach_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            tongtien();
        }

        public void tongtien()
        {
            int sum = 0;
            for (int i = 0; i < dgvSP_Khach.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgvSP_Khach.Rows[i].Cells[5].Value);

            }
            txtTienHang.Text = sum.ToString();

            if (txtPTCK.Text.Length != 0)
            {
                float x = float.Parse(txtPTCK.Text.ToString());
                float y = sum * x / 100;
                txtTienCK.Text = y.ToString();
                txtTongCong.Text = (sum - y).ToString();
            }
            else
                txtTongCong.Text = sum.ToString();
        }

        private void txtPTCK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtTienCK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTienKhach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (txtTongCong.Text.Length != 0 && txtTienKhach.Text.Length != 0)
                    {
                        float x = float.Parse(txtTongCong.Text.ToString());
                        float y = float.Parse(txtTienKhach.Text.ToString());
                        if (y > x)
                        {
                            txtTienTra.Text = (y - x).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Khách đưa thiếu tiền!");
                            txtTienKhach.Clear();
                            txtTienKhach.Focus();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Khách đưa thiếu tiền!");
                    txtTienKhach.Clear();
                    txtTienKhach.Focus();
                    return;
                }
            }
        }

        private void txtPTCK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tongtien();
                txtTienKhach.Clear();
                txtTienKhach.Focus();
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {

            dgvSP_Khach.Rows.Clear();
            dgvSP_Khach.Refresh();
            dgvSanPham.Rows.Clear();
            load_SP();
            dgvSanPham.Refresh();
            txtTienKhach.Clear();
            txtTienHang.Clear();
            txtTienTra.Clear();
            txtTongCong.Clear();
            txtMaKH.Clear();
            txtMaSP.Clear();
            txtPTCK.Clear();
            txtTienCK.Clear();
            lblTenKH.Text = "Nguyễn Văn A";
            lblDiem.Text = "...";
            lblSDT.Text = "0123456789";
        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            if (this.dgvSP_Khach.SelectedRows.Count > 0)
            {
                dgvSP_Khach.Rows.RemoveAt(this.dgvSP_Khach.SelectedRows[0].Index);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (this.dgvSanPham.SelectedRows.Count > 0)
            {
                add_giohang(Convert.ToInt32(dgvSanPham.CurrentRow.Cells[0].Value));
            }
            else
                MessageBox.Show("Vui lòng chọn sản phẩm!");

        }

        private void dgvSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btn_lammoi_Click("", e);
                load_SP();
            }
            if (e.KeyCode == Keys.F4)
            {
                btnThem_Click("", e);
            }
        }

        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMaSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMaSP.Text.Length != 0)
                {
                    add_giohang(Convert.ToInt32(txtMaSP.Text.ToString()));
                    txtMaSP.Clear();
                }
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            frmCam_QR cam = new frmCam_QR();
            cam.ShowDialog();
        }

        public void Cam_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader red = new BarcodeReader();
            var res = red.Decode(bitmap);
            if (res != null)
            {
                txtMaSP.Invoke(new MethodInvoker(delegate ()
                {
                    txtMaSP.Text = res.ToString();
                }));
            }
            pictureBox1.Image = bitmap;
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo info in cameras)
            {
                comboBox1.Items.Add(info.Name);
                comboBox1.SelectedIndex = 0;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cam = new VideoCaptureDevice(cameras[comboBox1.SelectedIndex].MonikerString);
            cam.NewFrame += Cam_NewFrame;
            cam.Start();
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            if (txtMaSP.Text.Length != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Thêm sản phẩm có ID: " + txtMaSP.Text.ToString(), "Thông báo!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        add_giohang(Convert.ToInt32(txtMaSP.Text.ToString()));
                        txtMaSP.Clear();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Sản phẩm không tồn tại!");
                        txtMaSP.Clear();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    txtMaSP.Clear();
                }
            }
        }

        private void frmBanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cam != null)
            {
                if (cam.IsRunning)
                {
                    cam.Stop();
                }
            }
        }

        private void btnCtrKM_Click(object sender, EventArgs e)
        {
            frmKhuyenMai km = new frmKhuyenMai();
            km.ShowDialog();
        }

        private void txtMaKH_Click(object sender, EventArgs e)
        {

        }


        public List<Ado.GioHang> get_DataGioHang()
        {

            List<Ado.GioHang> lst = new List<Ado.GioHang>();

            foreach (DataGridViewRow row in dgvSP_Khach.Rows)
            {
                bool check = false;
                Ado.GioHang gh = new Ado.GioHang();
                gh.Id = Convert.ToInt32(row.Cells["masp"].Value);
                gh.Soluong = Convert.ToInt32(row.Cells["soluongsp"].Value);
                gh.Dongia = float.Parse(row.Cells["giaban"].Value.ToString());
                gh.Thanhtien = float.Parse(row.Cells["thanhtien"].Value.ToString());
                foreach (Ado.GioHang item in lst)
                {
                    if (item.Id == gh.Id)
                    {
                        item.Soluong += gh.Soluong;
                        item.Thanhtien += float.Parse(row.Cells["thanhtien"].Value.ToString());
                        check = true;
                    }
                }

                if (!check)
                {
                    lst.Add(gh);
                }
                //More code here
            }
            return lst;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            frmLuuHD luu = new frmLuuHD();
            if (dgvSP_Khach.RowCount != 0)
            {
                luu.giohang = get_DataGioHang();
                if (txtMaKH.Text.Length != 0)
                {
                    luu.maKH = Convert.ToInt32(txtMaKH.Text.ToString());
                }
                luu.maKM = id_km;
                luu.tongtien = Convert.ToInt32(txtTongCong.Text.ToString());
                luu.id_NV = cbxNhanVien.SelectedValue.ToString();
                luu.ShowDialog();
            }
            else
                MessageBox.Show("Giỏ hàng rỗng!");
            txtMaKH.Clear();
            id_km = 0;
        }

        public void capnhat()
        {
            for (int i = 0; i < dgvSP_Khach.RowCount; i++)
            {
                dgvSP_Khach.Rows[i].Cells[5].Value = Convert.ToInt32(dgvSP_Khach.Rows[i].Cells[3].Value) * Convert.ToInt32(dgvSP_Khach.Rows[i].Cells[4].Value);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvSP_Khach.RowCount != 0)
            {
                if (id_km != 0)
                {
                    tinh_Khuyenmai();

                }
                else
                {
                    capnhat();
                    tongtien();
                }


            }
            else
                MessageBox.Show("Chưa có sản phẩm!");
        }

        private void dgvSP_Khach_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSP_Khach.RowCount != 0)
            {
                capnhat();
                tongtien();

            }
            else
                MessageBox.Show("Chưa có sản phẩm!");
        }

        public void tinh_Khuyenmai()
        {
            if (id_km != 0)
            {
                foreach (CHITIETKHUYENMAI item in banhang.get_DataCTKM(id_km))
                {
                    if (item.TINHTRANG.ToString().Equals("True"))
                    {
                        for (int i = 0; i < dgvSP_Khach.RowCount; i++)
                        {
                            if (Convert.ToInt32(dgvSP_Khach.Rows[i].Cells[0].Value) == item.ID_SP)
                            {
                                float km = (float)(Convert.ToInt32(dgvSP_Khach.Rows[i].Cells[3].Value) - (Convert.ToInt32(dgvSP_Khach.Rows[i].Cells[3].Value) * item.HESOKM / 100));
                                dgvSP_Khach.Rows[i].Cells[5].Value = km * Convert.ToInt32(dgvSP_Khach.Rows[i].Cells[4].Value);
                            }
                        }
                    }
                }
                tongtien();
            }

        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            try
            {
                #region one
                string fileName = "exempleWord.docx";
                var doc = DocX.Create(fileName);
                doc.InsertParagraph("CỬA HÀNG TIỆN LỢI");
                #endregion


                string title = "Hoá đơn bán hàng";
                string dc = "740 C Nguyễn Kiệm";
                string tennv = cbxNhanVien.SelectedValue.ToString();
                string x = "===================================================================";
                doc.InsertParagraph(title);
                doc.InsertParagraph("Địa chỉ: " + dc);
                doc.InsertParagraph("Nhân viên: " + tennv);
                doc.InsertParagraph(x);

                for (int i = 0; i < dgvSP_Khach.RowCount; i++)
                {
                    string a = dgvSP_Khach.Rows[i].Cells[1].Value.ToString();
                    string b = dgvSP_Khach.Rows[i].Cells[3].Value.ToString();
                    string c = dgvSP_Khach.Rows[i].Cells[5].Value.ToString();

                    string row = b + "\t" + c + "\t" + a;
                    doc.InsertParagraph(row);
                }

                string y = "===================================================================";
                doc.InsertParagraph(y);
                string khach = txtTienKhach.Text.ToString();
                doc.InsertParagraph("Tiền khách đưa: " + khach);
                string tong = txtTongCong.Text.ToString();
                doc.InsertParagraph("Tổng cộng :" + tong);
                string du = txtTienTra.Text.ToString();
                doc.InsertParagraph("Trả lại :" + du);



                #region part of one
                doc.Save();
                Process.Start("WINWORD.EXE", fileName);
                #endregion
            }
            catch (Exception)
            {

                MessageBox.Show("Vui lòng loại bỏ hoá đơn cũ!");
            }
        }
    }
}
