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
    public partial class LstGain : LstBase
    {
        public LstGain()
        {
            InitializeComponent();
            InitializeComponent();
            loadReference();
            loadGrid();
        }
        Utility mUtility = new Utility();
        MasterBLL mMasterBLL = new MasterBLL();
        GainObj mGainObj = new GainObj();
        ResultToolTip mResultToolTip = new ResultToolTip();
        PeriodObj mPeriodObj = new PeriodObj();
        LuckyTypeObj mLuckyTypeObj = new LuckyTypeObj();
        ListObj mListObj = new ListObj();
        SubmitHeaderObj mSubmitHeaderObj = new SubmitHeaderObj();

        #region "Private Method"

        private void loadReference()
        {
            loadPeriod();
            loadLuckyType();
            cboState.SelectedIndex = 0;
            //cboOperator.SelectedIndex = 0;
        }


        private void loadPeriod()
        {
            cboLPeriod.DisplayMember = "Period Code";
            cboLPeriod.ValueMember = "ASK";
            cboLPeriod.DataSource = mMasterBLL.selectDataTable("LM_Period", "");
        }
        private void loadLuckyType()
        {
            cboLT.DisplayMember = "Lucky Code";
            cboLT.ValueMember = "ASK";
            cboLT.DataSource = mMasterBLL.selectDataTable("LM_Luckytype", "");
        }


        private void loadGrid()
        {
            try
            {

                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("@PeriodAsk",cboLPeriod.SelectedValue.ToString());
                dic.Add("@LuckyTypeAsk", cboLT.SelectedValue.ToString());
                dic.Add("@Status", cboState.SelectedIndex.ToString());
                dgvGainlist.DataSource = mMasterBLL.executeSelectProcedure("CS_SP_SELECT_GAIN&LOSE", dic);


                //dgvGainlist.DataSource = mMasterBLL.selectDataTable("LM_Gain", "");
                mUtility.setDataGridColumn(ref dgvGainlist);
                dgvGainlist.Columns[8].Visible = false;
                dgvGainlist.Columns[9].Visible = false;
                dgvGainlist.Columns[10].Visible = false;

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
                ProGain L_ProGain = new ProGain();
                L_ProGain.ShowDialog();
                if (L_ProGain.DialogResult == DialogResult.Cancel)
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
                if (dgvGainlist.Rows.Count > 0)
                {
                    if (dgvGainlist.CurrentRow.Cells[0].Value != null)
                    {
                        ProGain L_ProGain = new ProGain(dgvGainlist.CurrentRow.Cells[0].ToString());
                        L_ProGain.ShowDialog();
                        if (L_ProGain.DialogResult == DialogResult.Cancel)
                        {
                            loadGrid();
                        }                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());             
            }
        }

        private void dgvGainlist_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((int)e.ColumnIndex == dgvGainlist.Columns[3].Index)
            {
                if (e.Value != null)
                {
                    mSubmitHeaderObj.Ask = Convert.ToString(e.Value);
                    e.Value = ((SubmitHeaderObj)mMasterBLL.selectObjbyAskobj("LM_SubmitHeader", mSubmitHeaderObj)).SubmitCode ;

                }
            }

            if ((int)e.ColumnIndex == dgvGainlist.Columns[4].Index)
            {
                if (e.Value != null)
                {
                    mListObj.Ask = Convert.ToString(e.Value);
                    e.Value = ((ListObj)mMasterBLL.selectObjbyAskobj("LM_List", mListObj)).ListCode;
                }
            }
            if ((int)e.ColumnIndex == dgvGainlist.Columns[6].Index)
            {
                if (e.Value != null)
                {
                    if (Convert.ToString(e.Value) == "1")
                    {
                        e.Value = "Gain";
                    }
                    else
                    {
                        e.Value = "Lose";
                    }
                }
            }
            //if ((int)e.ColumnIndex == dgvGainlist.Columns[8].Index)
            //{
            //    if (e.Value != null)
            //    {
            //        if (Convert.ToString(e.Value) == "1")
            //        {
            //            e.Value = "Procss";
            //        }
            //        else
            //        {
            //            e.Value = "New";
            //        }
            //    }
            //}
            //if ((int)e.ColumnIndex == dgvGainlist.Columns[9].Index)
            //{
            //    if (e.Value != null)
            //    {
            //        mLuckyTypeObj.Ask = Convert.ToString(e.Value);
            //        e.Value = ((LuckyTypeObj)mMasterBLL.selectObjbyAskobj("LM_LuckyType", mLuckyTypeObj)).LuckyTypeCode;

            //    }
            //}

            //if ((int)e.ColumnIndex == dgvGainlist.Columns[10].Index)
            //{
            //    if (e.Value != null)
            //    {
            //        mPeriodObj.Ask = Convert.ToString(e.Value);
            //        e.Value = ((PeriodObj)mMasterBLL.selectObjbyAskobj("LM_Period", mPeriodObj)).PeriodCode;

            //    }
            //}

            if ((int)e.ColumnIndex == dgvGainlist.Columns[11].Index)
            {
                if (e.Value != null)
                {
                    if (Convert.ToString(e.Value) == "1")
                    {
                        e.Value = "Gain";
                    }
                    else if (Convert.ToString(e.Value) == "2")
                    {
                        e.Value = "Up/Down";
                    }
                    else if (Convert.ToString(e.Value) == "3")
                    {
                        e.Value = "Round";
                    }
                    else
                    {
                        e.Value = "Lose";
                    }
                }
            }

        }

        private void dgvGainlist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void grbList_Enter(object sender, EventArgs e)
        {

        }

        private void btnRefreshSea_Click(object sender, EventArgs e)
        {
            loadGrid();
            //mGainObj.PeridoAsk = Convert.ToString(cboLPeriod.SelectedValue);
            //mGainObj.LuckyTypeAsk = Convert.ToString(cboLT.SelectedValue);
            //Dictionary<string, string> dic = new Dictionary<string, string>();
            //dic.Add("@PeriodAsk", mGainObj.PeridoAsk);
            //dic.Add("@LuckyTypeAsk", mGainObj.LuckyTypeAsk);
            //dgvGainlist.DataSource = mMasterBLL.executeSelectProcedure("CS_SP_SELECT_GAIN", dic);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            cboState.SelectedIndex = 0;
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("@PeridoAsk", cboLPeriod.SelectedValue.ToString());
            dic.Add("@TypeAsk", cboLT.SelectedValue.ToString());
            //dic.Add("@Status", "1");
            dgvGainlist.DataSource = mMasterBLL.executeSelectProcedure("CS_SP_PROCESS_GAIN", dic);



            //dgvResult.DataSource = mMasterBLL.getGain("CS_SP_PROCESS_GAIN", Convert.ToInt64(mListObj.TypeAsk), Convert.ToInt64(mPeriodObj.Ask), mPeriodObj.StartDate, mPeriodObj.EndDate, mLuckyTypeObj.NumberofPass);
            
        }
   
    
    
    
    }
}