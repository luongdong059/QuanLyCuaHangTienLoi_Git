
namespace QuanLyCuaHangTienLoi.View
{
    partial class frmThemNCC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemNCC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgvDanhSachNCC = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnDMSP = new System.Windows.Forms.Button();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dgvDMSP = new System.Windows.Forms.DataGridView();
            this.idsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.cbxSanPham = new System.Windows.Forms.ComboBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThemNCC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvDanhSachNCC);
            this.groupControl1.Location = new System.Drawing.Point(13, 13);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(598, 685);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh sách nhà cung cấp";
            // 
            // dgvDanhSachNCC
            // 
            this.dgvDanhSachNCC.AllowUserToAddRows = false;
            this.dgvDanhSachNCC.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNCC.Location = new System.Drawing.Point(6, 32);
            this.dgvDanhSachNCC.Name = "dgvDanhSachNCC";
            this.dgvDanhSachNCC.RowHeadersWidth = 51;
            this.dgvDanhSachNCC.RowTemplate.Height = 24;
            this.dgvDanhSachNCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachNCC.Size = new System.Drawing.Size(587, 648);
            this.dgvDanhSachNCC.TabIndex = 0;
            this.dgvDanhSachNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachNCC_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Transparent;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(627, 603);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(140, 44);
            this.btnThem.TabIndex = 68;
            this.btnThem.Text = "Thêm NCC";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Transparent;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(933, 603);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(128, 44);
            this.btnLuu.TabIndex = 67;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 19);
            this.label7.TabIndex = 65;
            this.label7.Text = "Tên nhà cung cấp";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNCC.Location = new System.Drawing.Point(174, 51);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(6);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(228, 34);
            this.txtTenNCC.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 69;
            this.label1.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(174, 110);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(6);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(228, 34);
            this.txtDiaChi.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 71;
            this.label2.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(174, 170);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(6);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(228, 34);
            this.txtSDT.TabIndex = 72;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtSDT);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.txtTenNCC);
            this.groupControl2.Controls.Add(this.label7);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.txtDiaChi);
            this.groupControl2.Location = new System.Drawing.Point(627, 13);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(434, 227);
            this.groupControl2.TabIndex = 73;
            this.groupControl2.Text = "Thông tin nhà cung cấp";
            // 
            // btnDMSP
            // 
            this.btnDMSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDMSP.FlatAppearance.BorderSize = 0;
            this.btnDMSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDMSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDMSP.ForeColor = System.Drawing.Color.Transparent;
            this.btnDMSP.Location = new System.Drawing.Point(627, 653);
            this.btnDMSP.Name = "btnDMSP";
            this.btnDMSP.Size = new System.Drawing.Size(434, 44);
            this.btnDMSP.TabIndex = 74;
            this.btnDMSP.Text = "Danh mục sản phẩm";
            this.btnDMSP.UseVisualStyleBackColor = false;
            this.btnDMSP.Click += new System.EventHandler(this.btnDMSP_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.dgvDMSP);
            this.groupControl3.Location = new System.Drawing.Point(627, 374);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(434, 223);
            this.groupControl3.TabIndex = 75;
            this.groupControl3.Text = "Danh mục sản phẩm";
            // 
            // dgvDMSP
            // 
            this.dgvDMSP.AllowUserToAddRows = false;
            this.dgvDMSP.BackgroundColor = System.Drawing.Color.White;
            this.dgvDMSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDMSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsp,
            this.tensp,
            this.giaban});
            this.dgvDMSP.Location = new System.Drawing.Point(5, 31);
            this.dgvDMSP.Name = "dgvDMSP";
            this.dgvDMSP.RowHeadersWidth = 51;
            this.dgvDMSP.RowTemplate.Height = 24;
            this.dgvDMSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDMSP.Size = new System.Drawing.Size(423, 184);
            this.dgvDMSP.TabIndex = 0;
            this.dgvDMSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDMSP_CellClick);
            // 
            // idsp
            // 
            this.idsp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idsp.DefaultCellStyle = dataGridViewCellStyle1;
            this.idsp.HeaderText = "ID";
            this.idsp.MinimumWidth = 6;
            this.idsp.Name = "idsp";
            this.idsp.ReadOnly = true;
            this.idsp.Width = 51;
            // 
            // tensp
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tensp.DefaultCellStyle = dataGridViewCellStyle2;
            this.tensp.HeaderText = "Tên sản phẩm";
            this.tensp.MinimumWidth = 6;
            this.tensp.Name = "tensp";
            this.tensp.ReadOnly = true;
            this.tensp.Width = 125;
            // 
            // giaban
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = ". VNĐ";
            dataGridViewCellStyle3.NullValue = null;
            this.giaban.DefaultCellStyle = dataGridViewCellStyle3;
            this.giaban.HeaderText = "Giá bán";
            this.giaban.MinimumWidth = 6;
            this.giaban.Name = "giaban";
            this.giaban.ReadOnly = true;
            this.giaban.Width = 125;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.cbxSanPham);
            this.groupControl4.Controls.Add(this.txtGiaBan);
            this.groupControl4.Controls.Add(this.label4);
            this.groupControl4.Controls.Add(this.label3);
            this.groupControl4.Location = new System.Drawing.Point(627, 246);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(434, 122);
            this.groupControl4.TabIndex = 76;
            this.groupControl4.Text = "Thông tin sản phẩm";
            // 
            // cbxSanPham
            // 
            this.cbxSanPham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSanPham.FormattingEnabled = true;
            this.cbxSanPham.Location = new System.Drawing.Point(174, 35);
            this.cbxSanPham.Name = "cbxSanPham";
            this.cbxSanPham.Size = new System.Drawing.Size(228, 30);
            this.cbxSanPham.TabIndex = 75;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.Location = new System.Drawing.Point(174, 77);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(6);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(228, 34);
            this.txtGiaBan.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 71;
            this.label4.Text = "Giá bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 70;
            this.label3.Text = "Tên sản phẩm";
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThemNCC.FlatAppearance.BorderSize = 0;
            this.btnThemNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNCC.ForeColor = System.Drawing.Color.Transparent;
            this.btnThemNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNCC.Image")));
            this.btnThemNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemNCC.Location = new System.Drawing.Point(783, 603);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(135, 44);
            this.btnThemNCC.TabIndex = 77;
            this.btnThemNCC.Text = "Thêm SP";
            this.btnThemNCC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemNCC.UseVisualStyleBackColor = false;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
            // 
            // frmThemNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 710);
            this.Controls.Add(this.btnThemNCC);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.btnDMSP);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmThemNCC";
            this.Text = "frmThemNCC";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgvDanhSachNCC;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSDT;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Button btnDMSP;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.DataGridView dgvDMSP;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThemNCC;
        private System.Windows.Forms.ComboBox cbxSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaban;
    }
}