namespace CHARS.HR.PL.Setup
{
    partial class SetAgent
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
            this.rtxtAgentRemark = new System.Windows.Forms.RichTextBox();
            this.txtAgentEmail = new System.Windows.Forms.TextBox();
            this.rtxtAgentAddress = new System.Windows.Forms.RichTextBox();
            this.lblAgentAddress = new System.Windows.Forms.Label();
            this.lblAgentEmail = new System.Windows.Forms.Label();
            this.lblAgentRemark = new System.Windows.Forms.Label();
            this.lblAgentPhone = new System.Windows.Forms.Label();
            this.txtAgentPhone = new System.Windows.Forms.TextBox();
            this.lblAgentCode = new System.Windows.Forms.Label();
            this.txtAgentCode = new System.Windows.Forms.TextBox();
            this.lblAgentDescription = new System.Windows.Forms.Label();
            this.txtAgentDescription = new System.Windows.Forms.TextBox();
            this.lblPerson = new System.Windows.Forms.Label();
            this.cboPerson = new System.Windows.Forms.ComboBox();
            this.lblPersonDescription = new System.Windows.Forms.Label();
            this.pan.SuspendLayout();
            this.grbEntry.SuspendLayout();
            this.grbEntryData.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorproviderbase)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Location = new System.Drawing.Point(16, 34);
            this.pan.Size = new System.Drawing.Size(490, 389);
            // 
            // grbEntry
            // 
            this.grbEntry.Size = new System.Drawing.Size(485, 384);
            // 
            // grbEntryData
            // 
            this.grbEntryData.Controls.Add(this.lblPersonDescription);
            this.grbEntryData.Controls.Add(this.cboPerson);
            this.grbEntryData.Controls.Add(this.lblPerson);
            this.grbEntryData.Controls.Add(this.rtxtAgentRemark);
            this.grbEntryData.Controls.Add(this.txtAgentEmail);
            this.grbEntryData.Controls.Add(this.rtxtAgentAddress);
            this.grbEntryData.Controls.Add(this.lblAgentAddress);
            this.grbEntryData.Controls.Add(this.lblAgentEmail);
            this.grbEntryData.Controls.Add(this.lblAgentRemark);
            this.grbEntryData.Controls.Add(this.lblAgentPhone);
            this.grbEntryData.Controls.Add(this.txtAgentPhone);
            this.grbEntryData.Controls.Add(this.lblAgentCode);
            this.grbEntryData.Controls.Add(this.txtAgentCode);
            this.grbEntryData.Controls.Add(this.lblAgentDescription);
            this.grbEntryData.Controls.Add(this.txtAgentDescription);
            this.grbEntryData.Location = new System.Drawing.Point(4, 10);
            this.grbEntryData.Size = new System.Drawing.Size(476, 334);
            // 
            // grbControl
            // 
            this.grbControl.Size = new System.Drawing.Size(476, 40);
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
            this.btnClose.Location = new System.Drawing.Point(391, 10);
            this.toolTipbase.SetToolTip(this.btnClose, "Click to close");
            // 
            // lblHeader
            // 
            this.lblHeader.Location = new System.Drawing.Point(235, 9);
            this.lblHeader.Size = new System.Drawing.Size(45, 19);
            this.lblHeader.Text = "Agent";
            // 
            // rtxtAgentRemark
            // 
            this.rtxtAgentRemark.BackColor = System.Drawing.Color.AliceBlue;
            this.rtxtAgentRemark.Location = new System.Drawing.Point(134, 235);
            this.rtxtAgentRemark.Name = "rtxtAgentRemark";
            this.rtxtAgentRemark.Size = new System.Drawing.Size(290, 92);
            this.rtxtAgentRemark.TabIndex = 6;
            this.rtxtAgentRemark.Text = "";
            this.rtxtAgentRemark.Enter += new System.EventHandler(this.rtxtAgentRemark_Enter);
            // 
            // txtAgentEmail
            // 
            this.txtAgentEmail.BackColor = System.Drawing.Color.AliceBlue;
            this.txtAgentEmail.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgentEmail.Location = new System.Drawing.Point(134, 122);
            this.txtAgentEmail.Name = "txtAgentEmail";
            this.txtAgentEmail.Size = new System.Drawing.Size(290, 21);
            this.txtAgentEmail.TabIndex = 4;
            this.txtAgentEmail.Enter += new System.EventHandler(this.txtAgentEmail_Enter);
            // 
            // rtxtAgentAddress
            // 
            this.rtxtAgentAddress.BackColor = System.Drawing.Color.AliceBlue;
            this.rtxtAgentAddress.Location = new System.Drawing.Point(134, 148);
            this.rtxtAgentAddress.Name = "rtxtAgentAddress";
            this.rtxtAgentAddress.Size = new System.Drawing.Size(290, 82);
            this.rtxtAgentAddress.TabIndex = 5;
            this.rtxtAgentAddress.Text = "";
            this.rtxtAgentAddress.Enter += new System.EventHandler(this.rtxtAgentAddress_Enter);
            // 
            // lblAgentAddress
            // 
            this.lblAgentAddress.AutoSize = true;
            this.lblAgentAddress.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAgentAddress.Location = new System.Drawing.Point(35, 151);
            this.lblAgentAddress.Name = "lblAgentAddress";
            this.lblAgentAddress.Size = new System.Drawing.Size(85, 15);
            this.lblAgentAddress.TabIndex = 128;
            this.lblAgentAddress.Text = "Agent Address :";
            // 
            // lblAgentEmail
            // 
            this.lblAgentEmail.AutoSize = true;
            this.lblAgentEmail.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAgentEmail.Location = new System.Drawing.Point(41, 125);
            this.lblAgentEmail.Name = "lblAgentEmail";
            this.lblAgentEmail.Size = new System.Drawing.Size(76, 15);
            this.lblAgentEmail.TabIndex = 127;
            this.lblAgentEmail.Text = "Agent E-mail :";
            // 
            // lblAgentRemark
            // 
            this.lblAgentRemark.AutoSize = true;
            this.lblAgentRemark.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentRemark.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAgentRemark.Location = new System.Drawing.Point(35, 238);
            this.lblAgentRemark.Name = "lblAgentRemark";
            this.lblAgentRemark.Size = new System.Drawing.Size(82, 15);
            this.lblAgentRemark.TabIndex = 126;
            this.lblAgentRemark.Text = "Agent Remark :";
            // 
            // lblAgentPhone
            // 
            this.lblAgentPhone.AutoSize = true;
            this.lblAgentPhone.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentPhone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAgentPhone.Location = new System.Drawing.Point(42, 99);
            this.lblAgentPhone.Name = "lblAgentPhone";
            this.lblAgentPhone.Size = new System.Drawing.Size(75, 15);
            this.lblAgentPhone.TabIndex = 125;
            this.lblAgentPhone.Text = "Agent Phone :";
            // 
            // txtAgentPhone
            // 
            this.txtAgentPhone.BackColor = System.Drawing.Color.AliceBlue;
            this.txtAgentPhone.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgentPhone.Location = new System.Drawing.Point(134, 96);
            this.txtAgentPhone.Name = "txtAgentPhone";
            this.txtAgentPhone.Size = new System.Drawing.Size(290, 21);
            this.txtAgentPhone.TabIndex = 3;
            this.txtAgentPhone.Enter += new System.EventHandler(this.txtAgentPhone_Enter);
            // 
            // lblAgentCode
            // 
            this.lblAgentCode.AutoSize = true;
            this.lblAgentCode.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAgentCode.Location = new System.Drawing.Point(47, 45);
            this.lblAgentCode.Name = "lblAgentCode";
            this.lblAgentCode.Size = new System.Drawing.Size(70, 15);
            this.lblAgentCode.TabIndex = 123;
            this.lblAgentCode.Text = "Agent Code :";
            // 
            // txtAgentCode
            // 
            this.txtAgentCode.BackColor = System.Drawing.Color.AliceBlue;
            this.txtAgentCode.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgentCode.Location = new System.Drawing.Point(134, 42);
            this.txtAgentCode.Name = "txtAgentCode";
            this.txtAgentCode.Size = new System.Drawing.Size(290, 21);
            this.txtAgentCode.TabIndex = 1;
            this.txtAgentCode.Enter += new System.EventHandler(this.txtAgentCode_Enter);
            // 
            // lblAgentDescription
            // 
            this.lblAgentDescription.AutoSize = true;
            this.lblAgentDescription.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAgentDescription.Location = new System.Drawing.Point(15, 75);
            this.lblAgentDescription.Name = "lblAgentDescription";
            this.lblAgentDescription.Size = new System.Drawing.Size(102, 15);
            this.lblAgentDescription.TabIndex = 121;
            this.lblAgentDescription.Text = "Agent Description :";
            // 
            // txtAgentDescription
            // 
            this.txtAgentDescription.BackColor = System.Drawing.Color.AliceBlue;
            this.txtAgentDescription.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgentDescription.Location = new System.Drawing.Point(134, 69);
            this.txtAgentDescription.Name = "txtAgentDescription";
            this.txtAgentDescription.Size = new System.Drawing.Size(290, 21);
            this.txtAgentDescription.TabIndex = 2;
            this.txtAgentDescription.Enter += new System.EventHandler(this.txtAgentDescription_Enter);
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerson.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPerson.Location = new System.Drawing.Point(71, 18);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(46, 15);
            this.lblPerson.TabIndex = 150;
            this.lblPerson.Text = "Person :";
            // 
            // cboPerson
            // 
            this.cboPerson.BackColor = System.Drawing.Color.AliceBlue;
            this.cboPerson.FormattingEnabled = true;
            this.cboPerson.Location = new System.Drawing.Point(134, 15);
            this.cboPerson.Name = "cboPerson";
            this.cboPerson.Size = new System.Drawing.Size(166, 23);
            this.cboPerson.TabIndex = 0;
            this.cboPerson.Enter += new System.EventHandler(this.cboPerson_Enter);
            // 
            // lblPersonDescription
            // 
            this.lblPersonDescription.AutoSize = true;
            this.lblPersonDescription.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPersonDescription.Location = new System.Drawing.Point(306, 19);
            this.lblPersonDescription.Name = "lblPersonDescription";
            this.lblPersonDescription.Size = new System.Drawing.Size(46, 15);
            this.lblPersonDescription.TabIndex = 151;
            this.lblPersonDescription.Text = "Person :";
            // 
            // SetAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 440);
            this.Name = "SetAgent";
            this.Text = "SetAgent";
            this.toolTipbase.SetToolTip(this, "Drap to move to desired location");
            this.Load += new System.EventHandler(this.SetAgent_Load);
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

        private System.Windows.Forms.RichTextBox rtxtAgentRemark;
        public System.Windows.Forms.TextBox txtAgentEmail;
        private System.Windows.Forms.RichTextBox rtxtAgentAddress;
        public System.Windows.Forms.Label lblAgentAddress;
        public System.Windows.Forms.Label lblAgentEmail;
        public System.Windows.Forms.Label lblAgentRemark;
        public System.Windows.Forms.Label lblAgentPhone;
        public System.Windows.Forms.TextBox txtAgentPhone;
        public System.Windows.Forms.Label lblAgentCode;
        public System.Windows.Forms.TextBox txtAgentCode;
        public System.Windows.Forms.Label lblAgentDescription;
        public System.Windows.Forms.TextBox txtAgentDescription;
        private System.Windows.Forms.ComboBox cboPerson;
        public System.Windows.Forms.Label lblPerson;
        public System.Windows.Forms.Label lblPersonDescription;
    }
}