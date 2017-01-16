namespace CHARS.LMS.List
{
    partial class LstGain
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
            this.btnRefreshSea = new System.Windows.Forms.Button();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.cboPeriod = new System.Windows.Forms.ComboBox();
            this.lblluckyType = new System.Windows.Forms.Label();
            this.cboLuckyType = new System.Windows.Forms.ComboBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboLPeriod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLT = new System.Windows.Forms.ComboBox();
            this.dgvGainlist = new System.Windows.Forms.DataGridView();
            this.pan.SuspendLayout();
            this.grbList.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGainlist)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Size = new System.Drawing.Size(836, 441);
            // 
            // grbList
            // 
            this.grbList.Controls.Add(this.label2);
            this.grbList.Controls.Add(this.cboState);
            this.grbList.Controls.Add(this.button1);
            this.grbList.Controls.Add(this.button2);
            this.grbList.Controls.Add(this.label3);
            this.grbList.Controls.Add(this.cboLPeriod);
            this.grbList.Controls.Add(this.label4);
            this.grbList.Controls.Add(this.cboLT);
            this.grbList.Controls.Add(this.dgvGainlist);
            this.grbList.Size = new System.Drawing.Size(836, 441);
            this.grbList.Controls.SetChildIndex(this.grbControl, 0);
            this.grbList.Controls.SetChildIndex(this.dgvGainlist, 0);
            this.grbList.Controls.SetChildIndex(this.cboLT, 0);
            this.grbList.Controls.SetChildIndex(this.label4, 0);
            this.grbList.Controls.SetChildIndex(this.cboLPeriod, 0);
            this.grbList.Controls.SetChildIndex(this.label3, 0);
            this.grbList.Controls.SetChildIndex(this.button2, 0);
            this.grbList.Controls.SetChildIndex(this.button1, 0);
            this.grbList.Controls.SetChildIndex(this.cboState, 0);
            this.grbList.Controls.SetChildIndex(this.label2, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(449, 14);
            this.toolTipList.SetToolTip(this.btnSearch, "Click to search");
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(186, 14);
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
            this.btnExport.Location = new System.Drawing.Point(709, 14);
            this.toolTipList.SetToolTip(this.btnExport, "Click to export to outsite");
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(361, 14);
            this.toolTipList.SetToolTip(this.btnImport, "Click to import from outsider");
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(623, 14);
            this.toolTipList.SetToolTip(this.btnPreview, "Click to preview report");
            // 
            // grbControl
            // 
            this.grbControl.Location = new System.Drawing.Point(3, 395);
            this.grbControl.Size = new System.Drawing.Size(830, 43);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(274, 14);
            this.toolTipList.SetToolTip(this.btnHistory, "Click to check history of selected item");
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(537, 14);
            // 
            // dgvConList
            // 
            this.dgvConList.AllowUserToAddRows = false;
            this.dgvConList.AllowUserToDeleteRows = false;
            this.dgvConList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvConList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConList.Location = new System.Drawing.Point(3, 40);
            this.dgvConList.Name = "dgvConList";
            this.dgvConList.ReadOnly = true;
            this.dgvConList.RowHeadersVisible = false;
            this.dgvConList.RowTemplate.Height = 24;
            this.dgvConList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvConList.Size = new System.Drawing.Size(830, 353);
            this.dgvConList.TabIndex = 19;
            // 
            // btnRefreshSea
            // 
            this.btnRefreshSea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshSea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.btnRefreshSea.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRefreshSea.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefreshSea.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshSea.ForeColor = System.Drawing.Color.Snow;
            this.btnRefreshSea.Location = new System.Drawing.Point(746, 11);
            this.btnRefreshSea.Name = "btnRefreshSea";
            this.btnRefreshSea.Size = new System.Drawing.Size(83, 23);
            this.btnRefreshSea.TabIndex = 179;
            this.btnRefreshSea.Text = "&Refresh";
            this.btnRefreshSea.UseVisualStyleBackColor = false;
            this.btnRefreshSea.Click += new System.EventHandler(this.btnRefreshSea_Click);
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPeriod.Location = new System.Drawing.Point(224, 16);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(44, 15);
            this.lblPeriod.TabIndex = 178;
            this.lblPeriod.Text = "Period :";
            // 
            // cboPeriod
            // 
            this.cboPeriod.FormattingEnabled = true;
            this.cboPeriod.Location = new System.Drawing.Point(271, 13);
            this.cboPeriod.Name = "cboPeriod";
            this.cboPeriod.Size = new System.Drawing.Size(123, 21);
            this.cboPeriod.TabIndex = 177;
            // 
            // lblluckyType
            // 
            this.lblluckyType.AutoSize = true;
            this.lblluckyType.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblluckyType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblluckyType.Location = new System.Drawing.Point(5, 15);
            this.lblluckyType.Name = "lblluckyType";
            this.lblluckyType.Size = new System.Drawing.Size(73, 15);
            this.lblluckyType.TabIndex = 176;
            this.lblluckyType.Text = "Lucky Type :";
            // 
            // cboLuckyType
            // 
            this.cboLuckyType.FormattingEnabled = true;
            this.cboLuckyType.Location = new System.Drawing.Point(83, 13);
            this.cboLuckyType.Name = "cboLuckyType";
            this.cboLuckyType.Size = new System.Drawing.Size(121, 21);
            this.cboLuckyType.TabIndex = 175;
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.btnProcess.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnProcess.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.ForeColor = System.Drawing.Color.Snow;
            this.btnProcess.Location = new System.Drawing.Point(661, 11);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(83, 23);
            this.btnProcess.TabIndex = 180;
            this.btnProcess.Text = "&Process";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(420, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 182;
            this.label1.Text = "Status :";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Gain",
            "Lose",
            "All"});
            this.cboStatus.Location = new System.Drawing.Point(467, 14);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(123, 21);
            this.cboStatus.TabIndex = 181;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(420, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 191;
            this.label2.Text = "Status :";
            // 
            // cboState
            // 
            this.cboState.FormattingEnabled = true;
            this.cboState.Items.AddRange(new object[] {
            "Gain",
            "Lose",
            "All"});
            this.cboState.Location = new System.Drawing.Point(467, 16);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(123, 21);
            this.cboState.TabIndex = 190;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(661, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 189;
            this.button1.Text = "&Process";
            this.toolTipList.SetToolTip(this.button1, "Click to refrech all change");
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(746, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 188;
            this.button2.Text = "&Refresh";
            this.toolTipList.SetToolTip(this.button2, "Click to refrech all change");
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(224, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 187;
            this.label3.Text = "Period :";
            // 
            // cboLPeriod
            // 
            this.cboLPeriod.FormattingEnabled = true;
            this.cboLPeriod.Location = new System.Drawing.Point(271, 15);
            this.cboLPeriod.Name = "cboLPeriod";
            this.cboLPeriod.Size = new System.Drawing.Size(123, 21);
            this.cboLPeriod.TabIndex = 186;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(5, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 185;
            this.label4.Text = "Lucky Type :";
            // 
            // cboLT
            // 
            this.cboLT.FormattingEnabled = true;
            this.cboLT.Location = new System.Drawing.Point(83, 15);
            this.cboLT.Name = "cboLT";
            this.cboLT.Size = new System.Drawing.Size(121, 21);
            this.cboLT.TabIndex = 184;
            // 
            // dgvGainlist
            // 
            this.dgvGainlist.AllowUserToAddRows = false;
            this.dgvGainlist.AllowUserToDeleteRows = false;
            this.dgvGainlist.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvGainlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGainlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGainlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGainlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGainlist.Location = new System.Drawing.Point(3, 42);
            this.dgvGainlist.Name = "dgvGainlist";
            this.dgvGainlist.ReadOnly = true;
            this.dgvGainlist.RowHeadersVisible = false;
            this.dgvGainlist.RowTemplate.Height = 24;
            this.dgvGainlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvGainlist.Size = new System.Drawing.Size(830, 353);
            this.dgvGainlist.TabIndex = 183;
            // 
            // LstGain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 441);
            this.Name = "LstGain";
            this.Text = "Gain";
            this.Controls.SetChildIndex(this.pan, 0);
            this.pan.ResumeLayout(false);
            this.grbList.ResumeLayout(false);
            this.grbList.PerformLayout();
            this.grbControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGainlist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConList;
        public System.Windows.Forms.Button btnRefreshSea;
        public System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.ComboBox cboPeriod;
        public System.Windows.Forms.Label lblluckyType;
        private System.Windows.Forms.ComboBox cboLuckyType;
        public System.Windows.Forms.Button btnProcess;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStatus;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboState;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboLPeriod;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboLT;
        private System.Windows.Forms.DataGridView dgvGainlist;
    }
}