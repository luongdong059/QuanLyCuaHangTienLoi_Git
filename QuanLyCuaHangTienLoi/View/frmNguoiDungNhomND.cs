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
    public partial class frmNguoiDungNhomND : Form
    {
        public frmNguoiDungNhomND()
        {
            InitializeComponent();
        }

        private void nGUOIDUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nGUOIDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLND);

        }

        private void frmNguoiDungNhomND_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLND.NHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.nHOMNGUOIDUNGTableAdapter.Fill(this.qLND.NHOMNGUOIDUNG);
            // TODO: This line of code loads data into the 'qLND.NGUOIDUNG' table. You can move, or remove it, as needed.
            this.nGUOIDUNGTableAdapter.Fill(this.qLND.NGUOIDUNG);

        }

        private void fillDKToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.nGUOIDUNGNHOMNGUOIDUNGDKTableAdapter.FillDK(this.qLND.NGUOIDUNGNHOMNGUOIDUNGDK, iD_NHOMToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void nHOMNGUOIDUNGComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            load();
        }

        public void load()
        {
            try
            {
                this.nGUOIDUNGNHOMNGUOIDUNGDKTableAdapter.FillDK(this.qLND.NGUOIDUNGNHOMNGUOIDUNGDK, nHOMNGUOIDUNGComboBox.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tenDN = nGUOIDUNGDataGridView.CurrentRow.Cells[0].Value.ToString();
            string maNhomND = nHOMNGUOIDUNGComboBox.SelectedValue.ToString();

            int? kq = nGUOIDUNGNHOMNGUOIDUNGDKTableAdapter.KTKC(maNhomND, tenDN);

            if (kq.Value == 0)
            {
                nGUOIDUNGNHOMNGUOIDUNGDKTableAdapter.Insert(maNhomND, tenDN, "");

                MessageBox.Show("Them thanh cong");
                load();
            }

            else
                MessageBox.Show("Trung khoa chinh");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maNhom = nGUOIDUNGNHOMNGUOIDUNGDKDataGridView.CurrentRow.Cells[0].Value.ToString();
            string tenDN = nGUOIDUNGNHOMNGUOIDUNGDKDataGridView.CurrentRow.Cells[1].Value.ToString();

            nGUOIDUNGNHOMNGUOIDUNGDKTableAdapter.DeleteQuery(maNhom, tenDN);

            MessageBox.Show("Xoa thanh cong");
            load();
        }
    }
}
