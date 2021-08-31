using System;
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
    public partial class frmQuanLyND : Form
    {
        public frmQuanLyND()
        {
            InitializeComponent();
        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            frmNguoiDung nd = new frmNguoiDung();
            nd.ShowDialog();
        }

        private void btnNhomND_Click(object sender, EventArgs e)
        {
            frmNhomND nd = new frmNhomND();
            nd.ShowDialog();
        }

        private void btnManHinh_Click(object sender, EventArgs e)
        {
            frmDanhMucMH nd = new frmDanhMucMH();
            nd.ShowDialog();
        }

        private void btnThemNDNhom_Click(object sender, EventArgs e)
        {
            frmNguoiDungNhomND nd = new frmNguoiDungNhomND();
            nd.ShowDialog();
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            frmPhanQuyen nd = new frmPhanQuyen();
            nd.ShowDialog();
        }
    }
}
