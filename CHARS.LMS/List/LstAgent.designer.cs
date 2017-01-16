namespace CHARS.LMS.List
{
    partial class LstAgent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAgent = new System.Windows.Forms.DataGridView();
            this.dgvAgents = new System.Windows.Forms.DataGridView();
            this.pan.SuspendLayout();
            this.grbList.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgents)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Size = new System.Drawing.Size(1023, 668);
            // 
            // grbList
            // 
            this.grbList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.grbList.AutoSize = true;
            this.grbList.Controls.Add(this.dgvAgents);
            this.grbList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbList.Location = new System.Drawing.Point(0, 0);
            this.grbList.Size = new System.Drawing.Size(1023, 668);
            this.grbList.Controls.SetChildIndex(this.grbControl, 0);
            this.grbList.Controls.SetChildIndex(this.dgvAgents, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(682, 13);
            this.toolTipList.SetToolTip(this.btnSearch, "Click to show all");
            this.btnSearch.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(259, 13);
            this.toolTipList.SetToolTip(this.btnEdit, "Click to edit selected item");
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(175, 13);
            this.toolTipList.SetToolTip(this.btnAddNew, "Click to prepare new item");
            this.btnAddNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(511, 13);
            this.toolTipList.SetToolTip(this.btnExport, "Click to export to outsite");
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(427, 13);
            this.toolTipList.SetToolTip(this.btnImport, "Click to import from outsider");
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(596, 13);
            this.toolTipList.SetToolTip(this.btnPreview, "Click to preview report");
            // 
            // grbControl
            // 
            this.grbControl.Location = new System.Drawing.Point(3, 622);
            this.grbControl.Size = new System.Drawing.Size(1017, 43);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(342, 13);
            this.toolTipList.SetToolTip(this.btnHistory, "Click to check history of selected item");
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(766, 14);
            // 
            // dgvAgent
            // 
            this.dgvAgent.AllowUserToAddRows = false;
            this.dgvAgent.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvAgent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAgent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAgent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgent.Location = new System.Drawing.Point(9, 20);
            this.dgvAgent.Name = "dgvAgent";
            this.dgvAgent.ReadOnly = true;
            this.dgvAgent.RowHeadersVisible = false;
            this.dgvAgent.RowTemplate.Height = 24;
            this.dgvAgent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgent.Size = new System.Drawing.Size(737, 256);
            this.dgvAgent.TabIndex = 16;
            this.dgvAgent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerson_CellDoubleClick);
            this.dgvAgent.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAgent_CellFormatting);
            // 
            // dgvAgents
            // 
            this.dgvAgents.AllowUserToAddRows = false;
            this.dgvAgents.AllowUserToDeleteRows = false;
            this.dgvAgents.AllowUserToOrderColumns = true;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvAgents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAgents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAgents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAgents.Location = new System.Drawing.Point(3, 16);
            this.dgvAgents.Name = "dgvAgents";
            this.dgvAgents.ReadOnly = true;
            this.dgvAgents.RowHeadersVisible = false;
            this.dgvAgents.RowTemplate.Height = 24;
            this.dgvAgents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAgents.Size = new System.Drawing.Size(1017, 606);
            this.dgvAgents.TabIndex = 18;
            // 
            // LstAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 668);
            this.Name = "LstAgent";
            this.Text = "LstAgent";
            this.Controls.SetChildIndex(this.pan, 0);
            this.pan.ResumeLayout(false);
            this.pan.PerformLayout();
            this.grbList.ResumeLayout(false);
            this.grbControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAgent;
        private System.Windows.Forms.DataGridView dgvAgents;
    }
}