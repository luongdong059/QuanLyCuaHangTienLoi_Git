
namespace QuanLyCuaHangTienLoi.View
{
    partial class frmKho
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgvPhieuDat = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnNCC = new System.Windows.Forms.Button();
            this.btnThemLSP = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnXemThongTin = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.idsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvPhieuDat);
            this.groupControl1.Location = new System.Drawing.Point(2, 4);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(6);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(945, 856);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh sách phiếu đặt";
            // 
            // dgvPhieuDat
            // 
            this.dgvPhieuDat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPhieuDat.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idncc,
            this.tenncc,
            this.tennhanvien,
            this.ngaylap,
            this.tongtien,
            this.donhang});
            this.dgvPhieuDat.Location = new System.Drawing.Point(8, 41);
            this.dgvPhieuDat.Margin = new System.Windows.Forms.Padding(5);
            this.dgvPhieuDat.Name = "dgvPhieuDat";
            this.dgvPhieuDat.RowHeadersWidth = 51;
            this.dgvPhieuDat.RowTemplate.Height = 24;
            this.dgvPhieuDat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuDat.Size = new System.Drawing.Size(931, 809);
            this.dgvPhieuDat.TabIndex = 0;
            // 
            // id
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle1;
            this.id.HeaderText = "ID Phieu Dat";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 51;
            // 
            // idncc
            // 
            this.idncc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idncc.DefaultCellStyle = dataGridViewCellStyle2;
            this.idncc.HeaderText = "ID NCC";
            this.idncc.MinimumWidth = 6;
            this.idncc.Name = "idncc";
            this.idncc.ReadOnly = true;
            this.idncc.Width = 76;
            // 
            // tenncc
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tenncc.DefaultCellStyle = dataGridViewCellStyle3;
            this.tenncc.HeaderText = "Tên nhà cung cấp";
            this.tenncc.MinimumWidth = 6;
            this.tenncc.Name = "tenncc";
            this.tenncc.ReadOnly = true;
            this.tenncc.Width = 125;
            // 
            // tennhanvien
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tennhanvien.DefaultCellStyle = dataGridViewCellStyle4;
            this.tennhanvien.HeaderText = "Nhân viên lập";
            this.tennhanvien.MinimumWidth = 6;
            this.tennhanvien.Name = "tennhanvien";
            this.tennhanvien.ReadOnly = true;
            this.tennhanvien.Width = 125;
            // 
            // ngaylap
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ngaylap.DefaultCellStyle = dataGridViewCellStyle5;
            this.ngaylap.HeaderText = "Ngày lập";
            this.ngaylap.MinimumWidth = 6;
            this.ngaylap.Name = "ngaylap";
            this.ngaylap.ReadOnly = true;
            this.ngaylap.Width = 125;
            // 
            // tongtien
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Format = ". VNĐ";
            dataGridViewCellStyle6.NullValue = ".";
            this.tongtien.DefaultCellStyle = dataGridViewCellStyle6;
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.MinimumWidth = 6;
            this.tongtien.Name = "tongtien";
            this.tongtien.ReadOnly = true;
            this.tongtien.Width = 125;
            // 
            // donhang
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.donhang.DefaultCellStyle = dataGridViewCellStyle7;
            this.donhang.HeaderText = "Tình trạng";
            this.donhang.MinimumWidth = 6;
            this.donhang.Name = "donhang";
            this.donhang.ReadOnly = true;
            this.donhang.Width = 125;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnNCC);
            this.groupControl2.Controls.Add(this.btnThemLSP);
            this.groupControl2.Controls.Add(this.btnNo);
            this.groupControl2.Controls.Add(this.btnXemThongTin);
            this.groupControl2.Controls.Add(this.btnNhapHang);
            this.groupControl2.Controls.Add(this.btnDatHang);
            this.groupControl2.Location = new System.Drawing.Point(957, 518);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(5);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(659, 342);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Điều khiển";
            // 
            // btnNCC
            // 
            this.btnNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNCC.ForeColor = System.Drawing.Color.White;
            this.btnNCC.Location = new System.Drawing.Point(247, 192);
            this.btnNCC.Margin = new System.Windows.Forms.Padding(5);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Size = new System.Drawing.Size(150, 77);
            this.btnNCC.TabIndex = 13;
            this.btnNCC.Text = "Nhà cung cấp";
            this.btnNCC.UseVisualStyleBackColor = false;
            this.btnNCC.Click += new System.EventHandler(this.btnNCC_Click);
            // 
            // btnThemLSP
            // 
            this.btnThemLSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThemLSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemLSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLSP.ForeColor = System.Drawing.Color.White;
            this.btnThemLSP.Location = new System.Drawing.Point(74, 192);
            this.btnThemLSP.Margin = new System.Windows.Forms.Padding(5);
            this.btnThemLSP.Name = "btnThemLSP";
            this.btnThemLSP.Size = new System.Drawing.Size(150, 77);
            this.btnThemLSP.TabIndex = 12;
            this.btnThemLSP.Text = "Thêm loại sản phẩm";
            this.btnThemLSP.UseVisualStyleBackColor = false;
            this.btnThemLSP.Click += new System.EventHandler(this.btnThemLSP_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(418, 192);
            this.btnNo.Margin = new System.Windows.Forms.Padding(5);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(150, 77);
            this.btnNo.TabIndex = 11;
            this.btnNo.Text = "Truy xuất thông tin nợ";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnXemThongTin
            // 
            this.btnXemThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnXemThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemThongTin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemThongTin.ForeColor = System.Drawing.Color.White;
            this.btnXemThongTin.Location = new System.Drawing.Point(418, 92);
            this.btnXemThongTin.Margin = new System.Windows.Forms.Padding(5);
            this.btnXemThongTin.Name = "btnXemThongTin";
            this.btnXemThongTin.Size = new System.Drawing.Size(150, 77);
            this.btnXemThongTin.TabIndex = 10;
            this.btnXemThongTin.Text = "Xem thông tin phiếu đặt";
            this.btnXemThongTin.UseVisualStyleBackColor = false;
            this.btnXemThongTin.Click += new System.EventHandler(this.btnXemThongTin_Click_1);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHang.ForeColor = System.Drawing.Color.White;
            this.btnNhapHang.Location = new System.Drawing.Point(247, 92);
            this.btnNhapHang.Margin = new System.Windows.Forms.Padding(5);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(150, 77);
            this.btnNhapHang.TabIndex = 9;
            this.btnNhapHang.Text = "Nhập hàng";
            this.btnNhapHang.UseVisualStyleBackColor = false;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnDatHang
            // 
            this.btnDatHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatHang.ForeColor = System.Drawing.Color.White;
            this.btnDatHang.Location = new System.Drawing.Point(74, 92);
            this.btnDatHang.Margin = new System.Windows.Forms.Padding(5);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(150, 77);
            this.btnDatHang.TabIndex = 8;
            this.btnDatHang.Text = "Đặt hàng";
            this.btnDatHang.UseVisualStyleBackColor = false;
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.dgvChiTiet);
            this.groupControl3.Location = new System.Drawing.Point(957, 4);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(659, 486);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Chi tiết phiếu đặt";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AllowUserToAddRows = false;
            this.dgvChiTiet.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsp,
            this.tensp,
            this.soluong,
            this.thanhtien});
            this.dgvChiTiet.Location = new System.Drawing.Point(6, 32);
            this.dgvChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.RowHeadersWidth = 51;
            this.dgvChiTiet.RowTemplate.Height = 24;
            this.dgvChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTiet.Size = new System.Drawing.Size(645, 440);
            this.dgvChiTiet.TabIndex = 0;
            // 
            // idsp
            // 
            this.idsp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idsp.DefaultCellStyle = dataGridViewCellStyle8;
            this.idsp.HeaderText = "ID";
            this.idsp.MinimumWidth = 6;
            this.idsp.Name = "idsp";
            this.idsp.ReadOnly = true;
            this.idsp.Width = 51;
            // 
            // tensp
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tensp.DefaultCellStyle = dataGridViewCellStyle9;
            this.tensp.HeaderText = "Tên sản phẩm";
            this.tensp.MinimumWidth = 6;
            this.tensp.Name = "tensp";
            this.tensp.ReadOnly = true;
            this.tensp.Width = 125;
            // 
            // soluong
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.soluong.DefaultCellStyle = dataGridViewCellStyle10;
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            this.soluong.Width = 125;
            // 
            // thanhtien
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Format = ". VNĐ";
            dataGridViewCellStyle11.NullValue = null;
            this.thanhtien.DefaultCellStyle = dataGridViewCellStyle11;
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.MinimumWidth = 6;
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            this.thanhtien.Width = 125;
            // 
            // frmKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1669, 1055);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmKho";
            this.Text = "frmKho";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgvPhieuDat;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Button btnNCC;
        private System.Windows.Forms.Button btnThemLSP;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnXemThongTin;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Button btnDatHang;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn donhang;
    }
}