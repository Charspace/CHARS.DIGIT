namespace CHARS.HR.PL.Setup
{
    partial class SetGain
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
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.dgvtxtSrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcboStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtComission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcboPaid = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pan.SuspendLayout();
            this.grbEntry.SuspendLayout();
            this.grbEntryData.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // grbEntryData
            // 
            this.grbEntryData.Controls.Add(this.dgvList);
            this.grbEntryData.Controls.SetChildIndex(this.dgvList, 0);
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSrNo,
            this.dgvtxtHeader,
            this.dgvtxtList,
            this.dgvtxtAmount,
            this.dgvcboStatus,
            this.dgvtxtComission,
            this.dgvcboPaid});
            this.dgvList.Location = new System.Drawing.Point(18, 192);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.Size = new System.Drawing.Size(676, 88);
            this.dgvList.TabIndex = 75;
            // 
            // dgvtxtSrNo
            // 
            this.dgvtxtSrNo.HeaderText = "No";
            this.dgvtxtSrNo.Name = "dgvtxtSrNo";
            this.dgvtxtSrNo.Width = 30;
            // 
            // dgvtxtHeader
            // 
            this.dgvtxtHeader.HeaderText = "Voucher";
            this.dgvtxtHeader.Name = "dgvtxtHeader";
            this.dgvtxtHeader.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtxtHeader.Width = 80;
            // 
            // dgvtxtList
            // 
            this.dgvtxtList.HeaderText = "List";
            this.dgvtxtList.Name = "dgvtxtList";
            this.dgvtxtList.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtxtList.Width = 150;
            // 
            // dgvtxtAmount
            // 
            this.dgvtxtAmount.HeaderText = "Amount";
            this.dgvtxtAmount.Name = "dgvtxtAmount";
            this.dgvtxtAmount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtxtAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtAmount.Width = 80;
            // 
            // dgvcboStatus
            // 
            this.dgvcboStatus.HeaderText = "Gain/Loose";
            this.dgvcboStatus.Name = "dgvcboStatus";
            this.dgvcboStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcboStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvcboStatus.Width = 150;
            // 
            // dgvtxtComission
            // 
            this.dgvtxtComission.HeaderText = "To Pay";
            this.dgvtxtComission.Name = "dgvtxtComission";
            this.dgvtxtComission.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtxtComission.Width = 80;
            // 
            // dgvcboPaid
            // 
            this.dgvcboPaid.HeaderText = "paid";
            this.dgvcboPaid.Name = "dgvcboPaid";
            this.dgvcboPaid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcboPaid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SetGainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 441);
            this.Name = "SetGainer";
            this.Text = "SetGainer";
            this.pan.ResumeLayout(false);
            this.grbEntry.ResumeLayout(false);
            this.grbEntryData.ResumeLayout(false);
            this.grbEntryData.PerformLayout();
            this.grbControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAmount;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcboStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtComission;
        private System.Windows.Forms.DataGridViewButtonColumn dgvcboPaid;
    }
}