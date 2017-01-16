namespace CHARS.HR.PL.Setup
{
    partial class SetPerson
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
            this.rtxtPrsonAddress = new System.Windows.Forms.RichTextBox();
            this.txtPersonPhone = new System.Windows.Forms.TextBox();
            this.rtxtPersonRemark = new System.Windows.Forms.RichTextBox();
            this.lblAgentAddress = new System.Windows.Forms.Label();
            this.lblAgentEmail = new System.Windows.Forms.Label();
            this.lblAgentRemark = new System.Windows.Forms.Label();
            this.lblPersonAddress = new System.Windows.Forms.Label();
            this.lblPersonName = new System.Windows.Forms.Label();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.lblPersonName1 = new System.Windows.Forms.Label();
            this.txtPersonNiceName = new System.Windows.Forms.TextBox();
            this.txtPersonEmail = new System.Windows.Forms.TextBox();
            this.chkMaster = new System.Windows.Forms.CheckBox();
            this.chkPlayer = new System.Windows.Forms.CheckBox();
            this.chkAgent = new System.Windows.Forms.CheckBox();
            this.txtAgentEmail = new System.Windows.Forms.TextBox();
            this.txtAgentPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAgentName = new System.Windows.Forms.TextBox();
            this.grbAgent = new System.Windows.Forms.GroupBox();
            this.nmcComission = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.grbMaster = new System.Windows.Forms.GroupBox();
            this.txtMasterEmail = new System.Windows.Forms.TextBox();
            this.txtMasterName = new System.Windows.Forms.TextBox();
            this.txtMasterPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grbPlayer = new System.Windows.Forms.GroupBox();
            this.txtPlayerEmail = new System.Windows.Forms.TextBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.txtPlayerPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pan.SuspendLayout();
            this.grbEntry.SuspendLayout();
            this.grbEntryData.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorproviderbase)).BeginInit();
            this.grbAgent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcComission)).BeginInit();
            this.grbMaster.SuspendLayout();
            this.grbPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Location = new System.Drawing.Point(10, 24);
            this.pan.Size = new System.Drawing.Size(828, 412);
            // 
            // grbEntry
            // 
            this.grbEntry.Size = new System.Drawing.Size(822, 409);
            this.grbEntry.Enter += new System.EventHandler(this.grbEntry_Enter);
            // 
            // grbEntryData
            // 
            this.grbEntryData.Controls.Add(this.grbPlayer);
            this.grbEntryData.Controls.Add(this.grbMaster);
            this.grbEntryData.Controls.Add(this.grbAgent);
            this.grbEntryData.Controls.Add(this.chkAgent);
            this.grbEntryData.Controls.Add(this.chkPlayer);
            this.grbEntryData.Controls.Add(this.chkMaster);
            this.grbEntryData.Controls.Add(this.txtPersonEmail);
            this.grbEntryData.Controls.Add(this.rtxtPrsonAddress);
            this.grbEntryData.Controls.Add(this.txtPersonPhone);
            this.grbEntryData.Controls.Add(this.rtxtPersonRemark);
            this.grbEntryData.Controls.Add(this.lblAgentAddress);
            this.grbEntryData.Controls.Add(this.lblAgentEmail);
            this.grbEntryData.Controls.Add(this.lblAgentRemark);
            this.grbEntryData.Controls.Add(this.lblPersonAddress);
            this.grbEntryData.Controls.Add(this.lblPersonName);
            this.grbEntryData.Controls.Add(this.txtPersonName);
            this.grbEntryData.Controls.Add(this.lblPersonName1);
            this.grbEntryData.Controls.Add(this.txtPersonNiceName);
            this.grbEntryData.Location = new System.Drawing.Point(4, 15);
            this.grbEntryData.Size = new System.Drawing.Size(812, 333);
            this.grbEntryData.Enter += new System.EventHandler(this.grbEntryData_Enter);
            // 
            // grbControl
            // 
            this.grbControl.Location = new System.Drawing.Point(4, 354);
            this.grbControl.Size = new System.Drawing.Size(812, 40);
            this.grbControl.Enter += new System.EventHandler(this.grbControl_Enter);
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
            this.btnClose.Location = new System.Drawing.Point(727, 10);
            this.toolTipbase.SetToolTip(this.btnClose, "Click to close");
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Location = new System.Drawing.Point(212, 7);
            this.lblHeader.Size = new System.Drawing.Size(0, 16);
            this.lblHeader.Text = "";
            this.lblHeader.Click += new System.EventHandler(this.lblHeader_Click);
            // 
            // rtxtPrsonAddress
            // 
            this.rtxtPrsonAddress.BackColor = System.Drawing.Color.AliceBlue;
            this.rtxtPrsonAddress.Location = new System.Drawing.Point(125, 112);
            this.rtxtPrsonAddress.MaxLength = 255;
            this.rtxtPrsonAddress.Name = "rtxtPrsonAddress";
            this.rtxtPrsonAddress.Size = new System.Drawing.Size(250, 68);
            this.rtxtPrsonAddress.TabIndex = 4;
            this.rtxtPrsonAddress.Text = "";
            this.rtxtPrsonAddress.Enter += new System.EventHandler(this.rtxtPrsonAddress_Enter);
            this.rtxtPrsonAddress.TextChanged += new System.EventHandler(this.rtxtPrsonAddress_TextChanged);
            // 
            // txtPersonPhone
            // 
            this.txtPersonPhone.BackColor = System.Drawing.Color.AliceBlue;
            this.txtPersonPhone.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonPhone.Location = new System.Drawing.Point(125, 62);
            this.txtPersonPhone.Name = "txtPersonPhone";
            this.txtPersonPhone.Size = new System.Drawing.Size(250, 21);
            this.txtPersonPhone.TabIndex = 2;
            this.txtPersonPhone.TextChanged += new System.EventHandler(this.txtPersonPhone_TextChanged);
            this.txtPersonPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonPhone_KeyPress);
            this.txtPersonPhone.Enter += new System.EventHandler(this.txtPersonPhone_Enter);
            // 
            // rtxtPersonRemark
            // 
            this.rtxtPersonRemark.BackColor = System.Drawing.Color.AliceBlue;
            this.rtxtPersonRemark.Location = new System.Drawing.Point(125, 184);
            this.rtxtPersonRemark.MaxLength = 255;
            this.rtxtPersonRemark.Name = "rtxtPersonRemark";
            this.rtxtPersonRemark.Size = new System.Drawing.Size(250, 78);
            this.rtxtPersonRemark.TabIndex = 5;
            this.rtxtPersonRemark.Text = "";
            this.rtxtPersonRemark.Enter += new System.EventHandler(this.rtxtPersonRemark_Enter);
            this.rtxtPersonRemark.TextChanged += new System.EventHandler(this.rtxtPersonRemark_TextChanged);
            // 
            // lblAgentAddress
            // 
            this.lblAgentAddress.AutoSize = true;
            this.lblAgentAddress.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAgentAddress.Location = new System.Drawing.Point(37, 65);
            this.lblAgentAddress.Name = "lblAgentAddress";
            this.lblAgentAddress.Size = new System.Drawing.Size(79, 15);
            this.lblAgentAddress.TabIndex = 140;
            this.lblAgentAddress.Text = "Person Phone :";
            this.lblAgentAddress.Click += new System.EventHandler(this.lblAgentAddress_Click);
            // 
            // lblAgentEmail
            // 
            this.lblAgentEmail.AutoSize = true;
            this.lblAgentEmail.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAgentEmail.Location = new System.Drawing.Point(37, 90);
            this.lblAgentEmail.Name = "lblAgentEmail";
            this.lblAgentEmail.Size = new System.Drawing.Size(80, 15);
            this.lblAgentEmail.TabIndex = 139;
            this.lblAgentEmail.Text = "Person E-mail :";
            this.lblAgentEmail.Click += new System.EventHandler(this.lblAgentEmail_Click);
            // 
            // lblAgentRemark
            // 
            this.lblAgentRemark.AutoSize = true;
            this.lblAgentRemark.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentRemark.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAgentRemark.Location = new System.Drawing.Point(31, 184);
            this.lblAgentRemark.Name = "lblAgentRemark";
            this.lblAgentRemark.Size = new System.Drawing.Size(86, 15);
            this.lblAgentRemark.TabIndex = 138;
            this.lblAgentRemark.Text = "Person Remark :";
            this.lblAgentRemark.Click += new System.EventHandler(this.lblAgentRemark_Click);
            // 
            // lblPersonAddress
            // 
            this.lblPersonAddress.AutoSize = true;
            this.lblPersonAddress.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPersonAddress.Location = new System.Drawing.Point(30, 113);
            this.lblPersonAddress.Name = "lblPersonAddress";
            this.lblPersonAddress.Size = new System.Drawing.Size(88, 15);
            this.lblPersonAddress.TabIndex = 137;
            this.lblPersonAddress.Text = "Person Address :";
            this.lblPersonAddress.Click += new System.EventHandler(this.lblPersonAddress_Click);
            // 
            // lblPersonName
            // 
            this.lblPersonName.AutoSize = true;
            this.lblPersonName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPersonName.Location = new System.Drawing.Point(39, 20);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Size = new System.Drawing.Size(77, 15);
            this.lblPersonName.TabIndex = 135;
            this.lblPersonName.Text = "Person Name :";
            this.lblPersonName.Click += new System.EventHandler(this.lblPersonName_Click);
            // 
            // txtPersonName
            // 
            this.txtPersonName.BackColor = System.Drawing.Color.AliceBlue;
            this.txtPersonName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonName.Location = new System.Drawing.Point(125, 14);
            this.txtPersonName.MaxLength = 200;
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(250, 21);
            this.txtPersonName.TabIndex = 0;
            this.toolTipbase.SetToolTip(this.txtPersonName, "aefef");
            this.txtPersonName.TextChanged += new System.EventHandler(this.txtPersonName_TextChanged);
            this.txtPersonName.Enter += new System.EventHandler(this.txtPersonName_Enter);
            // 
            // lblPersonName1
            // 
            this.lblPersonName1.AutoSize = true;
            this.lblPersonName1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonName1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPersonName1.Location = new System.Drawing.Point(15, 40);
            this.lblPersonName1.Name = "lblPersonName1";
            this.lblPersonName1.Size = new System.Drawing.Size(102, 15);
            this.lblPersonName1.TabIndex = 133;
            this.lblPersonName1.Text = "Person Nice Name :";
            this.lblPersonName1.Click += new System.EventHandler(this.lblPersonName1_Click);
            // 
            // txtPersonNiceName
            // 
            this.txtPersonNiceName.BackColor = System.Drawing.Color.AliceBlue;
            this.txtPersonNiceName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonNiceName.Location = new System.Drawing.Point(125, 38);
            this.txtPersonNiceName.MaxLength = 200;
            this.txtPersonNiceName.Name = "txtPersonNiceName";
            this.txtPersonNiceName.Size = new System.Drawing.Size(250, 21);
            this.txtPersonNiceName.TabIndex = 1;
            this.txtPersonNiceName.TextChanged += new System.EventHandler(this.txtPersonNiceName_TextChanged);
            this.txtPersonNiceName.Enter += new System.EventHandler(this.txtPersonNiceName_Enter);
            // 
            // txtPersonEmail
            // 
            this.txtPersonEmail.BackColor = System.Drawing.Color.AliceBlue;
            this.txtPersonEmail.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonEmail.Location = new System.Drawing.Point(125, 87);
            this.txtPersonEmail.MaxLength = 200;
            this.txtPersonEmail.Name = "txtPersonEmail";
            this.txtPersonEmail.Size = new System.Drawing.Size(250, 21);
            this.txtPersonEmail.TabIndex = 3;
            this.txtPersonEmail.TextChanged += new System.EventHandler(this.txtPersonEmail_TextChanged);
            this.txtPersonEmail.Enter += new System.EventHandler(this.txtPersonEmail_Enter);
            // 
            // chkMaster
            // 
            this.chkMaster.AutoSize = true;
            this.chkMaster.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.chkMaster.Location = new System.Drawing.Point(412, 30);
            this.chkMaster.Name = "chkMaster";
            this.chkMaster.Size = new System.Drawing.Size(61, 19);
            this.chkMaster.TabIndex = 6;
            this.chkMaster.Text = "Master";
            this.chkMaster.UseVisualStyleBackColor = true;
            this.chkMaster.CheckedChanged += new System.EventHandler(this.chkMaster_CheckedChanged);
            // 
            // chkPlayer
            // 
            this.chkPlayer.AutoSize = true;
            this.chkPlayer.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.chkPlayer.Location = new System.Drawing.Point(410, 245);
            this.chkPlayer.Name = "chkPlayer";
            this.chkPlayer.Size = new System.Drawing.Size(57, 19);
            this.chkPlayer.TabIndex = 8;
            this.chkPlayer.Text = "Player";
            this.chkPlayer.UseVisualStyleBackColor = true;
            this.chkPlayer.CheckedChanged += new System.EventHandler(this.chkPlayer_CheckedChanged);
            // 
            // chkAgent
            // 
            this.chkAgent.AutoSize = true;
            this.chkAgent.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.chkAgent.Location = new System.Drawing.Point(410, 123);
            this.chkAgent.Name = "chkAgent";
            this.chkAgent.Size = new System.Drawing.Size(55, 19);
            this.chkAgent.TabIndex = 7;
            this.chkAgent.Text = "Agent";
            this.chkAgent.UseVisualStyleBackColor = true;
            this.chkAgent.CheckedChanged += new System.EventHandler(this.chkAgent_CheckedChanged);
            // 
            // txtAgentEmail
            // 
            this.txtAgentEmail.BackColor = System.Drawing.Color.AliceBlue;
            this.txtAgentEmail.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgentEmail.Location = new System.Drawing.Point(69, 62);
            this.txtAgentEmail.MaxLength = 200;
            this.txtAgentEmail.Name = "txtAgentEmail";
            this.txtAgentEmail.Size = new System.Drawing.Size(231, 21);
            this.txtAgentEmail.TabIndex = 2;
            // 
            // txtAgentPhone
            // 
            this.txtAgentPhone.BackColor = System.Drawing.Color.AliceBlue;
            this.txtAgentPhone.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgentPhone.Location = new System.Drawing.Point(69, 39);
            this.txtAgentPhone.MaxLength = 200;
            this.txtAgentPhone.Name = "txtAgentPhone";
            this.txtAgentPhone.Size = new System.Drawing.Size(231, 21);
            this.txtAgentPhone.TabIndex = 1;
            this.txtAgentPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgentPhone_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(5, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 149;
            this.label1.Text = "Phone :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(2, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 148;
            this.label2.Text = "E-mail :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(5, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 147;
            this.label3.Text = "Name :";
            // 
            // txtAgentName
            // 
            this.txtAgentName.BackColor = System.Drawing.Color.AliceBlue;
            this.txtAgentName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgentName.Location = new System.Drawing.Point(69, 17);
            this.txtAgentName.MaxLength = 200;
            this.txtAgentName.Name = "txtAgentName";
            this.txtAgentName.Size = new System.Drawing.Size(231, 21);
            this.txtAgentName.TabIndex = 0;
            this.toolTipbase.SetToolTip(this.txtAgentName, "aefef");
            // 
            // grbAgent
            // 
            this.grbAgent.Controls.Add(this.nmcComission);
            this.grbAgent.Controls.Add(this.label10);
            this.grbAgent.Controls.Add(this.txtAgentEmail);
            this.grbAgent.Controls.Add(this.txtAgentName);
            this.grbAgent.Controls.Add(this.txtAgentPhone);
            this.grbAgent.Controls.Add(this.label3);
            this.grbAgent.Controls.Add(this.label1);
            this.grbAgent.Controls.Add(this.label2);
            this.grbAgent.Location = new System.Drawing.Point(472, 106);
            this.grbAgent.Name = "grbAgent";
            this.grbAgent.Size = new System.Drawing.Size(322, 116);
            this.grbAgent.TabIndex = 150;
            this.grbAgent.TabStop = false;
            // 
            // nmcComission
            // 
            this.nmcComission.Location = new System.Drawing.Point(69, 86);
            this.nmcComission.Name = "nmcComission";
            this.nmcComission.Size = new System.Drawing.Size(120, 23);
            this.nmcComission.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(-1, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 15);
            this.label10.TabIndex = 152;
            this.label10.Text = "Comission :";
            // 
            // grbMaster
            // 
            this.grbMaster.Controls.Add(this.txtMasterEmail);
            this.grbMaster.Controls.Add(this.txtMasterName);
            this.grbMaster.Controls.Add(this.txtMasterPhone);
            this.grbMaster.Controls.Add(this.label4);
            this.grbMaster.Controls.Add(this.label5);
            this.grbMaster.Controls.Add(this.label6);
            this.grbMaster.Location = new System.Drawing.Point(474, 11);
            this.grbMaster.Name = "grbMaster";
            this.grbMaster.Size = new System.Drawing.Size(320, 91);
            this.grbMaster.TabIndex = 7;
            this.grbMaster.TabStop = false;
            // 
            // txtMasterEmail
            // 
            this.txtMasterEmail.BackColor = System.Drawing.Color.AliceBlue;
            this.txtMasterEmail.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasterEmail.Location = new System.Drawing.Point(67, 62);
            this.txtMasterEmail.MaxLength = 200;
            this.txtMasterEmail.Name = "txtMasterEmail";
            this.txtMasterEmail.Size = new System.Drawing.Size(231, 21);
            this.txtMasterEmail.TabIndex = 2;
            // 
            // txtMasterName
            // 
            this.txtMasterName.BackColor = System.Drawing.Color.AliceBlue;
            this.txtMasterName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasterName.Location = new System.Drawing.Point(67, 17);
            this.txtMasterName.MaxLength = 200;
            this.txtMasterName.Name = "txtMasterName";
            this.txtMasterName.Size = new System.Drawing.Size(231, 21);
            this.txtMasterName.TabIndex = 0;
            this.toolTipbase.SetToolTip(this.txtMasterName, "aefef");
            // 
            // txtMasterPhone
            // 
            this.txtMasterPhone.BackColor = System.Drawing.Color.AliceBlue;
            this.txtMasterPhone.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasterPhone.Location = new System.Drawing.Point(67, 39);
            this.txtMasterPhone.MaxLength = 200;
            this.txtMasterPhone.Name = "txtMasterPhone";
            this.txtMasterPhone.Size = new System.Drawing.Size(231, 21);
            this.txtMasterPhone.TabIndex = 1;
            this.txtMasterPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMasterPhone_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(5, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(5, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 149;
            this.label5.Text = "Phone :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(2, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 148;
            this.label6.Text = " E-mail :";
            // 
            // grbPlayer
            // 
            this.grbPlayer.Controls.Add(this.txtPlayerEmail);
            this.grbPlayer.Controls.Add(this.txtPlayerName);
            this.grbPlayer.Controls.Add(this.txtPlayerPhone);
            this.grbPlayer.Controls.Add(this.label7);
            this.grbPlayer.Controls.Add(this.label8);
            this.grbPlayer.Controls.Add(this.label9);
            this.grbPlayer.Location = new System.Drawing.Point(472, 228);
            this.grbPlayer.Name = "grbPlayer";
            this.grbPlayer.Size = new System.Drawing.Size(322, 91);
            this.grbPlayer.TabIndex = 10;
            this.grbPlayer.TabStop = false;
            // 
            // txtPlayerEmail
            // 
            this.txtPlayerEmail.BackColor = System.Drawing.Color.AliceBlue;
            this.txtPlayerEmail.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerEmail.Location = new System.Drawing.Point(69, 62);
            this.txtPlayerEmail.MaxLength = 200;
            this.txtPlayerEmail.Name = "txtPlayerEmail";
            this.txtPlayerEmail.Size = new System.Drawing.Size(231, 21);
            this.txtPlayerEmail.TabIndex = 2;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.BackColor = System.Drawing.Color.AliceBlue;
            this.txtPlayerName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.Location = new System.Drawing.Point(69, 17);
            this.txtPlayerName.MaxLength = 200;
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(231, 21);
            this.txtPlayerName.TabIndex = 0;
            this.toolTipbase.SetToolTip(this.txtPlayerName, "aefef");
            // 
            // txtPlayerPhone
            // 
            this.txtPlayerPhone.BackColor = System.Drawing.Color.AliceBlue;
            this.txtPlayerPhone.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerPhone.Location = new System.Drawing.Point(69, 39);
            this.txtPlayerPhone.MaxLength = 200;
            this.txtPlayerPhone.Name = "txtPlayerPhone";
            this.txtPlayerPhone.Size = new System.Drawing.Size(231, 21);
            this.txtPlayerPhone.TabIndex = 1;
            this.txtPlayerPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlayerPhone_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(5, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 147;
            this.label7.Text = "Name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(5, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 149;
            this.label8.Text = "Phone :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(2, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 148;
            this.label9.Text = "E-mail :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(391, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Person";
            // 
            // SetPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 440);
            this.Controls.Add(this.label11);
            this.Name = "SetPerson";
            this.Text = "SetPerson";
            this.toolTipbase.SetToolTip(this, "Drap to move to desired location");
            this.Load += new System.EventHandler(this.SetPerson_Load);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.pan, 0);
            this.Controls.SetChildIndex(this.lblHeader, 0);
            this.pan.ResumeLayout(false);
            this.grbEntry.ResumeLayout(false);
            this.grbEntryData.ResumeLayout(false);
            this.grbEntryData.PerformLayout();
            this.grbControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorproviderbase)).EndInit();
            this.grbAgent.ResumeLayout(false);
            this.grbAgent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcComission)).EndInit();
            this.grbMaster.ResumeLayout(false);
            this.grbMaster.PerformLayout();
            this.grbPlayer.ResumeLayout(false);
            this.grbPlayer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtPrsonAddress;
        public System.Windows.Forms.TextBox txtPersonPhone;
        private System.Windows.Forms.RichTextBox rtxtPersonRemark;
        public System.Windows.Forms.Label lblAgentAddress;
        public System.Windows.Forms.Label lblAgentEmail;
        public System.Windows.Forms.Label lblAgentRemark;
        public System.Windows.Forms.Label lblPersonAddress;
        public System.Windows.Forms.Label lblPersonName;
        public System.Windows.Forms.TextBox txtPersonName;
        public System.Windows.Forms.Label lblPersonName1;
        public System.Windows.Forms.TextBox txtPersonNiceName;
        public System.Windows.Forms.TextBox txtPersonEmail;
        public System.Windows.Forms.TextBox txtAgentEmail;
        public System.Windows.Forms.TextBox txtAgentPhone;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtAgentName;
        private System.Windows.Forms.CheckBox chkAgent;
        private System.Windows.Forms.CheckBox chkPlayer;
        private System.Windows.Forms.CheckBox chkMaster;
        private System.Windows.Forms.GroupBox grbAgent;
        private System.Windows.Forms.GroupBox grbPlayer;
        public System.Windows.Forms.TextBox txtPlayerEmail;
        public System.Windows.Forms.TextBox txtPlayerName;
        public System.Windows.Forms.TextBox txtPlayerPhone;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grbMaster;
        public System.Windows.Forms.TextBox txtMasterEmail;
        public System.Windows.Forms.TextBox txtMasterName;
        public System.Windows.Forms.TextBox txtMasterPhone;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nmcComission;
        private System.Windows.Forms.Label label11;
    }
}