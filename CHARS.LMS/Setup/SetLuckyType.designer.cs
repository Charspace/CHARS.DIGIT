namespace CHARS.HR.PL.Setup
{
    partial class SetLuckyType
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
            this.components = new System.ComponentModel.Container();
            this.lblTypeCode = new System.Windows.Forms.Label();
            this.txtTypeCode = new System.Windows.Forms.TextBox();
            this.lblTypeDescription = new System.Windows.Forms.Label();
            this.txtTypeDescription = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblNumofPass = new System.Windows.Forms.Label();
            this.txtNumofPass = new System.Windows.Forms.TextBox();
            this.lblResultType = new System.Windows.Forms.Label();
            this.lblComission = new System.Windows.Forms.Label();
            this.rdoComissionTime = new System.Windows.Forms.RadioButton();
            this.rdoComissionPercent = new System.Windows.Forms.RadioButton();
            this.rdoPassPercent = new System.Windows.Forms.RadioButton();
            this.rdoPassTimes = new System.Windows.Forms.RadioButton();
            this.nmcComission = new System.Windows.Forms.NumericUpDown();
            this.nmcPass = new System.Windows.Forms.NumericUpDown();
            this.rdoTypeVote = new System.Windows.Forms.RadioButton();
            this.rdoTypeDraw = new System.Windows.Forms.RadioButton();
            this.lblComissionType = new System.Windows.Forms.Label();
            this.lblPassType = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.pan.SuspendLayout();
            this.grbEntry.SuspendLayout();
            this.grbEntryData.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorproviderbase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcComission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcPass)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Location = new System.Drawing.Point(6, 21);
            this.pan.Size = new System.Drawing.Size(444, 346);
            // 
            // grbEntry
            // 
            this.grbEntry.Location = new System.Drawing.Point(3, -7);
            this.grbEntry.Size = new System.Drawing.Size(434, 350);
            // 
            // grbEntryData
            // 
            this.grbEntryData.Controls.Add(this.label1);
            this.grbEntryData.Controls.Add(this.txtRemark);
            this.grbEntryData.Controls.Add(this.lblResultType);
            this.grbEntryData.Controls.Add(this.lblComission);
            this.grbEntryData.Controls.Add(this.lblNumofPass);
            this.grbEntryData.Controls.Add(this.txtNumofPass);
            this.grbEntryData.Controls.Add(this.lblTypeCode);
            this.grbEntryData.Controls.Add(this.txtTypeCode);
            this.grbEntryData.Controls.Add(this.lblTypeDescription);
            this.grbEntryData.Controls.Add(this.txtTypeDescription);
            this.grbEntryData.Controls.Add(this.lblPass);
            this.grbEntryData.Controls.Add(this.groupBox1);
            this.grbEntryData.Controls.Add(this.groupBox3);
            this.grbEntryData.Controls.Add(this.groupBox2);
            this.grbEntryData.Location = new System.Drawing.Point(5, 12);
            this.grbEntryData.Size = new System.Drawing.Size(421, 296);
            this.grbEntryData.Text = "Entry";
            // 
            // grbControl
            // 
            this.grbControl.Location = new System.Drawing.Point(3, 303);
            this.grbControl.Size = new System.Drawing.Size(423, 40);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(174, 11);
            this.btnDelete.TabIndex = 3;
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
            this.btnClose.Location = new System.Drawing.Point(335, 10);
            this.btnClose.TabIndex = 2;
            this.toolTipbase.SetToolTip(this.btnClose, "Click to close");
            // 
            // lblHeader
            // 
            this.lblHeader.Location = new System.Drawing.Point(189, 2);
            this.lblHeader.Size = new System.Drawing.Size(76, 16);
            this.lblHeader.Text = "Lucky Type";
            this.lblHeader.Visible = true;
            // 
            // lblTypeCode
            // 
            this.lblTypeCode.AutoSize = true;
            this.lblTypeCode.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTypeCode.Location = new System.Drawing.Point(28, 26);
            this.lblTypeCode.Name = "lblTypeCode";
            this.lblTypeCode.Size = new System.Drawing.Size(67, 15);
            this.lblTypeCode.TabIndex = 94;
            this.lblTypeCode.Text = "Type Code :";
            // 
            // txtTypeCode
            // 
            this.txtTypeCode.BackColor = System.Drawing.Color.AliceBlue;
            this.txtTypeCode.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeCode.Location = new System.Drawing.Point(115, 22);
            this.txtTypeCode.Name = "txtTypeCode";
            this.txtTypeCode.Size = new System.Drawing.Size(283, 21);
            this.txtTypeCode.TabIndex = 0;
            this.txtTypeCode.Enter += new System.EventHandler(this.txtTypeCode_Enter);
            // 
            // lblTypeDescription
            // 
            this.lblTypeDescription.AutoSize = true;
            this.lblTypeDescription.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTypeDescription.Location = new System.Drawing.Point(-1, 50);
            this.lblTypeDescription.Name = "lblTypeDescription";
            this.lblTypeDescription.Size = new System.Drawing.Size(99, 15);
            this.lblTypeDescription.TabIndex = 92;
            this.lblTypeDescription.Text = "Type Description :";
            // 
            // txtTypeDescription
            // 
            this.txtTypeDescription.BackColor = System.Drawing.Color.AliceBlue;
            this.txtTypeDescription.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeDescription.Location = new System.Drawing.Point(115, 47);
            this.txtTypeDescription.Name = "txtTypeDescription";
            this.txtTypeDescription.Size = new System.Drawing.Size(283, 21);
            this.txtTypeDescription.TabIndex = 1;
            this.txtTypeDescription.Enter += new System.EventHandler(this.txtTypeDescription_Enter);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPass.Location = new System.Drawing.Point(60, 169);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(35, 15);
            this.lblPass.TabIndex = 90;
            this.lblPass.Text = "Pass :";
            // 
            // lblNumofPass
            // 
            this.lblNumofPass.AutoSize = true;
            this.lblNumofPass.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumofPass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNumofPass.Location = new System.Drawing.Point(20, 73);
            this.lblNumofPass.Name = "lblNumofPass";
            this.lblNumofPass.Size = new System.Drawing.Size(75, 15);
            this.lblNumofPass.TabIndex = 96;
            this.lblNumofPass.Text = "Num of Pass :";
            // 
            // txtNumofPass
            // 
            this.txtNumofPass.BackColor = System.Drawing.Color.AliceBlue;
            this.txtNumofPass.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumofPass.Location = new System.Drawing.Point(115, 70);
            this.txtNumofPass.Name = "txtNumofPass";
            this.txtNumofPass.Size = new System.Drawing.Size(283, 21);
            this.txtNumofPass.TabIndex = 2;
            this.txtNumofPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumofPass_KeyPress);
            this.txtNumofPass.Enter += new System.EventHandler(this.txtNumofPass_Enter);
            // 
            // lblResultType
            // 
            this.lblResultType.AutoSize = true;
            this.lblResultType.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblResultType.Location = new System.Drawing.Point(18, 101);
            this.lblResultType.Name = "lblResultType";
            this.lblResultType.Size = new System.Drawing.Size(77, 15);
            this.lblResultType.TabIndex = 98;
            this.lblResultType.Text = "Type of Pass :";
            // 
            // lblComission
            // 
            this.lblComission.AutoSize = true;
            this.lblComission.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComission.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblComission.Location = new System.Drawing.Point(31, 127);
            this.lblComission.Name = "lblComission";
            this.lblComission.Size = new System.Drawing.Size(64, 15);
            this.lblComission.TabIndex = 97;
            this.lblComission.Text = "Comission :";
            // 
            // rdoComissionTime
            // 
            this.rdoComissionTime.AutoSize = true;
            this.rdoComissionTime.Checked = true;
            this.rdoComissionTime.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoComissionTime.Location = new System.Drawing.Point(4, 9);
            this.rdoComissionTime.Name = "rdoComissionTime";
            this.rdoComissionTime.Size = new System.Drawing.Size(55, 19);
            this.rdoComissionTime.TabIndex = 0;
            this.rdoComissionTime.TabStop = true;
            this.rdoComissionTime.Text = "Times";
            this.rdoComissionTime.UseVisualStyleBackColor = true;
            this.rdoComissionTime.CheckedChanged += new System.EventHandler(this.rdoComissionTime_CheckedChanged);
            // 
            // rdoComissionPercent
            // 
            this.rdoComissionPercent.AutoSize = true;
            this.rdoComissionPercent.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoComissionPercent.Location = new System.Drawing.Point(4, 25);
            this.rdoComissionPercent.Name = "rdoComissionPercent";
            this.rdoComissionPercent.Size = new System.Drawing.Size(61, 19);
            this.rdoComissionPercent.TabIndex = 1;
            this.rdoComissionPercent.Text = "Percent";
            this.rdoComissionPercent.UseVisualStyleBackColor = true;
            // 
            // rdoPassPercent
            // 
            this.rdoPassPercent.AutoSize = true;
            this.rdoPassPercent.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPassPercent.Location = new System.Drawing.Point(4, 28);
            this.rdoPassPercent.Name = "rdoPassPercent";
            this.rdoPassPercent.Size = new System.Drawing.Size(61, 19);
            this.rdoPassPercent.TabIndex = 1;
            this.rdoPassPercent.Text = "Percent";
            this.rdoPassPercent.UseVisualStyleBackColor = true;
            // 
            // rdoPassTimes
            // 
            this.rdoPassTimes.AutoSize = true;
            this.rdoPassTimes.Checked = true;
            this.rdoPassTimes.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPassTimes.Location = new System.Drawing.Point(4, 11);
            this.rdoPassTimes.Name = "rdoPassTimes";
            this.rdoPassTimes.Size = new System.Drawing.Size(55, 19);
            this.rdoPassTimes.TabIndex = 0;
            this.rdoPassTimes.TabStop = true;
            this.rdoPassTimes.Text = "Times";
            this.rdoPassTimes.UseVisualStyleBackColor = true;
            this.rdoPassTimes.CheckedChanged += new System.EventHandler(this.rdoPassTimes_CheckedChanged);
            // 
            // nmcComission
            // 
            this.nmcComission.Location = new System.Drawing.Point(71, 11);
            this.nmcComission.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmcComission.Name = "nmcComission";
            this.nmcComission.Size = new System.Drawing.Size(72, 23);
            this.nmcComission.TabIndex = 2;
            // 
            // nmcPass
            // 
            this.nmcPass.Location = new System.Drawing.Point(69, 13);
            this.nmcPass.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmcPass.Name = "nmcPass";
            this.nmcPass.Size = new System.Drawing.Size(74, 23);
            this.nmcPass.TabIndex = 2;
            // 
            // rdoTypeVote
            // 
            this.rdoTypeVote.AutoSize = true;
            this.rdoTypeVote.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTypeVote.Location = new System.Drawing.Point(72, 12);
            this.rdoTypeVote.Name = "rdoTypeVote";
            this.rdoTypeVote.Size = new System.Drawing.Size(46, 19);
            this.rdoTypeVote.TabIndex = 1;
            this.rdoTypeVote.Text = "Vote";
            this.rdoTypeVote.UseVisualStyleBackColor = true;
            // 
            // rdoTypeDraw
            // 
            this.rdoTypeDraw.AutoSize = true;
            this.rdoTypeDraw.Checked = true;
            this.rdoTypeDraw.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTypeDraw.Location = new System.Drawing.Point(4, 12);
            this.rdoTypeDraw.Name = "rdoTypeDraw";
            this.rdoTypeDraw.Size = new System.Drawing.Size(52, 19);
            this.rdoTypeDraw.TabIndex = 0;
            this.rdoTypeDraw.TabStop = true;
            this.rdoTypeDraw.Text = "Draw";
            this.rdoTypeDraw.UseVisualStyleBackColor = true;
            // 
            // lblComissionType
            // 
            this.lblComissionType.AutoSize = true;
            this.lblComissionType.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComissionType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblComissionType.Location = new System.Drawing.Point(145, 16);
            this.lblComissionType.Name = "lblComissionType";
            this.lblComissionType.Size = new System.Drawing.Size(74, 15);
            this.lblComissionType.TabIndex = 109;
            this.lblComissionType.Text = "Time/Percent ";
            // 
            // lblPassType
            // 
            this.lblPassType.AutoSize = true;
            this.lblPassType.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPassType.Location = new System.Drawing.Point(146, 16);
            this.lblPassType.Name = "lblPassType";
            this.lblPassType.Size = new System.Drawing.Size(74, 15);
            this.lblPassType.TabIndex = 110;
            this.lblPassType.Text = "Time/Percent ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoTypeVote);
            this.groupBox1.Controls.Add(this.rdoTypeDraw);
            this.groupBox1.Location = new System.Drawing.Point(115, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 35);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nmcPass);
            this.groupBox2.Controls.Add(this.rdoPassTimes);
            this.groupBox2.Controls.Add(this.rdoPassPercent);
            this.groupBox2.Controls.Add(this.lblPassType);
            this.groupBox2.Location = new System.Drawing.Point(115, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 50);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblComissionType);
            this.groupBox3.Controls.Add(this.rdoComissionTime);
            this.groupBox3.Controls.Add(this.rdoComissionPercent);
            this.groupBox3.Controls.Add(this.nmcComission);
            this.groupBox3.Location = new System.Drawing.Point(115, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 46);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(45, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 114;
            this.label1.Text = "Remark :";
            // 
            // txtRemark
            // 
            this.txtRemark.BackColor = System.Drawing.Color.AliceBlue;
            this.txtRemark.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.Location = new System.Drawing.Point(115, 215);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(283, 70);
            this.txtRemark.TabIndex = 6;
            // 
            // SetLuckyType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 379);
            this.Name = "SetLuckyType";
            this.Text = "SetLuckyType";
            this.toolTipbase.SetToolTip(this, "Drap to move to desired location");
            this.Load += new System.EventHandler(this.SetLuckyType_Load);
            this.pan.ResumeLayout(false);
            this.grbEntry.ResumeLayout(false);
            this.grbEntryData.ResumeLayout(false);
            this.grbEntryData.PerformLayout();
            this.grbControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorproviderbase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcComission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcPass)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTypeCode;
        public System.Windows.Forms.TextBox txtTypeCode;
        public System.Windows.Forms.Label lblTypeDescription;
        public System.Windows.Forms.TextBox txtTypeDescription;
        public System.Windows.Forms.Label lblPass;
        public System.Windows.Forms.Label lblNumofPass;
        public System.Windows.Forms.TextBox txtNumofPass;
        public System.Windows.Forms.Label lblResultType;
        public System.Windows.Forms.Label lblComission;
        private System.Windows.Forms.NumericUpDown nmcComission;
        private System.Windows.Forms.RadioButton rdoPassPercent;
        private System.Windows.Forms.RadioButton rdoPassTimes;
        private System.Windows.Forms.RadioButton rdoComissionPercent;
        private System.Windows.Forms.RadioButton rdoComissionTime;
        private System.Windows.Forms.RadioButton rdoTypeVote;
        private System.Windows.Forms.RadioButton rdoTypeDraw;
        private System.Windows.Forms.NumericUpDown nmcPass;
        public System.Windows.Forms.Label lblPassType;
        public System.Windows.Forms.Label lblComissionType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtRemark;
    }
}