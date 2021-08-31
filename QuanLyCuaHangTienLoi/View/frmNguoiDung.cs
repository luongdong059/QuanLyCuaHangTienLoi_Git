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
    public partial class frmNguoiDung : Form
    {
        public frmNguoiDung()
        {
            InitializeComponent();
        }

        OpenFileDialog opf = new OpenFileDialog();

        private void nGUOIDUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nGUOIDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLND);

        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLND.NGUOIDUNG' table. You can move, or remove it, as needed.
            this.nGUOIDUNGTableAdapter.Fill(this.qLND.NGUOIDUNG);

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            opf.Filter = "Choose Image(*.jpg; *.png;*.gif)|*.jpg; *.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }

            string imagepath = null;

            string imagePath = opf.FileName.ToString();
            if (!imagePath.Equals(""))
            {
                imagepath = get_nameIMG();
            }

            hINHTextEdit.Text = imagepath;
        }

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

        private void hINHTextEdit_DoubleClick(object sender, EventArgs e)
        {
            Image img = null;

            if (hINHTextEdit.Text.Length != 0)
            {
                try
                {
                    img = Image.FromFile(Application.StartupPath + "\\img\\" + hINHTextEdit.Text.ToString());
                }
                catch (Exception)
                {
                    return;
                }
            }
            else
                MessageBox.Show("Tên hình trống");

            pictureBox1.Image = img;
        }
    }
}
