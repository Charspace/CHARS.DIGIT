namespace CHARS.HR.PL.Setup
{
    partial class SetSubmit
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
            this.grbDraw = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblComm = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrepare = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.dgvDraw = new System.Windows.Forms.DataGridView();
            this.txtList = new System.Windows.Forms.TextBox();
            this.lblList = new System.Windows.Forms.Label();
            this.cboOperator = new System.Windows.Forms.ComboBox();
            this.dtpSubmitdate = new System.Windows.Forms.DateTimePicker();
            this.grbVote = new System.Windows.Forms.GroupBox();
            this.dgvVote = new System.Windows.Forms.DataGridView();
            this.dgvchkMainCompetator = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvchkSecondCompetator = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvtxtBodyAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtTotalGoamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcboupdown = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvchkmaung = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvtxtmaungamt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvchkBodyMaung = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblSubmitDate = new System.Windows.Forms.Label();
            this.cboAgent = new System.Windows.Forms.ComboBox();
            this.cboPlayer = new System.Windows.Forms.ComboBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.cboPeriod = new System.Windows.Forms.ComboBox();
            this.lblTypeCaption = new System.Windows.Forms.Label();
            this.lblluckyType = new System.Windows.Forms.Label();
            this.cboMaster = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnMaster = new System.Windows.Forms.Button();
            this.btnPeriod = new System.Windows.Forms.Button();
            this.btnPlayer = new System.Windows.Forms.Button();
            this.btnAgent = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.cboLuckyType = new System.Windows.Forms.ComboBox();
            this.pan.SuspendLayout();
            this.grbEntry.SuspendLayout();
            this.grbEntryData.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorproviderbase)).BeginInit();
            this.grbDraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDraw)).BeginInit();
            this.grbVote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVote)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Location = new System.Drawing.Point(7, 19);
            this.pan.Size = new System.Drawing.Size(981, 490);
            this.pan.ParentChanged += new System.EventHandler(this.pan_ParentChanged);
            // 
            // grbEntry
            // 
            this.grbEntry.Size = new System.Drawing.Size(974, 489);
            // 
            // grbEntryData
            // 
            this.grbEntryData.Controls.Add(this.cboLuckyType);
            this.grbEntryData.Controls.Add(this.linkLabel3);
            this.grbEntryData.Controls.Add(this.btnAgent);
            this.grbEntryData.Controls.Add(this.linkLabel1);
            this.grbEntryData.Controls.Add(this.linkLabel2);
            this.grbEntryData.Controls.Add(this.btnPlayer);
            this.grbEntryData.Controls.Add(this.btnPeriod);
            this.grbEntryData.Controls.Add(this.btnMaster);
            this.grbEntryData.Controls.Add(this.cboMaster);
            this.grbEntryData.Controls.Add(this.lblTypeCaption);
            this.grbEntryData.Controls.Add(this.lblluckyType);
            this.grbEntryData.Controls.Add(this.lblPeriod);
            this.grbEntryData.Controls.Add(this.cboPeriod);
            this.grbEntryData.Controls.Add(this.cboPlayer);
            this.grbEntryData.Controls.Add(this.grbDraw);
            this.grbEntryData.Controls.Add(this.dtpSubmitdate);
            this.grbEntryData.Controls.Add(this.grbVote);
            this.grbEntryData.Controls.Add(this.lblSubmitDate);
            this.grbEntryData.Controls.Add(this.cboAgent);
            this.grbEntryData.Location = new System.Drawing.Point(4, 8);
            this.grbEntryData.Size = new System.Drawing.Size(965, 441);
            // 
            // grbControl
            // 
            this.grbControl.Controls.Add(this.btnPrint);
            this.grbControl.Location = new System.Drawing.Point(4, 442);
            this.grbControl.Size = new System.Drawing.Size(965, 40);
            this.grbControl.Controls.SetChildIndex(this.btnPrint, 0);
            this.grbControl.Controls.SetChildIndex(this.btnClose, 0);
            this.grbControl.Controls.SetChildIndex(this.btnSave, 0);
            this.grbControl.Controls.SetChildIndex(this.btnNew, 0);
            this.grbControl.Controls.SetChildIndex(this.btnDelete, 0);
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
            this.btnClose.Location = new System.Drawing.Point(880, 10);
            this.btnClose.TabIndex = 4;
            this.toolTipbase.SetToolTip(this.btnClose, "Click to close");
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Location = new System.Drawing.Point(489, 1);
            this.lblHeader.Size = new System.Drawing.Size(48, 16);
            this.lblHeader.Text = "Submit";
            this.lblHeader.Visible = true;
            // 
            // grbDraw
            // 
            this.grbDraw.Controls.Add(this.btnRemove);
            this.grbDraw.Controls.Add(this.lblComm);
            this.grbDraw.Controls.Add(this.LblTotal);
            this.grbDraw.Controls.Add(this.lblCount);
            this.grbDraw.Controls.Add(this.btnClear);
            this.grbDraw.Controls.Add(this.btnPrepare);
            this.grbDraw.Controls.Add(this.txtAmount);
            this.grbDraw.Controls.Add(this.dgvDraw);
            this.grbDraw.Controls.Add(this.txtList);
            this.grbDraw.Controls.Add(this.lblList);
            this.grbDraw.Controls.Add(this.cboOperator);
            this.grbDraw.Location = new System.Drawing.Point(4, 74);
            this.grbDraw.Name = "grbDraw";
            this.grbDraw.Size = new System.Drawing.Size(956, 359);
            this.grbDraw.TabIndex = 129;
            this.grbDraw.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemove.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemove.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnRemove.Location = new System.Drawing.Point(436, 19);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(83, 23);
            this.btnRemove.TabIndex = 144;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblComm
            // 
            this.lblComm.AutoSize = true;
            this.lblComm.Location = new System.Drawing.Point(403, 334);
            this.lblComm.Name = "lblComm";
            this.lblComm.Size = new System.Drawing.Size(46, 16);
            this.lblComm.TabIndex = 143;
            this.lblComm.Text = "Com : ";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(180, 334);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(47, 16);
            this.LblTotal.TabIndex = 142;
            this.LblTotal.Text = "Total : ";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(6, 334);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(49, 16);
            this.lblCount.TabIndex = 141;
            this.lblCount.Text = "Count :";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnClear.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnClear.Location = new System.Drawing.Point(867, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 22);
            this.btnClear.TabIndex = 140;
            this.btnClear.Text = "&Clear All ";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPrepare
            // 
            this.btnPrepare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrepare.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrepare.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrepare.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPrepare.Location = new System.Drawing.Point(353, 19);
            this.btnPrepare.Name = "btnPrepare";
            this.btnPrepare.Size = new System.Drawing.Size(83, 23);
            this.btnPrepare.TabIndex = 3;
            this.btnPrepare.Text = "&Add";
            this.btnPrepare.UseVisualStyleBackColor = false;
            this.btnPrepare.Click += new System.EventHandler(this.btnPrepare_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.AliceBlue;
            this.txtAmount.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(249, 21);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(85, 21);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.Text = "1000";
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // dgvDraw
            // 
            this.dgvDraw.AllowUserToAddRows = false;
            this.dgvDraw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDraw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDraw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDraw.Location = new System.Drawing.Point(6, 51);
            this.dgvDraw.Name = "dgvDraw";
            this.dgvDraw.RowHeadersVisible = false;
            this.dgvDraw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDraw.Size = new System.Drawing.Size(944, 280);
            this.dgvDraw.TabIndex = 4;
            this.dgvDraw.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDraw_CellMouseUp);
            this.dgvDraw.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDraw_CellFormatting);
            this.dgvDraw.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDraw_CellEndEdit);
            this.dgvDraw.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvDraw_EditingControlShowing);
            // 
            // txtList
            // 
            this.txtList.BackColor = System.Drawing.Color.AliceBlue;
            this.txtList.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtList.Location = new System.Drawing.Point(144, 21);
            this.txtList.MaxLength = 3;
            this.txtList.Name = "txtList";
            this.txtList.Size = new System.Drawing.Size(85, 21);
            this.txtList.TabIndex = 1;
            this.txtList.Text = "12";
            this.txtList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtList_KeyPress);
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblList.Location = new System.Drawing.Point(4, 24);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(28, 15);
            this.lblList.TabIndex = 130;
            this.lblList.Text = "Cri :";
            // 
            // cboOperator
            // 
            this.cboOperator.FormattingEnabled = true;
            this.cboOperator.Items.AddRange(new object[] {
            "Begin",
            "End",
            "Contain",
            "Equal",
            "Round",
            "Round-6",
            "ALL"});
            this.cboOperator.Location = new System.Drawing.Point(39, 20);
            this.cboOperator.Name = "cboOperator";
            this.cboOperator.Size = new System.Drawing.Size(85, 23);
            this.cboOperator.TabIndex = 0;
            // 
            // dtpSubmitdate
            // 
            this.dtpSubmitdate.CalendarFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSubmitdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSubmitdate.Location = new System.Drawing.Point(434, 12);
            this.dtpSubmitdate.Name = "dtpSubmitdate";
            this.dtpSubmitdate.Size = new System.Drawing.Size(200, 23);
            this.dtpSubmitdate.TabIndex = 2;
            // 
            // grbVote
            // 
            this.grbVote.Controls.Add(this.dgvVote);
            this.grbVote.Location = new System.Drawing.Point(4, 74);
            this.grbVote.Name = "grbVote";
            this.grbVote.Size = new System.Drawing.Size(958, 359);
            this.grbVote.TabIndex = 130;
            this.grbVote.TabStop = false;
            // 
            // dgvVote
            // 
            this.dgvVote.AllowUserToAddRows = false;
            this.dgvVote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvchkMainCompetator,
            this.dgvchkSecondCompetator,
            this.dgvtxtBodyAmt,
            this.dgvtxtTotalGoamount,
            this.dgvcboupdown,
            this.dgvchkmaung,
            this.dgvtxtmaungamt,
            this.dgvchkBodyMaung});
            this.dgvVote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVote.Location = new System.Drawing.Point(3, 19);
            this.dgvVote.Name = "dgvVote";
            this.dgvVote.RowHeadersVisible = false;
            this.dgvVote.Size = new System.Drawing.Size(952, 337);
            this.dgvVote.TabIndex = 1;
            this.dgvVote.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvVote_CellFormatting);
            this.dgvVote.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVote_CellContentClick);
            // 
            // dgvchkMainCompetator
            // 
            this.dgvchkMainCompetator.FalseValue = "0";
            this.dgvchkMainCompetator.HeaderText = "Mai";
            this.dgvchkMainCompetator.Name = "dgvchkMainCompetator";
            this.dgvchkMainCompetator.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvchkMainCompetator.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvchkMainCompetator.TrueValue = "1";
            this.dgvchkMainCompetator.Width = 30;
            // 
            // dgvchkSecondCompetator
            // 
            this.dgvchkSecondCompetator.FalseValue = "0";
            this.dgvchkSecondCompetator.HeaderText = "Sec";
            this.dgvchkSecondCompetator.Name = "dgvchkSecondCompetator";
            this.dgvchkSecondCompetator.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvchkSecondCompetator.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvchkSecondCompetator.TrueValue = "1";
            this.dgvchkSecondCompetator.Width = 30;
            // 
            // dgvtxtBodyAmt
            // 
            this.dgvtxtBodyAmt.HeaderText = "Body Amt";
            this.dgvtxtBodyAmt.Name = "dgvtxtBodyAmt";
            // 
            // dgvtxtTotalGoamount
            // 
            this.dgvtxtTotalGoamount.HeaderText = "Total Amt";
            this.dgvtxtTotalGoamount.Name = "dgvtxtTotalGoamount";
            // 
            // dgvcboupdown
            // 
            this.dgvcboupdown.HeaderText = "Up/Down";
            this.dgvcboupdown.Items.AddRange(new object[] {
            "+",
            "-"});
            this.dgvcboupdown.Name = "dgvcboupdown";
            // 
            // dgvchkmaung
            // 
            this.dgvchkmaung.FalseValue = "0";
            this.dgvchkmaung.HeaderText = "Maung";
            this.dgvchkmaung.Name = "dgvchkmaung";
            this.dgvchkmaung.TrueValue = "1";
            // 
            // dgvtxtmaungamt
            // 
            this.dgvtxtmaungamt.HeaderText = "Mg Amt";
            this.dgvtxtmaungamt.Name = "dgvtxtmaungamt";
            // 
            // dgvchkBodyMaung
            // 
            this.dgvchkBodyMaung.FalseValue = "0";
            this.dgvchkBodyMaung.HeaderText = "Body";
            this.dgvchkBodyMaung.Name = "dgvchkBodyMaung";
            this.dgvchkBodyMaung.TrueValue = "1";
            // 
            // lblSubmitDate
            // 
            this.lblSubmitDate.AutoSize = true;
            this.lblSubmitDate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmitDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSubmitDate.Location = new System.Drawing.Point(359, 16);
            this.lblSubmitDate.Name = "lblSubmitDate";
            this.lblSubmitDate.Size = new System.Drawing.Size(73, 15);
            this.lblSubmitDate.TabIndex = 125;
            this.lblSubmitDate.Text = "Submit Date :";
            // 
            // cboAgent
            // 
            this.cboAgent.FormattingEnabled = true;
            this.cboAgent.Location = new System.Drawing.Point(741, 12);
            this.cboAgent.Name = "cboAgent";
            this.cboAgent.Size = new System.Drawing.Size(184, 23);
            this.cboAgent.TabIndex = 4;
            this.cboAgent.SelectedIndexChanged += new System.EventHandler(this.cboAgent_SelectedIndexChanged);
            // 
            // cboPlayer
            // 
            this.cboPlayer.FormattingEnabled = true;
            this.cboPlayer.Location = new System.Drawing.Point(741, 40);
            this.cboPlayer.Name = "cboPlayer";
            this.cboPlayer.Size = new System.Drawing.Size(184, 23);
            this.cboPlayer.TabIndex = 5;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPeriod.Location = new System.Drawing.Point(11, 43);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(44, 15);
            this.lblPeriod.TabIndex = 136;
            this.lblPeriod.Text = "Period :";
            // 
            // cboPeriod
            // 
            this.cboPeriod.FormattingEnabled = true;
            this.cboPeriod.Location = new System.Drawing.Point(97, 40);
            this.cboPeriod.Name = "cboPeriod";
            this.cboPeriod.Size = new System.Drawing.Size(200, 23);
            this.cboPeriod.TabIndex = 1;
            this.cboPeriod.SelectedIndexChanged += new System.EventHandler(this.cboPeriod_SelectedIndexChanged);
            // 
            // lblTypeCaption
            // 
            this.lblTypeCaption.AutoSize = true;
            this.lblTypeCaption.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeCaption.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTypeCaption.Location = new System.Drawing.Point(239, 17);
            this.lblTypeCaption.Name = "lblTypeCaption";
            this.lblTypeCaption.Size = new System.Drawing.Size(58, 15);
            this.lblTypeCaption.TabIndex = 137;
            this.lblTypeCaption.Text = "Draw/Vote";
            // 
            // lblluckyType
            // 
            this.lblluckyType.AutoSize = true;
            this.lblluckyType.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblluckyType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblluckyType.Location = new System.Drawing.Point(11, 15);
            this.lblluckyType.Name = "lblluckyType";
            this.lblluckyType.Size = new System.Drawing.Size(73, 15);
            this.lblluckyType.TabIndex = 139;
            this.lblluckyType.Text = "Lucky Type :";
            // 
            // cboMaster
            // 
            this.cboMaster.FormattingEnabled = true;
            this.cboMaster.Location = new System.Drawing.Point(434, 40);
            this.cboMaster.Name = "cboMaster";
            this.cboMaster.Size = new System.Drawing.Size(200, 23);
            this.cboMaster.TabIndex = 3;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrint.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrint.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPrint.Location = new System.Drawing.Point(257, 11);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 27);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnMaster
            // 
            this.btnMaster.Location = new System.Drawing.Point(651, 40);
            this.btnMaster.Name = "btnMaster";
            this.btnMaster.Size = new System.Drawing.Size(25, 23);
            this.btnMaster.TabIndex = 142;
            this.btnMaster.UseVisualStyleBackColor = true;
            this.btnMaster.Click += new System.EventHandler(this.btnMaster_Click);
            // 
            // btnPeriod
            // 
            this.btnPeriod.Location = new System.Drawing.Point(315, 40);
            this.btnPeriod.Name = "btnPeriod";
            this.btnPeriod.Size = new System.Drawing.Size(25, 23);
            this.btnPeriod.TabIndex = 143;
            this.btnPeriod.UseVisualStyleBackColor = true;
            this.btnPeriod.Click += new System.EventHandler(this.btnPeriod_Click);
            // 
            // btnPlayer
            // 
            this.btnPlayer.Location = new System.Drawing.Point(934, 43);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(25, 23);
            this.btnPlayer.TabIndex = 144;
            this.btnPlayer.UseVisualStyleBackColor = true;
            this.btnPlayer.Click += new System.EventHandler(this.btnPlayer_Click);
            // 
            // btnAgent
            // 
            this.btnAgent.Location = new System.Drawing.Point(934, 14);
            this.btnAgent.Name = "btnAgent";
            this.btnAgent.Size = new System.Drawing.Size(25, 23);
            this.btnAgent.TabIndex = 145;
            this.btnAgent.UseVisualStyleBackColor = true;
            this.btnAgent.Click += new System.EventHandler(this.btnAgent_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(118, 26);
            this.contextMenuStrip.Click += new System.EventHandler(this.contextMenuStrip_Click);
            // 
            // toolStripMenuItem
            // 
            this.toolStripMenuItem.Name = "toolStripMenuItem";
            this.toolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem.Text = "Remove";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(696, 15);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(41, 16);
            this.linkLabel1.TabIndex = 144;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Agent";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(383, 43);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(47, 16);
            this.linkLabel2.TabIndex = 145;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Master";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            this.linkLabel2.Click += new System.EventHandler(this.linkLabel2_Click);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(696, 43);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(43, 16);
            this.linkLabel3.TabIndex = 146;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Player";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // cboLuckyType
            // 
            this.cboLuckyType.FormattingEnabled = true;
            this.cboLuckyType.Location = new System.Drawing.Point(97, 11);
            this.cboLuckyType.Name = "cboLuckyType";
            this.cboLuckyType.Size = new System.Drawing.Size(200, 23);
            this.cboLuckyType.TabIndex = 0;
            // 
            // SetSubmit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 515);
            this.Name = "SetSubmit";
            this.Text = "SetSubmit";
            this.toolTipbase.SetToolTip(this, "Drap to move to desired location");
            this.Controls.SetChildIndex(this.pan, 0);
            this.Controls.SetChildIndex(this.lblHeader, 0);
            this.pan.ResumeLayout(false);
            this.grbEntry.ResumeLayout(false);
            this.grbEntryData.ResumeLayout(false);
            this.grbEntryData.PerformLayout();
            this.grbControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorproviderbase)).EndInit();
            this.grbDraw.ResumeLayout(false);
            this.grbDraw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDraw)).EndInit();
            this.grbVote.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVote)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDraw;
        private System.Windows.Forms.DateTimePicker dtpSubmitdate;
        public System.Windows.Forms.Label lblSubmitDate;
        private System.Windows.Forms.GroupBox grbVote;
        private System.Windows.Forms.ComboBox cboAgent;
        public System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.ComboBox cboPeriod;
        private System.Windows.Forms.ComboBox cboPlayer;
        public System.Windows.Forms.Label lblList;
        private System.Windows.Forms.ComboBox cboOperator;
        public System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.DataGridView dgvDraw;
        public System.Windows.Forms.Label lblTypeCaption;
        public System.Windows.Forms.Label lblluckyType;
        public System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DataGridView dgvVote;
        private System.Windows.Forms.ComboBox cboMaster;
        public System.Windows.Forms.Button btnPrepare;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvchkMainCompetator;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvchkSecondCompetator;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtBodyAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtTotalGoamount;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcboupdown;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvchkmaung;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtmaungamt;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvchkBodyMaung;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblComm;
        public System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnMaster;
        private System.Windows.Forms.Button btnPeriod;
        private System.Windows.Forms.Button btnAgent;
        private System.Windows.Forms.Button btnPlayer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cboLuckyType;
        public System.Windows.Forms.Button btnRemove;
    }
}