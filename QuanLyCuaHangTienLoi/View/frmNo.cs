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
    public partial class frmNo : Form
    {
        public int idpd_g;
        public frmNo()
        {
            InitializeComponent();
        }

        public void load()
        {
            Kho_BLLDAL kho = new Kho_BLLDAL();
            SanPham_BLLDAL sanpham1 = new SanPham_BLLDAL();
            foreach (CHITIETPHIEUDAT item in kho.get_DataSP_CTPD(idpd_g))
            {
                int dem = 0;
                foreach (CHITIETPHIEUNHAP x in kho.get_DataSP_CTPN(idpd_g))
                {
                    dem++;
                }
                if ( dem == 0)
                {
                    string ten = "";
                    foreach (SANPHAM item2 in sanpham1.get_DataSP())
                    {

                        if (item.ID_SP == item2.ID_SP)
                        {
                            ten = item2.TENSP.ToString();
                        }
                    }
                    dgvChiTiet.Rows.Add(item.ID_SP, ten, item.SOLUONG, item.THANHTIEN);
                }
                else
                {
                    foreach (CHITIETPHIEUNHAP item1 in kho.get_DataSP_CTPN(idpd_g))
                    {
                        if (item.ID_SP == item1.ID_SP)
                        {

                        }
                        else
                        {
                            string ten = "";
                            foreach (SANPHAM item2 in sanpham1.get_DataSP())
                            {

                                if (item.ID_SP == item2.ID_SP)
                                {
                                    ten = item2.TENSP.ToString();
                                }
                            }
                            dgvChiTiet.Rows.Add(item.ID_SP, ten, item.SOLUONG, item.THANHTIEN);
                        }
                    }
                }    
                
            }
        }

        private void frmNo_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            if (dgvChiTiet.RowCount > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dgvChiTiet.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dgvChiTiet.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvChiTiet.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvChiTiet.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgvChiTiet.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
    }
}
