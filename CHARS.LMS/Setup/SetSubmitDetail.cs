using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHARS.HR.COMMON.PL;
using CHARS.HR.COMMON.General;
using CHARS.HR.COMMON.BLL;
using CHARS.HR.BOL;

namespace CHARS.HR.PL.Setup
{
    public partial class SetSubmitDetail : SetBase
    {
        decimal mTotal = 0;
        decimal mCount = 0;
        MasterBLL mMasterBLL = new MasterBLL();
        Utility mUtility = new Utility();
        public SetSubmitDetail()
        {
            InitializeComponent();
            //loadReference();         
            //setToolTip();
            //saveState = true;
            //controlUI();
            //clearUI();
        }
        public SetSubmitDetail(string aLuckyType, string aPeriod)
         {
             InitializeComponent();
             //clearUI();
             //loadReference();
             //setToolTip();
             bindForm(aLuckyType, aPeriod);
             //saveState = false;
             //controlUI(); 
         }

        public SetSubmitDetail(string aLuckyType, string aPeriod, string aHeader)
        {
            InitializeComponent();
            //clearUI();
            //loadReference();
            //setToolTip();
            bindFormDetail(aLuckyType, aPeriod, aHeader);
            //saveState = false;
            //controlUI(); 
        }
        public void bindForm(string aLuckyType, string aPeriod)
        {
            try
            {
                mTotal = 0;
                mCount = 0;
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("@PeriodAsk", aPeriod);
                dic.Add("@LuckyTypeAsk", aLuckyType);
                //dic.Add("@SubmitHeader", aSubmitHeader);
                dgvList.DataSource = mMasterBLL.executeSelectProcedure("CS_SP_SELECT_SUBMIT_DETAIL", dic);
                //dgvList[3, 0].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                if (dgvList.Rows.Count > 0)
                {
                    for (int i = 0; i < dgvList.Rows.Count; i++)
                    {
                        mTotal = mTotal + Convert.ToDecimal(dgvList[3,i].Value);
                        mCount = mCount + 1;
                        
                        //dgvList[1, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                       
                    }
                }
                //dgvList.Columns[3].
                lblcount.Text =  mCount.ToString();
                lblTotal.Text = decimal.Round( mTotal,2).ToString();

               // dgvList.DataSource = mMasterBLL.selectDtlbyAsk("LM_SubmitDetail", mSubmitDetailObj, 4);                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void bindFormDetail(string aLuckyType, string aPeriod, string aHeader)
        {
            try
            {
                mTotal = 0;
                mCount = 0;
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("@PeriodAsk", aPeriod);
                dic.Add("@LuckyTypeAsk", aLuckyType);
                dic.Add("@HeaderAsk", aHeader);
                //dic.Add("@SubmitHeader", aSubmitHeader);
                dgvList.DataSource = mMasterBLL.executeSelectProcedure("CS_SP_SELECT_SUBMIT_DETAIL_BY", dic);
                //dgvList[3, 0].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                if (dgvList.Rows.Count > 0)
                {
                    for (int i = 0; i < dgvList.Rows.Count; i++)
                    {
                        mTotal = mTotal + Convert.ToDecimal(dgvList[3,i].Value);
                        mCount = mCount + 1;
                        
                        //dgvList[1, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                       
                    }
                }
                //dgvList.Columns[3].
                lblcount.Text =  mCount.ToString();
                lblTotal.Text = decimal.Round( mTotal,2).ToString();

               // dgvList.DataSource = mMasterBLL.selectDtlbyAsk("LM_SubmitDetail", mSubmitDetailObj, 4);                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
      
        private void dgvList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvList.Columns.Count > 1)
            {
                if ((int)e.ColumnIndex ==3) //main competator
                {
                    e.Value = decimal.Round(Convert.ToDecimal(e.Value),2);
                    //dgvList[e.ColumnIndex, 1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvList[e.ColumnIndex,e.RowIndex].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
           
        }

        private void dgvList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
             //lblcount.Text = mCount.ToString();
             //lblTotal.Text = mTotal.ToString();
        }


    }
}