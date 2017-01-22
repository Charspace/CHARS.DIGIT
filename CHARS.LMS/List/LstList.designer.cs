namespace CHARS.LMS.List
{
    partial class LstList
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
            this.dgvConList = new System.Windows.Forms.DataGridView();
            this.dgvConListAll = new System.Windows.Forms.DataGridView();
            this.cboLuckyType = new System.Windows.Forms.ComboBox();
            this.lblluckyType = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.btnRefreshSea = new System.Windows.Forms.Button();
            this.pan.SuspendLayout();
            this.grbList.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConListAll)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Size = new System.Drawing.Size(1042, 482);
            // 
            // grbList
            // 
            this.grbList.Controls.Add(this.btnRefreshSea);
            this.grbList.Controls.Add(this.dtpStartDate);
            this.grbList.Controls.Add(this.lblStartDate);
            this.grbList.Controls.Add(this.cboLuckyType);
            this.grbList.Controls.Add(this.lblluckyType);
            this.grbList.Controls.Add(this.dgvConListAll);
            this.grbList.Size = new System.Drawing.Size(1042, 482);
            this.grbList.Controls.SetChildIndex(this.grbControl, 0);
            this.grbList.Controls.SetChildIndex(this.dgvConListAll, 0);
            this.grbList.Controls.SetChildIndex(this.lblluckyType, 0);
            this.grbList.Controls.SetChildIndex(this.cboLuckyType, 0);
            this.grbList.Controls.SetChildIndex(this.lblStartDate, 0);
            this.grbList.Controls.SetChildIndex(this.dtpStartDate, 0);
            this.grbList.Controls.SetChildIndex(this.btnRefreshSea, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(608, 14);
            this.toolTipList.SetToolTip(this.btnSearch, "Click to show all");
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(358, 14);
            this.toolTipList.SetToolTip(this.btnEdit, "Click to edit selected item");
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(275, 14);
            this.toolTipList.SetToolTip(this.btnAddNew, "Click to prepare new item");
            this.btnAddNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(860, 14);
            this.toolTipList.SetToolTip(this.btnExport, "Click to export to outsite");
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(524, 14);
            this.toolTipList.SetToolTip(this.btnImport, "Click to import from outsider");
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(775, 14);
            this.toolTipList.SetToolTip(this.btnPreview, "Click to preview report");
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // grbControl
            // 
            this.grbControl.Location = new System.Drawing.Point(3, 436);
            this.grbControl.Size = new System.Drawing.Size(1036, 43);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(441, 14);
            this.toolTipList.SetToolTip(this.btnHistory, "Click to check history of selected item");
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(692, 14);
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvConList
            // 
            this.dgvConList.AllowUserToAddRows = false;
            this.dgvConList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvConList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConList.Location = new System.Drawing.Point(19, 22);
            this.dgvConList.Name = "dgvConList";
            this.dgvConList.ReadOnly = true;
            this.dgvConList.RowHeadersVisible = false;
            this.dgvConList.RowTemplate.Height = 24;
            this.dgvConList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConList.Size = new System.Drawing.Size(731, 231);
            this.dgvConList.TabIndex = 17;
            // 
            // dgvConListAll
            // 
            this.dgvConListAll.AllowUserToAddRows = false;
            this.dgvConListAll.AllowUserToDeleteRows = false;
            this.dgvConListAll.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvConListAll.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConListAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConListAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConListAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConListAll.Location = new System.Drawing.Point(3, 38);
            this.dgvConListAll.MultiSelect = false;
            this.dgvConListAll.Name = "dgvConListAll";
            this.dgvConListAll.ReadOnly = true;
            this.dgvConListAll.RowHeadersVisible = false;
            this.dgvConListAll.RowTemplate.Height = 24;
            this.dgvConListAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConListAll.Size = new System.Drawing.Size(1036, 406);
            this.dgvConListAll.TabIndex = 19;
            this.dgvConListAll.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConListAll_CellDoubleClick);
            this.dgvConListAll.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvConListAll_CellFormatting);
            // 
            // cboLuckyType
            // 
            this.cboLuckyType.FormattingEnabled = true;
            this.cboLuckyType.Location = new System.Drawing.Point(79, 11);
            this.cboLuckyType.Name = "cboLuckyType";
            this.cboLuckyType.Size = new System.Drawing.Size(153, 21);
            this.cboLuckyType.TabIndex = 165;
            // 
            // lblluckyType
            // 
            this.lblluckyType.AutoSize = true;
            this.lblluckyType.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblluckyType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblluckyType.Location = new System.Drawing.Point(6, 13);
            this.lblluckyType.Name = "lblluckyType";
            this.lblluckyType.Size = new System.Drawing.Size(77, 15);
            this.lblluckyType.TabIndex = 164;
            this.lblluckyType.Text = "Lucky Type : ";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(310, 12);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(146, 20);
            this.dtpStartDate.TabIndex = 166;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStartDate.Location = new System.Drawing.Point(249, 13);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(62, 15);
            this.lblStartDate.TabIndex = 167;
            this.lblStartDate.Text = "Start Date :";
            // 
            // btnRefreshSea
            // 
            this.btnRefreshSea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshSea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.btnRefreshSea.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRefreshSea.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefreshSea.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshSea.ForeColor = System.Drawing.Color.Snow;
            this.btnRefreshSea.Location = new System.Drawing.Point(953, 11);
            this.btnRefreshSea.Name = "btnRefreshSea";
            this.btnRefreshSea.Size = new System.Drawing.Size(83, 23);
            this.btnRefreshSea.TabIndex = 168;
            this.btnRefreshSea.Text = "&Refresh";
            this.toolTipList.SetToolTip(this.btnRefreshSea, "Click to refrech all change");
            this.btnRefreshSea.UseVisualStyleBackColor = false;
            this.btnRefreshSea.Click += new System.EventHandler(this.btnRefreshSea_Click);
            // 
            // LstList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 482);
            this.Name = "LstList";
            this.Text = "List";
            this.Controls.SetChildIndex(this.pan, 0);
            this.pan.ResumeLayout(false);
            this.grbList.ResumeLayout(false);
            this.grbList.PerformLayout();
            this.grbControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConListAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConList;
        private System.Windows.Forms.DataGridView dgvConListAll;
        private System.Windows.Forms.ComboBox cboLuckyType;
        public System.Windows.Forms.Label lblluckyType;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        public System.Windows.Forms.Label lblStartDate;
        public System.Windows.Forms.Button btnRefreshSea;
    }
}