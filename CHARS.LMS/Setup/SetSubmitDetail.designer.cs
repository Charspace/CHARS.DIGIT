namespace CHARS.HR.PL.Setup
{
    partial class SetSubmitDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pan.SuspendLayout();
            this.grbEntry.SuspendLayout();
            this.grbEntryData.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorproviderbase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Location = new System.Drawing.Point(10, 16);
            this.pan.Size = new System.Drawing.Size(833, 444);
            // 
            // grbEntry
            // 
            this.grbEntry.Controls.Add(this.label3);
            this.grbEntry.Controls.Add(this.lblcount);
            this.grbEntry.Controls.Add(this.lblTotal);
            this.grbEntry.Controls.Add(this.label1);
            this.grbEntry.Size = new System.Drawing.Size(827, 441);
            this.grbEntry.Controls.SetChildIndex(this.label1, 0);
            this.grbEntry.Controls.SetChildIndex(this.lblTotal, 0);
            this.grbEntry.Controls.SetChildIndex(this.lblcount, 0);
            this.grbEntry.Controls.SetChildIndex(this.label3, 0);
            this.grbEntry.Controls.SetChildIndex(this.grbControl, 0);
            this.grbEntry.Controls.SetChildIndex(this.grbEntryData, 0);
            // 
            // grbEntryData
            // 
            this.grbEntryData.Controls.Add(this.dgvList);
            this.grbEntryData.Location = new System.Drawing.Point(4, 3);
            this.grbEntryData.Size = new System.Drawing.Size(823, 375);
            // 
            // grbControl
            // 
            this.grbControl.Location = new System.Drawing.Point(6, 395);
            this.grbControl.Size = new System.Drawing.Size(821, 40);
            // 
            // btnDelete
            // 
            this.toolTipbase.SetToolTip(this.btnDelete, "Click to delete");
            this.btnDelete.Visible = false;
            // 
            // btnNew
            // 
            this.toolTipbase.SetToolTip(this.btnNew, "Click to prepare new item");
            this.btnNew.Visible = false;
            // 
            // btnSave
            // 
            this.toolTipbase.SetToolTip(this.btnSave, "Click to save");
            this.btnSave.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(736, 10);
            this.toolTipbase.SetToolTip(this.btnClose, "Click to close");
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(5, 17);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowTemplate.Height = 24;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvList.Size = new System.Drawing.Size(812, 352);
            this.dgvList.TabIndex = 20;
            this.dgvList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvList_CellFormatting);
            this.dgvList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellEndEdit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Count : ";
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcount.Location = new System.Drawing.Point(69, 381);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(16, 17);
            this.lblcount.TabIndex = 6;
            this.lblcount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total : ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(395, 381);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(16, 17);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "0";
            // 
            // SetSubmitDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 474);
            this.Name = "SetSubmitDetail";
            this.Text = "SetSubmitDetail";
            this.toolTipbase.SetToolTip(this, "Drap to move to desired location");
            this.pan.ResumeLayout(false);
            this.grbEntry.ResumeLayout(false);
            this.grbEntry.PerformLayout();
            this.grbEntryData.ResumeLayout(false);
            this.grbControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorproviderbase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblcount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
    }
}