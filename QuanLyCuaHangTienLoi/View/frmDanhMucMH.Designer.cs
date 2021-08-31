
namespace QuanLyCuaHangTienLoi.View
{
    partial class frmDanhMucMH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhMucMH));
            System.Windows.Forms.Label iD_MANHINHLabel;
            System.Windows.Forms.Label tENMANHINHLabel;
            this.mANHINHBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.mANHINHBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mANHINHDataGridView = new System.Windows.Forms.DataGridView();
            this.iD_MANHINHSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.tENMANHINHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mANHINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLND = new QuanLyCuaHangTienLoi.QLND();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANHINHTableAdapter = new QuanLyCuaHangTienLoi.QLNDTableAdapters.MANHINHTableAdapter();
            this.tableAdapterManager = new QuanLyCuaHangTienLoi.QLNDTableAdapters.TableAdapterManager();
            iD_MANHINHLabel = new System.Windows.Forms.Label();
            tENMANHINHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mANHINHBindingNavigator)).BeginInit();
            this.mANHINHBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mANHINHDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iD_MANHINHSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENMANHINHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mANHINHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLND)).BeginInit();
            this.SuspendLayout();
            // 
            // mANHINHBindingNavigator
            // 
            this.mANHINHBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mANHINHBindingNavigator.BindingSource = this.mANHINHBindingSource;
            this.mANHINHBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mANHINHBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mANHINHBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mANHINHBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.mANHINHBindingNavigatorSaveItem});
            this.mANHINHBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mANHINHBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mANHINHBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mANHINHBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mANHINHBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mANHINHBindingNavigator.Name = "mANHINHBindingNavigator";
            this.mANHINHBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mANHINHBindingNavigator.Size = new System.Drawing.Size(452, 27);
            this.mANHINHBindingNavigator.TabIndex = 0;
            this.mANHINHBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // mANHINHBindingNavigatorSaveItem
            // 
            this.mANHINHBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mANHINHBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mANHINHBindingNavigatorSaveItem.Image")));
            this.mANHINHBindingNavigatorSaveItem.Name = "mANHINHBindingNavigatorSaveItem";
            this.mANHINHBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.mANHINHBindingNavigatorSaveItem.Text = "Save Data";
            this.mANHINHBindingNavigatorSaveItem.Click += new System.EventHandler(this.mANHINHBindingNavigatorSaveItem_Click);
            // 
            // mANHINHDataGridView
            // 
            this.mANHINHDataGridView.AutoGenerateColumns = false;
            this.mANHINHDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mANHINHDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.mANHINHDataGridView.DataSource = this.mANHINHBindingSource;
            this.mANHINHDataGridView.Location = new System.Drawing.Point(12, 217);
            this.mANHINHDataGridView.Name = "mANHINHDataGridView";
            this.mANHINHDataGridView.RowHeadersWidth = 51;
            this.mANHINHDataGridView.RowTemplate.Height = 24;
            this.mANHINHDataGridView.Size = new System.Drawing.Size(428, 342);
            this.mANHINHDataGridView.TabIndex = 1;
            // 
            // iD_MANHINHLabel
            // 
            iD_MANHINHLabel.AutoSize = true;
            iD_MANHINHLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_MANHINHLabel.Location = new System.Drawing.Point(22, 85);
            iD_MANHINHLabel.Name = "iD_MANHINHLabel";
            iD_MANHINHLabel.Size = new System.Drawing.Size(30, 22);
            iD_MANHINHLabel.TabIndex = 2;
            iD_MANHINHLabel.Text = "ID";
            // 
            // iD_MANHINHSpinEdit
            // 
            this.iD_MANHINHSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mANHINHBindingSource, "ID_MANHINH", true));
            this.iD_MANHINHSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.iD_MANHINHSpinEdit.Location = new System.Drawing.Point(187, 79);
            this.iD_MANHINHSpinEdit.Name = "iD_MANHINHSpinEdit";
            this.iD_MANHINHSpinEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_MANHINHSpinEdit.Properties.Appearance.Options.UseFont = true;
            this.iD_MANHINHSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.iD_MANHINHSpinEdit.Size = new System.Drawing.Size(215, 28);
            this.iD_MANHINHSpinEdit.TabIndex = 3;
            // 
            // tENMANHINHLabel
            // 
            tENMANHINHLabel.AutoSize = true;
            tENMANHINHLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENMANHINHLabel.Location = new System.Drawing.Point(22, 134);
            tENMANHINHLabel.Name = "tENMANHINHLabel";
            tENMANHINHLabel.Size = new System.Drawing.Size(115, 22);
            tENMANHINHLabel.TabIndex = 4;
            tENMANHINHLabel.Text = "Tên màn hinh";
            // 
            // tENMANHINHTextEdit
            // 
            this.tENMANHINHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mANHINHBindingSource, "TENMANHINH", true));
            this.tENMANHINHTextEdit.Location = new System.Drawing.Point(187, 128);
            this.tENMANHINHTextEdit.Name = "tENMANHINHTextEdit";
            this.tENMANHINHTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENMANHINHTextEdit.Properties.Appearance.Options.UseFont = true;
            this.tENMANHINHTextEdit.Size = new System.Drawing.Size(215, 28);
            this.tENMANHINHTextEdit.TabIndex = 5;
            // 
            // mANHINHBindingSource
            // 
            this.mANHINHBindingSource.DataMember = "MANHINH";
            this.mANHINHBindingSource.DataSource = this.qLND;
            // 
            // qLND
            // 
            this.qLND.DataSetName = "QLND";
            this.qLND.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_MANHINH";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_MANHINH";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENMANHINH";
            this.dataGridViewTextBoxColumn2.HeaderText = "TENMANHINH";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // mANHINHTableAdapter
            // 
            this.mANHINHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MANHINHTableAdapter = this.mANHINHTableAdapter;
            this.tableAdapterManager.NGUOIDUNGNHOMNGUOIDUNGDKTableAdapter = null;
            this.tableAdapterManager.NGUOIDUNGNHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.NGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.NHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.PHANQUYENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyCuaHangTienLoi.QLNDTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmDanhMucMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 579);
            this.Controls.Add(iD_MANHINHLabel);
            this.Controls.Add(this.iD_MANHINHSpinEdit);
            this.Controls.Add(tENMANHINHLabel);
            this.Controls.Add(this.tENMANHINHTextEdit);
            this.Controls.Add(this.mANHINHDataGridView);
            this.Controls.Add(this.mANHINHBindingNavigator);
            this.Name = "frmDanhMucMH";
            this.Text = "frmDanhMucMH";
            this.Load += new System.EventHandler(this.frmDanhMucMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mANHINHBindingNavigator)).EndInit();
            this.mANHINHBindingNavigator.ResumeLayout(false);
            this.mANHINHBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mANHINHDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iD_MANHINHSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENMANHINHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mANHINHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLND)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLND qLND;
        private System.Windows.Forms.BindingSource mANHINHBindingSource;
        private QLNDTableAdapters.MANHINHTableAdapter mANHINHTableAdapter;
        private QLNDTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mANHINHBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton mANHINHBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView mANHINHDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DevExpress.XtraEditors.SpinEdit iD_MANHINHSpinEdit;
        private DevExpress.XtraEditors.TextEdit tENMANHINHTextEdit;
    }
}