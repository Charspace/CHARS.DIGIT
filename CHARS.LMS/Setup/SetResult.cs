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

namespace CHARS.HR.PL.Setup
{
    public partial class SetResult : SetBase
    {
        public SetResult()
        {
            InitializeComponent();
            clearUI();
            loadReference();
            //setSampledata();
            //setToolTip();
            saveState = true;
            controlUI();
        }
        public SetResult(string aASK)
        {
            InitializeComponent();
            clearUI();
            loadReference();
           // setToolTip();
            bindForm(aASK);
            saveState = false;
            controlUI();
        }
        Utility mUtility = new Utility();
        MasterBLL mMasterBLL = new MasterBLL();
        ResultObj mResultObj = new ResultObj();
        ResultToolTip mResultToolTip = new ResultToolTip();
        ResultSample mResultSample = new ResultSample();
        private bool saveState = true;
        //private bool saveFlag = true;
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
                //DataTable l_databale = new DataTable();
                //l_databale = mMasterBLL.Findby("LM_LuckyType", mResultObj);
                mResultObj = (ResultObj)mMasterBLL.selectObjbyObj("LM_Result", mResultObj);
                bindUI();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void loadReference()
        {
            //loadLuckyType();
            //loadPeriod();
        }       
        private bool isValid()
        {
            try
            {
                bool valid = true;
                errorproviderbase.Clear();
                if (txtPeriod.TextLength == 0 || txtPeriod.Text.Trim() == "")
                {
                    valid = mUtility.setInvalidTextbox(errorproviderbase, txtPeriod);
                }
                else
                {
                    mUtility.setValidTextbox(errorproviderbase, txtPeriod);
                }
                if (txtLuckyType.TextLength == 0 || txtLuckyType.Text.Trim() == "")
                {
                    valid = mUtility.setInvalidTextbox(errorproviderbase, txtLuckyType);
                }
                else
                {
                    mUtility.setValidTextbox(errorproviderbase, txtLuckyType);
                }
                if (txtList.TextLength == 0 || txtList.Text.Trim() == "")
                {
                    valid = mUtility.setInvalidTextbox(errorproviderbase, txtList);
                }
                else
                {
                    mUtility.setValidTextbox(errorproviderbase, txtList);
                }
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
                if (mResultObj.Ask == "0")
                {
                    mResultObj.Ask = mUtility.getAsk();
                }
                //mResultObj.PeriodAsk = Convert.ToInt64(cboPeriod.SelectedValue);
                //mResultObj.TypeAsk = Convert.ToInt64(cboLuckyType.SelectedValue);
                //mResultObj.List = Convert.ToString(txtList.Text.Trim());
                ListObj l_List = new ListObj();
                l_List.ListCode = Convert.ToString(txtList.Text.Trim());
                DataTable dtl_list= new DataTable();

                dtl_list = mMasterBLL.selectDataTablebyIndex("LM_List", l_List, 5);
                if (dtl_list.Rows.Count > 0)
                {
                    mResultObj.List = Convert.ToString(dtl_list.Rows[0][0]);
                }
                else
                {
                    MessageBox.Show("Invalid List Code! ","Edit");
                }


                mResultObj.MainCompetatorGain = "0";// Convert.ToString(txtMainCompetator.Text.Trim());
                mResultObj.CompetatorGain = "0"; Convert.ToString(txtCompetator.Text.Trim());
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
               mUtility.clearTextBox(txtPeriod,txtLuckyType,txtList,txtMainCompetator,txtCompetator);
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
                mPeriodObj.Ask = mResultObj.Period;
                mLuckyTypeObj.Ask = mResultObj.LuckyType.ToString();
                mListObj.Ask = mResultObj.List;
                txtPeriod.Text = ((PeriodObj)mMasterBLL.selectObjbyAskobj("LM_Period", mPeriodObj)).PeriodCode;
                txtLuckyType.Text = ((LuckyTypeObj)mMasterBLL.selectObjbyAskobj("LM_LuckyType", mLuckyTypeObj)).LuckyTypeCode;
                txtList.Text = ((ListObj)mMasterBLL.selectObjbyAskobj("LM_List", mListObj)).ListCode;               
                //txtCompetator.Text = mResultObj.CompetatorGain.ToString();
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
                toolTipbase.SetToolTip(txtPeriod, mResultToolTip.PeriodAsk);
                toolTipbase.SetToolTip(txtLuckyType, mResultToolTip.TypeAsk);
                toolTipbase.SetToolTip(txtList, mResultToolTip.ListAsk);
                toolTipbase.SetToolTip(txtMainCompetator, mResultToolTip.MainCompetatorGain);
                toolTipbase.SetToolTip(txtCompetator, mResultToolTip.CompetatorGain);
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
       
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValid())
                {
                    
                    if (saveState)
                    {
                        bindLObj();
                        if (mMasterBLL.saveObj("LM_Result", mResultObj))
                        {
                            MessageBox.Show("Save Completely");
                            saveState = false;
                        }
                    }
                    else
                    {
                        if (mResultObj.Status == "0")
                        {
                            bindLObj();
                            if (mMasterBLL.updateObj("LM_Result", mResultObj))
                            {
                                MessageBox.Show("update Completely");
                            }
                            else
                            {
                                MessageBox.Show("Update fail");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Can't edit,it already processed");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (mResultObj.Status=="0")
                {
                if (MessageBox.Show("Are you sure", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                   // bindLObj();
                    if (mMasterBLL.deleteObj("LM_Result", mResultObj, 1))
                    {
                        MessageBox.Show("Successfully deleted");
                        clearUI();

                    }
                    else
                    {
                        MessageBox.Show("Fail to deleted");
                    }
                }
                }else
                {
                    MessageBox.Show("Can't delete,it already process");
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                mResultObj = new ResultObj();
                clearUI();
                loadReference();
                setSampledata();
                setToolTip();
                saveState = true;
                controlUI(); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SetResult_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}