namespace CHARS.HR.PL.Setup
{
    partial class SetCompetator
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
            this.lblCompetatorCode = new System.Windows.Forms.Label();
            this.txtCompetatorCode = new System.Windows.Forms.TextBox();
            this.lblCompetatorDescription = new System.Windows.Forms.Label();
            this.txtCompetatorDescription = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.rtxtCompetatorRemark = new System.Windows.Forms.RichTextBox();
            this.pan.SuspendLayout();
            this.grbEntry.SuspendLayout();
            this.grbEntryData.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorproviderbase)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Size = new System.Drawing.Size(507, 224);
            // 
            // grbEntry
            // 
            this.grbEntry.Size = new System.Drawing.Size(500, 221);
            // 
            // grbEntryData
            // 
            this.grbEntryData.Controls.Add(this.rtxtCompetatorRemark);
            this.grbEntryData.Controls.Add(this.lblRemark);
            this.grbEntryData.Controls.Add(this.lblCompetatorCode);
            this.grbEntryData.Controls.Add(this.txtCompetatorCode);
            this.grbEntryData.Controls.Add(this.lblCompetatorDescription);
            this.grbEntryData.Controls.Add(this.txtCompetatorDescription);
            this.grbEntryData.Size = new System.Drawing.Size(473, 153);
            // 
            // grbControl
            // 
            this.grbControl.Location = new System.Drawing.Point(7, 171);
            this.grbControl.Size = new System.Drawing.Size(470, 40);
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
            this.btnClose.Location = new System.Drawing.Point(385, 10);
            this.toolTipbase.SetToolTip(this.btnClose, "Click to close");
            // 
            // lblHeader
            // 
            this.lblHeader.Location = new System.Drawing.Point(222, 9);
            this.lblHeader.Size = new System.Drawing.Size(82, 19);
            this.lblHeader.Text = "Competator";
            // 
            // lblCompetatorCode
            // 
            this.lblCompetatorCode.AutoSize = true;
            this.lblCompetatorCode.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetatorCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCompetatorCode.Location = new System.Drawing.Point(38, 37);
            this.lblCompetatorCode.Name = "lblCompetatorCode";
            this.lblCompetatorCode.Size = new System.Drawing.Size(99, 15);
            this.lblCompetatorCode.TabIndex = 98;
            this.lblCompetatorCode.Text = "Competator Code :";
            // 
            // txtCompetatorCode
            // 
            this.txtCompetatorCode.BackColor = System.Drawing.Color.AliceBlue;
            this.txtCompetatorCode.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompetatorCode.Location = new System.Drawing.Point(145, 30);
            this.txtCompetatorCode.Name = "txtCompetatorCode";
            this.txtCompetatorCode.Size = new System.Drawing.Size(290, 21);
            this.txtCompetatorCode.TabIndex = 97;
            this.txtCompetatorCode.Text = "Competator";
            this.txtCompetatorCode.Enter += new System.EventHandler(this.txtCompetatorCode_Enter);
            // 
            // lblCompetatorDescription
            // 
            this.lblCompetatorDescription.AutoSize = true;
            this.lblCompetatorDescription.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetatorDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCompetatorDescription.Location = new System.Drawing.Point(8, 64);
            this.lblCompetatorDescription.Name = "lblCompetatorDescription";
            this.lblCompetatorDescription.Size = new System.Drawing.Size(131, 15);
            this.lblCompetatorDescription.TabIndex = 96;
            this.lblCompetatorDescription.Text = "Competator Description :";
            // 
            // txtCompetatorDescription
            // 
            this.txtCompetatorDescription.BackColor = System.Drawing.Color.AliceBlue;
            this.txtCompetatorDescription.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompetatorDescription.Location = new System.Drawing.Point(145, 58);
            this.txtCompetatorDescription.Name = "txtCompetatorDescription";
            this.txtCompetatorDescription.Size = new System.Drawing.Size(290, 21);
            this.txtCompetatorDescription.TabIndex = 95;
            this.txtCompetatorDescription.Text = "Competator Description";
            this.txtCompetatorDescription.Enter += new System.EventHandler(this.txtCompetatorDescription_Enter);
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemark.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRemark.Location = new System.Drawing.Point(87, 92);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(50, 15);
            this.lblRemark.TabIndex = 100;
            this.lblRemark.Text = "Remark :";
            // 
            // rtxtCompetatorRemark
            // 
            this.rtxtCompetatorRemark.BackColor = System.Drawing.Color.AliceBlue;
            this.rtxtCompetatorRemark.Location = new System.Drawing.Point(145, 82);
            this.rtxtCompetatorRemark.Name = "rtxtCompetatorRemark";
            this.rtxtCompetatorRemark.Size = new System.Drawing.Size(275, 65);
            this.rtxtCompetatorRemark.TabIndex = 120;
            this.rtxtCompetatorRemark.Text = "";
            this.rtxtCompetatorRemark.Enter += new System.EventHandler(this.rtxtCompetatorRemark_Enter);
            // 
            // SetCompetator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 270);
            this.Name = "SetCompetator";
            this.Text = "SetCompetator";
            this.toolTipbase.SetToolTip(this, "Drap to move to desired location");
            this.Load += new System.EventHandler(this.SetCompetator_Load);
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

        public System.Windows.Forms.Label lblRemark;
        public System.Windows.Forms.Label lblCompetatorCode;
        public System.Windows.Forms.TextBox txtCompetatorCode;
        public System.Windows.Forms.Label lblCompetatorDescription;
        public System.Windows.Forms.TextBox txtCompetatorDescription;
        private System.Windows.Forms.RichTextBox rtxtCompetatorRemark;
    }
}