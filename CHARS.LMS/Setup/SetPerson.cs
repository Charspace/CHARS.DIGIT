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
    public partial class SetPerson : SetBase
    {
        public SetPerson()
        {
            InitializeComponent();
            chkMaster_CheckedChanged(null, null);
            chkAgent_CheckedChanged(null, null);
            chkPlayer_CheckedChanged(null, null);
            //clearUI();
           //setSampledata();
           // setToolTip();
            saveState = true;
            controlUI();
        }
        public SetPerson(string aPerson,string aMaster, string aPlayer, string aAgent)
        {
            InitializeComponent();
            clearUI();
            //setToolTip();
            bindForm(aPerson, aMaster, aPlayer, aAgent);
            mPersonAsk = aPerson;
            mAgentAsk = aAgent;
            mMasterAsk = aMaster;
            mPlayerAsk = aPlayer;            
            saveState = false;
            controlUI();           
        }

        Utility mUtility = new Utility();
        MasterBLL mMasterBLL = new MasterBLL();
        PersonObj mPersonObj = new PersonObj();
        MasterObj mMasterObj = new MasterObj();
        PlayerObj mPlayerObj = new PlayerObj();
        AgentObj mAgengObj = new AgentObj();
        PersonSample mSamplePerson = new PersonSample();
        PersonToolTip mToolTipPerson = new PersonToolTip();
        string mPersonAsk = "";
        string mAgentAsk = "";
        string mPlayerAsk = "";
        string mMasterAsk = "";
        private bool saveState = true;

        #region"Private Method"
        public void bindForm(string aPerson, string aMaster, string aPlayer, string aAgent)
        {
            try
            {
                mPersonObj = new PersonObj();
                mPersonObj.Ask = aPerson;
                mMasterObj = new MasterObj();
                mMasterObj.Ask = aMaster;
                mPlayerObj = new PlayerObj();
                mPlayerObj.Ask = aPlayer;
                mAgengObj = new AgentObj();
                mAgengObj.Ask = aAgent;

                //DataTable l_databale = new DataTable();
                mPersonObj = (PersonObj) mMasterBLL.selectObjbyAskobj("LM_Person", mPersonObj);
                mMasterObj = (MasterObj)mMasterBLL.selectObjbyAskobj("LM_Master", mMasterObj);
                mPlayerObj = (PlayerObj)mMasterBLL.selectObjbyAskobj("LM_Player", mPlayerObj);
                mAgengObj = (AgentObj)mMasterBLL.selectObjbyAskobj("LM_Agent", mAgengObj);
                //mPersonObj.Ask = l_databale.Rows[0][0].ToString();// Convert.ToInt64(l_databale.Rows[0][0]);
                //mPersonObj.PersonName = l_databale.Rows[0][1].ToString();
                //mPersonObj.PersonNiceName = l_databale.Rows[0][2].ToString();                
                //mPersonObj.PersonAddress = l_databale.Rows[0][4].ToString();
                //mPersonObj.PersonPhone = l_databale.Rows[0][5].ToString();
                //mPersonObj.PersonEmail = l_databale.Rows[0][6].ToString();
                //mPersonObj.PersonRemark = l_databale.Rows[0][6].ToString();
                bindUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool isValid()
        {
            try
            {
                errorproviderbase.Clear();
                bool valid = true;
                if (txtPersonName.TextLength == 0 || txtPersonName.Text.Trim() == "")
                {
                    valid = mUtility.setInvalidTextbox(errorproviderbase, txtPersonName);
                }
                else
                {
                    mUtility.setValidTextbox(errorproviderbase, txtPersonName);
                }
                if (txtPersonPhone.TextLength == 0 || txtPersonPhone.Text.Trim() == "")
                {
                    valid = mUtility.setInvalidTextbox(errorproviderbase, txtPersonPhone);
                }
                else
                {
                    mUtility.setValidTextbox(errorproviderbase, txtPersonPhone);
                }
                if (txtPersonEmail.TextLength != 0 || txtPersonEmail.Text.Trim() != "")
                {
                    if (!mUtility.checkEmailFormat(txtPersonEmail)) 
                    {
                        valid = mUtility.setInvalidEmailFormat(errorproviderbase, txtPersonEmail);
                    }
                    else
                    {
                        mUtility.setValidTextbox(errorproviderbase, txtPersonEmail);
                    }
                }

                if (chkMaster.Checked) 
                {
                    if (txtMasterName.TextLength == 0 || txtMasterName.Text.Trim() == "")
                    {
                        valid = mUtility.setInvalidTextbox(errorproviderbase, txtMasterName);
                    }
                    else
                    {
                        mUtility.setValidTextbox(errorproviderbase, txtMasterName);
                    }
                    if (txtMasterPhone.TextLength == 0 || txtMasterPhone.Text.Trim() == "")
                    {
                        valid = mUtility.setInvalidTextbox(errorproviderbase, txtMasterPhone);
                    }
                    else
                    {
                        mUtility.setValidTextbox(errorproviderbase, txtMasterPhone);
                    }
                    if (txtMasterEmail.TextLength != 0 || txtMasterEmail.Text.Trim() != "")
                    {
                        if (!mUtility.checkEmailFormat(txtMasterEmail))
                        {
                            valid = mUtility.setInvalidEmailFormat(errorproviderbase, txtMasterEmail);
                        }
                        else
                        {
                            mUtility.setValidTextbox(errorproviderbase, txtMasterEmail);
                        }
                    }                    
                }
                if (chkAgent.Checked)
                {
                    if (txtAgentName.TextLength == 0 || txtAgentName.Text.Trim() == "")
                    {
                        valid = mUtility.setInvalidTextbox(errorproviderbase, txtAgentName);
                    }
                    else
                    {
                        mUtility.setValidTextbox(errorproviderbase, txtAgentName);
                    }
                    if (txtAgentPhone.TextLength == 0 || txtAgentPhone.Text.Trim() == "")
                    {
                        valid = mUtility.setInvalidTextbox(errorproviderbase, txtAgentPhone);
                    }
                    else
                    {
                        mUtility.setValidTextbox(errorproviderbase, txtAgentPhone);
                    }
                    if (txtAgentEmail.TextLength != 0 || txtAgentEmail.Text.Trim() != "")
                    {
                        if (!mUtility.checkEmailFormat(txtAgentEmail))
                        {
                            valid = mUtility.setInvalidEmailFormat(errorproviderbase, txtAgentEmail);
                        }
                        else
                        {
                            mUtility.setValidTextbox(errorproviderbase, txtAgentEmail);
                        }
                    }                    
                }
                if (chkPlayer.Checked)
                {
                    if (txtPlayerName.TextLength == 0 || txtPlayerName.Text.Trim() == "")
                    {
                        valid = mUtility.setInvalidTextbox(errorproviderbase, txtPlayerName);
                    }
                    else
                    {
                        mUtility.setValidTextbox(errorproviderbase, txtPlayerName);
                    }
                    if (txtPlayerPhone.TextLength == 0 || txtPlayerPhone.Text.Trim() == "")
                    {
                        valid = mUtility.setInvalidTextbox(errorproviderbase, txtPlayerPhone);
                    }
                    else
                    {
                        mUtility.setValidTextbox(errorproviderbase, txtPlayerPhone);
                    }
                    if (txtPlayerEmail.TextLength != 0 || txtPlayerEmail.Text.Trim() != "")
                    {
                        if (!mUtility.checkEmailFormat(txtAgentEmail))
                        {
                            valid = mUtility.setInvalidEmailFormat(errorproviderbase, txtPlayerEmail);
                        }
                        else
                        {
                            mUtility.setValidTextbox(errorproviderbase, txtPlayerEmail);
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
        private void bindPersonObj()
        {      
            try
            {
                if (mPersonObj.Ask.ToString() == "")
                {
                    mPersonAsk = mUtility.getAsk();
                }
                //else
                //{
                //    mPersonObj.Ask = mPersonAsk;
                //}
                mPersonObj.Ask = mPersonAsk;
                mPersonObj.TS = "1";
                mPersonObj.UD = "0";
                mPersonObj.PersonName = txtPersonName.Text.Trim();
                mPersonObj.PersonNiceName = txtPersonNiceName.Text.Trim();                
                mPersonObj.PersonAddress = rtxtPrsonAddress.Text.Trim();
                mPersonObj.PersonPhone = txtPersonPhone.Text.Trim();
                mPersonObj.PersonEmail = txtPersonEmail.Text.Trim();
                mPersonObj.PersonRemark = rtxtPersonRemark.Text.Trim();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void bindMasterObj()
        {
            try
            {
                if (mMasterObj.Ask.ToString() == "")
                {
                    //mMasterObj.Ask = mUtility.getAsk();
                    mMasterAsk = mUtility.getAsk();
                }
                //else
                //{
                //    mMasterObj.Ask = mMasterAsk;
                //}
                mMasterObj.Ask = mMasterAsk;
                mMasterObj.TS = "1";
                mMasterObj.UD = "0";
                mMasterObj.PersonAsk = mPersonAsk;// mPersonObj.Ask;
                mMasterObj.MasterCode = txtMasterName.Text.Trim();
                mMasterObj.MasterDescription = txtMasterName.Text.Trim();
                mMasterObj.MasterPhone = txtMasterPhone.Text.Trim();

                mMasterObj.MasterEmail = txtMasterEmail.Text.Trim();
                mMasterObj.MasterRemark = "";// txtPersonEmail.Text.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void bindPlayerObj()
        {
            try
            {
                if (mPlayerObj.Ask.ToString() == "")
                {
                    //mPlayerObj.Ask = mUtility.getAsk();
                    mPlayerAsk = mUtility.getAsk();
                }
                //else
                //{
                //    mPlayerObj.Ask = mPlayerAsk;
                //}
                mPlayerObj.Ask = mPlayerAsk;
                mPlayerObj.TS = "1";
                mPlayerObj.UD = "0";
                mPlayerObj.PersonAsk = mPersonAsk;// mPersonObj.Ask;
                mPlayerObj.PlayerCode = txtPlayerName.Text.Trim();
                mPlayerObj.PlayerDescription = txtPlayerName.Text.Trim();
                mPlayerObj.PlayerPhone = txtPlayerPhone.Text.Trim();
                mPlayerObj.PlayerEmail = txtPlayerEmail.Text.Trim();
                mPlayerObj.PlayerRemark = "";// txtp.Text.Trim();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void bindAgentObj()
        {
            try
            {
                if (mAgengObj.Ask.ToString() == "")
                {
                    //mAgengObj.Ask = mUtility.getAsk();
                    mAgentAsk = mUtility.getAsk();
                }
                //else
                //{
                //    mAgengObj.Ask = mAgentAsk;
                //}
                mAgengObj.Ask = mAgentAsk;
                mAgengObj.TS = "1";
                mAgengObj.UD = "0";
                mAgengObj.PersonAsk = mPersonAsk;// mPersonObj.Ask;
                mAgengObj.AgentCode = txtAgentName.Text.Trim();
                mAgengObj.AgentDescription =  txtAgentName.Text.Trim();
                mAgengObj.AgentPhone = txtAgentPhone.Text.Trim();
                mAgengObj.AgentEmail = txtAgentEmail.Text.Trim();
                mAgengObj.AgentComission = nmcComission.Value.ToString();
                mAgengObj.AgentRemark = txtPersonEmail.Text.Trim();               
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
                mUtility.clearTextBox(txtPersonName, txtPersonNiceName, txtPersonPhone, txtPersonEmail, txtMasterName, txtMasterPhone
                    ,txtMasterEmail,txtAgentName,txtAgentPhone,txtAgentEmail,txtPlayerName,txtPlayerPhone
                    ,txtPlayerEmail);
                nmcComission.Value = 0;
                mUtility.clearRichTextBox(rtxtPrsonAddress, rtxtPersonRemark);
                mUtility.setValidTextboxs(errorproviderbase, txtPersonName, txtPersonPhone, txtPersonEmail); 
                chkMaster.Checked = false;
                chkAgent.Checked = false;
                chkPlayer.Checked = false;
                chkMaster_CheckedChanged(null, null);
                chkAgent_CheckedChanged(null, null);
                chkPlayer_CheckedChanged(null, null);
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
                toolTipbase.SetToolTip(txtPersonName, mToolTipPerson.PersonName);
                toolTipbase.SetToolTip(txtPersonNiceName, mToolTipPerson.PersonNiceName);
                toolTipbase.SetToolTip(rtxtPrsonAddress, mToolTipPerson.PersonAddress);
                toolTipbase.SetToolTip(txtPersonPhone, mToolTipPerson.PersonPhone);
                toolTipbase.SetToolTip(txtPersonEmail, mToolTipPerson.PersonEmail);
                toolTipbase.SetToolTip(rtxtPersonRemark, mToolTipPerson.PersonRemark);
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
                //mUtility.setTextBoxSampleData(txtPersonName, mSamplePerson.PersonName);
                //mUtility.setTextBoxSampleData(txtPersonNiceName, mSamplePerson.PersonNiceName);
                //mUtility.setRichTextBoxSampleData(rtxtPrsonAddress, mSamplePerson.PersonAddress);
                //mUtility.setTextBoxSampleData(txtPersonPhone, mSamplePerson.PersonPhone);
                //mUtility.setTextBoxSampleData(txtPersonEmail, mSamplePerson.PersonEmail);
                //mUtility.setRichTextBoxSampleData(rtxtPersonRemark, mSamplePerson.PersonRemark);
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
                txtPersonName.Text = mPersonObj.PersonName;
                txtPersonNiceName.Text = mPersonObj.PersonNiceName;
                rtxtPrsonAddress.Text = mPersonObj.PersonAddress.ToString();
                txtPersonPhone.Text = mPersonObj.PersonPhone.ToString();
                txtPersonEmail.Text = mPersonObj.PersonEmail.ToString();
                rtxtPersonRemark.Text = mPersonObj.PersonRemark.ToString();

                txtMasterName.Text = mMasterObj.MasterCode;
                txtMasterPhone.Text = mMasterObj.MasterPhone;
                txtMasterEmail.Text = mMasterObj.MasterEmail;

                txtPlayerName.Text = mPlayerObj.PlayerCode;
                txtPlayerPhone.Text = mPlayerObj.PlayerPhone;
                txtPlayerEmail.Text = mPlayerObj.PlayerEmail;

                txtAgentName.Text = mAgengObj.AgentCode;
                txtAgentPhone.Text = mAgengObj.AgentPhone;
                txtAgentEmail.Text = mAgengObj.AgentEmail;
                nmcComission.Value = Convert.ToDecimal(mAgengObj.AgentComission);
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

        #region"Private Event"
        private void SetPerson_Load(object sender, EventArgs e)
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
                mPersonObj = new PersonObj();
                clearUI();
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
                    bool success = true;
                    if (saveState)
                    {
                        bindPersonObj();
                        success = mMasterBLL.saveObj("LM_Person", mPersonObj);
                    }
                    else 
                    {
                        bindPersonObj();
                        success = mMasterBLL.updateObj("LM_Person", mPersonObj);
                    }
                    if (!success) 
                    {
                        MessageBox.Show("Save Fail on Person");
                        return;
                    }
                    if (chkMaster.Checked)
                    {
                       if (mMasterObj.Ask.ToString() == "")
                       {
                           bindMasterObj();
                           success = mMasterBLL.saveObj("LM_Master", mMasterObj);
                       }
                       else 
                       {
                           bindMasterObj();
                           success = mMasterBLL.updateObj("LM_Master", mMasterObj);
                       }
                       if(!success) 
                       {
                           MessageBox.Show("Save Fail on Master");
                           return;
                       }
                    }
                    if (chkAgent.Checked)
                    {
                        if (mAgengObj.Ask.ToString() == "")
                        {
                            bindAgentObj();
                            success = mMasterBLL.saveObj("LM_Agent", mAgengObj);
                        }
                        else
                        {
                            bindAgentObj();
                            success = mMasterBLL.updateObj("LM_Agent", mAgengObj);
                        }
                        if (!success)
                        {
                            MessageBox.Show("Save fail on Agent");
                            return;
                        }
                    }
                    if (chkPlayer.Checked)
                    {
                        if (mPlayerObj.Ask.ToString() == "")
                        {
                            bindPlayerObj();
                            success = mMasterBLL.saveObj("LM_Player", mPlayerObj);
                        }
                        else
                        {
                            bindPlayerObj();
                            success = mMasterBLL.updateObj("LM_Player", mPlayerObj);
                        }
                        if (!success)
                        {
                            MessageBox.Show("Save fail on player");
                            return;
                        }
                    }
                    if (saveState)
                    {
                        MessageBox.Show("Save Completely");
                    }
                    else 
                    {
                        MessageBox.Show("update Completely");
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
                l_SubmitHeaderObj.AgentAsk = mAgengObj.Ask;
                l_SubmitHeaderObj.PlayerAsk = mPlayerObj.Ask;
                l_SubmitHeaderObj.MasterAsk = mMasterObj.Ask;
                if (!mMasterBLL.isExistData("LM_SubmitHeader", l_SubmitHeaderObj, 6) &&
                    !mMasterBLL.isExistData("LM_SubmitHeader", l_SubmitHeaderObj, 7) &&
                    !mMasterBLL.isExistData("LM_SubmitHeader", l_SubmitHeaderObj, 8))
                {
                if (MessageBox.Show("Are you sure", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bindPersonObj();
                    if (mMasterBLL.deleteObj("LM_Person", mPersonObj, 1))
                    {
                        if (mAgengObj.Ask != "")
                        {
                            mMasterBLL.deleteObj("LM_Agent", mAgengObj, 1);
                        }
                        if (mPlayerObj.Ask != "")
                        {
                            mMasterBLL.deleteObj("LM_Player", mPlayerObj, 1);
                        }
                        if (mMasterObj.Ask != "")
                        {
                            mMasterBLL.deleteObj("LM_Master", mMasterObj, 1);
                        }
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
        private void txtPersonName_Enter(object sender, EventArgs e)
        { 
            mUtility.enterTextbox( txtPersonName,mSamplePerson.PersonName);                
        }
        private void txtPersonPhone_Enter(object sender, EventArgs e)
        {            
            mUtility.enterTextbox( txtPersonPhone, mSamplePerson.PersonPhone);
        }
        private void txtPersonEmail_Enter(object sender, EventArgs e)
        {
           mUtility.enterTextbox( txtPersonEmail, mSamplePerson.PersonEmail);
        }       
        private void rtxtPrsonAddress_Enter(object sender, EventArgs e)
        {
            mUtility.enterRichTextbox( rtxtPrsonAddress, mSamplePerson.PersonAddress);
        }
        private void txtPersonNiceName_Enter(object sender, EventArgs e)
        {
            mUtility.enterTextbox(txtPersonNiceName, mSamplePerson.PersonNiceName);
        }
        private void rtxtPersonRemark_Enter(object sender, EventArgs e)
        {
            mUtility.enterRichTextbox(rtxtPersonRemark, mSamplePerson.PersonRemark);
        }
        #endregion

        private void txtPersonName_TextChanged(object sender, EventArgs e)
        {
            txtAgentName.Text = txtPersonName.Text;
            txtMasterName.Text = txtPersonName.Text;
            txtPlayerName.Text = txtPersonName.Text;
        }

        private void txtPersonNiceName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPersonPhone_TextChanged(object sender, EventArgs e)
        {
            txtPlayerPhone.Text = txtPersonPhone.Text;
            txtAgentPhone.Text = txtPersonPhone.Text;
            txtMasterPhone.Text = txtPersonPhone.Text;
        }

        private void rtxtPrsonAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPersonEmail_TextChanged(object sender, EventArgs e)
        {
            txtAgentEmail.Text = txtPersonEmail.Text;
            txtPlayerEmail.Text = txtPersonEmail.Text;
            txtMasterEmail.Text = txtPersonEmail.Text;
        }

        private void rtxtPersonRemark_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAgentRemark_Click(object sender, EventArgs e)
        {

        }

        private void lblPersonAddress_Click(object sender, EventArgs e)
        {

        }

        private void lblAgentEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblAgentAddress_Click(object sender, EventArgs e)
        {

        }

        private void lblPersonName1_Click(object sender, EventArgs e)
        {

        }

        private void lblPersonName_Click(object sender, EventArgs e)
        {

        }

        private void grbEntryData_Enter(object sender, EventArgs e)
        {

        }

        private void grbEntry_Enter(object sender, EventArgs e)
        {

        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }

        private void grbControl_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void chkMaster_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkMaster.Checked)
            {
                grbMaster.Enabled = false;
                mUtility.setValidTextboxs(errorproviderbase, txtMasterName, txtMasterPhone, txtMasterEmail);                
            }
            else
            {
                grbMaster.Enabled = true;
            }
        }

        private void chkAgent_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkAgent.Checked)
            {
                grbAgent.Enabled = false;
                mUtility.setValidTextboxs(errorproviderbase, txtAgentName, txtAgentPhone, txtAgentEmail);
            }
            else
            {
                grbAgent.Enabled = true;
            }
        }

        private void chkPlayer_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkPlayer.Checked)
            {
                grbPlayer.Enabled = false;
                mUtility.setValidTextboxs(errorproviderbase, txtPlayerName, txtPlayerPhone, txtPlayerEmail);
            }
            else
            {
                grbPlayer.Enabled = true;
            }
        }

        private void txtPersonPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
           e.Handled = mUtility.checkNumber(e, txtPersonPhone);
        }

        private void txtMasterPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = mUtility.checkNumber(e, txtMasterPhone);
        }

        private void txtAgentPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = mUtility.checkNumber(e, txtAgentPhone);
        }

        private void txtPlayerPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = mUtility.checkNumber(e, txtPlayerPhone);
        }

    }
}