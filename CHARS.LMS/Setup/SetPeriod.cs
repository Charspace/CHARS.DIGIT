using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHARS.HR.COMMON.PL;
using CHARS.HR.COMMON.BLL;
using CHARS.HR.BOL;
using CHARS.HR.COMMON.General;



namespace CHARS.HR.PL.Setup
{
    public partial class SetPeriod : SetBase
    {
        public SetPeriod()
        {
            InitializeComponent();
            clearUI();
            loadReference();
            //setSampledata();
           //setToolTip();
            saveState = true;
            controlUI();
        }
        public SetPeriod(string aASK)
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
        PeriodObj mPeriodObj = new PeriodObj();
        PeriodToolTip mPeriodToolTip = new PeriodToolTip();
        PeriodSample mPeriodSample = new PeriodSample();
        private bool saveState = true;

        #region"Private Method"
        public void bindForm(string aAsk)
        {
            try
            {
                mPeriodObj = new PeriodObj();
                mPeriodObj.Ask = aAsk;
                //DataTable l_databale = new DataTable();
                //l_databale = mMasterBLL.Findby("Period", mPeriodObj);
                mPeriodObj =(PeriodObj) mMasterBLL.selectObjbyAskobj("LM_Period", mPeriodObj);
                //mPeriodObj.Ask = Convert.ToString(l_databale.Rows[0][0]);
                //mPeriodObj.LuckyTypeAsk = Convert.ToString(l_databale.Rows[0][1]);
                //mPeriodObj.PeriodCode = l_databale.Rows[0][2].ToString();
                //mPeriodObj.PeriodDescription = l_databale.Rows[0][3].ToString();
                //mPeriodObj.StartDate = l_databale.Rows[0][4].ToString();
                //mPeriodObj.EndDate = l_databale.Rows[0][5].ToString();
                //mPeriodObj.PeriodRemark = l_databale.Rows[0][6].ToString();                
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
        private bool isValid()
        {
            try
            {
                bool valid = true;
                errorproviderbase.Clear();

                if (cboLuckyType.SelectedValue == null || cboLuckyType.Text.Trim() == "")
                {
                    valid = mUtility.setInvalidComboBox(errorproviderbase, cboLuckyType);
                }
                else
                {
                    mUtility.setValidComboBox(errorproviderbase, cboLuckyType);
                }
                if (txtPeriodCode.TextLength == 0 || txtPeriodCode.Text.Trim() == "")
                {
                    valid = mUtility.setInvalidTextbox(errorproviderbase, txtPeriodCode);
                }
                else
                {
                    mUtility.setValidTextbox(errorproviderbase, txtPeriodCode);
                }
                if (DateTime.Compare(dtpStartDate.Value, dtpEndDate.Value) > 0 ) 
                {
                    errorproviderbase.SetError(dtpStartDate, "Start Date must be smaller than End Date");
                    valid = false;
                    return valid;
                }
                else
                {
                    errorproviderbase.SetError(dtpStartDate, "");
                }
                if (saveState )
                {
                    if (!isValidPeriodCode())
                    {
                        errorproviderbase.SetError(txtPeriodCode, "Period Code is already exists");
                        valid = false;
                        return valid;
                    }
                    else
                    {
                        errorproviderbase.SetError(txtPeriodCode, "");
                    }
                }
                if (saveState)
                {
                    if (!isValidPeriod())
                    {
                        errorproviderbase.SetError(dtpStartDate, "Start Date is already exists");
                        errorproviderbase.SetError(dtpEndDate, "End Date is already exists");
                        valid = false;
                        return valid;
                    }
                    else
                    {
                        errorproviderbase.SetError(dtpStartDate, "");
                        errorproviderbase.SetError(dtpEndDate, "");
                    }
                }
                //if (txtPeriodPhone.TextLength == 0 || txtPeriodPhone.Text.Trim() == "")
                //{
                //    valid = mUtility.setInvalidTextbox(errorproviderbase, txtPeriodPhone);
                //}
                //else
                //{
                //    mUtility.setValidTextbox(errorproviderbase, txtPeriodPhone);
                //}
                //to add datetimepicker
                return valid;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        private void bindPeriodObj()
        {
            try
            {
                if (mPeriodObj.Ask == "")
                {
                    mPeriodObj.Ask = mUtility.getAsk();
                }
                mPeriodObj.TS = "0";
                mPeriodObj.UD = "0";               
                mPeriodObj.PeriodCode = txtPeriodCode.Text.Trim();
                mPeriodObj.PeriodDescription = txtPeriodDescription.Text.Trim();
                mPeriodObj.StartDate = Utility.getDateString(dtpStartDate.Value);// dtpStartDate.Value.ToString();
                mPeriodObj.EndDate = Utility.getDateString(dtpEndDate.Value); //tpEndDate.Value.ToString();
                mPeriodObj.LuckyTypeAsk = Convert.ToString(cboLuckyType.SelectedValue);
                mPeriodObj.PeriodRemark = rtxtPeriodRemark.Text.Trim();
                //mPeriodObj.Status = 0;
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
                mUtility.clearTextBox(txtPeriodCode, txtPeriodDescription );
                mUtility.clearRichTextBox(rtxtPeriodRemark);
                mUtility.clearComboBox(cboLuckyType);
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
                cboLuckyType.SelectedValue = mPeriodObj.LuckyTypeAsk;
                txtPeriodCode.Text = mPeriodObj.PeriodCode.ToString();
                txtPeriodDescription.Text = mPeriodObj.PeriodDescription.ToString();
                dtpStartDate.Value = Utility.getDateVale(mPeriodObj.StartDate);// mPeriodObj.StartDate.ToString();
                dtpEndDate.Value = Utility.getDateVale(mPeriodObj.EndDate);//  mPeriodObj.EndDate.ToString();                
                rtxtPeriodRemark.Text = mPeriodObj.PeriodRemark.ToString();
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
                toolTipbase.SetToolTip(cboLuckyType, mPeriodToolTip.LuckyTypeAsk);
                toolTipbase.SetToolTip(txtPeriodCode, mPeriodToolTip.PeriodCode);
                toolTipbase.SetToolTip(txtPeriodDescription, mPeriodToolTip.PeriodDescription);
                toolTipbase.SetToolTip(dtpStartDate, mPeriodToolTip.StartDate);
                toolTipbase.SetToolTip(dtpEndDate, mPeriodToolTip.EndDate);              
                toolTipbase.SetToolTip(rtxtPeriodRemark, mPeriodToolTip.PeriodRemark);
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
                mUtility.setComboBoxSampleData(cboLuckyType, mPeriodSample.LuckyTypeAsk);
                mUtility.setTextBoxSampleData(txtPeriodCode, mPeriodSample.PeriodCode);
                mUtility.setTextBoxSampleData(txtPeriodDescription, mPeriodSample.PeriodDescription);
                //mUtility.setTextBoxSampleData(txtPeriodPhone, mPeriodSample.PeriodPhone);
                //mUtility.setRichTextBoxSampleData(rtxtPeriodAddress, mPeriodSample.PeriodAddress);             
                mUtility.setRichTextBoxSampleData(rtxtPeriodRemark, mPeriodSample.PeriodRemark);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private bool isValidPeriodCode() 
        {
            try
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                mPeriodObj.PeriodDescription = txtPeriodDescription.Text.Trim();
                dic.Add("@luckyType", Convert.ToString(cboLuckyType.SelectedValue));
                dic.Add("@periodCode", txtPeriodCode.Text.Trim());                
                DataTable table = mMasterBLL.executeSelectProcedure("CS_SP_CHECK_PERIOD_CODE", dic);
                if (table.Rows.Count >= 1)
                {
                    return false;
                }
                else 
                {
                    return true;
                }
             }             
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return true;
        }

        private bool isValidPeriod()
        {
            try
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                mPeriodObj.PeriodDescription = txtPeriodDescription.Text.Trim();
                dic.Add("@luckyType", Convert.ToString(cboLuckyType.SelectedValue));
                dic.Add("@startDate", Utility.getDateString(dtpStartDate.Value));
                dic.Add("@endDate", Utility.getDateString(dtpEndDate.Value));
                DataTable table = mMasterBLL.executeSelectProcedure("CS_SP_CHECK_PERIOD", dic);
                if (table.Rows.Count >= 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return true;
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                mPeriodObj = new PeriodObj();
                clearUI();
                loadReference();
                setSampledata();
                setToolTip();
                saveState = true;
                controlUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValid())
                {
                    bindPeriodObj();
                    if (saveState)
                    {
                        if (mMasterBLL.saveObj("LM_Period", mPeriodObj))
                        {
                            MessageBox.Show("Save Completely");
                            saveState = false;
                        }
                    }
                    else
                    {
                        if (mMasterBLL.updateObj("LM_Period", mPeriodObj))
                        {
                            MessageBox.Show("update Completely");
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
                SubmitHeaderObj l_SubmitHeaderObj = new SubmitHeaderObj();
                l_SubmitHeaderObj.PeriodAsk = mPeriodObj.Ask;
                if (mPeriodObj.Status == "0" && !mMasterBLL.isExistData("LM_SubmitHeader", l_SubmitHeaderObj, 9))
                {
                    if (MessageBox.Show("Are you sure", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        bindPeriodObj();
                        if (mMasterBLL.deleteObj("LM_Period", mPeriodObj, 1))
                        {
                            MessageBox.Show("Successfully deleted");
                            clearUI();

                        }
                        else
                        {
                            MessageBox.Show("Fail to deleted");
                        }

                    }
                }

                else
                {
                    MessageBox.Show("Can't delete,it already process");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SetPeriod_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtPeriodCode_Enter(object sender, EventArgs e)
        {
            mUtility.enterTextbox(txtPeriodCode, mPeriodSample.PeriodCode); 
        }

        private void txtPeriodDescription_Enter(object sender, EventArgs e)
        {
            mUtility.enterTextbox(txtPeriodDescription, mPeriodSample.PeriodDescription); 
        }

        private void cboLuckyType_Enter(object sender, EventArgs e)
        {
            mUtility.enterComboBox(cboLuckyType, mPeriodSample.LuckyTypeAsk);
        }

        private void rtxtPeriodRemark_Enter(object sender, EventArgs e)
        {
            mUtility.enterRichTextbox(rtxtPeriodRemark, mPeriodSample.PeriodRemark);
        }

        private void dtpEndDate_Enter(object sender, EventArgs e)
        {

        }

        private void dtpStartDate_Enter(object sender, EventArgs e)
        {

        }
    }
}