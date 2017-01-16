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
using CHARS.HR.PL.Process;
using CHARS.HR.BOL;


namespace CHARS.LMS.List
{
    public partial class LstList : LstBase
    {
        public LstList()
        {
            InitializeComponent();
            loadReference();
            loadGrid();
            //setToolTip();
            //hideGridviewcolumn();
        }
        Utility mUtility = new Utility();
        MasterBLL mMasterBLL = new MasterBLL();
        ListObj mListObj = new ListObj();
        ListToolTip mListToolTip = new ListToolTip();
        LuckyTypeObj mLuckyTypeObj = new LuckyTypeObj();
        CompetatorObj mCompetatorObj = new CompetatorObj();


        private void loadReference()
        {
            loadLuckyType();
        }
        private void loadLuckyType()
        {
            cboLuckyType.DisplayMember = "Lucky Code";
            cboLuckyType.ValueMember = "ASK";
            cboLuckyType.DataSource = mMasterBLL.selectDataTable("LM_LuckyType", "");

        }


        #region"Properties"
        private void prepareFilter()
        {

        }
        private void setToolTip()
        {
            try
            {
                //this.dgvConListAll.Columns[0].ToolTipText = mListToolTip.Ask.ToString();
                //this.dgvConListAll.Columns[1].ToolTipText = mListToolTip.TypeAsk.ToString();
                //this.dgvConListAll.Columns[2].ToolTipText = mListToolTip.ListCode.ToString();
                //this.dgvConListAll.Columns[3].ToolTipText = mListToolTip.ListDescription.ToString();
                //this.dgvConListAll.Columns[4].ToolTipText = mListToolTip.MaincompetatorASK.ToString();
                //this.dgvConListAll.Columns[5].ToolTipText = mListToolTip.CompetatorASK.ToString();
                //this.dgvConListAll.Columns[6].ToolTipText = mListToolTip.MinimumAmount.ToString();
                //this.dgvConListAll.Columns[7].ToolTipText = mListToolTip.MaximumAmount.ToString();
                //this.dgvConListAll.Columns[8].ToolTipText = mListToolTip.PlusorMinus.ToString();
                //this.dgvConListAll.Columns[9].ToolTipText = mListToolTip.NumofGain.ToString();
                //this.dgvConListAll.Columns[10].ToolTipText = mListToolTip.GainPercent.ToString();
                //this.dgvConListAll.Columns[11].ToolTipText = mListToolTip.TotalNumofGain.ToString();
                //this.dgvConListAll.Columns[12].ToolTipText = mListToolTip.StartDate.ToString();
                //this.dgvConListAll.Columns[13].ToolTipText = mListToolTip.Enddate.ToString();
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
                this.dgvConListAll.Columns[0].Visible = false;
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
               // DataTable mm = new DataTable();
                //mListObj.TypeAsk = "1";
                dgvConListAll.DataSource = mMasterBLL.selectDataTable("LM_List", "");
                mUtility.setDataGridColumn(ref dgvConListAll);
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
                ProList L_ProList = new ProList();
                L_ProList.ShowDialog();
                if (L_ProList.DialogResult == DialogResult.Cancel)
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
                if (dgvConListAll.Rows.Count > 0)
                {
                    if (dgvConListAll.CurrentRow.Cells[0].Value != null)                    
                    {
                        //pan.BackColor = Color.AliceBlue;
                        //SetMaster L_SetMaster = new SetMaster((long)dgvMaster.CurrentRow.Cells[dgvtxaskey.Index].Value);
                        mLuckyTypeObj.Ask = Convert.ToString(dgvConListAll.CurrentRow.Cells[3].Value);
                        mLuckyTypeObj = (LuckyTypeObj)mMasterBLL.selectObjbyAskobj("LM_LuckyType", mLuckyTypeObj);
                         if (mLuckyTypeObj.ResultType == "1")
                            {
                                SetList L_SetList = new SetList(dgvConListAll.CurrentRow.Cells[0].Value.ToString());
                                L_SetList.ShowDialog();
                                if (L_SetList.DialogResult == DialogResult.Cancel)
                                {
                                    loadGrid();
                                    setToolTip();
                                }
                            }
                            else
                            {
                                SetListVote L_SetListVote = new SetListVote(dgvConListAll.CurrentRow.Cells[0].Value.ToString());
                                L_SetListVote.ShowDialog();
                                if (L_SetListVote.DialogResult == DialogResult.Cancel)
                                {
                                    loadGrid();
                                    setToolTip();
                                }
                            }     
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
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void btnClose_Click(object sender, EventArgs e)
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

        private void dgvConListAll_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void dgvConListAll_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((int)e.ColumnIndex == dgvConListAll.Columns[3].Index)
            {
                if (e.Value != null)
                {
                    mLuckyTypeObj.Ask = Convert.ToString(e.Value);                  
                    mLuckyTypeObj  = (LuckyTypeObj) mMasterBLL.selectObjbyAskobj("LM_LuckyType", mLuckyTypeObj);
                    e.Value = mLuckyTypeObj.LuckyTypeCode;
                }
            }
            if ((int)e.ColumnIndex == dgvConListAll.Columns[6].Index)
            {
                if (e.Value != null)
                {
                    mCompetatorObj.Ask = Convert.ToString(e.Value);                  
                    mCompetatorObj =(CompetatorObj) mMasterBLL.selectObjbyAskobj("LM_Competitor", mCompetatorObj);
                    e.Value = mCompetatorObj.CompetatorCode;                  

                }
            }
            if ((int)e.ColumnIndex == dgvConListAll.Columns[7].Index)
            {
                if (e.Value != null)
                {
                    mCompetatorObj.Ask = Convert.ToString(e.Value);
                    mCompetatorObj = (CompetatorObj)mMasterBLL.selectObjbyAskobj("LM_Competitor", mCompetatorObj);
                    e.Value = mCompetatorObj.CompetatorCode; 
                }
            }
            if ((int)e.ColumnIndex == dgvConListAll.Columns[16].Index)
            {
                if (e.Value != null)
                {
                    e.Value = Utility.getDateVale(e.Value.ToString()).Date.ToShortDateString();
                  
                }
            }
            if ((int)e.ColumnIndex == dgvConListAll.Columns[17].Index)
            {
                if (e.Value != null)
                {
                    e.Value = Utility.getDateVale(e.Value.ToString()).Date.ToShortDateString(); 
                }
            }
            if ((int)e.ColumnIndex == 8)
            {
                if (e.Value != null)
                {
                    e.Value = Decimal.Round(Convert.ToDecimal(e.Value), 2);
                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            } if ((int)e.ColumnIndex == 9)
            {
                if (e.Value != null)
                {
                    e.Value = Decimal.Round(Convert.ToDecimal(e.Value), 2);
                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }

            if ((int)e.ColumnIndex == 12)
            {
                if (e.Value != null)
                {
                    e.Value = Decimal.Round(Convert.ToDecimal(e.Value), 2);
                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
            if ((int)e.ColumnIndex == 14)
            {
                if (e.Value != null)
                {
                    e.Value = Decimal.Round(Convert.ToDecimal(e.Value), 2);
                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }



        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnRefreshSea_Click(object sender, EventArgs e)
        {
            mListObj.TypeAsk = Convert.ToString(cboLuckyType.SelectedValue);
            mListObj.StartDate = Utility.getDateString(dtpStartDate.Value);
            Dictionary<string,string> dic = new Dictionary<string,string>();
            dic.Add("@SD",mListObj.StartDate);
            dic.Add("@LuckyTypeAsk",mListObj.TypeAsk);
            dgvConListAll.DataSource = mMasterBLL.executeSelectProcedure("CS_SP_SELECT_LIST", dic);            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
















    }
}