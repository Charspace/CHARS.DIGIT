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
    public partial class SetMaster : SetBase
    {   
        public SetMaster()
        {
            InitializeComponent();
            clearUI();
            loadReference();
            setSampledata();
            setToolTip();
            saveState = true;
            controlUI();
        }
        public SetMaster(string aASK)
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
        MasterObj mMasterObj = new MasterObj();
        MasterToolTip mMasterToolTip = new MasterToolTip();
        MasterSample mMasterSample = new MasterSample();
        private bool saveState = true;

        //reference 
        PersonObj mPersonObj = new PersonObj();

        #region"Private Method"
        public void bindForm(string aAsk)
        {
            try
            {
                mMasterObj = new MasterObj();
                mMasterObj.Ask = aAsk;
                DataTable l_databale = new DataTable();
                l_databale = mMasterBLL.Findby("Master", mMasterObj);

                mMasterObj.Ask = Convert.ToString(l_databale.Rows[0][0]);
                mMasterObj.PersonAsk = Convert.ToString(l_databale.Rows[0][1]);
                mMasterObj.MasterCode = l_databale.Rows[0][2].ToString();
                mMasterObj.MasterDescription = l_databale.Rows[0][3].ToString();
                mMasterObj.MasterPhone = l_databale.Rows[0][4].ToString();
                //mMasterObj.MasterAddress = l_databale.Rows[0][5].ToString();
                mMasterObj.MasterEmail = l_databale.Rows[0][6].ToString();
                mMasterObj.MasterEmail = l_databale.Rows[0][7].ToString();
                bindUI();           
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void loadReference()
        {
            loadPerson();
        }
        private void loadPerson()
        {                      
            cboPerson.DisplayMember = "Person Name";
            cboPerson.ValueMember = "ASK";
            //cboCompanyName.DataSource = mPayrollCompany.PayrollList;      
            cboPerson.DataSource = mMasterBLL.selectDataTable("Person", "");
        }
        private bool isValid()
        {
            try
            {
                bool valid = true;
                errorproviderbase.Clear();
                
                if (cboPerson.SelectedValue == null || cboPerson.Text.Trim() == "")
                { 
                    valid = mUtility.setInvalidComboBox(errorproviderbase, cboPerson);
                }
                else
                {
                    mUtility.setValidComboBox(errorproviderbase, cboPerson);
                }                
                if (txtMasterCode.TextLength == 0 || txtMasterCode.Text.Trim() == "")
                {
                    valid = mUtility.setInvalidTextbox(errorproviderbase, txtMasterCode);
                }
                else
                {
                    mUtility.setValidTextbox(errorproviderbase, txtMasterCode);
                }
                if (txtMasterPhone.TextLength == 0 || txtMasterPhone.Text.Trim() == "")
                {
                    valid = mUtility.setInvalidTextbox(errorproviderbase, txtMasterPhone);
                }
                else
                {
                    mUtility.setValidTextbox(errorproviderbase, txtMasterPhone);
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
                if (mMasterObj.Ask == "0")
                {
                    mMasterObj.Ask = mUtility.getAsk();
                }
                mMasterObj.PersonAsk = Convert.ToString(cboPerson.SelectedValue);
                mMasterObj.MasterCode = txtMasterCode.Text.Trim();
                mMasterObj.MasterDescription = txtMasterDescription.Text.Trim();
                mMasterObj.MasterPhone = txtMasterPhone.Text.Trim();
               // mMasterObj.MasterAddress = rtxtMasterAddress.Text.Trim();
                mMasterObj.MasterEmail = txtMasterEmail.Text.Trim();
                mMasterObj.MasterRemark = rtxtMasterRemark.Text.Trim(); 
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
                mUtility.clearTextBox(txtMasterCode, txtMasterDescription, txtMasterPhone, txtMasterEmail);
                mUtility.clearRichTextBox(rtxtMasterAddress, rtxtMasterRemark);
                mUtility.clearComboBox(cboPerson);
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
                cboPerson.SelectedValue = mMasterObj.PersonAsk;
                txtMasterCode.Text = mMasterObj.MasterCode.ToString();                
                txtMasterDescription.Text = mMasterObj.MasterDescription.ToString();
                txtMasterPhone.Text = mMasterObj.MasterPhone.ToString();
                txtMasterEmail.Text = mMasterObj.MasterEmail.ToString();
               // rtxtMasterAddress.Text = mMasterObj.MasterAddress.ToString();
                rtxtMasterRemark.Text = mMasterObj.MasterRemark.ToString();
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
                toolTipbase.SetToolTip(cboPerson, mMasterToolTip.PersonAsk);
                toolTipbase.SetToolTip(txtMasterCode, mMasterToolTip.MasterCode);
                toolTipbase.SetToolTip(txtMasterDescription, mMasterToolTip.MasterDescription);
                toolTipbase.SetToolTip(txtMasterPhone, mMasterToolTip.MasterPhone);
                toolTipbase.SetToolTip(rtxtMasterAddress, mMasterToolTip.MasterAddress);
                toolTipbase.SetToolTip(txtMasterEmail, mMasterToolTip.MasterEmail);
                toolTipbase.SetToolTip(rtxtMasterRemark, mMasterToolTip.MasterRemark);
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
                mUtility.setComboBoxSampleData(cboPerson, mMasterSample.PersonAsk);
                mUtility.setTextBoxSampleData(txtMasterCode, mMasterSample.MasterCode);
                mUtility.setTextBoxSampleData(txtMasterDescription, mMasterSample.MasterDescription);
                mUtility.setTextBoxSampleData(txtMasterPhone, mMasterSample.MasterPhone);
                mUtility.setRichTextBoxSampleData(rtxtMasterAddress, mMasterSample.MasterAddress);
                mUtility.setTextBoxSampleData(txtMasterEmail, mMasterSample.MasterEmail);
                mUtility.setRichTextBoxSampleData(rtxtMasterRemark, mMasterSample.MasterRemark);
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
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                mMasterObj = new MasterObj();
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
                    bindLObj();
                    if (saveState)
                    {
                        if (mMasterBLL.saveObj("Master", mMasterObj))
                        {
                            MessageBox.Show("Save Completely");
                            saveState = false;
                        }
                    }
                    else
                    {
                        if (mMasterBLL.updateObj("Master", mMasterObj))
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
                if (MessageBox.Show("Are you sure", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bindLObj();                     
                    if (mMasterBLL.deleteObj("Master", mMasterObj, 1))
                    {
                        clearUI();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void SetMaster_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void cboPerson_Enter(object sender, EventArgs e)
        {
            mUtility.enterComboBox(cboPerson, mMasterSample.PersonAsk); 
        }
        private void txtMasterDescription_Enter(object sender, EventArgs e)
        {
            mUtility.enterTextbox(txtMasterDescription, mMasterSample.MasterDescription); 
        }
        private void txtMasterPhone_Enter(object sender, EventArgs e)
        {
            mUtility.enterTextbox(txtMasterPhone, mMasterSample.MasterPhone); 
        }
        private void txtMasterEmail_Enter(object sender, EventArgs e)
        {
            mUtility.enterTextbox(txtMasterEmail, mMasterSample.MasterEmail); 
        }
        private void rtxtMasterAddress_Enter(object sender, EventArgs e)
        {
            mUtility.enterRichTextbox(rtxtMasterAddress, mMasterSample.MasterAddress);
        }
        private void rtxtMasterRemark_Enter(object sender, EventArgs e)
        {
            mUtility.enterRichTextbox(rtxtMasterRemark, mMasterSample.MasterRemark);

        }
        private void txtMasterCode_Enter(object sender, EventArgs e)
        {
            mUtility.enterTextbox(txtMasterCode, mMasterSample.MasterCode);
        }
        
        #endregion

        private void cboPerson_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}