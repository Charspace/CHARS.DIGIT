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


namespace CHARS.HR.PL.Process
{
    public partial class ProGain : SetBase
    {
        public ProGain()
        {
            InitializeComponent();
            clearUI();
            loadReference();
            //setSampledata();
            //setToolTip();
            saveState = true;
            controlUI();
        }
        public ProGain(string aASK)
        {
            InitializeComponent();
            clearUI();
            loadReference();
            //setToolTip();
            bindForm(aASK);
            saveState = false;
            controlUI();
        }

        Utility mUtility = new Utility();
        MasterBLL mMasterBLL = new MasterBLL();
        GainObj mGainObj = new GainObj();
        ResultToolTip mResultToolTip = new ResultToolTip();
        ResultSample mResultSample = new ResultSample();
        private bool saveState = true;
        private bool saveFlag = true;
        //reference 
        PeriodObj mPeriodObj = new PeriodObj();
        LuckyTypeObj mLuckyTypeObj = new LuckyTypeObj();
        ListObj mListObj = new ListObj();
        CompetatorObj mCompetatorObj = new CompetatorObj();
        SubmitHeaderObj mSubmitHeaderObj = new SubmitHeaderObj();



        #region"Private Method"
        public void bindForm(string aAsk)
        {
            try
            {
                //mGainObj = new GainObj();
                //mGainObj.Ask = aAsk;
                //DataTable l_databale = new DataTable();
                //l_databale = mMasterBLL.Findby("Result", mGainObj);

                //mGainObj.Ask = Convert.ToString(l_databale.Rows[0][0]);
                //mGainObj.PeriodAsk = Convert.ToString(l_databale.Rows[0][1]);
                //mGainObj.TypeAsk = Convert.ToString(l_databale.Rows[0][2]);
                //mGainObj.ListAsk = Convert.ToString(l_databale.Rows[0][3]);
                //mGainObj.MainCompetatorGain = Convert.ToString(l_databale.Rows[0][4]);
                //mGainObj.CompetatorGain = Convert.ToString(l_databale.Rows[0][5]);
                //bindUI();
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
            cboLuckyType.DataSource = mMasterBLL.selectDataTable("LM_LuckyType", "");
        }
        private void loadPeriod()
        {
            cboPeriod.DisplayMember = "Period Code";
            cboPeriod.ValueMember = "ASK";
            cboPeriod.DataSource = mMasterBLL.selectDataTable("LM_Period", "");
        }
        private bool isValid()
        {
            try
            {
                bool valid = true;
                errorproviderbase.Clear();
                //if (cboPerson.SelectedValue == null || cboPerson.Text.Trim() == "")
                //{
                //    valid = mUtility.setInvalidComboBox(errorproviderbase, cboPerson);
                //}
                //else
                //{
                //    mUtility.setValidComboBox(errorproviderbase, cboPerson);
                //}
                //if (txtAgentCode.TextLength == 0 || txtAgentCode.Text.Trim() == "")
                //{
                //    valid = mUtility.setInvalidTextbox(errorproviderbase, txtAgentCode);
                //}
                //else
                //{
                //    mUtility.setValidTextbox(errorproviderbase, txtAgentCode);
                //}
                //if (txtAgentPhone.TextLength == 0 || txtAgentPhone.Text.Trim() == "")
                //{
                //    valid = mUtility.setInvalidTextbox(errorproviderbase, txtAgentPhone);
                //}
                //else
                //{
                //    mUtility.setValidTextbox(errorproviderbase, txtAgentPhone);
                //}
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
                if (mGainObj.Ask == "0")
                {
                    mGainObj.Ask = mUtility.getAsk();
                }
                //mGainObj.PeridoAsk = Convert.ToString(cboPeriod.SelectedValue);
                //mGainObj.LuckyTypeAsk = Convert.ToString(cboLuckyType.SelectedValue);
                //mGainObj.ListAsk = "0";// Convert.ToInt64(cboPerson.SelectedValue);
                //mGainObj.MainCompetatorGain = "0";// txtAgentPhone.Text.Trim();
                //mGainObj.CompetatorGain = "0";// rtxtAgentAddress.Text.Trim();                
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
               //cboPeriod.SelectedValue = mGainObj.PeriodAsk;
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
                for (int i = 0; i < dgvResult.Rows.Count; i++)
                {
                    if (dgvResult[7, i].Value.ToString() != "" || dgvResult[7, i] != null)
                    {
                        //mGainObj.Ask = mUtility.getAsk();
                        //mGainObj.PeriodAsk = Convert.ToString(dgvResult[5, i].Value);
                        //mGainObj.TypeAsk = Convert.ToString(dgvResult[6, i].Value);
                        //mGainObj.ListAsk = Convert.ToString(dgvResult[0, i].Value);
                        //mGainObj.MainCompetatorGain = Convert.ToString(dgvResult[3, i].Value);
                        //mGainObj.CompetatorGain = Convert.ToString(dgvResult[4, i].Value);
                        //if (!mMasterBLL.saveObj("LM_Result", mGainObj))
                        //{
                        //    valid = false;
                        //}
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
                for (int i = 0; i <= dgvResult.Rows.Count - 1; i++)
                {
                    if (dgvResult[0, i].Value.ToString() != "" || dgvResult[0, i] != null)
                    {
                        mGainObj.Ask = mUtility.getAsk();
                        mGainObj.TS = "0";
                        mGainObj.UD = "0";
                        mGainObj.PeridoAsk = Convert.ToString(cboPeriod.SelectedValue);
                        mGainObj.LuckyTypeAsk = Convert.ToString(cboLuckyType.SelectedValue); 
                        mGainObj.ListAsk = Convert.ToString(dgvResult[4, i].Value);
                        mGainObj.HeaderAsk = Convert.ToString(dgvResult[3, i].Value);
                        mGainObj.Amount = Convert.ToString(dgvResult[5, i].Value);
                        mGainObj.Status = Convert.ToString(dgvResult[6, i].Value);
                        mGainObj.ToPay = Convert.ToString(dgvResult[7, i].Value);
                        mGainObj.Confirm = Convert.ToString(dgvResult[8, i].Value);                       
                        mGainObj.GainType = Convert.ToString(dgvResult[11, i].Value);
                        if (!mMasterBLL.saveObj("LM_Gain", mGainObj))
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

        #region "Private Event"
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
                        if (saveResultDraw())
                        {
                            MessageBox.Show("Save Completely");
                        }
                    }
                }
                else
                {
                    if (isValid())
                    {
                        if (saveResult())
                        {
                            MessageBox.Show("Save Completely");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnPrepare_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable L_Listdtl = new DataTable();
                DataTable L_Resultdtl = new DataTable();
                mPeriodObj.Ask = Convert.ToString(cboPeriod.SelectedValue);
                mLuckyTypeObj.Ask = Convert.ToString(cboLuckyType.SelectedValue);
                mLuckyTypeObj = new LuckyTypeObj();
                mLuckyTypeObj.Ask = Convert.ToString(cboLuckyType.SelectedValue);
                mLuckyTypeObj = (LuckyTypeObj)mMasterBLL.selectObjbyAskobj("LM_LuckyType", mLuckyTypeObj);
                mPeriodObj = (PeriodObj)mMasterBLL.selectObjbyAskobj("LM_Period", mPeriodObj);
                mListObj.TypeAsk = mLuckyTypeObj.Ask;
                if (mLuckyTypeObj.ResultType == "1")
                {
                   //if (mLuckyTypeObj.NumberofPass == "1")
                   // {
                   //     //L_Resultdtl = mMasterBLL.getPersonDraw("CS_SP_SELECT_DRAW", Convert.ToInt64(mListObj.TypeAsk), mPeriodObj.StartDate, mPeriodObj.EndDate, "731", 3);
                   // }
                   // else if (mLuckyTypeObj.NumberofPass == "2")
                   // {
                   //     L_Resultdtl = mMasterBLL.getPersonDraw("CS_SP_SELECT_DRAW", Convert.ToInt64(mListObj.TypeAsk), mPeriodObj.StartDate, mPeriodObj.EndDate, "731", 3);
                   //     L_Resultdtl.Merge(mMasterBLL.getPersonDraw("CS_SP_SELECT_DRAW", Convert.ToInt64(mListObj.TypeAsk), mPeriodObj.StartDate, mPeriodObj.EndDate, "528", 3));
                   // }
                    L_Resultdtl = mMasterBLL.getGain("CS_SP_PROCESS", Convert.ToInt64(mListObj.TypeAsk), Convert.ToInt64(mPeriodObj.Ask), mPeriodObj.StartDate, mPeriodObj.EndDate, mLuckyTypeObj.NumberofPass);
                    dgvResult.DataSource = L_Resultdtl;
                    if (L_Resultdtl.Rows.Count > 0)
                    {
                        //formatGridviewColumn();
                        mUtility.setDataGridColumn(ref dgvResult);
                        dgvResult.Columns[8].Visible = false;
                        dgvResult.Columns[11].Visible = false;
                        //dgvResult.Columns[12].Visible = false;
                    }
                }
                else if (mLuckyTypeObj.ResultType == "0")
                {
                    dgvResult.DataSource = mMasterBLL.getPersonVote("CS_SP_SELECT_VOTE", Convert.ToInt64(mListObj.TypeAsk), mPeriodObj.StartDate, mPeriodObj.EndDate);
                    formatGridviewColumnVote();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void dgvResult_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((int)e.ColumnIndex == dgvResult.Columns[3].Index)
            {
                if (e.Value != null)
                {
                    mSubmitHeaderObj.Ask = Convert.ToString(e.Value);
                    e.Value = ((SubmitHeaderObj)mMasterBLL.selectObjbyAskobj("LM_SubmitHeader", mSubmitHeaderObj)).SubmitCode;

                }
            }

            if ((int)e.ColumnIndex == dgvResult.Columns[4].Index)
            {
                if (e.Value != null)
                {
                    mListObj.Ask = Convert.ToString(e.Value);
                    e.Value = ((ListObj)mMasterBLL.selectObjbyAskobj("LM_List", mListObj)).ListCode;
                }
            }
            if ((int)e.ColumnIndex == dgvResult.Columns[6].Index)
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
            if ((int)e.ColumnIndex == dgvResult.Columns[9].Index)
            {
                if (e.Value != null)
                {
                    mLuckyTypeObj.Ask = Convert.ToString(e.Value);
                    e.Value = ((LuckyTypeObj)mMasterBLL.selectObjbyAskobj("LM_LuckyType", mLuckyTypeObj)).LuckyTypeCode;

                }
            }

            if ((int)e.ColumnIndex == dgvResult.Columns[10].Index)
            {
                if (e.Value != null)
                {
                    mPeriodObj.Ask = Convert.ToString(e.Value);
                    e.Value = ((PeriodObj)mMasterBLL.selectObjbyAskobj("LM_Period", mPeriodObj)).PeriodCode;

                }
            }

            if ((int)e.ColumnIndex == dgvResult.Columns[11].Index)
            {
                if (e.Value != null)
                {
                    if (Convert.ToString(e.Value) == "1")
                    {
                        e.Value = "GAIN";
                    }
                    else if (Convert.ToString(e.Value) == "2")
                    {
                        e.Value = "UP/DOWN";
                    }
                    else if (Convert.ToString(e.Value) == "3")
                    {
                        e.Value = "ROUND";
                    }
                    else
                    {
                        e.Value = "";
                    }
                }
            }

        }
        private void cboLuckyType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}