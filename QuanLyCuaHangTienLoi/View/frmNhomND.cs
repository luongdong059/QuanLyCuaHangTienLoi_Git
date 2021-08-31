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
    public partial class frmNhomND : Form
    {
        public frmNhomND()
        {
            InitializeComponent();
        }

        private void nHOMNGUOIDUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHOMNGUOIDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLND);

        }

        private void frmNhomND_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLND.NHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.nHOMNGUOIDUNGTableAdapter.Fill(this.qLND.NHOMNGUOIDUNG);

        }
    }
}
