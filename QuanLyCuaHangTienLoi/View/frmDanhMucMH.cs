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
    public partial class frmDanhMucMH : Form
    {
        public frmDanhMucMH()
        {
            InitializeComponent();
        }

        private void mANHINHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mANHINHBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLND);

        }

        private void frmDanhMucMH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLND.MANHINH' table. You can move, or remove it, as needed.
            this.mANHINHTableAdapter.Fill(this.qLND.MANHINH);

        }
    }
}
