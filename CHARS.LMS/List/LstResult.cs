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
using CHARS.HR.PL.Process;

namespace CHARS.LMS.List
{
    public partial class LstResult : LstBase
    {
        public LstResult()
        {
            InitializeComponent();
            
            loadReference();
            loadGrid();
            //setToolTip();
            //hideGridviewcolumn();
        }
        Utility mUtility = new Utility();
        MasterBLL mMasterBLL = new MasterBLL();
        ResultObj mResultObj = new ResultObj();
        ResultToolTip mResultToolTip = new ResultToolTip();
        PeriodObj mPeriodObj = new PeriodObj();
        LuckyTypeObj mLuckyTypeObj = new LuckyTypeObj();
        ListObj mListObj = new ListObj();
        //PersonObj mPersonObj = new PersonObj();

        #region"Properties"

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
                this.dgvList.Columns[0].ToolTipText = mResultToolTip.Ask.ToString();
                this.dgvList.Columns[1].ToolTipText = mResultToolTip.PeriodAsk.ToString();
                this.dgvList.Columns[2].ToolTipText = mResultToolTip.TypeAsk.ToString();
                this.dgvList.Columns[3].ToolTipText = mResultToolTip.ListAsk.ToString();
                this.dgvList.Columns[4].ToolTipText = mResultToolTip.MainCompetatorGain.ToString();
                this.dgvList.Columns[5].ToolTipText = mResultToolTip.CompetatorGain.ToString();               
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
                this.dgvList.Columns[0].Visible = false;
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
                mResultObj.Period = Convert.ToString(cboPeriod.SelectedValue);
                mResultObj.LuckyType = Convert.ToString(cboLuckyType.SelectedValue);
                Dictionary<string, string> dic = new Dictionary<string, string>();
                //dic.Add("@PeriodAsk", mResultObj.PeriodAsk);
                dic.Add("@LuckyTypeAsk", mResultObj.LuckyType);
                dgvList.DataSource = mMasterBLL.executeSelectProcedure("CS_SP_SELECT_RESULT", dic);
                mUtility.setDataGridColumn(ref dgvList);
                dgvList.Columns[6].Visible = false;
                dgvList.Columns[7].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());               
            }

        }


        #endregion

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                ProResult L_ProResult = new ProResult();
                L_ProResult.ShowDialog();
                if (L_ProResult.DialogResult == DialogResult.Cancel)
                {
                    loadGrid();
                }
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

        private void btnShowAll_Click(object sender, EventArgs e)
        {

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvList.Rows.Count > 0)
                {
                    //if (dgvList.CurrentRow.Cells[dgvtxaskey.Index].Value != null)
                    if (dgvList.CurrentRow.Cells[0].Value != null)
                    {
                        //pan.BackColor = Color.AliceBlue;
                        //SetPlayer L_SetPlayer = new SetPlayer((long)dgvList.CurrentRow.Cells[dgvtxaskey.Index].Value);
                        SetResult L_SetResult = new SetResult(dgvList.CurrentRow.Cells[0].Value.ToString());
                        L_SetResult.ShowDialog();
                        if (L_SetResult.DialogResult == DialogResult.Cancel)
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

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void dgvList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((int)e.ColumnIndex == dgvList.Columns[3].Index) //period
            {
                if (e.Value != null)
                {
                    mPeriodObj.Ask = Convert.ToString(e.Value);
                    e.Value = ((PeriodObj)mMasterBLL.selectObjbyAskobj("LM_Period", mPeriodObj)).PeriodCode;
                }

            }

            if ((int)e.ColumnIndex == dgvList.Columns[4].Index) //lucky type
            {
                if (e.Value != null)
                {
                    mLuckyTypeObj.Ask = Convert.ToString(e.Value);
                    e.Value = ((LuckyTypeObj)mMasterBLL.selectObjbyAskobj("LM_LuckyType", mLuckyTypeObj)).LuckyTypeCode;
                }
            }

            if ((int)e.ColumnIndex == dgvList.Columns[5].Index) //list
            {
                if (e.Value != null)
                {
                    mListObj.Ask = Convert.ToString(e.Value);
                    e.Value = ((ListObj)mMasterBLL.selectObjbyAskobj("LM_List", mListObj)).ListCode;
                }
            }

            if ((int)e.ColumnIndex == dgvList.Columns[8].Index)
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
            //if ((int)e.ColumnIndex == dgvList.Columns[5].Index)
            //{
            //    if (e.Value != null)
            //    {
            //        e.Value = decimal.Round(Convert.ToDecimal(e.Value), 0).ToString();
            //    }
            //}
        }

      

        private void btnRefreshSea_Click(object sender, EventArgs e)
        {
            loadGrid();
        }
  
    
    }
}