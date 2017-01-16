namespace CHARS.HR.PL.Process
{
    partial class ProList
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
            this.lblTypeCaption = new System.Windows.Forms.Label();
            this.lblPrefix = new System.Windows.Forms.Label();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.lblDigit = new System.Windows.Forms.Label();
            this.nmcDigit = new System.Windows.Forms.NumericUpDown();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dgvVote = new System.Windows.Forms.DataGridView();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblluckyType = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.cboLuckyType = new System.Windows.Forms.ComboBox();
            this.grbDraw = new System.Windows.Forms.GroupBox();
            this.btnPrepare = new System.Windows.Forms.Button();
            this.lblMaxAmount = new System.Windows.Forms.Label();
            this.txtMaxamount = new System.Windows.Forms.TextBox();
            this.lblMinAmount = new System.Windows.Forms.Label();
            this.txtMinAmount = new System.Windows.Forms.TextBox();
            this.dgvDrawResult = new System.Windows.Forms.DataGridView();
            this.dgvtxtNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtListCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtListDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcboMainCompetator = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcboStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtGo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcboCompetator = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtTotalOperator = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcboGoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtTotalPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pan.SuspendLayout();
            this.grbEntry.SuspendLayout();
            this.grbEntryData.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorproviderbase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcDigit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVote)).BeginInit();
            this.grbDraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrawResult)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Location = new System.Drawing.Point(7, 18);
            this.pan.Size = new System.Drawing.Size(720, 474);
            // 
            // grbEntry
            // 
            this.grbEntry.Size = new System.Drawing.Size(717, 471);
            // 
            // grbEntryData
            // 
            this.grbEntryData.Controls.Add(this.dgvDrawResult);
            this.grbEntryData.Controls.Add(this.lblMaxAmount);
            this.grbEntryData.Controls.Add(this.txtMaxamount);
            this.grbEntryData.Controls.Add(this.dgvVote);
            this.grbEntryData.Controls.Add(this.lblMinAmount);
            this.grbEntryData.Controls.Add(this.txtMinAmount);
            this.grbEntryData.Controls.Add(this.grbDraw);
            this.grbEntryData.Controls.Add(this.lblTypeCaption);
            this.grbEntryData.Controls.Add(this.dtpStartDate);
            this.grbEntryData.Controls.Add(this.dtpEndDate);
            this.grbEntryData.Controls.Add(this.lblStartDate);
            this.grbEntryData.Controls.Add(this.lblluckyType);
            this.grbEntryData.Controls.Add(this.lblEndDate);
            this.grbEntryData.Controls.Add(this.cboLuckyType);
            this.grbEntryData.Location = new System.Drawing.Point(4, 1);
            this.grbEntryData.Size = new System.Drawing.Size(709, 424);
            // 
            // grbControl
            // 
            this.grbControl.Location = new System.Drawing.Point(2, 425);
            this.grbControl.Size = new System.Drawing.Size(709, 40);
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
            this.btnClose.Location = new System.Drawing.Point(624, 10);
            this.toolTipbase.SetToolTip(this.btnClose, "Click to close");
            // 
            // lblHeader
            // 
            this.lblHeader.Location = new System.Drawing.Point(346, -2);
            // 
            // lblTypeCaption
            // 
            this.lblTypeCaption.AutoSize = true;
            this.lblTypeCaption.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeCaption.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTypeCaption.Location = new System.Drawing.Point(368, 17);
            this.lblTypeCaption.Name = "lblTypeCaption";
            this.lblTypeCaption.Size = new System.Drawing.Size(58, 15);
            this.lblTypeCaption.TabIndex = 123;
            this.lblTypeCaption.Text = "Draw/Vote";
            // 
            // lblPrefix
            // 
            this.lblPrefix.AutoSize = true;
            this.lblPrefix.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrefix.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrefix.Location = new System.Drawing.Point(10, 17);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.Size = new System.Drawing.Size(41, 15);
            this.lblPrefix.TabIndex = 113;
            this.lblPrefix.Text = "Prefix :";
            // 
            // txtPrefix
            // 
            this.txtPrefix.BackColor = System.Drawing.Color.AliceBlue;
            this.txtPrefix.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrefix.Location = new System.Drawing.Point(57, 15);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(103, 21);
            this.txtPrefix.TabIndex = 112;
            // 
            // lblDigit
            // 
            this.lblDigit.AutoSize = true;
            this.lblDigit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDigit.Location = new System.Drawing.Point(203, 18);
            this.lblDigit.Name = "lblDigit";
            this.lblDigit.Size = new System.Drawing.Size(37, 15);
            this.lblDigit.TabIndex = 111;
            this.lblDigit.Text = "Digit :";
            this.lblDigit.Click += new System.EventHandler(this.lblDigit_Click);
            // 
            // nmcDigit
            // 
            this.nmcDigit.Location = new System.Drawing.Point(246, 15);
            this.nmcDigit.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmcDigit.Name = "nmcDigit";
            this.nmcDigit.Size = new System.Drawing.Size(73, 23);
            this.nmcDigit.TabIndex = 110;
            this.nmcDigit.ValueChanged += new System.EventHandler(this.nmcDigit_ValueChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(125, 37);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 23);
            this.dtpStartDate.TabIndex = 122;
            // 
            // dgvVote
            // 
            this.dgvVote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcboMainCompetator,
            this.dgvcboStatus,
            this.dgvtxtGo,
            this.dgvtxtPercent,
            this.dgvcboCompetator,
            this.dgvtxtTotalOperator,
            this.dgvcboGoTotal,
            this.dgvtxtTotalPercent});
            this.dgvVote.Location = new System.Drawing.Point(1, 133);
            this.dgvVote.Name = "dgvVote";
            this.dgvVote.RowHeadersVisible = false;
            this.dgvVote.Size = new System.Drawing.Size(704, 288);
            this.dgvVote.TabIndex = 0;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(476, 37);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(227, 23);
            this.dtpEndDate.TabIndex = 124;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStartDate.Location = new System.Drawing.Point(16, 42);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(62, 15);
            this.lblStartDate.TabIndex = 125;
            this.lblStartDate.Text = "Start Date :";
            // 
            // lblluckyType
            // 
            this.lblluckyType.AutoSize = true;
            this.lblluckyType.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblluckyType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblluckyType.Location = new System.Drawing.Point(16, 20);
            this.lblluckyType.Name = "lblluckyType";
            this.lblluckyType.Size = new System.Drawing.Size(73, 15);
            this.lblluckyType.TabIndex = 128;
            this.lblluckyType.Text = "Lucky Type :";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEndDate.Location = new System.Drawing.Point(367, 43);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(58, 15);
            this.lblEndDate.TabIndex = 126;
            this.lblEndDate.Text = "End Date :";
            // 
            // cboLuckyType
            // 
            this.cboLuckyType.FormattingEnabled = true;
            this.cboLuckyType.Location = new System.Drawing.Point(124, 12);
            this.cboLuckyType.Name = "cboLuckyType";
            this.cboLuckyType.Size = new System.Drawing.Size(201, 23);
            this.cboLuckyType.TabIndex = 127;
            this.cboLuckyType.SelectedIndexChanged += new System.EventHandler(this.cboLuckyType_SelectedIndexChanged);
            // 
            // grbDraw
            // 
            this.grbDraw.Controls.Add(this.btnPrepare);
            this.grbDraw.Controls.Add(this.lblPrefix);
            this.grbDraw.Controls.Add(this.lblDigit);
            this.grbDraw.Controls.Add(this.txtPrefix);
            this.grbDraw.Controls.Add(this.nmcDigit);
            this.grbDraw.Location = new System.Drawing.Point(6, 85);
            this.grbDraw.Name = "grbDraw";
            this.grbDraw.Size = new System.Drawing.Size(697, 44);
            this.grbDraw.TabIndex = 114;
            this.grbDraw.TabStop = false;
            this.grbDraw.Enter += new System.EventHandler(this.grbDraw_Enter);
            // 
            // btnPrepare
            // 
            this.btnPrepare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrepare.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrepare.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPrepare.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrepare.ForeColor = System.Drawing.Color.Snow;
            this.btnPrepare.Location = new System.Drawing.Point(591, 14);
            this.btnPrepare.Name = "btnPrepare";
            this.btnPrepare.Size = new System.Drawing.Size(106, 24);
            this.btnPrepare.TabIndex = 114;
            this.btnPrepare.Text = "&Prepare";
            this.toolTipbase.SetToolTip(this.btnPrepare, "Click to save");
            this.btnPrepare.UseVisualStyleBackColor = false;
            this.btnPrepare.Click += new System.EventHandler(this.btnPrepare_Click);
            // 
            // lblMaxAmount
            // 
            this.lblMaxAmount.AutoSize = true;
            this.lblMaxAmount.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMaxAmount.Location = new System.Drawing.Point(367, 66);
            this.lblMaxAmount.Name = "lblMaxAmount";
            this.lblMaxAmount.Size = new System.Drawing.Size(104, 15);
            this.lblMaxAmount.TabIndex = 182;
            this.lblMaxAmount.Text = "Maximum Amount :";
            // 
            // txtMaxamount
            // 
            this.txtMaxamount.BackColor = System.Drawing.Color.AliceBlue;
            this.txtMaxamount.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxamount.Location = new System.Drawing.Point(477, 63);
            this.txtMaxamount.Name = "txtMaxamount";
            this.txtMaxamount.Size = new System.Drawing.Size(226, 21);
            this.txtMaxamount.TabIndex = 181;
            // 
            // lblMinAmount
            // 
            this.lblMinAmount.AutoSize = true;
            this.lblMinAmount.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMinAmount.Location = new System.Drawing.Point(16, 64);
            this.lblMinAmount.Name = "lblMinAmount";
            this.lblMinAmount.Size = new System.Drawing.Size(103, 15);
            this.lblMinAmount.TabIndex = 180;
            this.lblMinAmount.Text = "Minimum Amount :";
            // 
            // txtMinAmount
            // 
            this.txtMinAmount.BackColor = System.Drawing.Color.AliceBlue;
            this.txtMinAmount.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinAmount.Location = new System.Drawing.Point(125, 63);
            this.txtMinAmount.Name = "txtMinAmount";
            this.txtMinAmount.Size = new System.Drawing.Size(200, 21);
            this.txtMinAmount.TabIndex = 179;
            // 
            // dgvDrawResult
            // 
            this.dgvDrawResult.AllowUserToAddRows = false;
            this.dgvDrawResult.AllowUserToOrderColumns = true;
            this.dgvDrawResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDrawResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrawResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtNo,
            this.dgvtxtListCode,
            this.dgvtxtListDescription});
            this.dgvDrawResult.Location = new System.Drawing.Point(1, 133);
            this.dgvDrawResult.Name = "dgvDrawResult";
            this.dgvDrawResult.Size = new System.Drawing.Size(704, 286);
            this.dgvDrawResult.TabIndex = 1;
            this.dgvDrawResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrawResult_CellContentClick);
            // 
            // dgvtxtNo
            // 
            this.dgvtxtNo.HeaderText = "No";
            this.dgvtxtNo.Name = "dgvtxtNo";
            this.dgvtxtNo.ReadOnly = true;
            // 
            // dgvtxtListCode
            // 
            this.dgvtxtListCode.HeaderText = "List Code";
            this.dgvtxtListCode.Name = "dgvtxtListCode";
            // 
            // dgvtxtListDescription
            // 
            this.dgvtxtListDescription.HeaderText = "List Description";
            this.dgvtxtListDescription.Name = "dgvtxtListDescription";
            // 
            // dgvcboMainCompetator
            // 
            this.dgvcboMainCompetator.HeaderText = "Main Competator";
            this.dgvcboMainCompetator.Name = "dgvcboMainCompetator";
            this.dgvcboMainCompetator.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcboMainCompetator.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvcboMainCompetator.Width = 200;
            // 
            // dgvcboStatus
            // 
            this.dgvcboStatus.HeaderText = "+/-";
            this.dgvcboStatus.Items.AddRange(new object[] {
            "+",
            "-"});
            this.dgvcboStatus.Name = "dgvcboStatus";
            this.dgvcboStatus.Width = 50;
            // 
            // dgvtxtGo
            // 
            this.dgvtxtGo.HeaderText = "Score";
            this.dgvtxtGo.Name = "dgvtxtGo";
            this.dgvtxtGo.Width = 50;
            // 
            // dgvtxtPercent
            // 
            this.dgvtxtPercent.HeaderText = "%";
            this.dgvtxtPercent.Name = "dgvtxtPercent";
            this.dgvtxtPercent.Width = 50;
            // 
            // dgvcboCompetator
            // 
            this.dgvcboCompetator.HeaderText = "Competator";
            this.dgvcboCompetator.Name = "dgvcboCompetator";
            this.dgvcboCompetator.Width = 190;
            // 
            // dgvtxtTotalOperator
            // 
            this.dgvtxtTotalOperator.HeaderText = "T(+/-)";
            this.dgvtxtTotalOperator.Items.AddRange(new object[] {
            "+",
            "-"});
            this.dgvtxtTotalOperator.Name = "dgvtxtTotalOperator";
            this.dgvtxtTotalOperator.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtxtTotalOperator.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvtxtTotalOperator.Width = 50;
            // 
            // dgvcboGoTotal
            // 
            this.dgvcboGoTotal.HeaderText = "T(Score)";
            this.dgvcboGoTotal.Name = "dgvcboGoTotal";
            this.dgvcboGoTotal.Width = 60;
            // 
            // dgvtxtTotalPercent
            // 
            this.dgvtxtTotalPercent.HeaderText = "T(%)";
            this.dgvtxtTotalPercent.Name = "dgvtxtTotalPercent";
            this.dgvtxtTotalPercent.Width = 50;
            // 
            // ProList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 505);
            this.Name = "ProList";
            this.Text = "ProList";
            this.toolTipbase.SetToolTip(this, "Drap to move to desired location");
            this.Load += new System.EventHandler(this.ProList_Load);
            this.pan.ResumeLayout(false);
            this.grbEntry.ResumeLayout(false);
            this.grbEntryData.ResumeLayout(false);
            this.grbEntryData.PerformLayout();
            this.grbControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorproviderbase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcDigit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVote)).EndInit();
            this.grbDraw.ResumeLayout(false);
            this.grbDraw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrawResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTypeCaption;
        public System.Windows.Forms.Label lblPrefix;
        public System.Windows.Forms.TextBox txtPrefix;
        public System.Windows.Forms.Label lblDigit;
        private System.Windows.Forms.NumericUpDown nmcDigit;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DataGridView dgvVote;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        public System.Windows.Forms.Label lblStartDate;
        public System.Windows.Forms.Label lblluckyType;
        public System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.ComboBox cboLuckyType;
        private System.Windows.Forms.GroupBox grbDraw;
        public System.Windows.Forms.Button btnPrepare;
        public System.Windows.Forms.Label lblMaxAmount;
        public System.Windows.Forms.TextBox txtMaxamount;
        public System.Windows.Forms.Label lblMinAmount;
        public System.Windows.Forms.TextBox txtMinAmount;
        private System.Windows.Forms.DataGridView dgvDrawResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtListCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtListDescription;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcboMainCompetator;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcboStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtGo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtPercent;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcboCompetator;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvtxtTotalOperator;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcboGoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtTotalPercent;
    }
}