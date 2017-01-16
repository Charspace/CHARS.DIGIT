using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHARS.HR.COMMON;
using CHARS.HR.COMMON.PL;
using CHARS.HR.COMMON.BLL;
using CHARS.HR.COMMON.General;
using CHARS.HR.PL.Setup;
using CHARS.HR.BOL;


namespace CHARS.LMS.List
{
    public partial class LstCompetator : LstBase
    {
        public LstCompetator()
        {
            InitializeComponent();
            loadGrid();
            //setToolTip();
            //hideGridviewcolumn();
        }
        Utility mUtility = new Utility();
        MasterBLL mMasterBLL = new MasterBLL();
        CompetatorObj mCompetatorObj = new CompetatorObj();
        CompetatorToolTip mCompetatorToolTip = new CompetatorToolTip();
        #region"Properties"
        private void prepareFilter()
        {

        }
        private void setToolTip()
        {
            try
            {
                this.dgvConList.Columns[0].ToolTipText = mCompetatorToolTip.Ask.ToString();
                this.dgvConList.Columns[1].ToolTipText = mCompetatorToolTip.CompetatorCode.ToString();
                this.dgvConList.Columns[2].ToolTipText = mCompetatorToolTip.CompetatorDescription.ToString();
                this.dgvConList.Columns[3].ToolTipText = mCompetatorToolTip.CompetatorRemark.ToString();            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void hideGridviewcolumn()
        {
            try
            {
                this.dgvConList.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void sequenceGridviewcolumn()
        {
            //this.dgvPerson.Columns[0].Visible = false;
        }
        private void loadGrid()
        {            
            DataTable mm = new DataTable();
            dgvConList.DataSource = mMasterBLL.selectDataTable("LM_Competitor", "");
            mUtility.setDataGridColumn(ref dgvConList);
        }
        #endregion
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                SetCompetator L_SetCompetator = new SetCompetator();
                L_SetCompetator.ShowDialog();
                if (L_SetCompetator.DialogResult == DialogResult.Cancel)
                {
                    loadGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());                
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvConList.Rows.Count > 0)
                {
                    if (dgvConList.CurrentRow.Cells[0].Value != null)
                        //if (dgvConList.CurrentRow.Cells[dgvtxaskey.Index].Value != null)
                    {
                        string a = dgvConList.CurrentRow.Cells[0].Value.ToString();
                        //pan.BackColor = Color.AliceBlue;
                       // SetCompetator L_SetCompetator = new SetCompetator((long)dgvConList.CurrentRow.Cells[dgvtxaskey.Index].Value);
                        SetCompetator L_SetCompetator = new SetCompetator(dgvConList.CurrentRow.Cells[0].Value.ToString());
                        L_SetCompetator.ShowDialog();
                        if (L_SetCompetator.DialogResult == DialogResult.Cancel)
                        {
                            loadGrid();
                        }
                        //pan.BackColor = System.Drawing.SystemColors.Control;
                        // this.textBox1.BackColor = System.Drawing.SystemColors.Control;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //GeneralUtility.ShowErrorMsg(ex);
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvPerson_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnEdit_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void butFind_Click(object sender, EventArgs e)
        {
            try
            {
                loadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}