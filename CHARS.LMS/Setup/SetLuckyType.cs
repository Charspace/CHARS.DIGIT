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
using CHARS.HR.COMMON;
using CHARS.HR.BOL;


namespace CHARS.HR.PL.Setup
{
    public partial class SetLuckyType : SetBase
    {
        public SetLuckyType()
        {
            InitializeComponent();
            clearUI();
            loadReference();          
            saveState = true;
            controlUI();
        }
        public SetLuckyType(long aASK)
        {
            InitializeComponent();
            clearUI();
            loadReference();
            setToolTip();
            bindForm(aASK);
            saveState = false;
            controlUI();
        }

        Utility mUtility = new Utility();
        MasterBLL mMasterBLL = new MasterBLL();        
        LuckyTypeObj mLuckyTypeObj = new LuckyTypeObj ();
        LuckyTypeToolTip mLuckyTypeToolTip = new LuckyTypeToolTip();
        LuckyTypeSample mLuckyTypeSample = new LuckyTypeSample();

        private bool saveState = true;
       


        #region"Private Method"
        public void bindForm(long aAsk)
        {
            try
            {
                mLuckyTypeObj = new LuckyTypeObj();
                mLuckyTypeObj.Ask = Convert.ToString( aAsk);
                //DataTable l_databale = new DataTable();
                //l_databale = mMasterBLL.Findby("LM_LuckyType", mLuckyTypeObj);

                mLuckyTypeObj = (LuckyTypeObj)mMasterBLL.selectObjbyObj("LM_LuckyType", mLuckyTypeObj);               

                //mLuckyTypeObj.Ask = mLuckyTypeObj.Ask;
                //mLuckyTypeObj.LuckyTypeCode = mLuckyTypeObj.LuckyTypeCode;
                //mLuckyTypeObj.LuckyTypeDescription = mLuckyTypeObj.LuckyTypeDescription;
                //mLuckyTypeObj.NumberofPass = mLuckyTypeObj.NumberofPass;
                //mLuckyTypeObj.ResultType = mLuckyTypeObj.ResultType;
                //mLuckyTypeObj.CommissionType = mLuckyTypeObj.CommissionType;
                //mLuckyTypeObj.Commission = mLuckyTypeObj.Commission;
                //mLuckyTypeObj.PassType = mLuckyTypeObj.PassType;
                //mLuckyTypeObj.Pass = mLuckyTypeObj.Pass;

                bindUI();
            }           
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void loadReference()
        {
            
        }       
        private bool isValid()
        {
            try
            {
                bool valid = true;
                errorproviderbase.Clear();
                if (txtTypeCode.TextLength == 0 || txtTypeCode.Text.Trim() == "")
                {
                    valid = mUtility.setInvalidTextbox(errorproviderbase, txtTypeCode);
                }
                else
                {
                    mUtility.setValidTextbox(errorproviderbase, txtTypeCode);
                }
                if (txtNumofPass.TextLength == 0 || txtNumofPass.Text.Trim() == "")
                {
                    valid = mUtility.setInvalidTextbox(errorproviderbase, txtNumofPass);
                }
                else
                {
                    mUtility.setValidTextbox(errorproviderbase, txtNumofPass);
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
                if (mLuckyTypeObj.Ask == "")
                {
                    mLuckyTypeObj.Ask = Convert.ToString( mUtility.getAsk());
                }
                mLuckyTypeObj.TS = ApplicationMember.mUserLevel;
                mLuckyTypeObj.UD = ApplicationMember.mLoginUserAsk;  //ApplicationMember.mLoginID;
               
                mLuckyTypeObj.LuckyTypeCode = txtTypeCode.Text.Trim();
                mLuckyTypeObj.LuckyTypeDescription = txtTypeDescription.Text.Trim();
                if (txtNumofPass.Text != "")
                {
                mLuckyTypeObj.NumberofPass = Convert.ToString(txtNumofPass.Text.Trim());
                }

                if (rdoTypeDraw.Checked)
                {
                mLuckyTypeObj.ResultType = "1";
                }
                else
                {
                mLuckyTypeObj.ResultType = "0";
                }


                if (rdoComissionTime.Checked)
                {
                    mLuckyTypeObj.CommissionType = "1";
                }
                else
                {
                    mLuckyTypeObj.CommissionType = "0";
                }
                mLuckyTypeObj.Commission = Convert.ToString(nmcComission.Value);

                if (rdoPassTimes.Checked)
                {
                    mLuckyTypeObj.PassType = "1";
                }
                else
                {
                    mLuckyTypeObj.PassType = "0";
                }
                mLuckyTypeObj.Pass = Convert.ToString(nmcPass.Value.ToString());
                mLuckyTypeObj.Remark = txtRemark.Text.Trim();
             }        
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void clearUI()
        {
            mUtility.clearTextBox(txtTypeCode, txtTypeDescription, txtNumofPass, txtRemark);
            mUtility.clearLabel(lblComissionType, lblPassType);
            mUtility.clearNumberUpDown(nmcPass, nmcComission);            
            mUtility.checkRadioButton(true, rdoTypeDraw, rdoComissionTime, rdoPassTimes);
            lblComissionType.Text = "Times";
            lblPassType.Text = "Times";            
        }
        private void bindUI()
        {
            txtTypeCode.Text = mLuckyTypeObj.LuckyTypeCode;
            txtTypeDescription.Text = mLuckyTypeObj.LuckyTypeDescription;
            txtNumofPass.Text = mLuckyTypeObj.NumberofPass.ToString();
            if (mLuckyTypeObj.ResultType == "1")
            {
                rdoTypeDraw.Checked = true;
            }
            else
            {
                rdoTypeVote.Checked = true;
            }

            if (mLuckyTypeObj.PassType =="1")
            {
                rdoPassTimes.Checked = true;
            }
            else
            {
                rdoPassPercent.Checked = true;
            }
            nmcPass.Value =Convert.ToDecimal( mLuckyTypeObj.Pass);

            if (mLuckyTypeObj.CommissionType =="1")
            {
                rdoComissionTime.Checked = true;
            }
            else
            {
                rdoComissionPercent.Checked = true;
            }
            nmcComission.Value =Convert.ToDecimal( mLuckyTypeObj.Commission);
            txtRemark.Text = mLuckyTypeObj.Remark;

        }
        private void setToolTip()
        {
            try
            {
                toolTipbase.SetToolTip(txtTypeCode, mLuckyTypeToolTip.LuckyTypeCode);
                toolTipbase.SetToolTip(txtTypeDescription, mLuckyTypeToolTip.LuckyTypeDescription);
                toolTipbase.SetToolTip(txtNumofPass, mLuckyTypeToolTip.NumberofPass);
                toolTipbase.SetToolTip(rdoTypeDraw, mLuckyTypeToolTip.ResultType);
                toolTipbase.SetToolTip(rdoTypeVote, mLuckyTypeToolTip.ResultType);
                toolTipbase.SetToolTip(nmcComission, mLuckyTypeToolTip.Commission);
                toolTipbase.SetToolTip(nmcPass, mLuckyTypeToolTip.Pass);               
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
                mUtility.setTextBoxSampleData(txtTypeCode, mLuckyTypeSample.LuckyTypeCode);
                mUtility.setTextBoxSampleData(txtTypeDescription, mLuckyTypeSample.LuckyTypeDescription);
                mUtility.setTextBoxSampleData(txtNumofPass, mLuckyTypeSample.NumberofPass);
                //mUtility.setRichTextBoxSampleData(rtxtMasterAddress, mLuckyTypeSample.MasterAddress);
                //mUtility.setTextBoxSampleData(txtMasterEmail, mLuckyTypeSample.MasterEmail);
                //mUtility.setRichTextBoxSampleData(rtxtMasterRemark, mLuckyTypeSample.MasterRemark);
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
                    //mUtility.enableButton(false, btnDelete);
                    mUtility.visibleButton(false, btnDelete);
                }
                else
                {
                    //mUtility.enableButton(true, btnDelete);
                    mUtility.visibleButton(true, btnDelete);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
        #endregion        


        #region"Private Method"
        private void SetLuckyType_Load(object sender, EventArgs e)
        {
            try
            {
                
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
                mLuckyTypeObj = new LuckyTypeObj();
                clearUI();
                loadReference();                
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
                    bindLObj();
                    if (saveState)
                    {
                        if (mMasterBLL.saveObj("LM_LuckyType", mLuckyTypeObj))
                        {
                            MessageBox.Show("Save Completely");
                            saveState = false;
                        }
                    }
                    else
                    {
                        if (mMasterBLL.updateObj("LM_LuckyType", mLuckyTypeObj))
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
                ListObj l_List = new ListObj();
                l_List.TypeAsk = mLuckyTypeObj.Ask;
                if (!mMasterBLL.isExistData("LM_List",l_List,4))
                {
                    if (MessageBox.Show("Are you sure", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        bindLObj();
                        if (mMasterBLL.deleteObj("LM_LuckyType", mLuckyTypeObj, 1))
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
        #endregion

               
        private void rdoComissionTime_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoComissionTime.Checked)
            {
                lblComissionType.Text = "Times";
            }
            else 
            {
                lblComissionType.Text = "Percent";
            }
        }
        private void rdoPassTimes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPassTimes.Checked)
            {
                lblPassType.Text = "Times";
            }
            else
            {
                lblPassType.Text = "Percent";
            }
        }

        private void txtTypeCode_Enter(object sender, EventArgs e)
        {
            mUtility.enterTextbox(txtTypeCode, mLuckyTypeSample.LuckyTypeCode); 
        }

        private void txtTypeDescription_Enter(object sender, EventArgs e)
        {
            mUtility.enterTextbox(txtTypeDescription, mLuckyTypeSample.LuckyTypeDescription); 
        }

        private void txtNumofPass_Enter(object sender, EventArgs e)
        {
            mUtility.enterTextbox(txtNumofPass, mLuckyTypeSample.NumberofPass); 
        }

        private void txtNumofPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = mUtility.checkNumber(e, txtNumofPass);
        }

      

        
       

    }
}