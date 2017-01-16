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
    public partial class LstAgent : LstBase
    {
        public LstAgent()
        {
            InitializeComponent();
            loadGrid();
            //setToolTip();
            hideGridviewcolumn();
        }
        Utility mUtility = new Utility();
        MasterBLL mMasterBLL = new MasterBLL();
        AgentObj mAgentObj = new AgentObj();
        AgentToolTip mAgentToolTip = new AgentToolTip();
        PersonObj  mPersonObj = new PersonObj();

        #region"Private Method"
        private void prepareFilter()
        {

        }
        private void setToolTip()
        {
            try
            {
                this.dgvAgent.Columns[0].ToolTipText = mAgentToolTip.Ask.ToString();
                this.dgvAgent.Columns[1].ToolTipText = mAgentToolTip.PersonAsk.ToString();
                this.dgvAgent.Columns[2].ToolTipText = mAgentToolTip.AgentCode.ToString();
                this.dgvAgent.Columns[3].ToolTipText = mAgentToolTip.AgentDescription.ToString();
                this.dgvAgent.Columns[4].ToolTipText = mAgentToolTip.AgentPhone.ToString();
                this.dgvAgent.Columns[5].ToolTipText = mAgentToolTip.AgentAddress.ToString();
                this.dgvAgent.Columns[6].ToolTipText = mAgentToolTip.AgentEmail.ToString();
                this.dgvAgent.Columns[7].ToolTipText = mAgentToolTip.AgentRemark.ToString();
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
                //this.dgvAgent.Columns[0].Visible = false;
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
            try
            {
                DataTable mm = new DataTable();
                //dgvAgent.DataSource = mMasterBLL.selectDataTable("Agent", "");
                dgvAgents.DataSource = mMasterBLL.selectDataTable("Agent", "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion
        
        #region"Private Event"
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                SetAgent L_SetAgent = new SetAgent();
                L_SetAgent.ShowDialog();
                if (L_SetAgent.DialogResult == DialogResult.Cancel)
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
                if (dgvAgent.Rows.Count > 0)
                {                    
                    if (dgvAgent.CurrentRow.Cells[0].Value != null)
                    {
                        //pan.BackColor = Color.AliceBlue;
                       // SetAgent L_SetAgent = new SetAgent((long)dgvAgent.CurrentRow.Cells[dgvtxaskey.Index].Value);
                        SetAgent L_SetAgent = new SetAgent((string)dgvAgent.CurrentRow.Cells[0].Value);
                        L_SetAgent.ShowDialog();
                        if (L_SetAgent.DialogResult == DialogResult.Cancel)
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
        
      

        private void dgvAgent_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((int)e.ColumnIndex == dgvAgent.Columns[1].Index)
            {
                if (e.Value != null)
                {
                    mPersonObj.Ask = e.Value.ToString();// Convert.ToInt64(e.Value);
                    DataTable m = new DataTable();
                    m = mMasterBLL.selectDataTablebyAsk("Person", mPersonObj);
                    if (m.Rows.Count > 0)
                    {
                        e.Value = m.Rows[0][1].ToString();
                    }
                }
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                //this.Opacity = this.Opacity = 0.1;               
                FindBase L_FindBase = new FindBase("Period",new PeriodObj());
                L_FindBase.ShowDialog();
                if (L_FindBase.DialogResult == DialogResult.OK)
                {
                    loadGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        #endregion
    }
}