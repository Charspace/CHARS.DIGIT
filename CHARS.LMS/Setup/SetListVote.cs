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
    public partial class SetListVote : SetBase
    {
       public SetListVote()
        {
            InitializeComponent();
            clearUI();
            loadReference();
            //setSampledata();
            //setToolTip();
            saveState = true;
            controlUI();
        }
        public SetListVote(string aASK)
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
               // l_databale = mMasterBLL.Findby("LM_List", mListObj);
                mListObj = (ListObj)mMasterBLL.selectObjbyAskobj("LM_List", mListObj);

                //mListObj.Ask = Convert.ToString(l_databale.Rows[0][0]);
                //mListObj.TypeAsk = Convert.ToString(l_databale.Rows[0][1]);
                //mListObj.ListCode = l_databale.Rows[0][2].ToString();
                //mListObj.ListDescription = l_databale.Rows[0][3].ToString();
                //mListObj.MainCompetitorASK =Convert.ToString( l_databale.Rows[0][4]);
                //mListObj.CompetitorASK =Convert.ToString( l_databale.Rows[0][5]);
                //mListObj.MinimumAmount =Convert.ToString( l_databale.Rows[0][6]);
                //mListObj.MaximumAmount = Convert.ToString(l_databale.Rows[0][7]);
                //mListObj.PlusOrMinus =Convert.ToString( l_databale.Rows[0][8]);
                //mListObj.NumOfGain =Convert.ToString(  l_databale.Rows[0][9]);
                //mListObj.GainPercent = Convert.ToString(l_databale.Rows[0][10]);
                //mListObj.TotalNumOfGain =Convert.ToString(  l_databale.Rows[0][11]);
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
            loadMainCompetator();
            loadCompetator();
            loadLuckyType();
        }
        private void loadMainCompetator()
        {
            cboMainCompetator.DisplayMember = "Competitor Code";
            cboMainCompetator.ValueMember = "ASK";
            cboMainCompetator.DataSource = mMasterBLL.selectDataTable("LM_Competitor", "");

        }
       
        private void loadCompetator()
        {
            cboCompetator.DisplayMember = "Competitor Code";
            cboCompetator.ValueMember = "ASK";
            cboCompetator.DataSource = mMasterBLL.selectDataTable("LM_Competitor", "");

        }
        private void loadLuckyType()
        {
            cboLuckyType.DisplayMember = "Lucky Code";
            cboLuckyType.ValueMember = "ASK";
            cboLuckyType.DataSource = mMasterBLL.selectDataTable("LM_LuckyType", "");

        }
        private bool isValid()
        {
            try
            {
                bool valid = true;
                errorproviderbase.Clear();
                if (cboMainCompetator.SelectedValue == null || cboMainCompetator.Text.Trim() == "")
                {
                    valid = mUtility.setInvalidComboBox(errorproviderbase, cboMainCompetator);
                }
                else
                {
                    mUtility.setValidComboBox(errorproviderbase, cboMainCompetator);
                }
                if (cboCompetator.SelectedValue == null || cboCompetator.Text.Trim() == "")
                {
                    valid = mUtility.setInvalidComboBox(errorproviderbase, cboCompetator);
                }
                else
                {
                    mUtility.setValidComboBox(errorproviderbase, cboCompetator);
                } 
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
                if (mListObj.Ask == "0")
                {
                    mListObj.Ask = mUtility.getAsk();
                }
                mListObj.TypeAsk = Convert.ToString(cboLuckyType.SelectedValue);
                mListObj.ListCode = txtListCode.Text.ToString().Trim();
                mListObj.ListDescription = txtListDescription.Text.ToString().Trim();
                mListObj.MainCompetitorASK = Convert.ToString(cboMainCompetator.SelectedValue);
                mListObj.CompetitorASK = Convert.ToString(cboCompetator.SelectedValue);
                mListObj.MinimumAmount = Convert.ToString( txtMinAmount.Text.ToString().Trim());
                mListObj.MaximumAmount = Convert.ToString( txtMaxamount.Text.ToString().Trim());
                if (cboplusorminus.SelectedIndex == 0)
                {
                    mListObj.PlusOrMinus = "1";
                }
                else if (cboplusorminus.SelectedIndex ==1)
                {
                    mListObj.PlusOrMinus = "2";
                }
                else if (cboplusorminus.SelectedIndex == -1)
                {
                    mListObj.PlusOrMinus = "0";
                }               
                mListObj.NumOfGain = Convert.ToString(txtNumofGain.Text.ToString().Trim());
                mListObj.GainPercent = Convert.ToString(txtGainPercent.Text.ToString().Trim());
                mListObj.TotalNumOfGain = Convert.ToString(txtTotalGain.Text.ToString().Trim());
                mListObj.TotalPercent = txtTotalPercent.Text.Trim();
                if (cboTotalPlusMinus.SelectedIndex == 0)
                {
                    mListObj.TotalPlusMinus = "1";
                }
                else if (cboTotalPlusMinus.SelectedIndex == 1)
                {
                    mListObj.TotalPlusMinus = "2";
                }
                else
                {
                    mListObj.TotalPlusMinus = "0";
                }                
                mListObj.StartDate = Utility.getDateString( dtpStartDate.Value);
                mListObj.EndDate = Utility.getDateString(dtpEndDate.Value);
                
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
                mUtility.clearTextBox(txtListCode, txtListDescription,  txtMaxamount,txtMinAmount,txtNumofGain,txtTotalGain,txtGainPercent);
                mUtility.clearRichTextBox( rtxtListRemark);
                mUtility.clearComboBox(cboMainCompetator, cboCompetator, cboplusorminus);
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
                txtListCode.Text = mListObj.ListCode.ToString();
                txtListDescription.Text = mListObj.ListDescription.ToString();
                mLuckyTypeObj.Ask = Convert.ToString(mListObj.TypeAsk);
                //txtLuckyType.Text = ((LuckyTypeObj)mMasterBLL.selectObjbyAskobj("LM_LuckyType", mLuckyTypeObj)).LuckyTypeCode;
                cboLuckyType.SelectedValue = mListObj.TypeAsk;
                txtMaxamount.Text = mListObj.MaximumAmount.ToString();
                txtMinAmount.Text = mListObj.MinimumAmount.ToString();
                cboMainCompetator.SelectedValue = mListObj.MainCompetitorASK;
                cboCompetator.SelectedValue = mListObj.CompetitorASK;
                
                txtGainPercent.Text = mListObj.GainPercent.ToString();
                txtNumofGain.Text = mListObj.NumOfGain.ToString();
                //cboplusorminus.SelectedValue = mListObj.PlusOrMinus;
                if (mListObj.PlusOrMinus == "1")
                {
                    cboplusorminus.SelectedIndex = 0;
                }
                else if (mListObj.PlusOrMinus == "2")
                {
                    cboplusorminus.SelectedIndex =1;
                }
                else
                {
                    cboplusorminus.SelectedIndex = -1;
                }  



                txtTotalGain.Text = mListObj.TotalNumOfGain.ToString();
                txtTotalPercent.Text = mListObj.TotalPercent;
               // txtTotalplusminus.SelectedValue = mListObj.TotalPlusMinus;
                if (mListObj.TotalPlusMinus == "1")
                {
                    cboTotalPlusMinus.SelectedIndex =0;
                }
                else if (mListObj.TotalPlusMinus == "2")
                {
                    cboTotalPlusMinus.SelectedIndex = 1;
                }
                else
                {
                    cboTotalPlusMinus.SelectedIndex = -1;
                }
                dtpStartDate.Value = Utility.getDateVale(mListObj.StartDate);
                dtpEndDate.Value = Utility.getDateVale(mListObj.EndDate);
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
                //toolTipbase.SetToolTip(txtLuckyType, mListToolTip.TypeAsk);
                toolTipbase.SetToolTip(txtMaxamount, mListToolTip.MaximumAmount);
                toolTipbase.SetToolTip(txtMinAmount, mListToolTip.MinimumAmount);
                toolTipbase.SetToolTip(cboMainCompetator, mListToolTip.MaincompetatorASK);
                toolTipbase.SetToolTip(cboCompetator, mListToolTip.CompetatorASK);
                toolTipbase.SetToolTip(cboplusorminus, mListToolTip.PlusorMinus);
                toolTipbase.SetToolTip(txtTotalGain, mListToolTip.TotalNumofGain);
                toolTipbase.SetToolTip(txtGainPercent, mListToolTip.GainPercent);
                toolTipbase.SetToolTip(txtNumofGain, mListToolTip.NumofGain);
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

        private void txtNumofGain_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                mListObj = new ListObj();
                clearUI();
                loadReference();
                setSampledata();
                //setToolTip();
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
                if (MessageBox.Show("Are you sure", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bindLObj();
                    if (mMasterBLL.deleteObj("LM_List", mListObj, 1))
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

        private void rtxtListRemark_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblListRemark_Click(object sender, EventArgs e)
        {

        }
    }
}