namespace CHARS.HR.PL.Process
{
    partial class ProResult
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
            this.grbVote = new System.Windows.Forms.GroupBox();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.lblluckyType = new System.Windows.Forms.Label();
            this.cboLuckyType = new System.Windows.Forms.ComboBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.cboPeriod = new System.Windows.Forms.ComboBox();
            this.btnPrepare = new System.Windows.Forms.Button();
            this.btnPeriod = new System.Windows.Forms.Button();
            this.pan.SuspendLayout();
            this.grbEntry.SuspendLayout();
            this.grbEntryData.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorproviderbase)).BeginInit();
            this.grbVote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Location = new System.Drawing.Point(8, 19);
            this.pan.Size = new System.Drawing.Size(640, 362);
            // 
            // grbEntry
            // 
            this.grbEntry.Location = new System.Drawing.Point(3, -3);
            this.grbEntry.Size = new System.Drawing.Size(635, 364);
            // 
            // grbEntryData
            // 
            this.grbEntryData.Controls.Add(this.btnPeriod);
            this.grbEntryData.Controls.Add(this.btnPrepare);
            this.grbEntryData.Controls.Add(this.lblluckyType);
            this.grbEntryData.Controls.Add(this.cboLuckyType);
            this.grbEntryData.Controls.Add(this.lblPeriod);
            this.grbEntryData.Controls.Add(this.cboPeriod);
            this.grbEntryData.Controls.Add(this.grbVote);
            this.grbEntryData.Location = new System.Drawing.Point(0, 12);
            this.grbEntryData.Size = new System.Drawing.Size(630, 312);
            // 
            // grbControl
            // 
            this.grbControl.Location = new System.Drawing.Point(4, 321);
            this.grbControl.Size = new System.Drawing.Size(626, 40);
            // 
            // btnDelete
            // 
            this.toolTipbase.SetToolTip(this.btnDelete, "Click to delete");
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.toolTipbase.SetToolTip(this.btnNew, "Click to prepare new item");
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.toolTipbase.SetToolTip(this.btnSave, "Click to save");
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(541, 10);
            this.toolTipbase.SetToolTip(this.btnClose, "Click to close");
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Location = new System.Drawing.Point(292, 1);
            this.lblHeader.Size = new System.Drawing.Size(43, 16);
            this.lblHeader.Text = "Result";
            this.lblHeader.Visible = true;
            // 
            // grbVote
            // 
            this.grbVote.Controls.Add(this.dgvResult);
            this.grbVote.Location = new System.Drawing.Point(2, 46);
            this.grbVote.Name = "grbVote";
            this.grbVote.Size = new System.Drawing.Size(628, 273);
            this.grbVote.TabIndex = 131;
            this.grbVote.TabStop = false;
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResult.Location = new System.Drawing.Point(3, 19);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.Size = new System.Drawing.Size(622, 251);
            this.dgvResult.TabIndex = 1;
            this.dgvResult.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvResult_CellFormatting);
            // 
            // lblluckyType
            // 
            this.lblluckyType.AutoSize = true;
            this.lblluckyType.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblluckyType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblluckyType.Location = new System.Drawing.Point(10, 16);
            this.lblluckyType.Name = "lblluckyType";
            this.lblluckyType.Size = new System.Drawing.Size(73, 15);
            this.lblluckyType.TabIndex = 145;
            this.lblluckyType.Text = "Lucky Type :";
            // 
            // cboLuckyType
            // 
            this.cboLuckyType.FormattingEnabled = true;
            this.cboLuckyType.Location = new System.Drawing.Point(88, 13);
            this.cboLuckyType.Name = "cboLuckyType";
            this.cboLuckyType.Size = new System.Drawing.Size(163, 23);
            this.cboLuckyType.TabIndex = 144;
            this.cboLuckyType.SelectedIndexChanged += new System.EventHandler(this.cboLuckyType_SelectedIndexChanged);
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPeriod.Location = new System.Drawing.Point(285, 16);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(44, 15);
            this.lblPeriod.TabIndex = 142;
            this.lblPeriod.Text = "Period :";
            // 
            // cboPeriod
            // 
            this.cboPeriod.FormattingEnabled = true;
            this.cboPeriod.Location = new System.Drawing.Point(335, 13);
            this.cboPeriod.Name = "cboPeriod";
            this.cboPeriod.Size = new System.Drawing.Size(141, 23);
            this.cboPeriod.TabIndex = 141;
            // 
            // btnPrepare
            // 
            this.btnPrepare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrepare.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrepare.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPrepare.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrepare.ForeColor = System.Drawing.Color.Snow;
            this.btnPrepare.Location = new System.Drawing.Point(540, 13);
            this.btnPrepare.Name = "btnPrepare";
            this.btnPrepare.Size = new System.Drawing.Size(83, 27);
            this.btnPrepare.TabIndex = 146;
            this.btnPrepare.Text = "&Prepare";
            this.toolTipbase.SetToolTip(this.btnPrepare, "Click to save");
            this.btnPrepare.UseVisualStyleBackColor = false;
            this.btnPrepare.Click += new System.EventHandler(this.btnPrepare_Click);
            // 
            // btnPeriod
            // 
            this.btnPeriod.Location = new System.Drawing.Point(495, 13);
            this.btnPeriod.Name = "btnPeriod";
            this.btnPeriod.Size = new System.Drawing.Size(25, 23);
            this.btnPeriod.TabIndex = 147;
            this.btnPeriod.UseVisualStyleBackColor = true;
            this.btnPeriod.Click += new System.EventHandler(this.btnPeriod_Click);
            // 
            // ProResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 394);
            this.Name = "ProResult";
            this.Text = "SetResult";
            this.toolTipbase.SetToolTip(this, "Drap to move to desired location");
            this.pan.ResumeLayout(false);
            this.grbEntry.ResumeLayout(false);
            this.grbEntryData.ResumeLayout(false);
            this.grbEntryData.PerformLayout();
            this.grbControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorproviderbase)).EndInit();
            this.grbVote.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbVote;
        private System.Windows.Forms.DataGridView dgvResult;
        public System.Windows.Forms.Label lblluckyType;
        private System.Windows.Forms.ComboBox cboLuckyType;
        public System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.ComboBox cboPeriod;
        public System.Windows.Forms.Button btnPrepare;
        private System.Windows.Forms.Button btnPeriod;

    }
}