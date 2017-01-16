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
    public partial class SetPlayer : SetBase
    {
        public SetPlayer()
        {
            InitializeComponent();
            clearUI();
            loadReference();
            //setSampledata();
            //setToolTip();
            saveState = true;
            controlUI();
        }
        public SetPlayer(string aASK)
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
        PlayerObj mPlayerObj = new PlayerObj();
        PlayerSample mPlayerSample = new PlayerSample();
        PlayerToolTip mPlayerToolTip = new PlayerToolTip();
        private bool saveState = true;

        //reference 
        PersonObj mPersonObj = new PersonObj();

        #region"Private Method"
        public void bindForm(string aAsk)
        {
            try
            {
                mPlayerObj = new PlayerObj();
                mPlayerObj.Ask = aAsk;
                DataTable l_databale = new DataTable();
                l_databale = mMasterBLL.Findby("Player", mPlayerObj);

                mPlayerObj.Ask = Convert.ToString(l_databale.Rows[0][0]);
                mPlayerObj.PersonAsk = Convert.ToString(l_databale.Rows[0][1]);
                mPlayerObj.PlayerCode = l_databale.Rows[0][2].ToString();
                mPlayerObj.PlayerDescription = l_databale.Rows[0][3].ToString();
                mPlayerObj.PlayerPhone = l_databale.Rows[0][4].ToString();
                //mPlayerObj.PlayerAddress = l_databale.Rows[0][5].ToString();
                mPlayerObj.PlayerEmail = l_databale.Rows[0][6].ToString();
                mPlayerObj.PlayerRemark = l_databale.Rows[0][7].ToString();
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
                if (txtPlayerCode.TextLength == 0 || txtPlayerCode.Text.Trim() == "")
                {
                    valid = mUtility.setInvalidTextbox(errorproviderbase, txtPlayerCode);
                }
                else
                {
                    mUtility.setValidTextbox(errorproviderbase, txtPlayerCode);
                }
                if (txtPlayerPhone.TextLength == 0 || txtPlayerPhone.Text.Trim() == "")
                {
                    valid = mUtility.setInvalidTextbox(errorproviderbase, txtPlayerPhone);
                }
                else
                {
                    mUtility.setValidTextbox(errorproviderbase, txtPlayerPhone);
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
                if (mPlayerObj.Ask =="0")
                {
                    mPlayerObj.Ask = mUtility.getAsk();
                }
                mPlayerObj.PersonAsk = Convert.ToString(cboPerson.SelectedValue);
                mPlayerObj.PlayerCode = txtPlayerCode.Text.Trim();                
                mPlayerObj.PlayerDescription = txtPlayerDescription.Text.Trim();
                mPlayerObj.PlayerPhone = txtPlayerPhone.Text.Trim();
                //mPlayerObj.PlayerAddress = rtxtPlayerAddress.Text.Trim();
                mPlayerObj.PlayerEmail = txtPlayerEmail.Text.Trim();
                mPlayerObj.PlayerRemark = rtxtPlayerRemark.Text.Trim();
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
                mUtility.clearTextBox(txtPlayerCode, txtPlayerDescription, txtPlayerPhone,txtPlayerEmail);
                mUtility.clearRichTextBox(rtxtPlayerAddress, rtxtPlayerRemark);
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
                cboPerson.SelectedValue = mPlayerObj.PersonAsk;
                txtPlayerCode.Text = mPlayerObj.PlayerCode;
                txtPlayerDescription.Text = mPlayerObj.PlayerDescription;
                txtPlayerPhone.Text = mPlayerObj.PlayerPhone.ToString();
                txtPlayerEmail.Text = mPlayerObj.PlayerEmail.ToString();
                //rtxtPlayerAddress.Text = mPlayerObj.PlayerAddress.ToString();
                rtxtPlayerRemark.Text = mPlayerObj.PlayerRemark.ToString();
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
                toolTipbase.SetToolTip(cboPerson, mPlayerToolTip.PersonAsk);
                toolTipbase.SetToolTip(txtPlayerCode, mPlayerToolTip.PlayerCode);
                toolTipbase.SetToolTip(txtPlayerDescription, mPlayerToolTip.PlayerDescription);
                toolTipbase.SetToolTip(txtPlayerPhone, mPlayerToolTip.PlayerPhone);
                toolTipbase.SetToolTip(rtxtPlayerAddress, mPlayerToolTip.PlayerAddress);
                toolTipbase.SetToolTip(txtPlayerEmail, mPlayerToolTip.PlayerEmail);
                toolTipbase.SetToolTip(rtxtPlayerRemark, mPlayerToolTip.PlayerRemark);
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
                mUtility.setComboBoxSampleData(cboPerson, mPlayerSample.PersonAsk);
                mUtility.setTextBoxSampleData(txtPlayerCode, mPlayerSample.PlayerCode);
                mUtility.setTextBoxSampleData(txtPlayerDescription, mPlayerSample.PlayerDescription);
                mUtility.setTextBoxSampleData(txtPlayerPhone, mPlayerSample.PlayerPhone);
                mUtility.setRichTextBoxSampleData(rtxtPlayerAddress, mPlayerSample.PlayerAddress);
                mUtility.setTextBoxSampleData(txtPlayerEmail, mPlayerSample.PlayerEmail);
                mUtility.setRichTextBoxSampleData(rtxtPlayerRemark, mPlayerSample.PlayerRemark);
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
                mPlayerObj = new PlayerObj();
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
                        if (mMasterBLL.saveObj("Player", mPlayerObj))
                        {
                            MessageBox.Show("Save Completely");
                            saveState = false;
                        }
                    }
                    else
                    {
                        if (mMasterBLL.updateObj("Player", mPlayerObj))
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
                    if (mMasterBLL.deleteObj("Player", mPlayerObj, 1))
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

        private void SetPlayer_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }





        #endregion

        private void cboPerson_Enter(object sender, EventArgs e)
        {
            mUtility.enterComboBox(cboPerson, mPlayerSample.PersonAsk);
        }

        private void txtPlayerCode_Enter(object sender, EventArgs e)
        {
            mUtility.enterTextbox(txtPlayerCode, mPlayerSample.PlayerCode); 
        }

        private void txtPlayerDescription_Enter(object sender, EventArgs e)
        {
            mUtility.enterTextbox(txtPlayerDescription, mPlayerSample.PlayerDescription); 
        } 

        private void txtPlayerPhone_Enter(object sender, EventArgs e)
        {
             mUtility.enterTextbox(txtPlayerPhone, mPlayerSample.PlayerPhone); 
        }

        private void txtPlayerEmail_Enter(object sender, EventArgs e)
        {
            mUtility.enterTextbox(txtPlayerEmail, mPlayerSample.PlayerEmail); 
        }

        private void rtxtPlayerAddress_Enter(object sender, EventArgs e)
        {
            mUtility.enterRichTextbox(rtxtPlayerAddress, mPlayerSample.PlayerAddress);
        }

        private void rtxtPlayerRemark_Enter(object sender, EventArgs e)
        {
            mUtility.enterRichTextbox(rtxtPlayerRemark, mPlayerSample.PlayerRemark);
        }
    }
}