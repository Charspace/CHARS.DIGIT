namespace CHARS.HR.PL.Setup
{
    partial class SetPlayer
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
            this.rtxtPlayerRemark = new System.Windows.Forms.RichTextBox();
            this.txtPlayerEmail = new System.Windows.Forms.TextBox();
            this.rtxtPlayerAddress = new System.Windows.Forms.RichTextBox();
            this.lblPlayerAddress = new System.Windows.Forms.Label();
            this.lblPlayerEmail = new System.Windows.Forms.Label();
            this.lblPlayerRemark = new System.Windows.Forms.Label();
            this.lblPlayerPhon = new System.Windows.Forms.Label();
            this.txtPlayerPhone = new System.Windows.Forms.TextBox();
            this.lblPlayerCode = new System.Windows.Forms.Label();
            this.txtPlayerCode = new System.Windows.Forms.TextBox();
            this.lblPlayerDescription = new System.Windows.Forms.Label();
            this.txtPlayerDescription = new System.Windows.Forms.TextBox();
            this.lblPerson = new System.Windows.Forms.Label();
            this.cboPerson = new System.Windows.Forms.ComboBox();
            this.pan.SuspendLayout();
            this.grbEntry.SuspendLayout();
            this.grbEntryData.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorproviderbase)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Size = new System.Drawing.Size(491, 389);
            // 
            // grbEntry
            // 
            this.grbEntry.Size = new System.Drawing.Size(485, 384);
            // 
            // grbEntryData
            // 
            this.grbEntryData.Controls.Add(this.lblPerson);
            this.grbEntryData.Controls.Add(this.cboPerson);
            this.grbEntryData.Controls.Add(this.rtxtPlayerRemark);
            this.grbEntryData.Controls.Add(this.txtPlayerEmail);
            this.grbEntryData.Controls.Add(this.rtxtPlayerAddress);
            this.grbEntryData.Controls.Add(this.lblPlayerAddress);
            this.grbEntryData.Controls.Add(this.lblPlayerEmail);
            this.grbEntryData.Controls.Add(this.lblPlayerRemark);
            this.grbEntryData.Controls.Add(this.lblPlayerPhon);
            this.grbEntryData.Controls.Add(this.txtPlayerPhone);
            this.grbEntryData.Controls.Add(this.lblPlayerCode);
            this.grbEntryData.Controls.Add(this.txtPlayerCode);
            this.grbEntryData.Controls.Add(this.lblPlayerDescription);
            this.grbEntryData.Controls.Add(this.txtPlayerDescription);
            this.grbEntryData.Size = new System.Drawing.Size(475, 334);
            // 
            // grbControl
            // 
            this.grbControl.Size = new System.Drawing.Size(475, 40);
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
            this.btnClose.Location = new System.Drawing.Point(390, 10);
            this.toolTipbase.SetToolTip(this.btnClose, "Click to close");
            // 
            // lblHeader
            // 
            this.lblHeader.Location = new System.Drawing.Point(226, 9);
            this.lblHeader.Size = new System.Drawing.Size(47, 19);
            this.lblHeader.Text = "Player";
            // 
            // rtxtPlayerRemark
            // 
            this.rtxtPlayerRemark.BackColor = System.Drawing.Color.AliceBlue;
            this.rtxtPlayerRemark.Location = new System.Drawing.Point(125, 235);
            this.rtxtPlayerRemark.Name = "rtxtPlayerRemark";
            this.rtxtPlayerRemark.Size = new System.Drawing.Size(275, 89);
            this.rtxtPlayerRemark.TabIndex = 6;
            this.rtxtPlayerRemark.Text = "";
            this.rtxtPlayerRemark.Enter += new System.EventHandler(this.rtxtPlayerRemark_Enter);
            // 
            // txtPlayerEmail
            // 
            this.txtPlayerEmail.BackColor = System.Drawing.Color.AliceBlue;
            this.txtPlayerEmail.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerEmail.Location = new System.Drawing.Point(125, 125);
            this.txtPlayerEmail.Name = "txtPlayerEmail";
            this.txtPlayerEmail.Size = new System.Drawing.Size(275, 21);
            this.txtPlayerEmail.TabIndex = 4;
            this.txtPlayerEmail.Text = "E-mail";
            this.txtPlayerEmail.Enter += new System.EventHandler(this.txtPlayerEmail_Enter);
            // 
            // rtxtPlayerAddress
            // 
            this.rtxtPlayerAddress.BackColor = System.Drawing.Color.AliceBlue;
            this.rtxtPlayerAddress.Location = new System.Drawing.Point(125, 158);
            this.rtxtPlayerAddress.Name = "rtxtPlayerAddress";
            this.rtxtPlayerAddress.Size = new System.Drawing.Size(275, 71);
            this.rtxtPlayerAddress.TabIndex = 5;
            this.rtxtPlayerAddress.Text = "";
            this.rtxtPlayerAddress.Enter += new System.EventHandler(this.rtxtPlayerAddress_Enter);
            // 
            // lblPlayerAddress
            // 
            this.lblPlayerAddress.AutoSize = true;
            this.lblPlayerAddress.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPlayerAddress.Location = new System.Drawing.Point(28, 166);
            this.lblPlayerAddress.Name = "lblPlayerAddress";
            this.lblPlayerAddress.Size = new System.Drawing.Size(87, 15);
            this.lblPlayerAddress.TabIndex = 128;
            this.lblPlayerAddress.Text = "Player Address :";
            // 
            // lblPlayerEmail
            // 
            this.lblPlayerEmail.AutoSize = true;
            this.lblPlayerEmail.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPlayerEmail.Location = new System.Drawing.Point(37, 128);
            this.lblPlayerEmail.Name = "lblPlayerEmail";
            this.lblPlayerEmail.Size = new System.Drawing.Size(78, 15);
            this.lblPlayerEmail.TabIndex = 127;
            this.lblPlayerEmail.Text = "Player E-mail :";
            // 
            // lblPlayerRemark
            // 
            this.lblPlayerRemark.AutoSize = true;
            this.lblPlayerRemark.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerRemark.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPlayerRemark.Location = new System.Drawing.Point(31, 238);
            this.lblPlayerRemark.Name = "lblPlayerRemark";
            this.lblPlayerRemark.Size = new System.Drawing.Size(84, 15);
            this.lblPlayerRemark.TabIndex = 126;
            this.lblPlayerRemark.Text = "Player Remark :";
            // 
            // lblPlayerPhon
            // 
            this.lblPlayerPhon.AutoSize = true;
            this.lblPlayerPhon.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerPhon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPlayerPhon.Location = new System.Drawing.Point(38, 102);
            this.lblPlayerPhon.Name = "lblPlayerPhon";
            this.lblPlayerPhon.Size = new System.Drawing.Size(77, 15);
            this.lblPlayerPhon.TabIndex = 125;
            this.lblPlayerPhon.Text = "Player Phone :";
            // 
            // txtPlayerPhone
            // 
            this.txtPlayerPhone.BackColor = System.Drawing.Color.AliceBlue;
            this.txtPlayerPhone.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerPhone.Location = new System.Drawing.Point(125, 98);
            this.txtPlayerPhone.Name = "txtPlayerPhone";
            this.txtPlayerPhone.Size = new System.Drawing.Size(275, 21);
            this.txtPlayerPhone.TabIndex = 3;
            this.txtPlayerPhone.Text = "Competator Description";
            this.txtPlayerPhone.Enter += new System.EventHandler(this.txtPlayerPhone_Enter);
            // 
            // lblPlayerCode
            // 
            this.lblPlayerCode.AutoSize = true;
            this.lblPlayerCode.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPlayerCode.Location = new System.Drawing.Point(43, 48);
            this.lblPlayerCode.Name = "lblPlayerCode";
            this.lblPlayerCode.Size = new System.Drawing.Size(72, 15);
            this.lblPlayerCode.TabIndex = 123;
            this.lblPlayerCode.Text = "Player Code :";
            // 
            // txtPlayerCode
            // 
            this.txtPlayerCode.BackColor = System.Drawing.Color.AliceBlue;
            this.txtPlayerCode.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerCode.Location = new System.Drawing.Point(125, 44);
            this.txtPlayerCode.Name = "txtPlayerCode";
            this.txtPlayerCode.Size = new System.Drawing.Size(275, 21);
            this.txtPlayerCode.TabIndex = 1;
            this.txtPlayerCode.Text = "Competator";
            this.txtPlayerCode.Enter += new System.EventHandler(this.txtPlayerCode_Enter);
            // 
            // lblPlayerDescription
            // 
            this.lblPlayerDescription.AutoSize = true;
            this.lblPlayerDescription.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPlayerDescription.Location = new System.Drawing.Point(11, 75);
            this.lblPlayerDescription.Name = "lblPlayerDescription";
            this.lblPlayerDescription.Size = new System.Drawing.Size(104, 15);
            this.lblPlayerDescription.TabIndex = 121;
            this.lblPlayerDescription.Text = "Player Description :";
            // 
            // txtPlayerDescription
            // 
            this.txtPlayerDescription.BackColor = System.Drawing.Color.AliceBlue;
            this.txtPlayerDescription.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerDescription.Location = new System.Drawing.Point(125, 71);
            this.txtPlayerDescription.Name = "txtPlayerDescription";
            this.txtPlayerDescription.Size = new System.Drawing.Size(275, 21);
            this.txtPlayerDescription.TabIndex = 2;
            this.txtPlayerDescription.Text = "Competator Description";
            this.txtPlayerDescription.Enter += new System.EventHandler(this.txtPlayerDescription_Enter);
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerson.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPerson.Location = new System.Drawing.Point(69, 20);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(46, 15);
            this.lblPerson.TabIndex = 148;
            this.lblPerson.Text = "Person :";
            // 
            // cboPerson
            // 
            this.cboPerson.BackColor = System.Drawing.Color.AliceBlue;
            this.cboPerson.FormattingEnabled = true;
            this.cboPerson.Location = new System.Drawing.Point(125, 15);
            this.cboPerson.Name = "cboPerson";
            this.cboPerson.Size = new System.Drawing.Size(275, 23);
            this.cboPerson.TabIndex = 0;
            this.cboPerson.Enter += new System.EventHandler(this.cboPerson_Enter);
            // 
            // SetPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 439);
            this.Name = "SetPlayer";
            this.Text = "SetPlayer";
            this.toolTipbase.SetToolTip(this, "Drap to move to desired location");
            this.Load += new System.EventHandler(this.SetPlayer_Load);
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

        private System.Windows.Forms.RichTextBox rtxtPlayerRemark;
        public System.Windows.Forms.TextBox txtPlayerEmail;
        private System.Windows.Forms.RichTextBox rtxtPlayerAddress;
        public System.Windows.Forms.Label lblPlayerAddress;
        public System.Windows.Forms.Label lblPlayerEmail;
        public System.Windows.Forms.Label lblPlayerRemark;
        public System.Windows.Forms.Label lblPlayerPhon;
        public System.Windows.Forms.TextBox txtPlayerPhone;
        public System.Windows.Forms.Label lblPlayerCode;
        public System.Windows.Forms.TextBox txtPlayerCode;
        public System.Windows.Forms.Label lblPlayerDescription;
        public System.Windows.Forms.TextBox txtPlayerDescription;
        public System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.ComboBox cboPerson;
    }
}