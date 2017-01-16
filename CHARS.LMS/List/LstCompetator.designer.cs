namespace CHARS.LMS.List
{
    partial class LstCompetator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCompetator = new System.Windows.Forms.DataGridView();
            this.dgvConList = new System.Windows.Forms.DataGridView();
            this.pan.SuspendLayout();
            this.grbList.SuspendLayout();
            this.grbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConList)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Size = new System.Drawing.Size(798, 445);
            // 
            // grbList
            // 
            this.grbList.Controls.Add(this.dgvConList);
            this.grbList.Size = new System.Drawing.Size(798, 445);
            this.grbList.Controls.SetChildIndex(this.grbControl, 0);
            this.grbList.Controls.SetChildIndex(this.dgvConList, 0);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(380, 14);
            this.toolTipList.SetToolTip(this.btnSearch, "Click to search");
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(130, 14);
            this.toolTipList.SetToolTip(this.btnEdit, "Click to edit selected item");
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(47, 14);
            this.toolTipList.SetToolTip(this.btnAddNew, "Click to prepare new item");
            this.btnAddNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(630, 14);
            this.toolTipList.SetToolTip(this.btnExport, "Click to export to outsite");
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(296, 14);
            this.toolTipList.SetToolTip(this.btnImport, "Click to import from outsider");
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(547, 14);
            this.toolTipList.SetToolTip(this.btnPreview, "Click to preview report");
            // 
            // grbControl
            // 
            this.grbControl.Location = new System.Drawing.Point(3, 399);
            this.grbControl.Size = new System.Drawing.Size(792, 43);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(213, 14);
            this.toolTipList.SetToolTip(this.btnHistory, "Click to check history of selected item");
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(464, 14);
            // 
            // dgvCompetator
            // 
            this.dgvCompetator.AllowUserToAddRows = false;
            this.dgvCompetator.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvCompetator.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCompetator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCompetator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompetator.Location = new System.Drawing.Point(9, 26);
            this.dgvCompetator.Name = "dgvCompetator";
            this.dgvCompetator.ReadOnly = true;
            this.dgvCompetator.RowHeadersVisible = false;
            this.dgvCompetator.RowTemplate.Height = 24;
            this.dgvCompetator.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompetator.Size = new System.Drawing.Size(749, 270);
            this.dgvCompetator.TabIndex = 16;
            this.dgvCompetator.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerson_CellDoubleClick);
            // 
            // dgvConList
            // 
            this.dgvConList.AllowUserToAddRows = false;
            this.dgvConList.AllowUserToDeleteRows = false;
            this.dgvConList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvConList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConList.Location = new System.Drawing.Point(3, 16);
            this.dgvConList.Name = "dgvConList";
            this.dgvConList.ReadOnly = true;
            this.dgvConList.RowHeadersVisible = false;
            this.dgvConList.RowTemplate.Height = 24;
            this.dgvConList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvConList.Size = new System.Drawing.Size(792, 383);
            this.dgvConList.TabIndex = 19;
            this.dgvConList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerson_CellDoubleClick);
            // 
            // LstCompetator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 445);
            this.Name = "LstCompetator";
            this.Text = "LstCompetator";
            this.Controls.SetChildIndex(this.pan, 0);
            this.pan.ResumeLayout(false);
            this.grbList.ResumeLayout(false);
            this.grbControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompetator;
        private System.Windows.Forms.DataGridView dgvConList;
    }
}