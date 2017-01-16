namespace CHARS.HR.PL.Setup
{
    partial class SetMaster
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
            this.lblMasterPhone = new System.Windows.Forms.Label();
            this.txtMasterPhone = new System.Windows.Forms.TextBox();
            this.lblMasterCode = new System.Windows.Forms.Label();
            this.lblMasterDescription = new System.Windows.Forms.Label();
            this.txtMasterDescription = new System.Windows.Forms.TextBox();
            this.lblMasterRemark = new System.Windows.Forms.Label();
            this.lblMasterEmail = new System.Windows.Forms.Label();
            this.lblMasterAddress = new System.Windows.Forms.Label();
            this.rtxtMasterAddress = new System.Windows.Forms.RichTextBox();
            this.txtMasterEmail = new System.Windows.Forms.TextBox();
            this.rtxtMasterRemark = new System.Windows.Forms.RichTextBox();
            this.cboPerson = new System.Windows.Forms.ComboBox();
            this.lblPerson = new System.Windows.Forms.Label();
            this.txtMasterCode = new System.Windows.Forms.TextBox();
            this.pan.SuspendLayout();
            this.grbEntry.SuspendLayout();
            this.grbEntryData.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorproviderbase)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Size = new System.Drawing.Size(468, 389);
            // 
            // grbEntry
            // 
            this.grbEntry.Size = new System.Drawing.Size(464, 384);
            // 
            // grbEntryData
            // 
            this.grbEntryData.Controls.Add(this.txtMasterCode);
            this.grbEntryData.Controls.Add(this.lblPerson);
            this.grbEntryData.Controls.Add(this.cboPerson);
            this.grbEntryData.Controls.Add(this.rtxtMasterRemark);
            this.grbEntryData.Controls.Add(this.txtMasterEmail);
            this.grbEntryData.Controls.Add(this.rtxtMasterAddress);
            this.grbEntryData.Controls.Add(this.lblMasterAddress);
            this.grbEntryData.Controls.Add(this.lblMasterEmail);
            this.grbEntryData.Controls.Add(this.lblMasterRemark);
            this.grbEntryData.Controls.Add(this.lblMasterPhone);
            this.grbEntryData.Controls.Add(this.txtMasterPhone);
            this.grbEntryData.Controls.Add(this.lblMasterCode);
            this.grbEntryData.Controls.Add(this.lblMasterDescription);
            this.grbEntryData.Controls.Add(this.txtMasterDescription);
            this.grbEntryData.Location = new System.Drawing.Point(4, 11);
            this.grbEntryData.Size = new System.Drawing.Size(454, 325);
            // 
            // grbControl
            // 
            this.grbControl.Location = new System.Drawing.Point(4, 341);
            this.grbControl.Size = new System.Drawing.Size(454, 40);
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
            this.btnClose.Location = new System.Drawing.Point(369, 10);
            this.toolTipbase.SetToolTip(this.btnClose, "Click to close");
            // 
            // lblHeader
            // 
            this.lblHeader.Location = new System.Drawing.Point(220, 9);
            this.lblHeader.Size = new System.Drawing.Size(52, 19);
            this.lblHeader.Text = "Master";
            // 
            // lblMasterPhone
            // 
            this.lblMasterPhone.AutoSize = true;
            this.lblMasterPhone.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasterPhone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMasterPhone.Location = new System.Drawing.Point(47, 100);
            this.lblMasterPhone.Name = "lblMasterPhone";
            this.lblMasterPhone.Size = new System.Drawing.Size(81, 15);
            this.lblMasterPhone.TabIndex = 112;
            this.lblMasterPhone.Text = "Master Phone :";
            // 
            // txtMasterPhone
            // 
            this.txtMasterPhone.BackColor = System.Drawing.Color.AliceBlue;
            this.txtMasterPhone.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasterPhone.Location = new System.Drawing.Point(134, 97);
            this.txtMasterPhone.Name = "txtMasterPhone";
            this.txtMasterPhone.Size = new System.Drawing.Size(275, 21);
            this.txtMasterPhone.TabIndex = 111;
            this.txtMasterPhone.Enter += new System.EventHandler(this.txtMasterPhone_Enter);
            // 
            // lblMasterCode
            // 
            this.lblMasterCode.AutoSize = true;
            this.lblMasterCode.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasterCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMasterCode.Location = new System.Drawing.Point(52, 48);
            this.lblMasterCode.Name = "lblMasterCode";
            this.lblMasterCode.Size = new System.Drawing.Size(76, 15);
            this.lblMasterCode.TabIndex = 110;
            this.lblMasterCode.Text = "Master Code :";
            // 
            // lblMasterDescription
            // 
            this.lblMasterDescription.AutoSize = true;
            this.lblMasterDescription.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasterDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMasterDescription.Location = new System.Drawing.Point(20, 73);
            this.lblMasterDescription.Name = "lblMasterDescription";
            this.lblMasterDescription.Size = new System.Drawing.Size(108, 15);
            this.lblMasterDescription.TabIndex = 108;
            this.lblMasterDescription.Text = "Master Description :";
            // 
            // txtMasterDescription
            // 
            this.txtMasterDescription.BackColor = System.Drawing.Color.AliceBlue;
            this.txtMasterDescription.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasterDescription.Location = new System.Drawing.Point(134, 70);
            this.txtMasterDescription.Name = "txtMasterDescription";
            this.txtMasterDescription.Size = new System.Drawing.Size(275, 21);
            this.txtMasterDescription.TabIndex = 107;
            this.txtMasterDescription.Enter += new System.EventHandler(this.txtMasterDescription_Enter);
            // 
            // lblMasterRemark
            // 
            this.lblMasterRemark.AutoSize = true;
            this.lblMasterRemark.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasterRemark.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMasterRemark.Location = new System.Drawing.Point(40, 240);
            this.lblMasterRemark.Name = "lblMasterRemark";
            this.lblMasterRemark.Size = new System.Drawing.Size(88, 15);
            this.lblMasterRemark.TabIndex = 114;
            this.lblMasterRemark.Text = "Master Remark :";
            // 
            // lblMasterEmail
            // 
            this.lblMasterEmail.AutoSize = true;
            this.lblMasterEmail.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasterEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMasterEmail.Location = new System.Drawing.Point(46, 127);
            this.lblMasterEmail.Name = "lblMasterEmail";
            this.lblMasterEmail.Size = new System.Drawing.Size(82, 15);
            this.lblMasterEmail.TabIndex = 115;
            this.lblMasterEmail.Text = "Master E-mail :";
            // 
            // lblMasterAddress
            // 
            this.lblMasterAddress.AutoSize = true;
            this.lblMasterAddress.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasterAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMasterAddress.Location = new System.Drawing.Point(44, 153);
            this.lblMasterAddress.Name = "lblMasterAddress";
            this.lblMasterAddress.Size = new System.Drawing.Size(84, 15);
            this.lblMasterAddress.TabIndex = 116;
            this.lblMasterAddress.Text = "MasteAddress :";
            // 
            // rtxtMasterAddress
            // 
            this.rtxtMasterAddress.BackColor = System.Drawing.Color.AliceBlue;
            this.rtxtMasterAddress.Location = new System.Drawing.Point(134, 151);
            this.rtxtMasterAddress.Name = "rtxtMasterAddress";
            this.rtxtMasterAddress.Size = new System.Drawing.Size(275, 80);
            this.rtxtMasterAddress.TabIndex = 117;
            this.rtxtMasterAddress.Text = "";
            this.rtxtMasterAddress.Enter += new System.EventHandler(this.rtxtMasterAddress_Enter);
            // 
            // txtMasterEmail
            // 
            this.txtMasterEmail.BackColor = System.Drawing.Color.AliceBlue;
            this.txtMasterEmail.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasterEmail.Location = new System.Drawing.Point(134, 124);
            this.txtMasterEmail.Name = "txtMasterEmail";
            this.txtMasterEmail.Size = new System.Drawing.Size(275, 21);
            this.txtMasterEmail.TabIndex = 118;
            this.txtMasterEmail.Enter += new System.EventHandler(this.txtMasterEmail_Enter);
            // 
            // rtxtMasterRemark
            // 
            this.rtxtMasterRemark.BackColor = System.Drawing.Color.AliceBlue;
            this.rtxtMasterRemark.Location = new System.Drawing.Point(134, 237);
            this.rtxtMasterRemark.Name = "rtxtMasterRemark";
            this.rtxtMasterRemark.Size = new System.Drawing.Size(275, 81);
            this.rtxtMasterRemark.TabIndex = 119;
            this.rtxtMasterRemark.Text = "";
            this.rtxtMasterRemark.Enter += new System.EventHandler(this.rtxtMasterRemark_Enter);
            // 
            // cboPerson
            // 
            this.cboPerson.BackColor = System.Drawing.Color.AliceBlue;
            this.cboPerson.FormattingEnabled = true;
            this.cboPerson.Location = new System.Drawing.Point(134, 16);
            this.cboPerson.Name = "cboPerson";
            this.cboPerson.Size = new System.Drawing.Size(275, 23);
            this.cboPerson.TabIndex = 145;
            this.cboPerson.SelectedIndexChanged += new System.EventHandler(this.cboPerson_SelectedIndexChanged);
            this.cboPerson.Enter += new System.EventHandler(this.cboPerson_Enter);
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerson.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPerson.Location = new System.Drawing.Point(82, 20);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(46, 15);
            this.lblPerson.TabIndex = 146;
            this.lblPerson.Text = "Person :";
            // 
            // txtMasterCode
            // 
            this.txtMasterCode.BackColor = System.Drawing.Color.AliceBlue;
            this.txtMasterCode.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasterCode.Location = new System.Drawing.Point(134, 45);
            this.txtMasterCode.Name = "txtMasterCode";
            this.txtMasterCode.Size = new System.Drawing.Size(275, 21);
            this.txtMasterCode.TabIndex = 147;
            this.txtMasterCode.Enter += new System.EventHandler(this.txtMasterCode_Enter);
            // 
            // SetMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 442);
            this.Name = "SetMaster";
            this.Text = "SetMaster";
            this.toolTipbase.SetToolTip(this, "Drap to move to desired location");
            this.Load += new System.EventHandler(this.SetMaster_Load);
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

        public System.Windows.Forms.Label lblMasterRemark;
        public System.Windows.Forms.Label lblMasterPhone;
        public System.Windows.Forms.TextBox txtMasterPhone;
        public System.Windows.Forms.Label lblMasterCode;
        public System.Windows.Forms.Label lblMasterDescription;
        public System.Windows.Forms.TextBox txtMasterDescription;
        public System.Windows.Forms.Label lblMasterAddress;
        public System.Windows.Forms.Label lblMasterEmail;
        public System.Windows.Forms.TextBox txtMasterEmail;
        private System.Windows.Forms.RichTextBox rtxtMasterAddress;
        private System.Windows.Forms.RichTextBox rtxtMasterRemark;
        private System.Windows.Forms.ComboBox cboPerson;
        public System.Windows.Forms.Label lblPerson;
        public System.Windows.Forms.TextBox txtMasterCode;
    }
}