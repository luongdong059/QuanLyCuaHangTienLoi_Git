
namespace QuanLyCuaHangTienLoi.View
{
    partial class frmTroGiup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTroGiup));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgvDuLieu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenFile = new System.Windows.Forms.TextBox();
            this.btnChonFile = new System.Windows.Forms.Button();
            this.cbxSheet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPhanTich = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTuoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.label5 = new System.Windows.Forms.Label();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnDLSP = new System.Windows.Forms.Button();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btnDMSP_NCC = new System.Windows.Forms.Button();
            this.btnThemKM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvDuLieu);
            this.groupControl1.Location = new System.Drawing.Point(13, 13);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(524, 608);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Dữ liệu khách hàng";
            // 
            // dgvDuLieu
            // 
            this.dgvDuLieu.AllowUserToAddRows = false;
            this.dgvDuLieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDuLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuLieu.Location = new System.Drawing.Point(6, 32);
            this.dgvDuLieu.Name = "dgvDuLieu";
            this.dgvDuLieu.RowHeadersWidth = 51;
            this.dgvDuLieu.RowTemplate.Height = 24;
            this.dgvDuLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDuLieu.Size = new System.Drawing.Size(513, 571);
            this.dgvDuLieu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên file";
            // 
            // txtTenFile
            // 
            this.txtTenFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenFile.Location = new System.Drawing.Point(146, 41);
            this.txtTenFile.Name = "txtTenFile";
            this.txtTenFile.Size = new System.Drawing.Size(332, 30);
            this.txtTenFile.TabIndex = 2;
            // 
            // btnChonFile
            // 
            this.btnChonFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonFile.Location = new System.Drawing.Point(507, 39);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(73, 30);
            this.btnChonFile.TabIndex = 3;
            this.btnChonFile.Text = "...";
            this.btnChonFile.UseVisualStyleBackColor = true;
            this.btnChonFile.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // cbxSheet
            // 
            this.cbxSheet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSheet.FormattingEnabled = true;
            this.cbxSheet.Location = new System.Drawing.Point(146, 82);
            this.cbxSheet.Name = "cbxSheet";
            this.cbxSheet.Size = new System.Drawing.Size(332, 30);
            this.cbxSheet.TabIndex = 4;
            this.cbxSheet.SelectedIndexChanged += new System.EventHandler(this.cbxSheet_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sheet";
            // 
            // btnPhanTich
            // 
            this.btnPhanTich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPhanTich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhanTich.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanTich.ForeColor = System.Drawing.Color.White;
            this.btnPhanTich.Image = ((System.Drawing.Image)(resources.GetObject("btnPhanTich.Image")));
            this.btnPhanTich.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhanTich.Location = new System.Drawing.Point(280, 31);
            this.btnPhanTich.Name = "btnPhanTich";
            this.btnPhanTich.Size = new System.Drawing.Size(185, 42);
            this.btnPhanTich.TabIndex = 6;
            this.btnPhanTich.Text = "Phân tích";
            this.btnPhanTich.UseVisualStyleBackColor = false;
            this.btnPhanTich.Click += new System.EventHandler(this.btnPhanTich_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(178, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "....";
            // 
            // txtTuoi
            // 
            this.txtTuoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuoi.Location = new System.Drawing.Point(155, 31);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.Size = new System.Drawing.Size(100, 30);
            this.txtTuoi.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nhập độ tuổi";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Controls.Add(this.btnPhanTich);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.txtTuoi);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Location = new System.Drawing.Point(555, 213);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(738, 151);
            this.groupControl2.TabIndex = 10;
            this.groupControl2.Text = "Phân tích thông tin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sản phẩm gợi ý";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnThemKM);
            this.groupControl3.Controls.Add(this.btnDMSP_NCC);
            this.groupControl3.Controls.Add(this.btnDLSP);
            this.groupControl3.Location = new System.Drawing.Point(555, 435);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(738, 181);
            this.groupControl3.TabIndex = 11;
            this.groupControl3.Text = "Dữ liệu";
            // 
            // btnDLSP
            // 
            this.btnDLSP.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDLSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDLSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDLSP.ForeColor = System.Drawing.Color.White;
            this.btnDLSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDLSP.Location = new System.Drawing.Point(84, 58);
            this.btnDLSP.Name = "btnDLSP";
            this.btnDLSP.Size = new System.Drawing.Size(167, 80);
            this.btnDLSP.TabIndex = 5;
            this.btnDLSP.Text = "Thêm dữ liệu sản phẩm";
            this.btnDLSP.UseVisualStyleBackColor = false;
            this.btnDLSP.Click += new System.EventHandler(this.btnDLSP_Click);
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.cbxSheet);
            this.groupControl4.Controls.Add(this.label2);
            this.groupControl4.Controls.Add(this.btnChonFile);
            this.groupControl4.Controls.Add(this.label1);
            this.groupControl4.Controls.Add(this.txtTenFile);
            this.groupControl4.Location = new System.Drawing.Point(555, 17);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(738, 140);
            this.groupControl4.TabIndex = 12;
            this.groupControl4.Text = "Chọn file";
            // 
            // btnDMSP_NCC
            // 
            this.btnDMSP_NCC.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDMSP_NCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDMSP_NCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDMSP_NCC.ForeColor = System.Drawing.Color.White;
            this.btnDMSP_NCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDMSP_NCC.Location = new System.Drawing.Point(278, 58);
            this.btnDMSP_NCC.Name = "btnDMSP_NCC";
            this.btnDMSP_NCC.Size = new System.Drawing.Size(167, 80);
            this.btnDMSP_NCC.TabIndex = 6;
            this.btnDMSP_NCC.Text = "Thêm danh mục sản phẩm NCC";
            this.btnDMSP_NCC.UseVisualStyleBackColor = false;
            this.btnDMSP_NCC.Click += new System.EventHandler(this.btnDMSP_NCC_Click);
            // 
            // btnThemKM
            // 
            this.btnThemKM.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnThemKM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemKM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKM.ForeColor = System.Drawing.Color.White;
            this.btnThemKM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemKM.Location = new System.Drawing.Point(475, 58);
            this.btnThemKM.Name = "btnThemKM";
            this.btnThemKM.Size = new System.Drawing.Size(167, 80);
            this.btnThemKM.TabIndex = 7;
            this.btnThemKM.Text = "Thêm danh mục khuyến mãi";
            this.btnThemKM.UseVisualStyleBackColor = false;
            this.btnThemKM.Click += new System.EventHandler(this.btnThemKM_Click);
            // 
            // frmTroGiup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 724);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmTroGiup";
            this.Text = "frmTroGiup";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dgvDuLieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenFile;
        private System.Windows.Forms.Button btnChonFile;
        private System.Windows.Forms.ComboBox cbxSheet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPhanTich;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTuoi;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Button btnDLSP;
        private System.Windows.Forms.Button btnDMSP_NCC;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.Button btnThemKM;
    }
}