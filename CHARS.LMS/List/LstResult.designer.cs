namespace CHARS.LMS.List
{
    partial class LstResult
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
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnRefreshSea = new System.Windows.Forms.Button();
            this.cboPeriod = new System.Windows.Forms.ComboBox();
            this.lblluckyType = new System.Windows.Forms.Label();
            this.cboLuckyType = new System.Windows.Forms.ComboBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.pan.SuspendLayout();
            this.grbList.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Size = new System.Drawing.Size(807, 441);
            // 
            // grbList
            // 
            this.grbList.Controls.Add(this.btnRefreshSea);
            this.grbList.Controls.Add(this.lblPeriod);
            this.grbList.Controls.Add(this.cboPeriod);
            this.grbList.Controls.Add(this.lblluckyType);
            this.grbList.Controls.Add(this.cboLuckyType);
            this.grbList.Controls.Add(this.dgvList);
            this.grbList.Size = new System.Drawing.Size(807, 441);
            this.grbList.Controls.SetChildIndex(this.dgvList, 0);
            this.grbList.Controls.SetChildIndex(this.cboLuckyType, 0);
            this.grbList.Controls.SetChildIndex(this.lblluckyType, 0);
            this.grbList.Controls.SetChildIndex(this.cboPeriod, 0);
            this.grbList.Controls.SetChildIndex(this.lblPeriod, 0);
            this.grbList.Controls.SetChildIndex(this.btnRefreshSea, 0);
            this.grbList.Controls.SetChildIndex(this.grbControl, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(432, 14);
            this.toolTipList.SetToolTip(this.btnSearch, "Click to show all");
            this.btnSearch.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(182, 14);
            this.toolTipList.SetToolTip(this.btnEdit, "Click to edit selected item");
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(99, 14);
            this.toolTipList.SetToolTip(this.btnAddNew, "Click to prepare new item");
            this.btnAddNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(682, 14);
            this.toolTipList.SetToolTip(this.btnExport, "Click to export to outsite");
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(348, 14);
            this.toolTipList.SetToolTip(this.btnImport, "Click to import from outsider");
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(599, 14);
            this.toolTipList.SetToolTip(this.btnPreview, "Click to preview report");
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // grbControl
            // 
            this.grbControl.Location = new System.Drawing.Point(3, 395);
            this.grbControl.Size = new System.Drawing.Size(801, 43);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(265, 14);
            this.toolTipList.SetToolTip(this.btnHistory, "Click to check history of selected item");
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(516, 14);
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(14, 26);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.RowTemplate.Height = 24;
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResult.Size = new System.Drawing.Size(739, 264);
            this.dgvResult.TabIndex = 17;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(3, 39);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowTemplate.Height = 24;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(801, 354);
            this.dgvList.TabIndex = 19;
            this.dgvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellDoubleClick);
            this.dgvList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvList_CellFormatting);
            // 
            // btnRefreshSea
            // 
            this.btnRefreshSea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshSea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.btnRefreshSea.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRefreshSea.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefreshSea.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshSea.ForeColor = System.Drawing.Color.Snow;
            this.btnRefreshSea.Location = new System.Drawing.Point(718, 11);
            this.btnRefreshSea.Name = "btnRefreshSea";
            this.btnRefreshSea.Size = new System.Drawing.Size(83, 23);
            this.btnRefreshSea.TabIndex = 174;
            this.btnRefreshSea.Text = "&Refresh";
            this.toolTipList.SetToolTip(this.btnRefreshSea, "Click to refrech all change");
            this.btnRefreshSea.UseVisualStyleBackColor = false;
            this.btnRefreshSea.Click += new System.EventHandler(this.btnRefreshSea_Click);
            // 
            // cboPeriod
            // 
            this.cboPeriod.FormattingEnabled = true;
            this.cboPeriod.Location = new System.Drawing.Point(295, 12);
            this.cboPeriod.Name = "cboPeriod";
            this.cboPeriod.Size = new System.Drawing.Size(123, 21);
            this.cboPeriod.TabIndex = 172;
            this.cboPeriod.Visible = false;
            // 
            // lblluckyType
            // 
            this.lblluckyType.AutoSize = true;
            this.lblluckyType.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblluckyType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblluckyType.Location = new System.Drawing.Point(3, 14);
            this.lblluckyType.Name = "lblluckyType";
            this.lblluckyType.Size = new System.Drawing.Size(73, 15);
            this.lblluckyType.TabIndex = 171;
            this.lblluckyType.Text = "Lucky Type :";
            // 
            // cboLuckyType
            // 
            this.cboLuckyType.FormattingEnabled = true;
            this.cboLuckyType.Location = new System.Drawing.Point(81, 12);
            this.cboLuckyType.Name = "cboLuckyType";
            this.cboLuckyType.Size = new System.Drawing.Size(121, 21);
            this.cboLuckyType.TabIndex = 170;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPeriod.Location = new System.Drawing.Point(248, 15);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(44, 15);
            this.lblPeriod.TabIndex = 173;
            this.lblPeriod.Text = "Period :";
            this.lblPeriod.Visible = false;
            // 
            // LstResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 441);
            this.Name = "LstResult";
            this.Text = "Result";
            this.Controls.SetChildIndex(this.pan, 0);
            this.pan.ResumeLayout(false);
            this.grbList.ResumeLayout(false);
            this.grbList.PerformLayout();
            this.grbControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.DataGridView dgvList;
        public System.Windows.Forms.Button btnRefreshSea;
        private System.Windows.Forms.ComboBox cboPeriod;
        public System.Windows.Forms.Label lblluckyType;
        private System.Windows.Forms.ComboBox cboLuckyType;
        public System.Windows.Forms.Label lblPeriod;
    }
}