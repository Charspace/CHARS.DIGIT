
namespace CHARS.LMS.List
{
    partial class LstLucyType
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLuckyType = new System.Windows.Forms.DataGridView();
            this.dgvConList = new System.Windows.Forms.DataGridView();
            this.dgvLuckyTypeList = new System.Windows.Forms.DataGridView();
            this.pan.SuspendLayout();
            this.grbList.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuckyType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuckyTypeList)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Size = new System.Drawing.Size(1045, 437);
            // 
            // grbList
            // 
            this.grbList.Controls.Add(this.dgvLuckyTypeList);
            this.grbList.Size = new System.Drawing.Size(1045, 437);
            this.grbList.Controls.SetChildIndex(this.grbControl, 0);
            this.grbList.Controls.SetChildIndex(this.dgvLuckyTypeList, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(562, 14);
            this.toolTipList.SetToolTip(this.btnSearch, "Click to search");
            this.btnSearch.Click += new System.EventHandler(this.butFind_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(299, 14);
            this.toolTipList.SetToolTip(this.btnEdit, "Click to edit selected item");
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(212, 14);
            this.toolTipList.SetToolTip(this.btnAddNew, "Click to prepare new item");
            this.btnAddNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(822, 15);
            this.toolTipList.SetToolTip(this.btnExport, "Click to export to outsite");
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(474, 14);
            this.toolTipList.SetToolTip(this.btnImport, "Click to import from outsider");
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(736, 14);
            this.toolTipList.SetToolTip(this.btnPreview, "Click to preview report");
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // grbControl
            // 
            this.grbControl.Location = new System.Drawing.Point(3, 391);
            this.grbControl.Size = new System.Drawing.Size(1039, 43);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(387, 14);
            this.toolTipList.SetToolTip(this.btnHistory, "Click to check history of selected item");
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(650, 14);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvLuckyType
            // 
            this.dgvLuckyType.AllowUserToAddRows = false;
            this.dgvLuckyType.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvLuckyType.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLuckyType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLuckyType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuckyType.Location = new System.Drawing.Point(5, 19);
            this.dgvLuckyType.Name = "dgvLuckyType";
            this.dgvLuckyType.ReadOnly = true;
            this.dgvLuckyType.RowHeadersVisible = false;
            this.dgvLuckyType.RowTemplate.Height = 24;
            this.dgvLuckyType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLuckyType.Size = new System.Drawing.Size(1021, 270);
            this.dgvLuckyType.TabIndex = 14;
            // 
            // dgvConList
            // 
            this.dgvConList.AllowUserToAddRows = false;
            this.dgvConList.AllowUserToDeleteRows = false;
            this.dgvConList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvConList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvConList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConList.Location = new System.Drawing.Point(3, 16);
            this.dgvConList.Name = "dgvConList";
            this.dgvConList.ReadOnly = true;
            this.dgvConList.RowHeadersVisible = false;
            this.dgvConList.RowTemplate.Height = 24;
            this.dgvConList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvConList.Size = new System.Drawing.Size(1039, 375);
            this.dgvConList.TabIndex = 19;
            // 
            // dgvLuckyTypeList
            // 
            this.dgvLuckyTypeList.AllowUserToAddRows = false;
            this.dgvLuckyTypeList.AllowUserToDeleteRows = false;
            this.dgvLuckyTypeList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvLuckyTypeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLuckyTypeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLuckyTypeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuckyTypeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLuckyTypeList.Location = new System.Drawing.Point(3, 16);
            this.dgvLuckyTypeList.MultiSelect = false;
            this.dgvLuckyTypeList.Name = "dgvLuckyTypeList";
            this.dgvLuckyTypeList.ReadOnly = true;
            this.dgvLuckyTypeList.RowHeadersVisible = false;
            this.dgvLuckyTypeList.RowTemplate.Height = 24;
            this.dgvLuckyTypeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLuckyTypeList.Size = new System.Drawing.Size(1039, 375);
            this.dgvLuckyTypeList.TabIndex = 20;
            this.dgvLuckyTypeList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLuckyTypeList_CellDoubleClick);
            this.dgvLuckyTypeList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLuckyTypeList_CellFormatting);
            // 
            // LstLucyType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 437);
            this.Name = "LstLucyType";
            this.Text = "Lucy Type";
            this.Controls.SetChildIndex(this.pan, 0);
            this.pan.ResumeLayout(false);
            this.grbList.ResumeLayout(false);
            this.grbControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuckyType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuckyTypeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLuckyType;
        private System.Windows.Forms.DataGridView dgvConList;
        private System.Windows.Forms.DataGridView dgvLuckyTypeList;
    }
}