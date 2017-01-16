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
    public partial class SetList : SetBase
    {
        public SetList()
        {
            InitializeComponent();
            clearUI();
            loadReference();
            //setSampledata();
            //setToolTip();
            saveState = true;
            controlUI();
        }
        public SetList(string aASK)
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
        ListObj mListObj = new ListObj();       
        ListToolTip mListToolTip = new ListToolTip();
        ListSample mListSample = new ListSample();
        LuckyTypeObj mLuckyTypeObj = new LuckyTypeObj();
        private bool saveState = true;       

        #region"Private Method"
        public void bindForm(string aAsk)
        {
            try
            {
                mListObj = new ListObj();
                mListObj.Ask = aAsk;
                //DataTable l_databale = new DataTable();
                mListObj = (ListObj)mMasterBLL.selectObjbyAskobj("LM_List", mListObj);

                //mListObj.Ask = Convert.ToString(l_databale.Rows[0][0]);
                //mListObj.TypeAsk = Convert.ToString(l_databale.Rows[0][1]);
                //mListObj.ListCode = l_databale.Rows[0][2].ToString();
                //mListObj.ListDescription = l_databale.Rows[0][3].ToString();
                //mListObj.MainCompetitorASK = Convert.ToString(l_databale.Rows[0][4]);
                //mListObj.CompetitorASK = Convert.ToString(l_databale.Rows[0][5]);
                //mListObj.MinimumAmount = Convert.ToString(l_databale.Rows[0][6]);
                //mListObj.MaximumAmount = Convert.ToString(l_databale.Rows[0][7]);
                //mListObj.PlusOrMinus = Convert.ToString(l_databale.Rows[0][8]);
                //mListObj.NumOfGain = Convert.ToString(l_databale.Rows[0][9]);
                //mListObj.GainPercent = Convert.ToString(l_databale.Rows[0][10]);
                //mListObj.TotalNumOfGain = Convert.ToString(l_databale.Rows[0][11]);
                //mListObj.StartDate = l_databale.Rows[0][12].ToString();
                //mListObj.EndDate = l_databale.Rows[0][13].ToString();    
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
            cboLuckyType.DataSource = mMasterBLL.selectDataTable("LM_LuckyType", "");

        }
        //private void loadPerson()
        //{
        //    cboPerson.DisplayMember = "Person Name";
        //    cboPerson.ValueMember = "ASK";
        //    //cboCompanyName.DataSource = mPayrollCompany.PayrollList;      
        //    cboPerson.DataSource = mMasterBLL.selectDataTable("Person", "");
        //}
        private bool isValid()
        {
            try
            {
                bool valid = true;
                errorproviderbase.Clear();

                if (txtListCode.TextLength == 0 || txtListCode.Text.Trim() == "")
                {
                    valid = mUtility.setInvalidTextbox(errorproviderbase, txtListCode);
                }
                else
                {
                    mUtility.setValidTextbox(errorproviderbase, txtListCode);
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
                if (mListObj.Ask == "")
                {
                    mListObj.Ask = mUtility.getAsk().ToString();
                }
                mListObj.TypeAsk = Convert.ToString(cboLuckyType.SelectedValue);
                mListObj.ListCode = txtListCode.Text.ToString().Trim();
                mListObj.ListDescription = txtListDescription.Text.ToString().Trim();                
                mListObj.MinimumAmount = Convert.ToString(txtMinAmount.Text.ToString().Trim());
                mListObj.MaximumAmount = Convert.ToString(txtMaxamount.Text.ToString().Trim());                
                mListObj.StartDate =Utility.getDateString( dtpStartDate.Value);
                mListObj.EndDate = Utility.getDateString( dtpEndDate.Value);
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
                mUtility.clearTextBox(txtListCode, txtListDescription,  txtMaxamount,txtMinAmount);
                mUtility.clearRichTextBox( rtxtListRemark);
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
                cboLuckyType.SelectedValue = mListObj.TypeAsk;
                txtListCode.Text = mListObj.ListCode.ToString();
                txtListDescription.Text = mListObj.ListDescription.ToString();
                mLuckyTypeObj.Ask = Convert.ToString(mListObj.TypeAsk);
                //DataTable m = new DataTable();
                //m = mMasterBLL.selectDataTablebyAsk("LuckyType", mLuckyTypeObj);
                //txtLuckyType.Text = ((LuckyTypeObj)mMasterBLL.selectObjbyAskobj("LM_LuckyType", mLuckyTypeObj)).LuckyTypeCode;
                txtMaxamount.Text = mListObj.MaximumAmount.ToString();
                txtMinAmount.Text = mListObj.MinimumAmount.ToString();
                dtpStartDate.Value =Utility.getDateVale( mListObj.StartDate);
                dtpEndDate.Value =Utility.getDateVale( mListObj.EndDate);
                //rtxtListRemark.Text = mListObj.re.ToString();
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
                toolTipbase.SetToolTip(txtListCode, mListToolTip.ListCode);
                toolTipbase.SetToolTip(txtListDescription, mListToolTip.ListDescription);
                toolTipbase.SetToolTip(txtMaxamount, mListToolTip.MaximumAmount);
                toolTipbase.SetToolTip(txtMinAmount, mListToolTip.MinimumAmount);                
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
                //mUtility.setTextBoxSampleData(txtMasterCode, mListSample.MasterCode);
                //mUtility.setTextBoxSampleData(txtMasterDescription, mListSample.MasterDescription);
                //mUtility.setTextBoxSampleData(txtMasterPhone, mListSample.MasterPhone);
                //mUtility.setRichTextBoxSampleData(rtxtMasterAddress, mListSample.MasterAddress);
                //mUtility.setTextBoxSampleData(txtMasterEmail, mListSample.MasterEmail);
                //mUtility.setRichTextBoxSampleData(rtxtListRemark, mListSample.MasterRemark);
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
                    bindLObj();
                    if (saveState)
                    {
                        if (mMasterBLL.saveObj("LM_List", mListObj))
                        {
                            MessageBox.Show("Save Completely");
                            saveState = false;
                        }
                    }
                    else
                    {
                        if (mMasterBLL.updateObj("LM_List", mListObj))
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
                SubmitDetailObj l_SubmitDetailObj = new SubmitDetailObj();
                l_SubmitDetailObj.List = mListObj.Ask;
                if (!mMasterBLL.isExistData("LM_SubmitDetail", l_SubmitDetailObj, 5))
                {

                    if (MessageBox.Show("Are you sure", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        bindLObj();
                        if (mMasterBLL.deleteObj("LM_List", mListObj, 1))
                        {
                            clearUI();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Can't delete. It is already used");
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
                mListObj = new ListObj();
                clearUI();
                loadReference();
                setSampledata();
               // setToolTip();
                saveState = true;
                controlUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



    }
}