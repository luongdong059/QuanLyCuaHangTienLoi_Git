using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;
using Z.Dapper.Plus;
using System.Data.SqlClient;

namespace QuanLyCuaHangTienLoi.View
{
    public partial class frmTroGiup : Form
    {
        public frmTroGiup()
        {
            InitializeComponent();
        }

        Ado.ThongTin[] data = new Ado.ThongTin[1000];
        Ado.ThongTin[] data_out = new Ado.ThongTin[1000];
        Ado.ThongTin[] data_k = new Ado.ThongTin[100];
        Ado.Model_KNN knn = new Ado.Model_KNN();

        DataTableCollection dataTableCollection;
        private void btnChonFile_Click(object sender, EventArgs e)
        {
            docFileExcel();
        }

        public void docFileExcel()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtTenFile.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            dataTableCollection = result.Tables;
                            cbxSheet.Items.Clear();
                            foreach (DataTable item in dataTableCollection)
                            {
                                cbxSheet.Items.Add(item.TableName);
                            }
                        }
                    }
                }
            }
        }

        private void cbxSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = dataTableCollection[cbxSheet.SelectedItem.ToString()];
            dgvDuLieu.DataSource = dt;
        }

        private void btnPhanTich_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (dgvDuLieu.DataSource != null && dgvDuLieu.RowCount > 0)
            {
                try
                {
                    for (int i = 0; i < dgvDuLieu.RowCount; i++)
                    {
                        int tuoi = Convert.ToInt32(dgvDuLieu.Rows[i].Cells[0].Value);
                        string theloai = dgvDuLieu.Rows[i].Cells[1].Value.ToString();

                        Ado.ThongTin a = new Ado.ThongTin(tuoi, theloai);
                        data[n] = a;
                        n++;
                    }

                    try
                    {
                        if (txtTuoi.Text.Length != 0)
                        {
                            int tuoi = Convert.ToInt32(txtTuoi.Text);
                            Ado.ThongTin input = new Ado.ThongTin();
                            input.Tuoi = tuoi;

                            knn.layGiaTri(data, dgvDuLieu.RowCount, input, data_out);
                            knn.sapxep_tang(data_out);
                            knn.lay_k_giatri(data_out, data_k);
                            string a = knn.kiemtra_nhan(data_k);

                            label3.Text = a.ToString();
                        }
                        else
                            MessageBox.Show("Vui lòng nhập độ tuổi...!");
                    }
                    catch (Exception)
                    {

                        label3.Text = "error";
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Mẫu dữ liệu không chính xác...!");
                }


            }
            else
                MessageBox.Show("Dữ liệu rỗng");



        }

        private void btnDLSP_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn thực hiện thao tác này", "Thông báo!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                List<SANPHAM> sanpham = new List<SANPHAM>();
                if (dgvDuLieu.DataSource != null && dgvDuLieu.RowCount > 0)
                {
                    try
                    {
                        for (int i = 0; i < dgvDuLieu.RowCount; i++)
                        {
                            SANPHAM sp = new SANPHAM();
                            sp.TENSP = dgvDuLieu.Rows[i].Cells[0].Value.ToString();
                            sp.DVT = dgvDuLieu.Rows[i].Cells[1].Value.ToString();
                            sp.HINHANH = dgvDuLieu.Rows[i].Cells[4].Value.ToString();
                            sp.DONGIA = Convert.ToInt32(dgvDuLieu.Rows[i].Cells[5].Value.ToString());
                            sanpham.Add(sp);
                        }

                        try
                        {
                            SqlConnection connection = new SqlConnection(Properties.Settings.Default.LTWNCConn);
                            DapperPlusManager.Entity<SANPHAM>().Table("Sanpham");

                            if (sanpham != null)
                            {
                                using (IDbConnection db = connection)
                                {
                                    db.BulkInsert(sanpham);
                                    MessageBox.Show("Success!");
                                }
                            }

                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Error!");
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Mẫu dữ liệu không chính xác...!");
                    }
                }
                else
                    MessageBox.Show("Mẫu dữ liệu rỗng...!");

            }
           

        }

        private void btnDMSP_NCC_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn thực hiện thao tác này", "Thông báo!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                List<DANHMUCSANPHAM> sanpham = new List<DANHMUCSANPHAM>();
                if (dgvDuLieu.DataSource != null && dgvDuLieu.RowCount > 0)
                {
                    try
                    {
                        for (int i = 0; i < dgvDuLieu.RowCount; i++)
                        {
                            DANHMUCSANPHAM sp = new DANHMUCSANPHAM();
                            sp.ID_NCC = Convert.ToInt32(dgvDuLieu.Rows[i].Cells[0].Value.ToString());
                            sp.ID_SP = Convert.ToInt32(dgvDuLieu.Rows[i].Cells[1].Value.ToString());
                            sp.GiaBan = Convert.ToInt32(dgvDuLieu.Rows[i].Cells[2].Value.ToString());
                            sanpham.Add(sp);
                        }

                        try
                        {
                            SqlConnection connection = new SqlConnection(Properties.Settings.Default.LTWNCConn);
                            DapperPlusManager.Entity<DANHMUCSANPHAM>().Table("Danhmucsanpham");

                            if (sanpham != null)
                            {
                                using (IDbConnection db = connection)
                                {
                                    db.BulkInsert(sanpham);
                                    MessageBox.Show("Success!");
                                }
                            }

                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Error!");
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Mẫu dữ liệu không chính xác...!");
                    }


                }
                else
                    MessageBox.Show("Mẫu dữ liệu rỗng...!");

            }

        }

        private void btnThemKM_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn thực hiện thao tác này", "Thông báo!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                List<CHITIETKHUYENMAI> sanpham = new List<CHITIETKHUYENMAI>();
                if (dgvDuLieu.DataSource != null && dgvDuLieu.RowCount >0)
                {
                    try
                    {
                        for (int i = 0; i < dgvDuLieu.RowCount; i++)
                        {
                            CHITIETKHUYENMAI sp = new CHITIETKHUYENMAI();
                            sp.ID_KM = Convert.ToInt32(dgvDuLieu.Rows[i].Cells[0].Value.ToString());
                            sp.ID_SP = Convert.ToInt32(dgvDuLieu.Rows[i].Cells[1].Value.ToString());
                            sp.HESOKM = Convert.ToInt32(dgvDuLieu.Rows[i].Cells[2].Value.ToString());
                            sp.TINHTRANG = Boolean.Parse(dgvDuLieu.Rows[i].Cells[3].Value.ToString());
                            sanpham.Add(sp);
                        }

                        try
                        {
                            SqlConnection connection = new SqlConnection(Properties.Settings.Default.LTWNCConn);
                            DapperPlusManager.Entity<DANHMUCSANPHAM>().Table("Danhmucsanpham");

                            if (sanpham != null)
                            {
                                using (IDbConnection db = connection)
                                {
                                    db.BulkInsert(sanpham);
                                    MessageBox.Show("Success!");
                                }
                            }

                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Error!");
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Mẫu dữ liệu không chính xác...!");
                    }
                }
                
                else
                    MessageBox.Show("Mẫu dữ liệu rỗng...!");
            }

        }
    }
}
