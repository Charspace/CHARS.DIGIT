namespace CHARS.HR.PL.Setup
{
    partial class SetPeriod
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
            this.lblPeriodRemark = new System.Windows.Forms.Label();
            this.lblCompetatorCode = new System.Windows.Forms.Label();
            this.txtPeriodCode = new System.Windows.Forms.TextBox();
            this.lblCompetatorDescription = new System.Windows.Forms.Label();
            this.txtPeriodDescription = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.cboLuckyType = new System.Windows.Forms.ComboBox();
            this.lblluckyType = new System.Windows.Forms.Label();
            this.rtxtPeriodRemark = new System.Windows.Forms.RichTextBox();
            this.pan.SuspendLayout();
            this.grbEntry.SuspendLayout();
            this.grbEntryData.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorproviderbase)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Location = new System.Drawing.Point(5, 21);
            this.pan.Size = new System.Drawing.Size(452, 322);
            // 
            // grbEntry
            // 
            this.grbEntry.Location = new System.Drawing.Point(4, 0);
            this.grbEntry.Size = new System.Drawing.Size(444, 321);
            // 
            // grbEntryData
            // 
            this.grbEntryData.Controls.Add(this.rtxtPeriodRemark);
            this.grbEntryData.Controls.Add(this.lblluckyType);
            this.grbEntryData.Controls.Add(this.cboLuckyType);
            this.grbEntryData.Controls.Add(this.lblEndDate);
            this.grbEntryData.Controls.Add(this.lblStartDate);
            this.grbEntryData.Controls.Add(this.dtpEndDate);
            this.grbEntryData.Controls.Add(this.dtpStartDate);
            this.grbEntryData.Controls.Add(this.lblPeriodRemark);
            this.grbEntryData.Controls.Add(this.lblCompetatorCode);
            this.grbEntryData.Controls.Add(this.txtPeriodCode);
            this.grbEntryData.Controls.Add(this.lblCompetatorDescription);
            this.grbEntryData.Controls.Add(this.txtPeriodDescription);
            this.grbEntryData.Size = new System.Drawing.Size(433, 257);
            // 
            // grbControl
            // 
            this.grbControl.Location = new System.Drawing.Point(3, 275);
            this.grbControl.Size = new System.Drawing.Size(434, 40);
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
            this.btnClose.Location = new System.Drawing.Point(349, 10);
            this.toolTipbase.SetToolTip(this.btnClose, "Click to close");
            // 
            // lblHeader
            // 
            this.lblHeader.Location = new System.Drawing.Point(202, 3);
            this.lblHeader.Size = new System.Drawing.Size(44, 16);
            this.lblHeader.Text = "Period";
            this.lblHeader.Visible = true;
            // 
            // lblPeriodRemark
            // 
            this.lblPeriodRemark.AutoSize = true;
            this.lblPeriodRemark.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodRemark.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPeriodRemark.Location = new System.Drawing.Point(90, 167);
            this.lblPeriodRemark.Name = "lblPeriodRemark";
            this.lblPeriodRemark.Size = new System.Drawing.Size(50, 15);
            this.lblPeriodRemark.TabIndex = 106;
            this.lblPeriodRemark.Text = "Remark :";
            // 
            // lblCompetatorCode
            // 
            this.lblCompetatorCode.AutoSize = true;
            this.lblCompetatorCode.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetatorCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCompetatorCode.Location = new System.Drawing.Point(68, 22);
            this.lblCompetatorCode.Name = "lblCompetatorCode";
            this.lblCompetatorCode.Size = new System.Drawing.Size(72, 15);
            this.lblCompetatorCode.TabIndex = 104;
            this.lblCompetatorCode.Text = "Period Code :";
            // 
            // txtPeriodCode
            // 
            this.txtPeriodCode.BackColor = System.Drawing.Color.AliceBlue;
            this.txtPeriodCode.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodCode.Location = new System.Drawing.Point(154, 19);
            this.txtPeriodCode.Name = "txtPeriodCode";
            this.txtPeriodCode.Size = new System.Drawing.Size(250, 21);
            this.txtPeriodCode.TabIndex = 0;
            this.txtPeriodCode.Enter += new System.EventHandler(this.txtPeriodCode_Enter);
            // 
            // lblCompetatorDescription
            // 
            this.lblCompetatorDescription.AutoSize = true;
            this.lblCompetatorDescription.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetatorDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCompetatorDescription.Location = new System.Drawing.Point(36, 48);
            this.lblCompetatorDescription.Name = "lblCompetatorDescription";
            this.lblCompetatorDescription.Size = new System.Drawing.Size(104, 15);
            this.lblCompetatorDescription.TabIndex = 102;
            this.lblCompetatorDescription.Text = "Period Description :";
            // 
            // txtPeriodDescription
            // 
            this.txtPeriodDescription.BackColor = System.Drawing.Color.AliceBlue;
            this.txtPeriodDescription.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodDescription.Location = new System.Drawing.Point(154, 45);
            this.txtPeriodDescription.Name = "txtPeriodDescription";
            this.txtPeriodDescription.Size = new System.Drawing.Size(250, 21);
            this.txtPeriodDescription.TabIndex = 1;
            this.txtPeriodDescription.Enter += new System.EventHandler(this.txtPeriodDescription_Enter);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(154, 72);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(250, 23);
            this.dtpStartDate.TabIndex = 2;
            this.dtpStartDate.Enter += new System.EventHandler(this.dtpStartDate_Enter);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(154, 101);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(250, 23);
            this.dtpEndDate.TabIndex = 3;
            this.dtpEndDate.Enter += new System.EventHandler(this.dtpEndDate_Enter);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStartDate.Location = new System.Drawing.Point(78, 75);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(62, 15);
            this.lblStartDate.TabIndex = 109;
            this.lblStartDate.Text = "Start Date :";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEndDate.Location = new System.Drawing.Point(82, 105);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(58, 15);
            this.lblEndDate.TabIndex = 110;
            this.lblEndDate.Text = "End Date :";
            // 
            // cboLuckyType
            // 
            this.cboLuckyType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboLuckyType.FormattingEnabled = true;
            this.cboLuckyType.Location = new System.Drawing.Point(154, 130);
            this.cboLuckyType.Name = "cboLuckyType";
            this.cboLuckyType.Size = new System.Drawing.Size(250, 23);
            this.cboLuckyType.TabIndex = 4;
            this.cboLuckyType.Enter += new System.EventHandler(this.cboLuckyType_Enter);
            // 
            // lblluckyType
            // 
            this.lblluckyType.AutoSize = true;
            this.lblluckyType.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblluckyType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblluckyType.Location = new System.Drawing.Point(66, 133);
            this.lblluckyType.Name = "lblluckyType";
            this.lblluckyType.Size = new System.Drawing.Size(73, 15);
            this.lblluckyType.TabIndex = 113;
            this.lblluckyType.Text = "Lucky Type :";
            // 
            // rtxtPeriodRemark
            // 
            this.rtxtPeriodRemark.BackColor = System.Drawing.Color.AliceBlue;
            this.rtxtPeriodRemark.Location = new System.Drawing.Point(154, 167);
            this.rtxtPeriodRemark.Name = "rtxtPeriodRemark";
            this.rtxtPeriodRemark.Size = new System.Drawing.Size(250, 80);
            this.rtxtPeriodRemark.TabIndex = 5;
            this.rtxtPeriodRemark.Text = "";
            this.rtxtPeriodRemark.Enter += new System.EventHandler(this.rtxtPeriodRemark_Enter);
            // 
            // SetPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 353);
            this.Name = "SetPeriod";
            this.Text = "SetPeriod";
            this.toolTipbase.SetToolTip(this, "Drap to move to desired location");
            this.Load += new System.EventHandler(this.SetPeriod_Load);
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
        public System.Windows.Forms.Label lblPeriodRemark;
        public System.Windows.Forms.Label lblCompetatorCode;
        public System.Windows.Forms.TextBox txtPeriodCode;
        public System.Windows.Forms.Label lblCompetatorDescription;
        public System.Windows.Forms.TextBox txtPeriodDescription;
        public System.Windows.Forms.Label lblluckyType;
        private System.Windows.Forms.ComboBox cboLuckyType;
        private System.Windows.Forms.RichTextBox rtxtPeriodRemark;
    }
}