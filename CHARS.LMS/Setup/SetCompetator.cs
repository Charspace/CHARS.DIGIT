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
    public partial class SetCompetator : SetBase
    {
        public SetCompetator()
        {
            InitializeComponent();
            clearUI();
            loadReference();
            //setSampledata();
            //setToolTip();
            saveState = true;
            controlUI();
        }
        public SetCompetator(string aASK)
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
        CompetatorObj mCompetatorObj = new CompetatorObj();
        CompetatorToolTip mCompetatorToolTip = new CompetatorToolTip();
        CompetatorSample mCompetatorSample = new CompetatorSample();
        private bool saveState = true;

        #region"Private Method"
        public void bindForm(string aAsk)
        {
            mCompetatorObj = new CompetatorObj();
            mCompetatorObj.Ask = aAsk;
            DataTable l_databale = new DataTable();
            //l_databale = mMasterBLL.Findby("LM_Competitor", mCompetatorObj);
            mCompetatorObj = (CompetatorObj) mMasterBLL.selectObjbyAskobj("LM_Competitor", mCompetatorObj);
            //mCompetatorObj.Ask = Convert.ToString(l_databale.Rows[0][0]);
            //mCompetatorObj.CompetatorCode = l_databale.Rows[0][1].ToString();
            //mCompetatorObj.CompetatorDescription = l_databale.Rows[0][2].ToString();
            //mCompetatorObj.CompetatorRemark = l_databale.Rows[0][3].ToString();               
            bindUI();
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
                if (txtCompetatorCode.TextLength == 0 || txtCompetatorCode.Text.Trim() == "")
                {
                    valid = mUtility.setInvalidTextbox(errorproviderbase, txtCompetatorCode);
                }
                else
                {
                    mUtility.setValidTextbox(errorproviderbase, txtCompetatorCode);
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
                if (mCompetatorObj.Ask == "")
                {
                    mCompetatorObj.Ask = mUtility.getAsk();
                }
                mCompetatorObj.CompetatorCode = txtCompetatorCode.Text.Trim();
                mCompetatorObj.CompetatorDescription = txtCompetatorDescription.Text.Trim();
                mCompetatorObj.CompetatorRemark = rtxtCompetatorRemark.Text.Trim();            
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
                mUtility.clearTextBox(txtCompetatorCode, txtCompetatorDescription);
                mUtility.clearRichTextBox(rtxtCompetatorRemark);
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
                txtCompetatorCode.Text = mCompetatorObj.CompetatorCode;
                txtCompetatorDescription.Text = mCompetatorObj.CompetatorDescription;
                rtxtCompetatorRemark.Text = mCompetatorObj.CompetatorRemark;
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
                toolTipbase.SetToolTip(txtCompetatorCode, mCompetatorToolTip.CompetatorCode);
                toolTipbase.SetToolTip(txtCompetatorDescription, mCompetatorToolTip.CompetatorDescription);
                toolTipbase.SetToolTip(rtxtCompetatorRemark, mCompetatorToolTip.CompetatorRemark);                
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
                 mUtility.setTextBoxSampleData(txtCompetatorCode, mCompetatorSample.CompetatorCode);
                 mUtility.setTextBoxSampleData(txtCompetatorDescription, mCompetatorSample.CompetatorDescription);
                 mUtility.setRichTextBoxSampleData(rtxtCompetatorRemark, mCompetatorSample.CompetatorRemark);
               
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


        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                mCompetatorObj = new CompetatorObj();
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
                        if (mMasterBLL.saveObj("LM_Competitor", mCompetatorObj))
                        {
                            MessageBox.Show("Save Completely");
                            saveState = false;
                        }
                    }
                    else
                    {
                        if (mMasterBLL.updateObj("LM_Competitor", mCompetatorObj))
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
                    if (mMasterBLL.deleteObj("LM_Competitor", mCompetatorObj, 1))
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
        private void SetCompetator_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txtCompetatorCode_Enter(object sender, EventArgs e)
        {
            mUtility.enterTextbox(txtCompetatorCode, mCompetatorSample.CompetatorCode); 
        }

        private void txtCompetatorDescription_Enter(object sender, EventArgs e)
        {
            mUtility.enterTextbox(txtCompetatorDescription, mCompetatorSample.CompetatorDescription); 
        }

        private void rtxtCompetatorRemark_Enter(object sender, EventArgs e)
        {
            mUtility.enterRichTextbox(rtxtCompetatorRemark, mCompetatorSample.CompetatorRemark);
        }
    }
}