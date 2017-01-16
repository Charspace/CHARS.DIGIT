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
    public partial class LstSubmit : LstBase
    {
        public LstSubmit()
        {
            InitializeComponent();
            
            //loadData();
            loadReference();
            loadGrid();
        }
        Utility mUtility = new Utility();
        MasterBLL mMasterBLL = new MasterBLL();
        SubmitHeaderObj mSubmitHeaderObj = new SubmitHeaderObj();
        SubmitHeaderToolTip mSubmitHeaderToolTip = new SubmitHeaderToolTip();

        PlayerObj mPlayerObj = new PlayerObj();       
        MasterObj mMasterObj = new MasterObj();
        PeriodObj mPeriodObj = new PeriodObj();
        AgentObj mAgentObj = new AgentObj();
        LuckyTypeObj mLuckyTypeObj = new LuckyTypeObj();
        


        #region"Private Method"

        private void loadReference()
        {           
            loadPeriod();
            loadLuckyType();           
            //cboOperator.SelectedIndex = 0;
        }

       
        private void loadPeriod()
        {
            cboPeriod.DisplayMember = "Period Code";
            cboPeriod.ValueMember = "ASK";
            cboPeriod.DataSource = mMasterBLL.selectDataTable("LM_Period", "");
        }
        private void loadLuckyType()
        {
            cboLuckyType.DisplayMember = "Lucky Code";
            cboLuckyType.ValueMember = "ASK";
            cboLuckyType.DataSource = mMasterBLL.selectDataTable("LM_Luckytype", "");
        }

        private void prepareFilter()
        {

        }
        private void setToolTip()
        {
            try
            {
                this.dgvSubmit.Columns[0].ToolTipText = mSubmitHeaderToolTip.Ask.ToString();
                this.dgvSubmit.Columns[1].ToolTipText = mSubmitHeaderToolTip.PlayerAsk.ToString();
                this.dgvSubmit.Columns[2].ToolTipText = mSubmitHeaderToolTip.AgentAsk.ToString();
                this.dgvSubmit.Columns[3].ToolTipText = mSubmitHeaderToolTip.MasterAsk.ToString();
                this.dgvSubmit.Columns[4].ToolTipText = mSubmitHeaderToolTip.PeriodAsk.ToString();
                this.dgvSubmit.Columns[5].ToolTipText = mSubmitHeaderToolTip.Status.ToString();
                this.dgvSubmit.Columns[6].ToolTipText = mSubmitHeaderToolTip.SubmitDate.ToString();
                
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
                this.dgvSubmit.Columns[0].Visible = false;
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
                mSubmitHeaderObj.PeriodAsk = Convert.ToString(cboPeriod.SelectedValue);
                mSubmitHeaderObj.LuckyTypeAsk = Convert.ToString(cboLuckyType.SelectedValue);
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("@PeriodAsk", mSubmitHeaderObj.PeriodAsk);
                dic.Add("@LuckyTypeAsk", mSubmitHeaderObj.LuckyTypeAsk);
                dgvList.DataSource = mMasterBLL.executeSelectProcedure("CS_SP_SELECT_SUBMIT", dic);
                mUtility.setDataGridColumn(ref dgvList);
                if (dgvList.Rows.Count > 0)
                {
                    dgvList.Columns[4].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //try
            //{
            //    DataTable mm = new DataTable();
            //    //dgvList.DataSource = mMasterBLL.selectDataTable("LM_SubmitDetail", "");
            //    dgvList.DataSource = mMasterBLL.selectDataTableByTS("LM_SubmitHeader", ""); 
            //    mUtility.setDataGridColumn(ref dgvList);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }
        #endregion

        #region"Private Event"
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {

                SetSubmit L_SetSubmit = new SetSubmit();
                L_SetSubmit.ShowDialog();
                if (L_SetSubmit.DialogResult == DialogResult.Cancel)
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
                if (dgvList.Rows.Count > 0)
                {
                    if (dgvList.CurrentRow.Cells[0].Value != null)
                    {
                        SetSubmit L_SetSubmit = new SetSubmit(dgvList.CurrentRow.Cells[0].Value.ToString());
                        //SetSubmitEdit L_SetSubmit = new SetSubmitEdit(dgvList.CurrentRow.Cells[0].Value.ToString());
                        L_SetSubmit.ShowDialog();
                        if (L_SetSubmit.DialogResult == DialogResult.Cancel)
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

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

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

        private void btnShowAll_Click(object sender, EventArgs e)
        {

        }
    

        private void dgvSubmit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
        private void dgvSubmit_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((int)e.ColumnIndex == dgvList.Columns[5].Index) //player
            {
                if (e.Value != null)
                {
                    mPlayerObj.Ask = Convert.ToString(e.Value);
                    e.Value = ((PlayerObj)mMasterBLL.selectObjbyAskobj("LM_Player", mPlayerObj)).PlayerCode;                   
                }
                
            }
            if ((int)e.ColumnIndex == dgvList.Columns[6].Index)
            {
                if (e.Value != null)
                {
                    mAgentObj.Ask = Convert.ToString(e.Value);
                    e.Value = ((AgentObj)mMasterBLL.selectObjbyAskobj("LM_Agent", mAgentObj)).AgentCode;
                }
            }
            if ((int)e.ColumnIndex == dgvList.Columns[7].Index)
            {
                if (e.Value != null)
                {
                    mMasterObj.Ask = Convert.ToString(e.Value);
                    e.Value = ((MasterObj)mMasterBLL.selectObjbyAskobj("LM_Master", mMasterObj)).MasterCode;                   
                }
            }
            if ((int)e.ColumnIndex == dgvList.Columns[8].Index)
            {
                if (e.Value != null)
                {
                    mPeriodObj.Ask = Convert.ToString(e.Value);
                    e.Value = ((PeriodObj)mMasterBLL.selectObjbyAskobj("LM_Period", mPeriodObj)).PeriodCode;                      
                }
            }
            if ((int)e.ColumnIndex == dgvList.Columns[13].Index)
            {
                if (e.Value != null)
                {
                    mLuckyTypeObj.Ask = Convert.ToString(e.Value);
                    e.Value = ((LuckyTypeObj)mMasterBLL.selectObjbyAskobj("LM_LuckyType", mLuckyTypeObj)).LuckyTypeCode;
                }
            }
            if ((int)e.ColumnIndex == dgvList.Columns[10].Index)
            {
                if (e.Value != null)
                {
                    e.Value = Utility.getDateVale(e.Value.ToString()).Date.ToShortDateString();
                }
            }
            if ((int)e.ColumnIndex == dgvList.Columns[11].Index)
            {
                if (e.Value != null)
                {
                    e.Value = Decimal.Round(Convert.ToDecimal(e.Value), 2);
                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
            if ((int)e.ColumnIndex == dgvList.Columns[12].Index)
            {
                if (e.Value != null)
                {
                    e.Value = Decimal.Round(Convert.ToDecimal(e.Value), 2);
                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
            if ((int)e.ColumnIndex == dgvList.Columns[9].Index)
            {
                if (e.Value != null)
                {
                    if (e.Value.ToString() == "1")
                    {
                        e.Value = "Process";
                    }
                    else
                    {
                        e.Value = "Open";
                    }

                }
            }


        }


        #endregion

        private void cboLuckyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            mPeriodObj.LuckyTypeAsk = "1";
            loadPeriod();
        }

        private void btnRefreshSea_Click(object sender, EventArgs e)
        {

            loadGrid();

        }
   

        private void btnDetail_Click(object sender, EventArgs e)
        {
            SetSubmitDetail L_SetSubmitDetail = new SetSubmitDetail(cboLuckyType.SelectedValue.ToString(), cboPeriod.SelectedValue.ToString(), dgvList.CurrentRow.Cells[0].Value.ToString());
            L_SetSubmitDetail.ShowDialog();
            //if (L_SetSubmit.DialogResult == DialogResult.Cancel)
            //{
            //    loadGrid();
            //}
        }

        private void lblSummary_Click(object sender, EventArgs e)
        {
            SetSubmitDetail L_SetSubmitDetail = new SetSubmitDetail(cboLuckyType.SelectedValue.ToString(), cboPeriod.SelectedValue.ToString());
            L_SetSubmitDetail.ShowDialog();
            //if (L_SetSubmit.DialogResult == DialogResult.Cancel)
            //{
            //    loadGrid();
            //}
        }
    }

}