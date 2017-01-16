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
    public partial class SetAgent : SetBase
    {
        public SetAgent()
        {
            InitializeComponent();
            clearUI();
            loadReference();
            setSampledata();
            setToolTip();
            saveState = true;
            controlUI();
        }
        public SetAgent(string aASK)
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
        AgentObj mAgentObj = new AgentObj();
        AgentToolTip mAgentToolTip = new AgentToolTip();
        AgentSample mAgentSample = new AgentSample();
        private bool saveState = true;

        //reference 
        PersonObj mPersonObj = new PersonObj();


        #region"Private Method"
        public void bindForm(string aAsk)
        {
            try
            {
                mAgentObj = new AgentObj();
                mAgentObj.Ask = aAsk;
                DataTable l_databale = new DataTable();
                l_databale = mMasterBLL.Findby("Agent", mAgentObj);

                mAgentObj.Ask = Convert.ToString(l_databale.Rows[0][0]);
                mAgentObj.PersonAsk = Convert.ToString(l_databale.Rows[0][1]);
                mAgentObj.AgentCode = l_databale.Rows[0][2].ToString();
                mAgentObj.AgentDescription = l_databale.Rows[0][3].ToString();
                mAgentObj.AgentPhone = l_databale.Rows[0][4].ToString();
               // mAgentObj.AgentAddress = l_databale.Rows[0][5].ToString();
                mAgentObj.AgentEmail = l_databale.Rows[0][6].ToString();
                mAgentObj.AgentRemark = l_databale.Rows[0][7].ToString();
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
                if (txtAgentCode.TextLength == 0 || txtAgentCode.Text.Trim() == "")
                {
                    valid = mUtility.setInvalidTextbox(errorproviderbase, txtAgentCode);
                }
                else
                {
                    mUtility.setValidTextbox(errorproviderbase, txtAgentCode);
                }
                if (txtAgentPhone.TextLength == 0 || txtAgentPhone.Text.Trim() == "")
                {
                    valid = mUtility.setInvalidTextbox(errorproviderbase, txtAgentPhone);
                }
                else
                {
                    mUtility.setValidTextbox(errorproviderbase, txtAgentPhone);
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
                if (mAgentObj.Ask == "0")
                {
                    mAgentObj.Ask = mUtility.getAsk();
                }
                mAgentObj.AgentCode = txtAgentCode.Text.Trim();
                mAgentObj.PersonAsk = Convert.ToString(cboPerson.SelectedValue);
                mAgentObj.AgentDescription = txtAgentDescription.Text.Trim();
                mAgentObj.AgentPhone = txtAgentPhone.Text.Trim();
               // mAgentObj.AgentAddress = rtxtAgentAddress.Text.Trim();
                mAgentObj.AgentEmail = txtAgentEmail.Text.Trim();
                mAgentObj.AgentRemark = rtxtAgentRemark.Text.Trim();
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
                mUtility.clearTextBox(txtAgentCode, txtAgentDescription, txtAgentPhone,txtAgentEmail);
                mUtility.clearRichTextBox(rtxtAgentAddress, rtxtAgentRemark);
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
                cboPerson.SelectedValue = mAgentObj.PersonAsk;
                txtAgentCode.Text = mAgentObj.AgentCode;
                txtAgentDescription.Text = mAgentObj.AgentDescription;
                txtAgentPhone.Text = mAgentObj.AgentPhone.ToString();
                txtAgentEmail.Text = mAgentObj.AgentEmail.ToString();
                //rtxtAgentAddress.Text = mAgentObj.AgentAddress.ToString();
                rtxtAgentRemark.Text = mAgentObj.AgentRemark.ToString();
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
                toolTipbase.SetToolTip(cboPerson, mAgentToolTip.PersonAsk);
                toolTipbase.SetToolTip(txtAgentCode, mAgentToolTip.AgentCode);
                toolTipbase.SetToolTip(txtAgentDescription, mAgentToolTip.AgentDescription);
                toolTipbase.SetToolTip(txtAgentPhone, mAgentToolTip.AgentPhone);
                toolTipbase.SetToolTip(rtxtAgentAddress, mAgentToolTip.AgentAddress);
                toolTipbase.SetToolTip(txtAgentEmail, mAgentToolTip.AgentEmail);
                toolTipbase.SetToolTip(rtxtAgentRemark, mAgentToolTip.AgentRemark);
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
                mUtility.setComboBoxSampleData(cboPerson, mAgentSample.PersonAsk);
                mUtility.setTextBoxSampleData(txtAgentCode, mAgentSample.AgentCode);
                mUtility.setTextBoxSampleData(txtAgentDescription, mAgentSample.AgentDescription);
                mUtility.setTextBoxSampleData(txtAgentPhone, mAgentSample.AgentPhone);
                mUtility.setRichTextBoxSampleData(rtxtAgentAddress, mAgentSample.AgentAddress);
                mUtility.setTextBoxSampleData(txtAgentEmail, mAgentSample.AgentEmail);
                mUtility.setRichTextBoxSampleData(rtxtAgentRemark, mAgentSample.AgentRemark);
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
                mAgentObj = new AgentObj();
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValid())
                {
                    bindLObj();
                    if (saveState)
                    {
                        if (mMasterBLL.saveObj("Agent", mAgentObj))
                        {
                            MessageBox.Show("Save Completely");
                            saveState = false;
                        }
                    }
                    else
                    {
                        if (mMasterBLL.updateObj("Agent", mAgentObj))
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
                    if (mMasterBLL.deleteObj("Agent", mAgentObj, 1))
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
        private void SetAgent_Load(object sender, EventArgs e)
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
            mUtility.enterComboBox(cboPerson, mAgentSample.PersonAsk);
        }

        private void txtAgentCode_Enter(object sender, EventArgs e)
        {
            mUtility.enterTextbox(txtAgentCode, mAgentSample.AgentCode);
        } 

        private void txtAgentDescription_Enter(object sender, EventArgs e)
        {
            mUtility.enterTextbox(txtAgentDescription, mAgentSample.AgentDescription);
        }

        private void txtAgentPhone_Enter(object sender, EventArgs e)
        {
            mUtility.enterTextbox(txtAgentPhone, mAgentSample.AgentPhone);
        }

        private void txtAgentEmail_Enter(object sender, EventArgs e)
        {
            mUtility.enterTextbox(txtAgentEmail, mAgentSample.AgentEmail);
        }

        private void rtxtAgentAddress_Enter(object sender, EventArgs e)
        {
            mUtility.enterRichTextbox(rtxtAgentAddress, mAgentSample.AgentAddress);
        }

        private void rtxtAgentRemark_Enter(object sender, EventArgs e)
        {
            mUtility.enterRichTextbox(rtxtAgentRemark, mAgentSample.AgentRemark);
        }
        #endregion

    }
}