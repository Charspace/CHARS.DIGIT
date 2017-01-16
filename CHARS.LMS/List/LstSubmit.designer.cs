namespace CHARS.LMS.List
{
    partial class LstSubmit
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
            this.dgvSubmit = new System.Windows.Forms.DataGridView();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.lblluckyType = new System.Windows.Forms.Label();
            this.cboLuckyType = new System.Windows.Forms.ComboBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.cboPeriod = new System.Windows.Forms.ComboBox();
            this.btnRefreshSea = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.lblSummary = new System.Windows.Forms.Button();
            this.pan.SuspendLayout();
            this.grbList.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubmit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Size = new System.Drawing.Size(815, 470);
            // 
            // grbList
            // 
            this.grbList.Controls.Add(this.lblSummary);
            this.grbList.Controls.Add(this.btnDetail);
            this.grbList.Controls.Add(this.btnRefreshSea);
            this.grbList.Controls.Add(this.lblPeriod);
            this.grbList.Controls.Add(this.cboPeriod);
            this.grbList.Controls.Add(this.lblluckyType);
            this.grbList.Controls.Add(this.cboLuckyType);
            this.grbList.Controls.Add(this.dgvList);
            this.grbList.Size = new System.Drawing.Size(815, 470);
            this.grbList.Controls.SetChildIndex(this.grbControl, 0);
            this.grbList.Controls.SetChildIndex(this.dgvList, 0);
            this.grbList.Controls.SetChildIndex(this.cboLuckyType, 0);
            this.grbList.Controls.SetChildIndex(this.lblluckyType, 0);
            this.grbList.Controls.SetChildIndex(this.cboPeriod, 0);
            this.grbList.Controls.SetChildIndex(this.lblPeriod, 0);
            this.grbList.Controls.SetChildIndex(this.btnRefreshSea, 0);
            this.grbList.Controls.SetChildIndex(this.btnDetail, 0);
            this.grbList.Controls.SetChildIndex(this.lblSummary, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(486, 14);
            this.toolTipList.SetToolTip(this.btnSearch, "Click to show all");
            this.btnSearch.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(236, 14);
            this.toolTipList.SetToolTip(this.btnEdit, "Click to edit selected item");
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(153, 14);
            this.toolTipList.SetToolTip(this.btnAddNew, "Click to prepare new item");
            this.btnAddNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(736, 14);
            this.toolTipList.SetToolTip(this.btnExport, "Click to export to outsite");
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(402, 14);
            this.toolTipList.SetToolTip(this.btnImport, "Click to import from outsider");
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(653, 14);
            this.toolTipList.SetToolTip(this.btnPreview, "Click to preview report");
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // grbControl
            // 
            this.grbControl.Location = new System.Drawing.Point(3, 424);
            this.grbControl.Size = new System.Drawing.Size(809, 43);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(319, 14);
            this.toolTipList.SetToolTip(this.btnHistory, "Click to check history of selected item");
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(570, 14);
            // 
            // dgvSubmit
            // 
            this.dgvSubmit.AllowUserToAddRows = false;
            this.dgvSubmit.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvSubmit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSubmit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubmit.Location = new System.Drawing.Point(14, 26);
            this.dgvSubmit.Name = "dgvSubmit";
            this.dgvSubmit.ReadOnly = true;
            this.dgvSubmit.RowHeadersVisible = false;
            this.dgvSubmit.RowTemplate.Height = 24;
            this.dgvSubmit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubmit.Size = new System.Drawing.Size(739, 240);
            this.dgvSubmit.TabIndex = 17;
            this.dgvSubmit.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubmit_CellDoubleClick);
            this.dgvSubmit.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSubmit_CellFormatting);
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
            this.dgvList.Location = new System.Drawing.Point(3, 44);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowTemplate.Height = 24;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(809, 380);
            this.dgvList.TabIndex = 19;
            this.dgvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubmit_CellDoubleClick);
            this.dgvList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSubmit_CellFormatting);
            // 
            // lblluckyType
            // 
            this.lblluckyType.AutoSize = true;
            this.lblluckyType.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblluckyType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblluckyType.Location = new System.Drawing.Point(6, 13);
            this.lblluckyType.Name = "lblluckyType";
            this.lblluckyType.Size = new System.Drawing.Size(73, 15);
            this.lblluckyType.TabIndex = 141;
            this.lblluckyType.Text = "Lucky Type :";
            // 
            // cboLuckyType
            // 
            this.cboLuckyType.FormattingEnabled = true;
            this.cboLuckyType.Location = new System.Drawing.Point(84, 11);
            this.cboLuckyType.Name = "cboLuckyType";
            this.cboLuckyType.Size = new System.Drawing.Size(121, 21);
            this.cboLuckyType.TabIndex = 140;
            this.cboLuckyType.SelectedIndexChanged += new System.EventHandler(this.cboLuckyType_SelectedIndexChanged);
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPeriod.Location = new System.Drawing.Point(251, 14);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(44, 15);
            this.lblPeriod.TabIndex = 143;
            this.lblPeriod.Text = "Period :";
            // 
            // cboPeriod
            // 
            this.cboPeriod.FormattingEnabled = true;
            this.cboPeriod.Location = new System.Drawing.Point(298, 11);
            this.cboPeriod.Name = "cboPeriod";
            this.cboPeriod.Size = new System.Drawing.Size(123, 21);
            this.cboPeriod.TabIndex = 142;
            // 
            // btnRefreshSea
            // 
            this.btnRefreshSea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshSea.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefreshSea.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRefreshSea.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshSea.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnRefreshSea.Location = new System.Drawing.Point(729, 10);
            this.btnRefreshSea.Name = "btnRefreshSea";
            this.btnRefreshSea.Size = new System.Drawing.Size(83, 23);
            this.btnRefreshSea.TabIndex = 169;
            this.btnRefreshSea.Text = "&Refresh";
            this.toolTipList.SetToolTip(this.btnRefreshSea, "Click to refrech all change");
            this.btnRefreshSea.UseVisualStyleBackColor = false;
            this.btnRefreshSea.Click += new System.EventHandler(this.btnRefreshSea_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetail.BackColor = System.Drawing.SystemColors.Control;
            this.btnDetail.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDetail.Location = new System.Drawing.Point(551, 9);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(83, 23);
            this.btnDetail.TabIndex = 170;
            this.btnDetail.Text = "&Detail";
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // lblSummary
            // 
            this.lblSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSummary.BackColor = System.Drawing.SystemColors.Control;
            this.lblSummary.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSummary.Location = new System.Drawing.Point(640, 9);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(83, 23);
            this.lblSummary.TabIndex = 171;
            this.lblSummary.Text = "&Summary";
            this.lblSummary.UseVisualStyleBackColor = false;
            this.lblSummary.Click += new System.EventHandler(this.lblSummary_Click);
            // 
            // LstSubmit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 470);
            this.Name = "LstSubmit";
            this.Text = "Submit";
            this.Controls.SetChildIndex(this.pan, 0);
            this.pan.ResumeLayout(false);
            this.grbList.ResumeLayout(false);
            this.grbList.PerformLayout();
            this.grbControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubmit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubmit;
        private System.Windows.Forms.DataGridView dgvList;
        public System.Windows.Forms.Label lblluckyType;
        private System.Windows.Forms.ComboBox cboLuckyType;
        public System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.ComboBox cboPeriod;
        public System.Windows.Forms.Button btnRefreshSea;
        public System.Windows.Forms.Button btnDetail;
        public System.Windows.Forms.Button lblSummary;
    }
}