using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHARS.HR.COMMON.PL;
using CHARS.HR.COMMON.BLL;
using CHARS.HR.COMMON.General;
using CHARS.HR.BOL;
using CHARS.HR.COMMON;

namespace CHARS.HR.PL.Process
{
    public partial class ProResult : SetBase
    {
        public ProResult()
        {
            InitializeComponent();
            clearUI();
            loadReference();
            //setSampledata();
            //setToolTip();
            saveState = true;
            controlUI();
        }
        public ProResult(string aASK)
        {
            InitializeComponent();
            clearUI();
            loadReference();
            //setToolTip();
            bindForm(aASK);
            saveState = false;
            controlUI();
        }

        public ProResult(string aLuckyType, string aPeriod)
        {
            InitializeComponent();
            clearUI();
            loadReference();
            //setToolTip();
            cboLuckyType.SelectedValue = aLuckyType;
            cboPeriod.SelectedValue = aPeriod;
            saveState = false;
            controlUI();
        }
        
        Utility mUtility = new Utility();
        MasterBLL mMasterBLL = new MasterBLL();
        ResultObj mResultObj = new ResultObj();
        ResultToolTip mResultToolTip = new ResultToolTip();
        ResultSample mResultSample = new ResultSample();
        private bool saveState = true;
        private bool saveFlag = true;
        //reference 
        PeriodObj mPeriodObj = new PeriodObj();
        LuckyTypeObj mLuckyTypeObj = new LuckyTypeObj();
        ListObj mListObj = new ListObj();
        CompetatorObj mCompetatorObj = new CompetatorObj();

        #region"Private Method"
        public void bindForm(string aAsk)
        {
            try
            {
                mResultObj = new ResultObj();
                mResultObj.Ask = aAsk;
                DataTable l_databale = new DataTable();
                l_databale = mMasterBLL.Findby("Result", mResultObj);

                mResultObj.Ask = Convert.ToString(l_databale.Rows[0][0]);
                mResultObj.Period = Convert.ToString(l_databale.Rows[0][1]);
                mResultObj.LuckyType = Convert.ToString( l_databale.Rows[0][2]);
                mResultObj.List =Convert.ToString( l_databale.Rows[0][3]);
                mResultObj.MainCompetatorGain =Convert.ToString( l_databale.Rows[0][4]);
                mResultObj.CompetatorGain =Convert.ToString( l_databale.Rows[0][5]);
                bindUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void loadReference()
        {
            loadLuckyType();
            loadPeriod();
        }
        private void loadLuckyType()
        {
            cboLuckyType.DisplayMember = "Lucky Code";
            cboLuckyType.ValueMember = "ASK";
            DataTable tbl = mMasterBLL.selectDataTable("LM_LuckyType", "");
            cboLuckyType.DataSource = tbl;            
            cboLuckyType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboLuckyType.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboLuckyType.AutoCompleteCustomSource.AddRange(mUtility.getAutoCompleList(tbl, "Lucky Code"));
        }
        private void loadPeriod()
        {
            cboPeriod.DisplayMember = "Period Code";
            cboPeriod.ValueMember = "ASK";
            DataTable tbl = mMasterBLL.selectDataTable("LM_Period", "");
            cboPeriod.DataSource = tbl;
            cboPeriod.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboPeriod.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboPeriod.AutoCompleteCustomSource.AddRange(mUtility.getAutoCompleList(tbl, "Period Code"));
        }
        private bool isValid()
        {
            try
            {
                bool valid = true;
                errorproviderbase.Clear();

                if (cboLuckyType.SelectedIndex == -1)
                {
                    valid = mUtility.setInvalidComboBox(errorproviderbase, cboLuckyType);
                }
                else
                {
                    mUtility.setValidComboBox(errorproviderbase, cboLuckyType);
                }
                if (cboPeriod.SelectedIndex == -1)
                {
                    valid = mUtility.setInvalidComboBox(errorproviderbase, cboPeriod);
                }
                else
                {
                    mUtility.setValidComboBox(errorproviderbase, cboPeriod);
                }

                return valid;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        private void bindLObj()
        {
            try
            {
                if (mResultObj.Ask == "0")
                {
                    mResultObj.Ask = mUtility.getAsk();
                }
                mResultObj.Period = Convert.ToString(cboPeriod.SelectedValue);
                mResultObj.LuckyType = Convert.ToString(cboLuckyType.SelectedValue);
                mResultObj.List = "0";// Convert.ToInt64(cboPerson.SelectedValue);
                mResultObj.MainCompetatorGain = "0";// txtAgentPhone.Text.Trim();
                mResultObj.CompetatorGain = "0";// rtxtAgentAddress.Text.Trim();
                mResultObj.Status = "0";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void clearUI()
        {
            try
            {
               mUtility.clearComboBox(cboLuckyType, cboPeriod);
               mUtility.setValidComboBox(errorproviderbase, cboPeriod);
               mUtility.setValidComboBox(errorproviderbase, cboLuckyType);
               //dgvResult.Rows.Clear();
            }             
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void bindUI()
        {
            try
            {
                cboPeriod.SelectedValue = mResultObj.Period;               
                //txtAgentDescription.Text = mResultObj.AgentDescription;
                //txtAgentPhone.Text = mResultObj.AgentPhone.ToString();
                //txtAgentEmail.Text = mResultObj.AgentEmail.ToString();
                //rtxtAgentAddress.Text = mResultObj.AgentAddress.ToString();
                //rtxtAgentRemark.Text = mResultObj.AgentRemark.ToString();
            }             
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void setToolTip()
        {
            try
            {
                toolTipbase.SetToolTip(cboLuckyType, mResultToolTip.TypeAsk);
                toolTipbase.SetToolTip(cboPeriod, mResultToolTip.PeriodAsk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void setSampledata()
        {
            try
            {
                //mUtility.setComboBoxSampleData(cboPerson, mAgentSample.PersonAsk);
                //mUtility.setTextBoxSampleData(txtAgentCode, mAgentSample.AgentCode);
                //mUtility.setTextBoxSampleData(txtAgentDescription, mAgentSample.AgentDescription);
                //mUtility.setTextBoxSampleData(txtAgentPhone, mAgentSample.AgentPhone);
                //mUtility.setRichTextBoxSampleData(rtxtAgentAddress, mAgentSample.AgentAddress);
                //mUtility.setTextBoxSampleData(txtAgentEmail, mAgentSample.AgentEmail);
                //mUtility.setRichTextBoxSampleData(rtxtAgentRemark, mAgentSample.AgentRemark);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void controlUI()
        {
            try
            {
                if (saveState)
                {
                    mUtility.visibleButton(false, btnDelete);
                }
                else
                {
                    mUtility.visibleButton(true, btnDelete);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool saveResult()
        {
            bool valid = true;
            try
            {
                for (int i = 0; i < dgvResult.Rows.Count ; i++)
                {
                    if (dgvResult[7, i].Value.ToString() != "" || dgvResult[7, i] != null)
                    {
                        mResultObj.Ask = mUtility.getAsk();
                        mResultObj.Period = Convert.ToString(dgvResult[5, i].Value);
                        mResultObj.LuckyType = Convert.ToString(dgvResult[6, i].Value);
                        mResultObj.List = Convert.ToString(dgvResult[0, i].Value);
                        mResultObj.MainCompetatorGain = Convert.ToString(dgvResult[3, i].Value);
                        mResultObj.CompetatorGain = Convert.ToString(dgvResult[4, i].Value);
                        if (!mMasterBLL.saveObj("LM_Result", mResultObj))
                        {
                            valid = false;
                        }
                    }
                }
                return valid;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        private void formatGridviewColumn()
        {
            if (this.dgvResult.Columns.Count > 1)
            {
                //dgvResult.Columns.Add("MainCompetitor", "Main Competitor");
                //dgvResult.Columns.Add("SecondCompetitor", "Second Competitor");
                this.dgvResult.Columns[0].Visible = false;
                this.dgvResult.Columns[1].Visible = false;
                this.dgvResult.Columns[2].Visible = false;
                this.dgvResult.Columns[3].Visible = false;
                this.dgvResult.Columns[4].Visible = false;
                this.dgvResult.Columns[5].Visible = false;
                this.dgvResult.Columns[6].Visible = false;
                this.dgvResult.Columns[7].Visible = false;
                this.dgvResult.Columns[8].Visible = false;
                this.dgvResult.Columns[9].Visible = false;
                this.dgvResult.Columns[10].Visible = false;
                this.dgvResult.Columns[11].Visible = false;
                this.dgvResult.Columns[12].Visible = false;
                this.dgvResult.Columns[13].Visible = false;
                this.dgvResult.Columns[14].Visible = false;
                this.dgvResult.Columns[15].Visible = false;
                this.dgvResult.Columns[16].Visible = false;
                this.dgvResult.Columns[17].Visible = false;
                //this.dgvResult.Columns[18].Visible = false;
                //this.dgvResult.Columns[19].Visible = false;
                //Visible
                //this.dgvResult.Columns[18].Visible = true;
                this.dgvResult.Columns[4].Visible = true;
                this.dgvResult.Columns[5].Visible = true;

                //Display                
                this.dgvResult.Columns[4].DisplayIndex = 1; //code
                this.dgvResult.Columns[5].DisplayIndex = 2; //list code           
                //this.dgvResult.Columns[18].DisplayIndex = 3; //  list des

                //hearder 
                //body
                //this.dgvVote.Columns[4].HeaderText = "List Code";//main competator
                //this.dgvVote.Columns[5].HeaderText = "?"; //main check
                //this.dgvVote.Columns[0].HeaderText = "Go"; //go               

            }
        }
        private void formatGridviewColumnVote()
        {
            if (this.dgvResult.Columns.Count > 1)
            {
                dgvResult.Columns.Add("MainCompetitor", "Main Competitor");
                dgvResult.Columns.Add("SecondCompetitor", "Second Competitor");
                this.dgvResult.Columns[0].Visible = false;
                this.dgvResult.Columns[1].Visible = false;
                this.dgvResult.Columns[2].Visible = false;
                this.dgvResult.Columns[3].Visible = false;
                this.dgvResult.Columns[4].Visible = false;
                this.dgvResult.Columns[5].Visible = false;
                this.dgvResult.Columns[6].Visible = false;
                this.dgvResult.Columns[7].Visible = false;
                this.dgvResult.Columns[8].Visible = false;
                this.dgvResult.Columns[9].Visible = false;
                this.dgvResult.Columns[10].Visible = false;
                this.dgvResult.Columns[11].Visible = false;
                this.dgvResult.Columns[12].Visible = false;
                this.dgvResult.Columns[13].Visible = false;
                this.dgvResult.Columns[14].Visible = false;
                this.dgvResult.Columns[15].Visible = false;
                this.dgvResult.Columns[16].Visible = false;
                this.dgvResult.Columns[17].Visible = false;
                this.dgvResult.Columns[18].Visible = false;
                this.dgvResult.Columns[19].Visible = false;

                //Visible
                //this.dgvResult.Columns[18].Visible = true;
                this.dgvResult.Columns[4].Visible = true;
                this.dgvResult.Columns[6].Visible = true;
                this.dgvResult.Columns[7].Visible = true;
                this.dgvResult.Columns[18].Visible = true;
                this.dgvResult.Columns[19].Visible = true;

                //Display                
                this.dgvResult.Columns[4].DisplayIndex = 0; //code
                this.dgvResult.Columns[6].DisplayIndex = 1; //list code                              
                this.dgvResult.Columns[18].DisplayIndex = 2;
                this.dgvResult.Columns[7].DisplayIndex = 3;
                this.dgvResult.Columns[19].DisplayIndex = 4;
                //this.dgvResult.Columns[18].DisplayIndex = 5;
                //this.dgvResult.Columns[18].DisplayIndex = 3; //  list des

                //hearder 
                //body
                this.dgvResult.Columns[18].HeaderText = "Score";//main competator
                this.dgvResult.Columns[19].HeaderText = "Score"; //main check
                //this.dgvVote.Columns[0].HeaderText = "Go"; //go               

            }
        }

        private bool saveResultDraw()
        {
            
            bool valid = true;
            try
            {
                for (int i = 0; i <= dgvResult.Rows.Count-1; i++)
                {
                    if (dgvResult[0, i].Value.ToString() != "" || dgvResult[0, i] != null)
                    {
                        //if (mPeriodObj.Ask == "")
                        //{
                        //    mPeriodObj.Ask = mUtility.getAsk();
                        //}

                        mResultObj.Ask = mUtility.getAsk();
                        mResultObj.TS = ApplicationMember.mUserLevel;
                        mResultObj.UD = ApplicationMember.mLoginUserAsk;
                        mResultObj.Period = Convert.ToString(cboPeriod.SelectedValue); 
                        mResultObj.LuckyType = Convert.ToString(cboLuckyType.SelectedValue);
                        mListObj.ListCode = Convert.ToString(dgvResult[1, i].Value);

                        mResultObj.List = Convert.ToString(dgvResult[0, i].Value);
                        //mListObj.Ask = Convert.ToString(e.Value);
                        //e.Value = ((ListObj)mMasterBLL.selectObjbyAskobj("LM_List", mListObj)).ListCode;

                        //DataTable L_Resultdtl = new DataTable();
                        //Dictionary<string, string> dic = new Dictionary<string, string>();
                        //dic.Add("@ListCode", Convert.ToString(dgvResult[1, i].Value));
                        //L_Resultdtl = mMasterBLL.executeSelectProcedure("CS_SP_SELECT_LIST_BYCODE", dic);
                        //mResultObj.ListAsk = L_Resultdtl.Rows[0][0].ToString();


                        //mResultObj.ListAsk = ((ListObj)mMasterBLL.selectObjbyAskobj("LM_List", mListObj)).Ask;                         
                        mResultObj.MainCompetatorGain = "0";// Convert.ToString(dgvResult[18, i].Value);
                        mResultObj.CompetatorGain = "0";// Convert.ToString(dgvResult[19, i].Value);
                        if (!mMasterBLL.saveObj("LM_Result", mResultObj))
                        {
                            valid = false;
                        }
                    }
                }
                return valid;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        #endregion

        private void btnNew_Click(object sender, EventArgs e)
        {
            clearUI();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFlag)
                {
                    if (isValid())
                    {
                        mResultObj.Period = Convert.ToString(cboPeriod.SelectedValue);
                        if (!mMasterBLL.isExistData("LM_Result", mResultObj, 4))
                        {
                            if (saveResultDraw())
                            {
                                MessageBox.Show("Save Completely");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Result is already prepared.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



            //try
            //{
            //    if (isValid())
            //    {
            //        bindLObj();
            //        if (saveState)
            //        {
            //            if (!mMasterBLL.isExistData("LM_Result", mResultObj, 4))
            //            {
            //                if (mMasterBLL.saveObj("LM_Result", mResultObj))
            //                {
            //                    MessageBox.Show("Save Completely");
            //                    saveState = false;
            //                }
            //            }
            //            else
            //            {
            //                MessageBox.Show("Result is already prepared.");
            //                //if (MessageBox.Show("Result is already exists. Do you want to override?", "Comfirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //                //{
            //                //    if (mMasterBLL.deleteObj("LM_Result", mResultObj, 1))
            //                //    {
            //                //        if (mMasterBLL.saveObj("Result", mResultObj))
            //                //        {
            //                //            MessageBox.Show("Save Completely");
            //                //            saveState = false;
            //                //        }
            //                //    }
            //                //    else
            //                //    {
            //                //        MessageBox.Show("Fail to deleted");
            //                //    }
            //                //}
                            
            //            }
            //        }
            //        else
            //        {
            //            if (mMasterBLL.updateObj("Result", mResultObj))
            //            {
            //                MessageBox.Show("update Completely");
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
       

        private void btnPrepare_Click(object sender, EventArgs e)
        {
            try
            {
                ////dgvResult.Rows.Clear();
                //DataTable L_Listdtl = new DataTable();
                //DataTable L_Resultdtl = new DataTable();
                //mPeriodObj.Ask = Convert.ToString(cboPeriod.SelectedValue);
                //mLuckyTypeObj.Ask = Convert.ToString(cboLuckyType.SelectedValue);                
                //mLuckyTypeObj = new LuckyTypeObj();
                //mLuckyTypeObj.Ask = Convert.ToString(cboLuckyType.SelectedValue);
                //mLuckyTypeObj = (LuckyTypeObj)mMasterBLL.selectObjbyAskobj("LM_LuckyType", mLuckyTypeObj);
                //mPeriodObj = (PeriodObj)mMasterBLL.selectObjbyAskobj("LM_Period", mPeriodObj);
                //mListObj.TypeAsk = mLuckyTypeObj.Ask;

                DataTable L_Resultdtl = new DataTable();
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("@TypeAsk", Convert.ToString(cboLuckyType.SelectedValue));
                dic.Add("@PeriodAsk", Convert.ToString(cboPeriod.SelectedValue));
                L_Resultdtl = mMasterBLL.executeSelectProcedure("CS_SP_PROCESS_RESULT", dic);
                dgvResult.DataSource = L_Resultdtl;
                dgvResult.Columns[0].Visible = false;
                //formatGridviewColumn();

               


                //if (mLuckyTypeObj.ResultType == "1")
                //{
                //    ////L_Listdtl = mMasterBLL.getPersonDraw("CS_SP_SELECT_DRAW", Convert.ToInt64(mListObj.TypeAsk), mPeriodObj.StartDate, mPeriodObj.EndDate, "", 0);
                //    //if (mLuckyTypeObj.NumberofPass == "1")
                //    //{
                //    //    L_Resultdtl = mMasterBLL.getPersonDraw("CS_SP_SELECT_DRAW", Convert.ToInt64(mListObj.TypeAsk), mPeriodObj.StartDate, mPeriodObj.EndDate, "731", 3);
                //    //}
                //    //else if (mLuckyTypeObj.NumberofPass == "2")
                //    //{
                //    //    L_Resultdtl = mMasterBLL.getPersonDraw("CS_SP_SELECT_DRAW", Convert.ToInt64(mListObj.TypeAsk), mPeriodObj.StartDate, mPeriodObj.EndDate, "731", 3);
                //    //    L_Resultdtl.Merge(mMasterBLL.getPersonDraw("CS_SP_SELECT_DRAW", Convert.ToInt64(mListObj.TypeAsk), mPeriodObj.StartDate, mPeriodObj.EndDate, "528", 3));
                   
                //    //}
                //    Dictionary<string, string> dic = new Dictionary<string, string>();
                //    dic.Add("@TypeAsk", Convert.ToString(cboLuckyType.SelectedValue));
                //    dic.Add("@PeriodAsk", Convert.ToString(cboPeriod.SelectedValue));         
                //    L_Resultdtl = mMasterBLL.executeSelectProcedure("CS_SP_PROCESS_RESULT", dic);

                    


                //    //L_Resultdtl = mMasterBLL.getPersonDraw("CS_SP_SELECT_DRAW", Convert.ToInt64(mListObj.TypeAsk), mPeriodObj.StartDate, mPeriodObj.EndDate,  3);
                    
                //    //L_Resultdtl = mMasterBLL.getGain("CS_SP_PROCESS", Convert.ToInt64(mListObj.TypeAsk), Convert.ToInt64(mPeriodObj.Ask), mPeriodObj.StartDate, mPeriodObj.EndDate, mLuckyTypeObj.NumberofPass);
                //    dgvResult.DataSource = L_Resultdtl;                    
                //    formatGridviewColumn();
                //}
                //else if (mLuckyTypeObj.ResultType == "0")
                //{
                //    dgvResult.DataSource = mMasterBLL.getPersonVote("CS_SP_SELECT_VOTE", Convert.ToInt64(mListObj.TypeAsk), mPeriodObj.StartDate, mPeriodObj.EndDate);
                //    formatGridviewColumnVote();
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cboLuckyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //mLuckyTypeObj.Ask = Convert.ToString(cboLuckyType.SelectedValue);
                //mLuckyTypeObj = mMasterBLL.selectObjbyAskobj("LuckyType", mLuckyTypeObj);
                //mUtility.visibleGroupBox(false, grbDraw);
                //mUtility.visibleDataGridView(false, dgvDrawResult, dgvVote);
                //if (mLuckyTypeObj.ResultType == "1")
                //{
                //    //mUtility.enableGroupBox(true,grbDraw);
                //    //mUtility.visibleGroupBox(true, grbDraw);
                //    //mUtility.visibleDataGridView(true, dgvDrawResult);
                //    lblTypeCaption.Text = "Draw";
                //    saveFlag = true;
                //}
                //else
                //{
                //    //mUtility.enableGroupBox(true, grbVote);
                //    //mUtility.visibleGroupBox(false, grbDraw);
                //    //mUtility.visibleDataGridView(true, dgvVote);
                //    lblTypeCaption.Text = "Vote";
                //    saveFlag = false;
                //}



               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvResult_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if ((int)e.ColumnIndex == dgvResult.Columns[1].Index )
            //{
            //    if (e.Value != null)
            //    {
            //        mLuckyTypeObj.Ask = Convert.ToString(e.Value);
            //        e.Value = ((LuckyTypeObj)mMasterBLL.selectObjbyAskobj("LM_LuckyType", mLuckyTypeObj)).LuckyTypeCode;             
            //    }
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            try
            {
                FindOne L_FindOne = new FindOne("LM_Period", new PeriodObj());
                L_FindOne.ShowDialog();
                if (L_FindOne.Result != null)
                {
                    cboPeriod.Text = "";
                    cboPeriod.SelectedValue = L_FindOne.Result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
