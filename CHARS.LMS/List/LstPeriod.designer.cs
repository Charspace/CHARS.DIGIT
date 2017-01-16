namespace CHARS.LMS.List
{
    partial class LstPeriod
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
            this.dgvPeriod = new System.Windows.Forms.DataGridView();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnRevert = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnRefreshSea = new System.Windows.Forms.Button();
            this.lblSubmitDate = new System.Windows.Forms.Label();
            this.nmcYear = new System.Windows.Forms.NumericUpDown();
            this.pan.SuspendLayout();
            this.grbList.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcYear)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Size = new System.Drawing.Size(900, 520);
            // 
            // grbList
            // 
            this.grbList.Controls.Add(this.nmcYear);
            this.grbList.Controls.Add(this.lblSubmitDate);
            this.grbList.Controls.Add(this.btnRevert);
            this.grbList.Controls.Add(this.btnProcess);
            this.grbList.Controls.Add(this.btnRefreshSea);
            this.grbList.Controls.Add(this.dgvList);
            this.grbList.Size = new System.Drawing.Size(900, 520);
            this.grbList.Controls.SetChildIndex(this.grbControl, 0);
            this.grbList.Controls.SetChildIndex(this.dgvList, 0);
            this.grbList.Controls.SetChildIndex(this.btnRefreshSea, 0);
            this.grbList.Controls.SetChildIndex(this.btnProcess, 0);
            this.grbList.Controls.SetChildIndex(this.btnRevert, 0);
            this.grbList.Controls.SetChildIndex(this.lblSubmitDate, 0);
            this.grbList.Controls.SetChildIndex(this.nmcYear, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(607, 14);
            this.toolTipList.SetToolTip(this.btnSearch, "Click to show all");
            this.btnSearch.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(357, 14);
            this.toolTipList.SetToolTip(this.btnEdit, "Click to edit selected item");
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(274, 14);
            this.toolTipList.SetToolTip(this.btnAddNew, "Click to prepare new item");
            this.btnAddNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(857, 14);
            this.toolTipList.SetToolTip(this.btnExport, "Click to export to outsite");
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(523, 14);
            this.toolTipList.SetToolTip(this.btnImport, "Click to import from outsider");
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(774, 14);
            this.toolTipList.SetToolTip(this.btnPreview, "Click to preview report");
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // grbControl
            // 
            this.grbControl.Location = new System.Drawing.Point(3, 474);
            this.grbControl.Size = new System.Drawing.Size(894, 43);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(440, 14);
            this.toolTipList.SetToolTip(this.btnHistory, "Click to check history of selected item");
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(691, 14);
            // 
            // dgvPeriod
            // 
            this.dgvPeriod.AllowUserToAddRows = false;
            this.dgvPeriod.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvPeriod.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPeriod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeriod.Location = new System.Drawing.Point(6, 22);
            this.dgvPeriod.Name = "dgvPeriod";
            this.dgvPeriod.ReadOnly = true;
            this.dgvPeriod.RowHeadersVisible = false;
            this.dgvPeriod.RowTemplate.Height = 24;
            this.dgvPeriod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeriod.Size = new System.Drawing.Size(731, 231);
            this.dgvPeriod.TabIndex = 17;
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
            this.dgvList.Location = new System.Drawing.Point(3, 42);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowTemplate.Height = 24;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(891, 426);
            this.dgvList.TabIndex = 19;
            this.dgvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellDoubleClick);
            this.dgvList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvList_CellFormatting);
            this.dgvList.SelectionChanged += new System.EventHandler(this.dgvList_SelectionChanged);
            this.dgvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentClick);
            // 
            // btnRevert
            // 
            this.btnRevert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRevert.BackColor = System.Drawing.SystemColors.Control;
            this.btnRevert.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevert.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnRevert.Location = new System.Drawing.Point(725, 12);
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.Size = new System.Drawing.Size(83, 23);
            this.btnRevert.TabIndex = 174;
            this.btnRevert.Text = "&Revert";
            this.btnRevert.UseVisualStyleBackColor = false;
            this.btnRevert.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcess.BackColor = System.Drawing.SystemColors.Control;
            this.btnProcess.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnProcess.Location = new System.Drawing.Point(636, 12);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(83, 23);
            this.btnProcess.TabIndex = 173;
            this.btnProcess.Text = "&Process";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnRefreshSea
            // 
            this.btnRefreshSea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshSea.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefreshSea.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRefreshSea.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshSea.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnRefreshSea.Location = new System.Drawing.Point(814, 13);
            this.btnRefreshSea.Name = "btnRefreshSea";
            this.btnRefreshSea.Size = new System.Drawing.Size(83, 23);
            this.btnRefreshSea.TabIndex = 172;
            this.btnRefreshSea.Text = "&Refresh";
            this.toolTipList.SetToolTip(this.btnRefreshSea, "Click to refrech all change");
            this.btnRefreshSea.UseVisualStyleBackColor = false;
            this.btnRefreshSea.Click += new System.EventHandler(this.btnRefreshSea_Click);
            // 
            // lblSubmitDate
            // 
            this.lblSubmitDate.AutoSize = true;
            this.lblSubmitDate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmitDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSubmitDate.Location = new System.Drawing.Point(6, 16);
            this.lblSubmitDate.Name = "lblSubmitDate";
            this.lblSubmitDate.Size = new System.Drawing.Size(28, 15);
            this.lblSubmitDate.TabIndex = 127;
            this.lblSubmitDate.Text = "Year";
            // 
            // nmcYear
            // 
            this.nmcYear.Location = new System.Drawing.Point(40, 15);
            this.nmcYear.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmcYear.Name = "nmcYear";
            this.nmcYear.Size = new System.Drawing.Size(74, 20);
            this.nmcYear.TabIndex = 175;
            // 
            // LstPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 520);
            this.Name = "LstPeriod";
            this.Text = "Period";
            this.Controls.SetChildIndex(this.pan, 0);
            this.pan.ResumeLayout(false);
            this.grbList.ResumeLayout(false);
            this.grbList.PerformLayout();
            this.grbControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeriod;
        private System.Windows.Forms.DataGridView dgvList;
        public System.Windows.Forms.Button btnRevert;
        public System.Windows.Forms.Button btnProcess;
        public System.Windows.Forms.Button btnRefreshSea;
        public System.Windows.Forms.Label lblSubmitDate;
        private System.Windows.Forms.NumericUpDown nmcYear;
    }
}