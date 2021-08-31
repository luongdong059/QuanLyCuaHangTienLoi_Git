
namespace QuanLyCuaHangTienLoi.View
{
    partial class frmNhomND
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhomND));
            System.Windows.Forms.Label iD_NHOMLabel;
            System.Windows.Forms.Label tENNHOMLabel;
            this.qLND = new QuanLyCuaHangTienLoi.QLND();
            this.nHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHOMNGUOIDUNGTableAdapter = new QuanLyCuaHangTienLoi.QLNDTableAdapters.NHOMNGUOIDUNGTableAdapter();
            this.tableAdapterManager = new QuanLyCuaHangTienLoi.QLNDTableAdapters.TableAdapterManager();
            this.nHOMNGUOIDUNGBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.nHOMNGUOIDUNGBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nHOMNGUOIDUNGDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iD_NHOMTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENNHOMTextEdit = new DevExpress.XtraEditors.TextEdit();
            iD_NHOMLabel = new System.Windows.Forms.Label();
            tENNHOMLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingNavigator)).BeginInit();
            this.nHOMNGUOIDUNGBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iD_NHOMTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENNHOMTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // qLND
            // 
            this.qLND.DataSetName = "QLND";
            this.qLND.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHOMNGUOIDUNGBindingSource
            // 
            this.nHOMNGUOIDUNGBindingSource.DataMember = "NHOMNGUOIDUNG";
            this.nHOMNGUOIDUNGBindingSource.DataSource = this.qLND;
            // 
            // nHOMNGUOIDUNGTableAdapter
            // 
            this.nHOMNGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MANHINHTableAdapter = null;
            this.tableAdapterManager.NGUOIDUNGNHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.NGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.NHOMNGUOIDUNGTableAdapter = this.nHOMNGUOIDUNGTableAdapter;
            this.tableAdapterManager.PHANQUYENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyCuaHangTienLoi.QLNDTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nHOMNGUOIDUNGBindingNavigator
            // 
            this.nHOMNGUOIDUNGBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nHOMNGUOIDUNGBindingNavigator.BindingSource = this.nHOMNGUOIDUNGBindingSource;
            this.nHOMNGUOIDUNGBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nHOMNGUOIDUNGBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nHOMNGUOIDUNGBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.nHOMNGUOIDUNGBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.nHOMNGUOIDUNGBindingNavigatorSaveItem});
            this.nHOMNGUOIDUNGBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nHOMNGUOIDUNGBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nHOMNGUOIDUNGBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nHOMNGUOIDUNGBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nHOMNGUOIDUNGBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nHOMNGUOIDUNGBindingNavigator.Name = "nHOMNGUOIDUNGBindingNavigator";
            this.nHOMNGUOIDUNGBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nHOMNGUOIDUNGBindingNavigator.Size = new System.Drawing.Size(432, 27);
            this.nHOMNGUOIDUNGBindingNavigator.TabIndex = 0;
            this.nHOMNGUOIDUNGBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // nHOMNGUOIDUNGBindingNavigatorSaveItem
            // 
            this.nHOMNGUOIDUNGBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nHOMNGUOIDUNGBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nHOMNGUOIDUNGBindingNavigatorSaveItem.Image")));
            this.nHOMNGUOIDUNGBindingNavigatorSaveItem.Name = "nHOMNGUOIDUNGBindingNavigatorSaveItem";
            this.nHOMNGUOIDUNGBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.nHOMNGUOIDUNGBindingNavigatorSaveItem.Text = "Save Data";
            this.nHOMNGUOIDUNGBindingNavigatorSaveItem.Click += new System.EventHandler(this.nHOMNGUOIDUNGBindingNavigatorSaveItem_Click);
            // 
            // nHOMNGUOIDUNGDataGridView
            // 
            this.nHOMNGUOIDUNGDataGridView.AutoGenerateColumns = false;
            this.nHOMNGUOIDUNGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nHOMNGUOIDUNGDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.nHOMNGUOIDUNGDataGridView.DataSource = this.nHOMNGUOIDUNGBindingSource;
            this.nHOMNGUOIDUNGDataGridView.Location = new System.Drawing.Point(12, 185);
            this.nHOMNGUOIDUNGDataGridView.Name = "nHOMNGUOIDUNGDataGridView";
            this.nHOMNGUOIDUNGDataGridView.RowHeadersWidth = 51;
            this.nHOMNGUOIDUNGDataGridView.RowTemplate.Height = 24;
            this.nHOMNGUOIDUNGDataGridView.Size = new System.Drawing.Size(385, 272);
            this.nHOMNGUOIDUNGDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_NHOM";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_NHOM";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENNHOM";
            this.dataGridViewTextBoxColumn2.HeaderText = "TENNHOM";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // iD_NHOMLabel
            // 
            iD_NHOMLabel.AutoSize = true;
            iD_NHOMLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_NHOMLabel.Location = new System.Drawing.Point(30, 60);
            iD_NHOMLabel.Name = "iD_NHOMLabel";
            iD_NHOMLabel.Size = new System.Drawing.Size(82, 22);
            iD_NHOMLabel.TabIndex = 2;
            iD_NHOMLabel.Text = "ID Nhóm";
            // 
            // iD_NHOMTextEdit
            // 
            this.iD_NHOMTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHOMNGUOIDUNGBindingSource, "ID_NHOM", true));
            this.iD_NHOMTextEdit.Location = new System.Drawing.Point(161, 54);
            this.iD_NHOMTextEdit.Name = "iD_NHOMTextEdit";
            this.iD_NHOMTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_NHOMTextEdit.Properties.Appearance.Options.UseFont = true;
            this.iD_NHOMTextEdit.Size = new System.Drawing.Size(236, 28);
            this.iD_NHOMTextEdit.TabIndex = 3;
            // 
            // tENNHOMLabel
            // 
            tENNHOMLabel.AutoSize = true;
            tENNHOMLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENNHOMLabel.Location = new System.Drawing.Point(30, 106);
            tENNHOMLabel.Name = "tENNHOMLabel";
            tENNHOMLabel.Size = new System.Drawing.Size(87, 22);
            tENNHOMLabel.TabIndex = 4;
            tENNHOMLabel.Text = "Tên nhóm";
            // 
            // tENNHOMTextEdit
            // 
            this.tENNHOMTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHOMNGUOIDUNGBindingSource, "TENNHOM", true));
            this.tENNHOMTextEdit.Location = new System.Drawing.Point(161, 101);
            this.tENNHOMTextEdit.Name = "tENNHOMTextEdit";
            this.tENNHOMTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENNHOMTextEdit.Properties.Appearance.Options.UseFont = true;
            this.tENNHOMTextEdit.Size = new System.Drawing.Size(236, 28);
            this.tENNHOMTextEdit.TabIndex = 5;
            // 
            // frmNhomND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 477);
            this.Controls.Add(iD_NHOMLabel);
            this.Controls.Add(this.iD_NHOMTextEdit);
            this.Controls.Add(tENNHOMLabel);
            this.Controls.Add(this.tENNHOMTextEdit);
            this.Controls.Add(this.nHOMNGUOIDUNGDataGridView);
            this.Controls.Add(this.nHOMNGUOIDUNGBindingNavigator);
            this.Name = "frmNhomND";
            this.Text = "frmNhomND";
            this.Load += new System.EventHandler(this.frmNhomND_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingNavigator)).EndInit();
            this.nHOMNGUOIDUNGBindingNavigator.ResumeLayout(false);
            this.nHOMNGUOIDUNGBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iD_NHOMTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENNHOMTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLND qLND;
        private System.Windows.Forms.BindingSource nHOMNGUOIDUNGBindingSource;
        private QLNDTableAdapters.NHOMNGUOIDUNGTableAdapter nHOMNGUOIDUNGTableAdapter;
        private QLNDTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator nHOMNGUOIDUNGBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton nHOMNGUOIDUNGBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView nHOMNGUOIDUNGDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DevExpress.XtraEditors.TextEdit iD_NHOMTextEdit;
        private DevExpress.XtraEditors.TextEdit tENNHOMTextEdit;
    }
}