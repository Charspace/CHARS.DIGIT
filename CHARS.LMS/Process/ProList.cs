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

namespace CHARS.HR.PL.Process
{
    public partial class ProList : SetBase
    {
        public ProList()
        {
            InitializeComponent();
            loadReference();
            //setSampledata();
            //setToolTip();
            saveState = true;
            controlUI();
            
            //clearUI();
        }
        public ProList(long aASK)
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
        ListObj mListObj = new ListObj();
        ListToolTip mListToolTip = new ListToolTip();
        ListSample mListSample = new ListSample();
        CompetatorObj mCompetatorObj = new CompetatorObj();
        private bool saveState = true;
        private bool saveFlag = true;

        //reference 
        LuckyTypeObj mLuckyTypeObj = new LuckyTypeObj();

        #region"Private Method"
        public void bindForm(long aAsk)
        {
            try
            {
                //mListObj = new MasterObj();
                //mListObj.Ask = aAsk;
                //DataTable l_databale = new DataTable();
                //l_databale = mMasterBLL.Findby("Master", mListObj);

                //mListObj.Ask = Convert.ToInt64(l_databale.Rows[0][0]);
                //mListObj.PersonAsk = Convert.ToInt64(l_databale.Rows[0][1]);
                //mListObj.MasterCode = l_databale.Rows[0][2].ToString();
                //mListObj.MasterDescription = l_databale.Rows[0][3].ToString();
                //mListObj.MasterPhone = l_databale.Rows[0][4].ToString();
                //mListObj.MasterAddress = l_databale.Rows[0][5].ToString();
                //mListObj.MasterEmail = l_databale.Rows[0][6].ToString();
                //mListObj.MasterEmail = l_databale.Rows[0][7].ToString();
                //bindUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void loadReference()
        {
            loadLuckyType();
            loadCompetator();
            loadMainCompetator();

        }

        private void sortDisplaydgv()
        {
            dgvVote.Columns[0].DisplayIndex = 0;
            dgvVote.Columns[3].DisplayIndex = 1;
            dgvVote.Columns[1].DisplayIndex = 2;
            dgvVote.Columns[2].DisplayIndex = 3;
            dgvVote.Columns[4].DisplayIndex = 4;
            dgvVote.Columns[7].DisplayIndex = 5;
            dgvVote.Columns[5].DisplayIndex = 6;
            dgvVote.Columns[6].DisplayIndex = 7;
            
            

        }
        private void loadLuckyType()
        {
            cboLuckyType.DisplayMember = "Lucky Code";
            cboLuckyType.ValueMember = "ASK";           
            cboLuckyType.DataSource = mMasterBLL.selectDataTable("LM_LuckyType", "");
        }
        private void loadCompetator()
        {
            dgvcboCompetator.DisplayMember = "Competitor Code";
            dgvcboCompetator.ValueMember = "ASK";

            dgvcboCompetator.DataSource = mMasterBLL.selectDataTable("LM_Competitor", "");
        }
        private void loadMainCompetator()
        {
            dgvcboMainCompetator.DisplayMember = "Competitor Code";
            dgvcboMainCompetator.ValueMember = "ASK";
            dgvcboMainCompetator.DataSource = mMasterBLL.selectDataTable("LM_Competitor", "");
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
                if (txtMinAmount.TextLength == 0 || txtMinAmount.Text.Trim() == "")
                {
                    valid = mUtility.setInvalidTextbox(errorproviderbase, txtMinAmount);
                }
                else
                {
                    mUtility.setValidTextbox(errorproviderbase, txtMinAmount);
                }
                if (txtMaxamount.TextLength == 0 || txtMaxamount.Text.Trim() == "")
                {
                    valid = mUtility.setInvalidTextbox(errorproviderbase, txtMaxamount);
                }
                else
                {
                    mUtility.setValidTextbox(errorproviderbase, txtMaxamount);
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
                //if (mMasterObj.Ask == 0)
                //{
                //    mMasterObj.Ask = mUtility.getAsk();
                //}
                //mMasterObj.PersonAsk = Convert.ToInt64(cboPerson.SelectedValue);
                //mMasterObj.MasterCode = txtMasterCode.Text.Trim();
                //mMasterObj.MasterDescription = txtMasterDescription.Text.Trim();
                //mMasterObj.MasterPhone = txtMasterPhone.Text.Trim();
                //mMasterObj.MasterAddress = rtxtMasterAddress.Text.Trim();
                //mMasterObj.MasterEmail = txtMasterEmail.Text.Trim();
                //mMasterObj.MasterRemark = rtxtMasterRemark.Text.Trim();
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
                mUtility.clearTextBox(txtPrefix,txtMaxamount,txtMinAmount);               
                mUtility.clearNumberUpDown(nmcDigit);
                mUtility.clearComboBox(cboLuckyType);
                mUtility.clearLabel(lblTypeCaption);
                dgvDrawResult.Rows.Clear();
                dgvVote.Rows.Clear();
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
                //cboPerson.SelectedValue = mMasterObj.PersonAsk;
                //txtMasterCode.Text = mMasterObj.MasterCode.ToString();
                //txtMasterDescription.Text = mMasterObj.MasterDescription.ToString();
                //txtMasterPhone.Text = mMasterObj.MasterPhone.ToString();
                //txtMasterEmail.Text = mMasterObj.MasterEmail.ToString();
                //rtxtMasterAddress.Text = mMasterObj.MasterAddress.ToString();
                //rtxtMasterRemark.Text = mMasterObj.MasterRemark.ToString();
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
                //toolTipbase.SetToolTip(cboPerson, mMasterToolTip.PersonAsk);
                //toolTipbase.SetToolTip(txtMasterCode, mMasterToolTip.MasterCode);
                //toolTipbase.SetToolTip(txtMasterDescription, mMasterToolTip.MasterDescription);
                //toolTipbase.SetToolTip(txtMasterPhone, mMasterToolTip.MasterPhone);
                //toolTipbase.SetToolTip(rtxtMasterAddress, mMasterToolTip.MasterAddress);
                //toolTipbase.SetToolTip(txtMasterEmail, mMasterToolTip.MasterEmail);
                //toolTipbase.SetToolTip(rtxtMasterRemark, mMasterToolTip.MasterRemark);
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
                //mUtility.setComboBoxSampleData(cboPerson, mMasterSample.PersonAsk);
                //mUtility.setTextBoxSampleData(txtMasterCode, mMasterSample.MasterCode);
                //mUtility.setTextBoxSampleData(txtMasterDescription, mMasterSample.MasterDescription);
                //mUtility.setTextBoxSampleData(txtMasterPhone, mMasterSample.MasterPhone);
                //mUtility.setRichTextBoxSampleData(rtxtMasterAddress, mMasterSample.MasterAddress);
                //mUtility.setTextBoxSampleData(txtMasterEmail, mMasterSample.MasterEmail);
                //mUtility.setRichTextBoxSampleData(rtxtMasterRemark, mMasterSample.MasterRemark);
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
        private bool saveDraw()
        {
            bool valid = true;
            try
            {
                for (int i = 0; i < dgvDrawResult.Rows.Count-1; i++)
                {
                    if (dgvDrawResult[1,i].Value.ToString() != "" || dgvDrawResult[1,i]!= null)
                    {
                        mListObj.Ask = mUtility.getAsk();
                        mListObj.TS = "0";
                        mListObj.UD = "0";
                        mListObj.TypeAsk = Convert.ToString(cboLuckyType.SelectedValue);
                        mListObj.ListCode = dgvDrawResult[1, i].Value.ToString(); 
                        mListObj.ListDescription = dgvDrawResult[2, i].Value.ToString();
                        mListObj.MainCompetitorASK = "0";// Convert.ToInt64(cboMainCompetator.SelectedValue);
                        mListObj.CompetitorASK = "0";// Convert.ToInt64(cboCompetator.SelectedValue);
                        mListObj.MinimumAmount = Convert.ToString(txtMinAmount.Text.ToString().Trim());
                        mListObj.MaximumAmount = Convert.ToString(txtMaxamount.Text.ToString().Trim());
                        mListObj.PlusOrMinus = "0";// Convert.ToInt32(cboplusorminus.SelectedValue);
                        mListObj.NumOfGain = "0";// Convert.ToInt32(txtNumofGain.Text.ToString().Trim());
                        mListObj.GainPercent = "0";// Convert.ToDecimal(txtGainPercent.Text.ToString().Trim());
                        mListObj.TotalNumOfGain = "0";// Convert.ToInt32(txttotalnumofgain.Text.ToString().Trim());
                        mListObj.TotalPercent = "0";//
                        mListObj.TotalPlusMinus = "";//
                        mListObj.StartDate =Utility.getDateString( dtpStartDate.Value);
                        mListObj.EndDate =Utility.getDateString( dtpEndDate.Value);
                        if (!mMasterBLL.saveObj("LM_List", mListObj))
                        {
                            valid = false;
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
        private bool saveVote()
        {
            bool valid = true;
            try
            {
                string Code = "";
                for (int i = 0; i < dgvVote.Rows.Count - 1; i++)
                {
                    if ((dgvVote[0, i].Value.ToString() != "" || dgvVote[0, i] != null) &&
                    (dgvVote[4, i].Value.ToString() != "" || dgvVote[4, i] != null))
                    {
                        Code = "";
                        mListObj.Ask = mUtility.getAsk();
                        mListObj.TypeAsk = Convert.ToString(cboLuckyType.SelectedValue);
                        mCompetatorObj.Ask = Convert.ToString(dgvVote.Rows[i].Cells[0].Value);
                        mCompetatorObj = (CompetatorObj)mMasterBLL.selectObjbyAskobj("LM_Competitor", mCompetatorObj);
                        Code = mCompetatorObj.CompetatorCode;
                        //string a = (mMasterBLL.selectDataTablebyAsk("LM_Competitor", mCompetatorObj)).Rows[0][1].ToString();
                        mCompetatorObj.Ask = Convert.ToString(dgvVote.Rows[i].Cells[4].Value);
                        mCompetatorObj = (CompetatorObj)mMasterBLL.selectObjbyAskobj("LM_Competitor", mCompetatorObj);
                        Code = Code + " : " + mCompetatorObj.CompetatorCode;
                        //string b = (mMasterBLL.selectDataTablebyAsk("Competator", mCompetatorObj)).Rows[0][1].ToString();                      
                        mListObj.ListCode = Code;// a + " : " + b;
                        mListObj.ListDescription = Code;// a + " : " + b;     
                        mListObj.MainCompetitorASK = Convert.ToString(dgvVote.Rows[i].Cells[0].Value);
                        mListObj.CompetitorASK = Convert.ToString(dgvVote.Rows[i].Cells[4].Value);
                        mListObj.MinimumAmount = Convert.ToString(txtMinAmount.Text.ToString().Trim());
                        mListObj.MaximumAmount = Convert.ToString(txtMaxamount.Text.ToString().Trim());
                        if (dgvVote.Rows[i].Cells[1].Value.ToString()=="+") 
                        {
                            mListObj.PlusOrMinus = "1";
                        }
                        else if (dgvVote.Rows[i].Cells[1].Value.ToString() == "-")
                        {
                            mListObj.PlusOrMinus = "2";
                        }
                        else if (dgvVote.Rows[i].Cells[1].Value.ToString() == "=")
                        {
                            mListObj.PlusOrMinus = "3";
                        }
                        mListObj.NumOfGain = Convert.ToString(dgvVote.Rows[i].Cells[2].Value);
                        mListObj.GainPercent = Convert.ToString(dgvVote.Rows[i].Cells[3].Value);
                        mListObj.TotalNumOfGain = Convert.ToString(dgvVote.Rows[i].Cells[6].Value);
                        mListObj.TotalPercent = Convert.ToString(dgvVote.Rows[i].Cells[7].Value);
                        if (dgvVote.Rows[i].Cells[5].Value.ToString() == "+")
                        {
                            mListObj.TotalPlusMinus = "1";
                        }
                        else if (dgvVote.Rows[i].Cells[5].Value.ToString() == "-")
                        {
                            mListObj.TotalPlusMinus ="2";
                        }
                        else if (dgvVote.Rows[i].Cells[5].Value.ToString() == "=")
                        {
                            mListObj.TotalPlusMinus = "3";
                        }
                        //mListObj.TotalPlusorMinus =  //Convert.ToInt32(dgvList.Rows[i].Cells[5].Value);
                        mListObj.StartDate = Utility.getDateString( dtpStartDate.Value);
                        mListObj.EndDate = Utility.getDateString( dtpEndDate.Value);
                        if (!mMasterBLL.saveObj("LM_List", mListObj))
                        {
                            valid = false;
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
       

        private void cboLuckyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            mLuckyTypeObj.Ask = Convert.ToString(cboLuckyType.SelectedValue);
            mLuckyTypeObj = (LuckyTypeObj) mMasterBLL.selectObjbyAskobj("LM_LuckyType", mLuckyTypeObj);
            mUtility.visibleGroupBox(false, grbDraw);
            mUtility.visibleDataGridView(false, dgvDrawResult, dgvVote);

            if (mLuckyTypeObj.ResultType == "1")
            {
                //mUtility.enableGroupBox(true,grbDraw);
                mUtility.visibleGroupBox(true, grbDraw);
                mUtility.visibleDataGridView(true, dgvDrawResult);
                lblTypeCaption.Text = "Draw";
                saveFlag = true;
            }
            else
            {
                //mUtility.enableGroupBox(true, grbVote);
                mUtility.visibleGroupBox(false, grbDraw);
                mUtility.visibleDataGridView(true, dgvVote);
                lblTypeCaption.Text = "Vote";
                saveFlag = false;
            }
            


            //DataTable m = new DataTable();
            //m = mMasterBLL.selectDataTablebyAsk("LM_LuckyType", mLuckyTypeObj);
            //if (m.Rows.Count > 0)
            //{
            //    //mUtility.enableGroupBox(false, grbVote,grbDraw);
            //    mUtility.visibleGroupBox(false, grbDraw);
            //    mUtility.visibleDataGridView(false,  dgvDrawResult , dgvVote);

            //    if (m.Rows[0][4].ToString() == "1")
            //    {
            //        //mUtility.enableGroupBox(true,grbDraw);
            //        mUtility.visibleGroupBox(true, grbDraw);
            //        mUtility.visibleDataGridView(true, dgvDrawResult);
            //        lblTypeCaption.Text = "Draw";
            //        saveFlag = true;
            //    }
            //    else
            //    {
            //        //mUtility.enableGroupBox(true, grbVote);
            //        mUtility.visibleGroupBox(false, grbDraw);
            //        mUtility.visibleDataGridView(true,dgvVote);
            //        lblTypeCaption.Text = "Vote";
            //        saveFlag = false;
            //    }
            //}            
        }
        #endregion

        private void btnNew_Click(object sender, EventArgs e)
        {
            clearUI();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {            
            try
            {
                if (saveFlag)
                {
                    if (isValid())
                    {
                        if (saveDraw())
                        {
                            MessageBox.Show("Save Completely");
                        }
                    }
                }
                else
                {
                    if (isValid())
                    {
                        if (saveVote())
                        {
                            MessageBox.Show("Save Completely");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void lblDigit_Click(object sender, EventArgs e)
        {

        }

        private void nmcDigit_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnPrepare_Click(object sender, EventArgs e)
        {
            try
            {
                string L_prefix="";
                string L_count= "0";
                int L_loopCount = 0;
                int L_digit = 0;
                int L_length = 1; 
                L_prefix = txtPrefix.Text.ToString().Trim();
                L_digit = Convert.ToInt32(nmcDigit.Value);                
                L_loopCount = Convert.ToInt32(L_length + (L_count.PadLeft(L_digit , '0').Substring(0, L_digit )));
                dgvDrawResult.Rows.Clear();
                for (int i = 0; i < L_loopCount; i++)
                {                    
                    dgvDrawResult.Rows.Add();
                    dgvDrawResult[0, i].Value = i+1;
                    dgvDrawResult[1, i].Value = L_prefix + (i.ToString().PadLeft(L_digit, '0').Substring(0, L_digit));                    
                    dgvDrawResult[2, i].Value = L_prefix + i;
                }
                dgvDrawResult.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gbDrawResult_Enter(object sender, EventArgs e)
        {

        }

        private void dgvDrawResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void grbDraw_Enter(object sender, EventArgs e)
        {

        }

        private void ProList_Load(object sender, EventArgs e)
        {
            sortDisplaydgv();
        }

       

        
    }
}