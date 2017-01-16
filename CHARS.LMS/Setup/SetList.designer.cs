namespace CHARS.HR.PL.Setup
{
    partial class SetList
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
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.rtxtListRemark = new System.Windows.Forms.RichTextBox();
            this.lblListRemark = new System.Windows.Forms.Label();
            this.lblluckyType = new System.Windows.Forms.Label();
            this.lblListDescription = new System.Windows.Forms.Label();
            this.txtListDescription = new System.Windows.Forms.TextBox();
            this.lblListCode = new System.Windows.Forms.Label();
            this.txtListCode = new System.Windows.Forms.TextBox();
            this.lblMinAmount = new System.Windows.Forms.Label();
            this.txtMinAmount = new System.Windows.Forms.TextBox();
            this.lblMaxAmount = new System.Windows.Forms.Label();
            this.txtMaxamount = new System.Windows.Forms.TextBox();
            this.cboLuckyType = new System.Windows.Forms.ComboBox();
            this.pan.SuspendLayout();
            this.grbEntry.SuspendLayout();
            this.grbEntryData.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorproviderbase)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Location = new System.Drawing.Point(7, 23);
            this.pan.Size = new System.Drawing.Size(428, 369);
            // 
            // grbEntry
            // 
            this.grbEntry.Size = new System.Drawing.Size(423, 366);
            // 
            // grbEntryData
            // 
            this.grbEntryData.Controls.Add(this.cboLuckyType);
            this.grbEntryData.Controls.Add(this.lblMaxAmount);
            this.grbEntryData.Controls.Add(this.txtMaxamount);
            this.grbEntryData.Controls.Add(this.lblMinAmount);
            this.grbEntryData.Controls.Add(this.txtMinAmount);
            this.grbEntryData.Controls.Add(this.lblListCode);
            this.grbEntryData.Controls.Add(this.txtListCode);
            this.grbEntryData.Controls.Add(this.lblluckyType);
            this.grbEntryData.Controls.Add(this.lblListDescription);
            this.grbEntryData.Controls.Add(this.txtListDescription);
            this.grbEntryData.Controls.Add(this.rtxtListRemark);
            this.grbEntryData.Controls.Add(this.lblListRemark);
            this.grbEntryData.Controls.Add(this.dtpStartDate);
            this.grbEntryData.Controls.Add(this.dtpEndDate);
            this.grbEntryData.Controls.Add(this.lblStartDate);
            this.grbEntryData.Controls.Add(this.lblEndDate);
            this.grbEntryData.Location = new System.Drawing.Point(4, 8);
            this.grbEntryData.Size = new System.Drawing.Size(414, 304);
            // 
            // grbControl
            // 
            this.grbControl.Location = new System.Drawing.Point(4, 318);
            this.grbControl.Size = new System.Drawing.Size(414, 40);
            // 
            // btnDelete
            // 
            this.toolTipbase.SetToolTip(this.btnDelete, "Click to delete");
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.TabIndex = 1;
            this.toolTipbase.SetToolTip(this.btnNew, "Click to prepare new item");
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.TabIndex = 0;
            this.toolTipbase.SetToolTip(this.btnSave, "Click to save");
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(329, 10);
            this.toolTipbase.SetToolTip(this.btnClose, "Click to close");
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(199, 3);
            this.lblHeader.Size = new System.Drawing.Size(35, 19);
            this.lblHeader.Text = "List ";
            this.lblHeader.Visible = true;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEndDate.Location = new System.Drawing.Point(72, 186);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(58, 15);
            this.lblEndDate.TabIndex = 117;
            this.lblEndDate.Text = "End Date :";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStartDate.Location = new System.Drawing.Point(68, 158);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(62, 15);
            this.lblStartDate.TabIndex = 116;
            this.lblStartDate.Text = "Start Date :";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(137, 184);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(251, 23);
            this.dtpEndDate.TabIndex = 6;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(138, 155);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(251, 23);
            this.dtpStartDate.TabIndex = 5;
            // 
            // rtxtListRemark
            // 
            this.rtxtListRemark.BackColor = System.Drawing.Color.AliceBlue;
            this.rtxtListRemark.Location = new System.Drawing.Point(137, 212);
            this.rtxtListRemark.Name = "rtxtListRemark";
            this.rtxtListRemark.Size = new System.Drawing.Size(252, 81);
            this.rtxtListRemark.TabIndex = 7;
            this.rtxtListRemark.Text = "";
            // 
            // lblListRemark
            // 
            this.lblListRemark.AutoSize = true;
            this.lblListRemark.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListRemark.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblListRemark.Location = new System.Drawing.Point(78, 215);
            this.lblListRemark.Name = "lblListRemark";
            this.lblListRemark.Size = new System.Drawing.Size(50, 15);
            this.lblListRemark.TabIndex = 149;
            this.lblListRemark.Text = "Remark :";
            // 
            // lblluckyType
            // 
            this.lblluckyType.AutoSize = true;
            this.lblluckyType.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblluckyType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblluckyType.Location = new System.Drawing.Point(56, 19);
            this.lblluckyType.Name = "lblluckyType";
            this.lblluckyType.Size = new System.Drawing.Size(73, 15);
            this.lblluckyType.TabIndex = 156;
            this.lblluckyType.Text = "Lucky Type :";
            // 
            // lblListDescription
            // 
            this.lblListDescription.AutoSize = true;
            this.lblListDescription.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblListDescription.Location = new System.Drawing.Point(36, 72);
            this.lblListDescription.Name = "lblListDescription";
            this.lblListDescription.Size = new System.Drawing.Size(92, 15);
            this.lblListDescription.TabIndex = 152;
            this.lblListDescription.Text = "List Description :";
            // 
            // txtListDescription
            // 
            this.txtListDescription.BackColor = System.Drawing.Color.AliceBlue;
            this.txtListDescription.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListDescription.Location = new System.Drawing.Point(138, 70);
            this.txtListDescription.Name = "txtListDescription";
            this.txtListDescription.Size = new System.Drawing.Size(250, 21);
            this.txtListDescription.TabIndex = 2;
            // 
            // lblListCode
            // 
            this.lblListCode.AutoSize = true;
            this.lblListCode.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblListCode.Location = new System.Drawing.Point(68, 45);
            this.lblListCode.Name = "lblListCode";
            this.lblListCode.Size = new System.Drawing.Size(60, 15);
            this.lblListCode.TabIndex = 158;
            this.lblListCode.Text = "List Code :";
            // 
            // txtListCode
            // 
            this.txtListCode.BackColor = System.Drawing.Color.AliceBlue;
            this.txtListCode.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListCode.Location = new System.Drawing.Point(138, 43);
            this.txtListCode.Name = "txtListCode";
            this.txtListCode.Size = new System.Drawing.Size(250, 21);
            this.txtListCode.TabIndex = 1;
            // 
            // lblMinAmount
            // 
            this.lblMinAmount.AutoSize = true;
            this.lblMinAmount.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMinAmount.Location = new System.Drawing.Point(26, 102);
            this.lblMinAmount.Name = "lblMinAmount";
            this.lblMinAmount.Size = new System.Drawing.Size(103, 15);
            this.lblMinAmount.TabIndex = 160;
            this.lblMinAmount.Text = "Minimum Amount :";
            // 
            // txtMinAmount
            // 
            this.txtMinAmount.BackColor = System.Drawing.Color.AliceBlue;
            this.txtMinAmount.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinAmount.Location = new System.Drawing.Point(139, 100);
            this.txtMinAmount.Name = "txtMinAmount";
            this.txtMinAmount.Size = new System.Drawing.Size(250, 21);
            this.txtMinAmount.TabIndex = 3;
            // 
            // lblMaxAmount
            // 
            this.lblMaxAmount.AutoSize = true;
            this.lblMaxAmount.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMaxAmount.Location = new System.Drawing.Point(25, 129);
            this.lblMaxAmount.Name = "lblMaxAmount";
            this.lblMaxAmount.Size = new System.Drawing.Size(104, 15);
            this.lblMaxAmount.TabIndex = 162;
            this.lblMaxAmount.Text = "Maximum Amount :";
            // 
            // txtMaxamount
            // 
            this.txtMaxamount.BackColor = System.Drawing.Color.AliceBlue;
            this.txtMaxamount.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxamount.Location = new System.Drawing.Point(139, 127);
            this.txtMaxamount.Name = "txtMaxamount";
            this.txtMaxamount.Size = new System.Drawing.Size(250, 21);
            this.txtMaxamount.TabIndex = 4;
            // 
            // cboLuckyType
            // 
            this.cboLuckyType.FormattingEnabled = true;
            this.cboLuckyType.Location = new System.Drawing.Point(139, 14);
            this.cboLuckyType.Name = "cboLuckyType";
            this.cboLuckyType.Size = new System.Drawing.Size(249, 23);
            this.cboLuckyType.TabIndex = 0;
            // 
            // SetList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 398);
            this.Name = "SetList";
            this.Text = "SetList";
            this.toolTipbase.SetToolTip(this, "Drap to move to desired location");
            this.pan.ResumeLayout(false);
            this.grbEntry.ResumeLayout(false);
            this.grbEntryData.ResumeLayout(false);
            this.grbEntryData.PerformLayout();
            this.grbControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorproviderbase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblEndDate;
        public System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.RichTextBox rtxtListRemark;
        public System.Windows.Forms.Label lblListRemark;
        public System.Windows.Forms.Label lblListCode;
        public System.Windows.Forms.TextBox txtListCode;
        public System.Windows.Forms.Label lblluckyType;
        public System.Windows.Forms.Label lblListDescription;
        public System.Windows.Forms.TextBox txtListDescription;
        public System.Windows.Forms.Label lblMaxAmount;
        public System.Windows.Forms.TextBox txtMaxamount;
        public System.Windows.Forms.Label lblMinAmount;
        public System.Windows.Forms.TextBox txtMinAmount;
        private System.Windows.Forms.ComboBox cboLuckyType;
    }
}