namespace CHARS.LMS.List
{
    partial class LstDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvConList = new System.Windows.Forms.DataGridView();
            this.dgvtxtSrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAgent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtPlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtComission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvbtnApprove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pan.SuspendLayout();
            this.grbList.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Size = new System.Drawing.Size(784, 410);
            // 
            // grbList
            // 
            this.grbList.Controls.Add(this.dataGridView1);
            this.grbList.Size = new System.Drawing.Size(784, 410);
            this.grbList.Controls.SetChildIndex(this.grbControl, 0);
            this.grbList.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // btnSearch
            // 
            this.toolTipList.SetToolTip(this.btnSearch, "Click to search");
            // 
            // btnEdit
            // 
            this.toolTipList.SetToolTip(this.btnEdit, "Click to edit selected item");
            // 
            // btnAddNew
            // 
            this.toolTipList.SetToolTip(this.btnAddNew, "Click to prepare new item");
            this.btnAddNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExport
            // 
            this.toolTipList.SetToolTip(this.btnExport, "Click to export to outsite");
            // 
            // btnImport
            // 
            this.toolTipList.SetToolTip(this.btnImport, "Click to import from outsider");
            // 
            // btnPreview
            // 
            this.toolTipList.SetToolTip(this.btnPreview, "Click to preview report");
            // 
            // grbControl
            // 
            this.grbControl.Location = new System.Drawing.Point(3, 364);
            // 
            // btnHistory
            // 
            this.toolTipList.SetToolTip(this.btnHistory, "Click to check history of selected item");
            // 
            // dgvConList
            // 
            this.dgvConList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSrNo,
            this.dgvtxtAgent,
            this.dgvtxtPlayer,
            this.dgvtxtHeader,
            this.dgvtxtAmount,
            this.dgvtxtComission,
            this.dgvbtnApprove});
            this.dgvConList.Location = new System.Drawing.Point(6, 37);
            this.dgvConList.Name = "dgvConList";
            this.dgvConList.RowHeadersVisible = false;
            this.dgvConList.Size = new System.Drawing.Size(676, 88);
            this.dgvConList.TabIndex = 10;
            // 
            // dgvtxtSrNo
            // 
            this.dgvtxtSrNo.HeaderText = "No";
            this.dgvtxtSrNo.Name = "dgvtxtSrNo";
            this.dgvtxtSrNo.Width = 30;
            // 
            // dgvtxtAgent
            // 
            this.dgvtxtAgent.HeaderText = "Agent";
            this.dgvtxtAgent.Name = "dgvtxtAgent";
            this.dgvtxtAgent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtxtAgent.Width = 150;
            // 
            // dgvtxtPlayer
            // 
            this.dgvtxtPlayer.HeaderText = "Player";
            this.dgvtxtPlayer.Name = "dgvtxtPlayer";
            this.dgvtxtPlayer.Width = 150;
            // 
            // dgvtxtHeader
            // 
            this.dgvtxtHeader.HeaderText = "Voucher";
            this.dgvtxtHeader.Name = "dgvtxtHeader";
            this.dgvtxtHeader.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtxtHeader.Width = 80;
            // 
            // dgvtxtAmount
            // 
            this.dgvtxtAmount.HeaderText = "Amount";
            this.dgvtxtAmount.Name = "dgvtxtAmount";
            this.dgvtxtAmount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtxtAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtAmount.Width = 80;
            // 
            // dgvtxtComission
            // 
            this.dgvtxtComission.HeaderText = "Comission";
            this.dgvtxtComission.Name = "dgvtxtComission";
            this.dgvtxtComission.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtxtComission.Width = 80;
            // 
            // dgvbtnApprove
            // 
            this.dgvbtnApprove.HeaderText = "Approve";
            this.dgvbtnApprove.Name = "dgvbtnApprove";
            this.dgvbtnApprove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvbtnApprove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(778, 348);
            this.dataGridView1.TabIndex = 19;
            // 
            // LstDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 410);
            this.Name = "LstDetail";
            this.Text = "LstDetail";
            this.Controls.SetChildIndex(this.pan, 0);
            this.pan.ResumeLayout(false);
            this.grbList.ResumeLayout(false);
            this.grbControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAgent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtComission;
        private System.Windows.Forms.DataGridViewButtonColumn dgvbtnApprove;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}