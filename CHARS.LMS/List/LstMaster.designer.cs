namespace CHARS.LMS.List
{
    partial class LstMaster
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMaster = new System.Windows.Forms.DataGridView();
            this.dgvConList = new System.Windows.Forms.DataGridView();
            this.pan.SuspendLayout();
            this.grbList.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConList)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Size = new System.Drawing.Size(790, 446);
            // 
            // grbList
            // 
            this.grbList.Controls.Add(this.dgvConList);
            this.grbList.Size = new System.Drawing.Size(790, 446);
            this.grbList.Controls.SetChildIndex(this.grbControl, 0);
            this.grbList.Controls.SetChildIndex(this.dgvConList, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(369, 14);
            this.toolTipList.SetToolTip(this.btnSearch, "Click to show all");
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(119, 14);
            this.toolTipList.SetToolTip(this.btnEdit, "Click to edit selected item");
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(36, 14);
            this.toolTipList.SetToolTip(this.btnAddNew, "Click to prepare new item");
            this.btnAddNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(619, 14);
            this.toolTipList.SetToolTip(this.btnExport, "Click to export to outsite");
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(285, 14);
            this.toolTipList.SetToolTip(this.btnImport, "Click to import from outsider");
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(536, 14);
            this.toolTipList.SetToolTip(this.btnPreview, "Click to preview report");
            // 
            // grbControl
            // 
            this.grbControl.Location = new System.Drawing.Point(3, 400);
            this.grbControl.Size = new System.Drawing.Size(784, 43);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(202, 14);
            this.toolTipList.SetToolTip(this.btnHistory, "Click to check history of selected item");
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(453, 14);
            // 
            // dgvMaster
            // 
            this.dgvMaster.AllowUserToAddRows = false;
            this.dgvMaster.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvMaster.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaster.Location = new System.Drawing.Point(9, 26);
            this.dgvMaster.Name = "dgvMaster";
            this.dgvMaster.ReadOnly = true;
            this.dgvMaster.RowHeadersVisible = false;
            this.dgvMaster.RowTemplate.Height = 24;
            this.dgvMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaster.Size = new System.Drawing.Size(731, 231);
            this.dgvMaster.TabIndex = 16;
            this.dgvMaster.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerson_CellDoubleClick);
            this.dgvMaster.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMaster_CellFormatting);
            // 
            // dgvConList
            // 
            this.dgvConList.AllowUserToAddRows = false;
            this.dgvConList.AllowUserToDeleteRows = false;
            this.dgvConList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvConList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConList.Location = new System.Drawing.Point(3, 16);
            this.dgvConList.Name = "dgvConList";
            this.dgvConList.ReadOnly = true;
            this.dgvConList.RowHeadersVisible = false;
            this.dgvConList.RowTemplate.Height = 24;
            this.dgvConList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvConList.Size = new System.Drawing.Size(784, 384);
            this.dgvConList.TabIndex = 19;
            // 
            // LstMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 446);
            this.Name = "LstMaster";
            this.Text = "LstMaster";
            this.Controls.SetChildIndex(this.pan, 0);
            this.pan.ResumeLayout(false);
            this.grbList.ResumeLayout(false);
            this.grbControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaster;
        private System.Windows.Forms.DataGridView dgvConList;
    }
}