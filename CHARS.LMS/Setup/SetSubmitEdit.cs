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
    public partial class SetSubmitEdit : SetBase
    {
        public SetSubmitEdit()
        {
            InitializeComponent();
            loadReference();
            //setSampledata();
            //setToolTip();
            saveState = true;
            controlUI();
            clearUI();
        }
        public SetSubmitEdit(string aASK)
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
        SubmitHeaderObj mSubmitHeaderObj = new SubmitHeaderObj();
        SubmitHeaderSample mSubmitHeaderSample = new SubmitHeaderSample();
        SubmitHeaderToolTip mSubmitHeaderToolTip = new SubmitHeaderToolTip();

        SubmitDetailObj mSubmitDetailObj = new SubmitDetailObj();
        SubmitDetailSample mSubmitDetailSample = new SubmitDetailSample();
        SubmitDetailToolTip mSubmitDetailToolTip = new SubmitDetailToolTip();

        LuckyTypeObj mLuckyTypeObj = new LuckyTypeObj();
        PeriodObj mPeriodObj = new PeriodObj();
        ListObj mListObj = new ListObj();
        CompetatorObj mCompetatorObj = new CompetatorObj();
        DataTable mdt = new DataTable();
        
        decimal total = 0;
        int count = 0;
        decimal comm = 0;

        private bool saveState = true;
        private bool saveFlag = true;
        #region"Private Method"
        public void bindForm(string aAsk)
        {
            try
            {
                mSubmitHeaderObj = new SubmitHeaderObj();
                mSubmitHeaderObj.Ask = aAsk;
                mSubmitHeaderObj = (SubmitHeaderObj)mMasterBLL.selectObjbyAskobj("LM_SubmitHeader", mSubmitHeaderObj);
                bindUI();

                mSubmitDetailObj.HeaderAsk = aAsk;
                dgvDraw.DataSource = mMasterBLL.selectDtlbyAsk("LM_SubmitDetail", mSubmitDetailObj, 4);
                //dgvDraw.DataSource = mMasterBLL.selectDataTablebyIndex("LM_SubmitDetail", mSubmitDetailObj, 4);
                //sequenceGridviewcolumn();

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
                if (cboLuckyType.SelectedIndex == -1)
                {
                    valid = mUtility.setInvalidComboBox(errorproviderbase, cboLuckyType);
                }
                else
                {
                    mUtility.setValidComboBox(errorproviderbase, cboLuckyType);
                }
                if (cboPeriod.SelectedIndex == -1)
                {
                    valid = mUtility.setInvalidComboBox(errorproviderbase, cboPeriod);
                }
                else
                {
                    mUtility.setValidComboBox(errorproviderbase, cboPeriod);
                }
                if (cboMaster.SelectedIndex == -1)
                {
                    valid = mUtility.setInvalidComboBox(errorproviderbase, cboMaster);
                }
                else
                {
                    mUtility.setInvalidComboBox(errorproviderbase, cboMaster);
                }
                if (cboAgent.SelectedIndex == -1)
                {
                    valid = mUtility.setInvalidComboBox(errorproviderbase, cboAgent);
                }
                else
                {
                    mUtility.setValidComboBox(errorproviderbase, cboAgent);
                }
                if (cboPlayer.SelectedIndex == -1)
                {
                    valid = mUtility.setInvalidComboBox(errorproviderbase, cboPlayer);
                }
                else
                {
                    mUtility.setValidComboBox(errorproviderbase, cboPlayer);
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
                //if (mSubmitHeaderObj.Ask == 0)
                //{
                //    mSubmitHeaderObj.Ask = mUtility.getAsk();
                //}
                //mSubmitHeaderObj.PersonName = txtPersonName.Text.Trim();
                //mSubmitHeaderObj.PersonNiceName = txtPersonNiceName.Text.Trim();                
                //mSubmitHeaderObj.PersonAddress = rtxtPrsonAddress.Text.Trim();
                //mSubmitHeaderObj.PersonPhone = txtPersonPhone.Text.Trim();
                //mSubmitHeaderObj.PersonEmail = txtPersonEmail.Text.Trim();
                //mSubmitHeaderObj.PersonRemark = rtxtPersonRemark.Text.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void loadReference()
        {
            loadPlayer();
            loadAgent();
            loadPeriod();
            loadLuckyType();
            loadMaster();
            loadList();
            cboOperator.SelectedIndex = 0;
        }

        private void loadPlayer()
        {
            cboPlayer.DisplayMember = "Player Code";
            cboPlayer.ValueMember = "ASK";
            DataTable playerTbl = mMasterBLL.selectDataTable("LM_Player", "");
            cboPlayer.DataSource = playerTbl;
            cboPlayer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboPlayer.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboPlayer.AutoCompleteCustomSource.AddRange(mUtility.getAutoCompleList(playerTbl, "Player Code"));
        }
        private void loadAgent()
        {
            cboAgent.DisplayMember = "Agent Code";
            cboAgent.ValueMember = "ASK";
            DataTable agentTbl = mMasterBLL.selectDataTable("LM_Agent", "");
            cboAgent.DataSource = agentTbl;
            cboAgent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboAgent.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboAgent.AutoCompleteCustomSource.AddRange(mUtility.getAutoCompleList(agentTbl, "Agent Code"));
        }
        private void loadMaster()
        {
            cboMaster.DisplayMember = "Master Code";
            cboMaster.ValueMember = "ASK";
            DataTable masterTbl = mMasterBLL.selectDataTable("LM_Master", "");
            cboMaster.DataSource = masterTbl;
            cboMaster.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboMaster.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboMaster.AutoCompleteCustomSource.AddRange(mUtility.getAutoCompleList(masterTbl, "Master Code"));
        }
        private void loadPeriod()
        {
            cboPeriod.DisplayMember = "Period Code";
            cboPeriod.ValueMember = "ASK";
            DataTable periodTbl = mMasterBLL.selectDataTable("LM_Period", "");
            cboPeriod.DataSource = periodTbl;
            cboPeriod.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboPeriod.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboPeriod.AutoCompleteCustomSource.AddRange(mUtility.getAutoCompleList(periodTbl, "Period Code"));
        }
        private void loadLuckyType()
        {
            cboLuckyType.DisplayMember = "Lucky Code";
            cboLuckyType.ValueMember = "ASK";
            DataTable luckyTypeTbl = mMasterBLL.selectDataTable("LM_Luckytype", "");
            cboLuckyType.DataSource = luckyTypeTbl;
            cboLuckyType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboLuckyType.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cboLuckyType.AutoCompleteCustomSource.AddRange(mUtility.getAutoCompleList(luckyTypeTbl, "Lucky Code"));
        }
        private void loadList()
        {
            //dgvcbodraw.DisplayMember = "List Code";
            //dgvcbodraw.ValueMember = "ASK";
            //dgvcbodraw.DataSource = mMasterBLL.selectDataTable("LM_List", "");
        }
        private void clearUI()
        {
            try
            {
                mUtility.clearTextBox(txtList, txtAmount);
                //mUtility.clearComboBox(cboAgent, cboLuckyType, cboPeriod, cboPlayer,cboOperator); 
                mUtility.clearComboBox(cboAgent, cboLuckyType, cboPlayer, cboOperator, cboMaster, cboPeriod);
                //dgvDraw.Rows.Clear();
                //dgvVote.Rows.Clear();
                mUtility.setValidComboBox(errorproviderbase, cboPeriod);
                mUtility.setValidComboBox(errorproviderbase, cboLuckyType);
                mUtility.setValidComboBox(errorproviderbase, cboPlayer);
                mUtility.setValidComboBox(errorproviderbase, cboOperator);
                mUtility.setValidComboBox(errorproviderbase, cboMaster);
                mUtility.setValidComboBox(errorproviderbase, cboPeriod);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool saveHeader()
        {
            bool valid = true;
            try
            {

                mSubmitHeaderObj.Ask = mUtility.getAsk();
                mSubmitHeaderObj.TS = "0";
                mSubmitHeaderObj.UD = "0";

                mSubmitHeaderObj.SubmitCode = Convert.ToString(mUtility.getAsk());
                mSubmitHeaderObj.SubmitDescription = mSubmitHeaderObj.SubmitCode;// Convert.ToString(mUtility.getAsk());
                mSubmitHeaderObj.PlayerAsk = Convert.ToString(cboPlayer.SelectedValue);
                mSubmitHeaderObj.AgentAsk = Convert.ToString(cboAgent.SelectedValue);
                mSubmitHeaderObj.MasterAsk = Convert.ToString(cboMaster.SelectedValue);
                mSubmitHeaderObj.PeriodAsk = Convert.ToString(cboPeriod.SelectedValue);
                mSubmitHeaderObj.SubmitDate = Utility.getDateString(dtpSubmitdate.Value);
                mSubmitHeaderObj.Status = "1";
                mSubmitHeaderObj.Total = total.ToString();
                mSubmitHeaderObj.Comm = comm.ToString();
                mSubmitHeaderObj.LuckyTypeAsk = Convert.ToString(cboLuckyType.SelectedValue);
                if (!mMasterBLL.saveObj("LM_SubmitHeader", mSubmitHeaderObj))
                {
                    valid = false;
                    lblHeader.Text = mSubmitHeaderObj.SubmitCode;
                }
                return valid;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        private bool saveDetail()
        {
            bool valid = true;
            try
            {
                if (saveFlag)
                {
                    if (!saveDraw())
                    {
                        valid = false;
                    }
                }
                else
                {
                    if (!saveVote())
                    {
                        valid = false;
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
        private bool saveDraw()
        {
            bool valid = true;
            try
            {
                for (int i = 0; i <= dgvDraw.Rows.Count - 1; i++)
                {
                    if (dgvDraw[1, i].Value.ToString() != "" || dgvDraw[1, i] != null)
                    {
                        if (dgvDraw[0, i] != null && dgvDraw[0, i].Value.ToString() != "")
                        {
                            mSubmitDetailObj.Ask = mUtility.getAsk();
                            mSubmitDetailObj.TS = "0";
                            mSubmitDetailObj.UD = "0";
                            mSubmitDetailObj.HeaderAsk = mSubmitHeaderObj.Ask;
                            mSubmitDetailObj.List = dgvDraw[0, i].Value.ToString();
                            mSubmitDetailObj.Amount = dgvDraw[18, i].Value.ToString();
                            mSubmitDetailObj.Status = "0";
                            mSubmitDetailObj.Confirm = "0";
                            mSubmitDetailObj.VoteType = "1";
                            if (!mMasterBLL.saveObj("LM_SubmitDetail", mSubmitDetailObj))
                            {
                                valid = false;
                            }
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
                for (int i = 0; i < dgvVote.Rows.Count - 1; i++)
                {
                    if (dgvVote[15, i].Value.ToString() != "" || dgvDraw[0, i] != null)//check valid list
                    {
                        #region "Body"
                        if (dgvVote[2, i].Value != null)
                        {
                            if (dgvVote[2, i].Value.ToString() != "")//body
                            {
                                mSubmitDetailObj = new SubmitDetailObj();
                                mSubmitDetailObj.Ask = mUtility.getAsk();
                                mSubmitDetailObj.HeaderAsk = mSubmitHeaderObj.Ask;
                                mSubmitDetailObj.List = Convert.ToString(dgvVote[9, i].Value);
                                mSubmitDetailObj.Confirm = "0";
                                mSubmitDetailObj.Amount = Convert.ToString(dgvVote[2, i].Value);
                                mSubmitDetailObj.VoteType = LuckyMasterEnum.VoteeType.Body.ToString();
                                if (dgvVote[0, i].Value != null)
                                {
                                    if (dgvVote[0, i].Value.ToString() == "1")//main competator check
                                    {
                                        mSubmitDetailObj.Status = (string)LuckyMasterEnum.VoteeState.MainCompetator.ToString();
                                    }
                                }
                                if (dgvVote[1, i].Value != null)
                                {
                                    if (dgvVote[1, i].Value.ToString() == "1") //second competator check
                                    {
                                        mSubmitDetailObj.Status = LuckyMasterEnum.VoteeState.SecondCompetator.ToString();
                                    }
                                }
                                if (!mMasterBLL.saveObj("SubmitDetail", mSubmitDetailObj))
                                {
                                    valid = false;
                                }
                            }
                        }
                        #endregion
                        #region"Go Total"
                        if (dgvVote[3, i].Value != null)
                        {
                            if (dgvVote[3, i].Value.ToString() != "")//Go-total
                            {
                                mSubmitDetailObj = new SubmitDetailObj();
                                mSubmitDetailObj.Ask = mUtility.getAsk();
                                mSubmitDetailObj.HeaderAsk = mSubmitHeaderObj.Ask;
                                mSubmitDetailObj.List = Convert.ToString(dgvVote[8, i].Value);
                                mSubmitDetailObj.Confirm = "0";
                                mSubmitDetailObj.Amount = Convert.ToString(dgvVote[3, i].Value);
                                mSubmitDetailObj.VoteType = LuckyMasterEnum.VoteeType.GoTotal.ToString();
                                if (dgvVote[4, i].Value != null)
                                {
                                    if (dgvVote[4, i].Value.ToString() == "+")//up
                                    {
                                        mSubmitDetailObj.Status = LuckyMasterEnum.VoteeState.GoTotalUp.ToString();
                                    }
                                    else if (dgvVote[4, i].Value.ToString() == "-" && dgvVote[4, i].Value != null) //down
                                    {
                                        mSubmitDetailObj.Status = LuckyMasterEnum.VoteeState.GoTotalDown.ToString();
                                    }
                                    if (!mMasterBLL.saveObj("SubmitDetail", mSubmitDetailObj))
                                    {
                                        valid = false;
                                    }
                                }
                            }
                        }
                        #endregion
                        #region"Maung"
                        if (dgvVote[6, i].Value != null)
                        {
                            if (dgvVote[6, i].Value.ToString() != "")//maung type body
                            {
                                mSubmitDetailObj = new SubmitDetailObj();
                                mSubmitDetailObj.Ask = mUtility.getAsk();
                                mSubmitDetailObj.HeaderAsk = mSubmitHeaderObj.Ask;
                                mSubmitDetailObj.List = Convert.ToString(dgvVote[8, i].Value);
                                mSubmitDetailObj.Confirm = "0";
                                mSubmitDetailObj.Amount = Convert.ToString(dgvVote[6, i].Value);
                                mSubmitDetailObj.VoteType = LuckyMasterEnum.VoteeType.Maung.ToString();

                                #region "maung type body"
                                if (dgvVote[5, i].Value != null)
                                {
                                    if (dgvVote[5, i].Value.ToString() == "1")
                                    {
                                        if (dgvVote[0, i].Value != null)
                                        {
                                            if (dgvVote[0, i].Value.ToString() == "1")//main competator check
                                            {
                                                mSubmitDetailObj.Status = LuckyMasterEnum.VoteeState.MainCompetator.ToString();
                                            }
                                        }
                                        if (dgvVote[1, i].Value != null)
                                        {
                                            if (dgvVote[1, i].Value.ToString() == "1") //second competator check
                                            {
                                                mSubmitDetailObj.Status = LuckyMasterEnum.VoteeState.SecondCompetator.ToString();
                                            }
                                        }
                                        if (!mMasterBLL.saveObj("SubmitDetail", mSubmitDetailObj))
                                        {
                                            valid = false;
                                        }
                                    }
                                }
                                #endregion

                                #region "manung type go total"
                                if (dgvVote[7, i].Value != null)
                                {
                                    if (dgvVote[7, i].Value.ToString() == "1")
                                    {
                                        if (dgvVote[4, i].Value != null)
                                        {
                                            if (dgvVote[4, i].Value.ToString() == "+")//up
                                            {
                                                mSubmitDetailObj.Status = LuckyMasterEnum.VoteeState.GoTotalUp.ToString();
                                            }
                                            else if (dgvVote[4, i].Value.ToString() == "-" && dgvVote[4, i].Value != null) //down
                                            {
                                                mSubmitDetailObj.Status = LuckyMasterEnum.VoteeState.GoTotalDown.ToString();
                                            }
                                            if (!mMasterBLL.saveObj("SubmitDetail", mSubmitDetailObj))
                                            {
                                                valid = false;
                                            }
                                        }
                                    }
                                }
                                #endregion

                            }
                        }
                        #endregion
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

        private void setToolTip()
        {
            try
            {
                toolTipbase.SetToolTip(cboPlayer, mSubmitHeaderToolTip.PlayerAsk);
                toolTipbase.SetToolTip(cboAgent, mSubmitHeaderToolTip.AgentAsk);
                toolTipbase.SetToolTip(cboMaster, mSubmitHeaderToolTip.MasterAsk);
                toolTipbase.SetToolTip(cboPeriod, mSubmitHeaderToolTip.PeriodAsk);
                toolTipbase.SetToolTip(dtpSubmitdate, mSubmitHeaderToolTip.SubmitDate);

                //Tootl tip for darw data grid view
                //toolTipbase.SetToolTip(dgvtxtAmount, mSubmitDetailToolTip.Amount);

                //Tootl tip for vote data grid view

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
                //mUtility.setTextBoxSampleData(txtPersonName, mSubmitHeaderSample.PersonName);
                //mUtility.setTextBoxSampleData(txtPersonNiceName, mSubmitHeaderSample.PersonNiceName);
                //mUtility.setRichTextBoxSampleData(rtxtPrsonAddress, mSubmitHeaderSample.PersonAddress);
                //mUtility.setTextBoxSampleData(txtPersonPhone, mSubmitHeaderSample.PersonPhone);
                //mUtility.setTextBoxSampleData(txtPersonEmail, mSubmitHeaderSample.PersonEmail);
                //mUtility.setRichTextBoxSampleData(rtxtPersonRemark, mSubmitHeaderSample.PersonRemark);
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
                cboPlayer.SelectedValue = mSubmitHeaderObj.PlayerAsk;
                cboAgent.SelectedValue = mSubmitHeaderObj.AgentAsk;
                cboMaster.SelectedValue = mSubmitHeaderObj.MasterAsk;
                cboPeriod.SelectedValue = mSubmitHeaderObj.PeriodAsk;
                cboLuckyType.SelectedValue = mSubmitHeaderObj.LuckyTypeAsk;
                dtpSubmitdate.Value = Utility.getDateVale(mSubmitHeaderObj.SubmitDate);// onvert.ToDateTime(mSubmitHeaderObj.SubmitDate);


                #region "Submit Detail"

                #region ""
                #endregion

                #region ""
                #endregion



                #endregion
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
        private void sequenceGridviewcolumn()
        {
            if (this.dgvVote.Columns.Count > 7)
            {
                this.dgvVote.Columns[0].Visible = false;
                this.dgvVote.Columns[1].Visible = false;
                this.dgvVote.Columns[2].Visible = false;
                this.dgvVote.Columns[3].Visible = false;
                this.dgvVote.Columns[4].Visible = false;
                this.dgvVote.Columns[5].Visible = false;
                this.dgvVote.Columns[6].Visible = false;
                this.dgvVote.Columns[7].Visible = false;
                this.dgvVote.Columns[8].Visible = false;
                this.dgvVote.Columns[9].Visible = false;
                this.dgvVote.Columns[10].Visible = false;
                this.dgvVote.Columns[11].Visible = false;
                this.dgvVote.Columns[12].Visible = false;
                this.dgvVote.Columns[13].Visible = false;
                this.dgvVote.Columns[14].Visible = false;
                this.dgvVote.Columns[15].Visible = false;
                this.dgvVote.Columns[16].Visible = false;
                this.dgvVote.Columns[17].Visible = false;
                this.dgvVote.Columns[18].Visible = false;
                this.dgvVote.Columns[19].Visible = false;
                this.dgvVote.Columns[20].Visible = false;
                this.dgvVote.Columns[21].Visible = false;
                this.dgvVote.Columns[22].Visible = false;
                this.dgvVote.Columns[23].Visible = false;
                this.dgvVote.Columns[24].Visible = false;
                this.dgvVote.Columns[25].Visible = false;


                //Visible
                this.dgvVote.Columns[0].Visible = true;
                this.dgvVote.Columns[1].Visible = true;
                this.dgvVote.Columns[2].Visible = true;
                this.dgvVote.Columns[3].Visible = true;
                this.dgvVote.Columns[4].Visible = true;
                this.dgvVote.Columns[5].Visible = true;
                this.dgvVote.Columns[6].Visible = true;
                this.dgvVote.Columns[7].Visible = true;
                this.dgvVote.Columns[12].Visible = true;
                this.dgvVote.Columns[14].Visible = true;
                this.dgvVote.Columns[15].Visible = true;
                this.dgvVote.Columns[18].Visible = true;
                this.dgvVote.Columns[19].Visible = true;
                this.dgvVote.Columns[20].Visible = true;
                this.dgvVote.Columns[21].Visible = true;
                this.dgvVote.Columns[22].Visible = true;
                this.dgvVote.Columns[23].Visible = true;
                //this.dgvVote.Columns[24].Visible = true;
                //this.dgvVote.Columns[25].Visible = true;


                ////Visible
                //this.dgvVote.Columns[12].Visible = true;
                //this.dgvVote.Columns[0].Visible = true;
                //this.dgvVote.Columns[17].Visible = true;
                //this.dgvVote.Columns[16].Visible = true;
                //this.dgvVote.Columns[18].Visible = true;
                //this.dgvVote.Columns[1].Visible = true;
                //this.dgvVote.Columns[13].Visible = true;
                //this.dgvVote.Columns[18].Visible = true;
                //this.dgvVote.Columns[19].Visible = true;
                //this.dgvVote.Columns[20].Visible = true;
                //this.dgvVote.Columns[21].Visible = true;
                //this.dgvVote.Columns[4].Visible = true;
                //this.dgvVote.Columns[3].Visible = true;
                //this.dgvVote.Columns[5].Visible = true;
                //this.dgvVote.Columns[6].Visible = true;
                //this.dgvVote.Columns[2].Visible = true;
                //this.dgvVote.Columns[7].Visible = true;

                //Display
                //body
                this.dgvVote.Columns[14].DisplayIndex = 0;//main competator
                this.dgvVote.Columns[0].DisplayIndex = 1; //main check
                this.dgvVote.Columns[19].DisplayIndex = 2; //go               
                this.dgvVote.Columns[20].DisplayIndex = 3; //  percent
                this.dgvVote.Columns[18].DisplayIndex = 4; //up/dwon 
                this.dgvVote.Columns[2].DisplayIndex = 5; //body amount
                this.dgvVote.Columns[1].DisplayIndex = 6; //sec check
                this.dgvVote.Columns[15].DisplayIndex = 7; //competaotr  
                //Go Total
                this.dgvVote.Columns[12].DisplayIndex = 8;//List Code
                this.dgvVote.Columns[21].DisplayIndex = 9; //total go
                this.dgvVote.Columns[22].DisplayIndex = 10; //total go percent 
                this.dgvVote.Columns[23].DisplayIndex = 11; //total go up/down
                this.dgvVote.Columns[4].DisplayIndex = 12; //up down debate
                this.dgvVote.Columns[3].DisplayIndex = 13; //total amount
                //maung 
                this.dgvVote.Columns[7].DisplayIndex = 14; //body
                this.dgvVote.Columns[5].DisplayIndex = 15; //total go                 
                this.dgvVote.Columns[6].DisplayIndex = 16; //maung amount

                //hearder 
                //body
                this.dgvVote.Columns[14].HeaderText = "Class";//main competator
                this.dgvVote.Columns[0].HeaderText = "?"; //main check
                this.dgvVote.Columns[19].HeaderText = "Go"; //go               
                this.dgvVote.Columns[20].HeaderText = "%"; //  percent
                this.dgvVote.Columns[18].HeaderText = "+/-"; //up/dwon 
                this.dgvVote.Columns[2].HeaderText = "Body"; //body amount
                this.dgvVote.Columns[1].HeaderText = "?"; //sec check
                this.dgvVote.Columns[15].HeaderText = "Class"; //competaotr  
                //Go Total
                this.dgvVote.Columns[12].HeaderText = "Class";//List Code
                this.dgvVote.Columns[21].HeaderText = "Go";//total go
                this.dgvVote.Columns[22].HeaderText = "%";  //total go percent 
                this.dgvVote.Columns[23].HeaderText = "+/-";//total go up/down
                this.dgvVote.Columns[4].HeaderText = "=/-";  //up down debate
                this.dgvVote.Columns[3].HeaderText = "Go-T";  //total amount
                //maung 
                this.dgvVote.Columns[7].HeaderText = "Body";//body
                this.dgvVote.Columns[5].HeaderText = "MG"; //total go                 
                this.dgvVote.Columns[6].HeaderText = "MG-AMT";  //maung amount


                ////width
                //body
                this.dgvVote.Columns[14].Width = 100;//main competator
                this.dgvVote.Columns[0].Width = 30; //main check
                this.dgvVote.Columns[19].Width = 30; //go               
                this.dgvVote.Columns[20].Width = 30;//  percent
                this.dgvVote.Columns[18].Width = 30; //up/dwon 
                this.dgvVote.Columns[2].Width = 100; //body amount
                this.dgvVote.Columns[1].Width = 30; //sec check
                this.dgvVote.Columns[15].Width = 100; //competaotr  
                //Go Total
                this.dgvVote.Columns[12].Width = 100;//List Code
                this.dgvVote.Columns[21].Width = 30;//total go
                this.dgvVote.Columns[22].Width = 30;  //total go percent 
                this.dgvVote.Columns[23].Width = 30;//total go up/down
                this.dgvVote.Columns[4].Width = 45;  //up down debate
                this.dgvVote.Columns[3].Width = 100;  //total amount
                //maung 
                this.dgvVote.Columns[7].Width = 40;//body
                this.dgvVote.Columns[5].Width = 30;//total go                 
                this.dgvVote.Columns[6].Width = 100;  //maung amount


                //Backcolor
                ///this.dgvVote.BackgroundColor

                //this.dgvVote.Columns[12].Width = 100;//main competator
                //this.dgvVote.Columns[0].Width = 40; //main check
                //this.dgvVote.Columns[17].Width = 30; //go
                //this.dgvVote.Columns[16].Width = 30; //up/dwon
                //this.dgvVote.Columns[18].Width = 30; //  percent     
                //this.dgvVote.Columns[1].Width = 40; //sec check
                //this.dgvVote.Columns[13].Width = 100; //competaotr
                //this.dgvVote.Columns[2].Width = 100; //body amount
                //this.dgvVote.Columns[19].Width = 30; //total go
                //this.dgvVote.Columns[21].Width = 30; //total go up/down
                //this.dgvVote.Columns[20].Width = 30; //total go percent
                //this.dgvVote.Columns[4].Width = 40; //up down
                //this.dgvVote.Columns[3].Width = 100; //total amount
                //this.dgvVote.Columns[7].Width = 40; //body maung 
                //this.dgvVote.Columns[5].Width = 40; //go total maung
                //this.dgvVote.Columns[6].Width = 100; //maung amount




            }
        }

        private void formatGridviewColumn()
        {
            if (this.dgvDraw.Columns.Count > 1)
            {
                this.dgvDraw.Columns[0].Visible = false;
                this.dgvDraw.Columns[1].Visible = false;
                this.dgvDraw.Columns[2].Visible = false;
                this.dgvDraw.Columns[3].Visible = false;
                this.dgvDraw.Columns[4].Visible = false;
                this.dgvDraw.Columns[5].Visible = false;
                this.dgvDraw.Columns[6].Visible = false;
                this.dgvDraw.Columns[7].Visible = false;
                this.dgvDraw.Columns[8].Visible = false;
                this.dgvDraw.Columns[9].Visible = false;
                this.dgvDraw.Columns[10].Visible = false;
                this.dgvDraw.Columns[11].Visible = false;
                this.dgvDraw.Columns[12].Visible = false;
                this.dgvDraw.Columns[13].Visible = false;
                this.dgvDraw.Columns[14].Visible = false;
                this.dgvDraw.Columns[15].Visible = false;
                this.dgvDraw.Columns[16].Visible = false;
                this.dgvDraw.Columns[17].Visible = false;

                //Visible
                this.dgvDraw.Columns[18].Visible = true;
                this.dgvDraw.Columns[4].Visible = true;
                this.dgvDraw.Columns[5].Visible = true;

                //Display                
                this.dgvDraw.Columns[4].DisplayIndex = 1; //code
                this.dgvDraw.Columns[5].DisplayIndex = 2; //list code           
                this.dgvDraw.Columns[18].DisplayIndex = 3; //  list des

                //hearder 
                //body
                //this.dgvVote.Columns[4].HeaderText = "List Code";//main competator
                //this.dgvVote.Columns[5].HeaderText = "?"; //main check
                //this.dgvVote.Columns[0].HeaderText = "Go"; //go               

            }
        }
        #endregion



        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                mSubmitHeaderObj = new SubmitHeaderObj();
                clearUI();
                //setSampledata();
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
                    if (saveHeader() && saveDetail())
                    {
                        MessageBox.Show("Save Completely");
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
                    //if (mMasterBLL.deleteObj("Person", mSubmitHeaderObj))
                    //{
                    //    clearUI();
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnPrepare_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable L_dt = new DataTable();
                DataTable L_dtn = new DataTable();
                int L_ListOperator = 0;
                string L_digit = "";
                L_digit = txtList.Text.Trim();
                if (cboOperator.SelectedIndex != -1)
                {
                    if (cboOperator.SelectedIndex == 0)
                    {
                        L_ListOperator = 2;
                    }
                    if (cboOperator.SelectedIndex == 1)
                    {
                        L_ListOperator = 3;
                    }
                    if (cboOperator.SelectedIndex == 2)
                    {
                        L_ListOperator = 1;
                    }
                    if (cboOperator.SelectedIndex == 3)
                    {
                        L_ListOperator = 0;
                    }
                    if (cboOperator.SelectedIndex == 4)
                    {
                        L_ListOperator = 4;
                    }
                }
                if (dgvDraw.Rows.Count >= 1)
                {
                    L_dt = (DataTable)dgvDraw.DataSource;
                }
                mListObj.TypeAsk = cboLuckyType.SelectedValue.ToString();
                mPeriodObj.Ask = Convert.ToString(cboPeriod.SelectedValue);
                mPeriodObj = (PeriodObj)mMasterBLL.selectObjbyAskobj("LM_Period", mPeriodObj);
                //dgvDraw.DataSource = L_dt;
                //dgvDraw.DataSource = mMasterBLL.getPersonDraw("CS_SP_SELECT_DRAW", Convert.ToInt64(mListObj.TypeAsk), mPeriodObj.StartDate, mPeriodObj.EndDate, L_digit, L_ListOperator);
                L_dtn = mMasterBLL.getPersonDraw("CS_SP_SELECT_DRAW", Convert.ToInt64(mListObj.TypeAsk), mPeriodObj.StartDate, mPeriodObj.EndDate, L_digit, L_ListOperator);
                setSameAmt(L_dtn);
                dgvDraw.DataSource = mdt;
                formatGridviewColumn();

                //L_dtn = (DataTable)dgvDraw.DataSource;                
                //L_dt.Merge(L_dtn);

                //dgvDraw.DataSource = L_dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void setSameAmt(DataTable adt)
        {


            if (dgvDraw.Rows.Count >= 1)
            {
                mdt = (DataTable)dgvDraw.DataSource;
            }
            adt.Columns.Add("Amount");
            for (int i = 0; i <= adt.Rows.Count - 1; i++)
            {
                adt.Rows[i][18] = txtAmount.Text.Trim();
            }
            if (mdt.Rows.Count >= 1)
            {
                mdt.Merge(adt);
            }
            else
            {
                mdt = adt;
            }
            for (int i = 0; i <= mdt.Rows.Count - 1; i++)
            {
                if (mdt.Rows[i][18] != null && mdt.Rows[i][18].ToString() != "")
                {
                    total = total + Convert.ToDecimal(mdt.Rows[i][18]);
                }
                count = count + 1;
            }
            if (mLuckyTypeObj.CommissionType == "0")//percent
            {
                comm = (Convert.ToDecimal(mLuckyTypeObj.Commission) / 100) * total;
            }
            else
            {
                comm = (Convert.ToDecimal(mLuckyTypeObj.Commission) * total);
            }
            lblCount.Text = "Count : " + count;
            LblTotal.Text = "Total : " + total;
            lblComm.Text = "Comm : " + comm;

        }

        private void cboLuckyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                mLuckyTypeObj.Ask = Convert.ToString(cboLuckyType.SelectedValue);
                //DataTable m = new DataTable();
                mLuckyTypeObj = (LuckyTypeObj)mMasterBLL.selectObjbyAskobj("LM_LuckyType", mLuckyTypeObj);
                mUtility.visibleGroupBox(false, grbDraw, grbVote);
                if (mLuckyTypeObj.ResultType == "1")
                {
                    //mUtility.enableGroupBox(true,grbDraw);
                    mUtility.visibleGroupBox(true, grbDraw);
                    //mUtility.visibleDataGridView(true, dgvDraw);
                    lblTypeCaption.Text = "Draw";
                    saveFlag = true;
                }
                else if (mLuckyTypeObj.ResultType == "0")
                {
                    //mUtility.enableGroupBox(true, grbVote);
                    mUtility.visibleGroupBox(true, grbVote);
                    //mUtility.visibleDataGridView(true, dgvVote);
                    lblTypeCaption.Text = "Vote";
                    saveFlag = false;
                }
                cboOperator.SelectedIndex = 0;



                //if (m.Rows.Count > 0)
                //{
                //    //mUtility.enableGroupBox(false, grbVote,grbDraw);
                //    mUtility.visibleGroupBox(false, grbDraw, grbVote);
                //    //mUtility.visibleDataGridView(false, dgvDraw, dgvVote);

                //    if (m.Rows[0][4].ToString() == "1")
                //    {
                //        //mUtility.enableGroupBox(true,grbDraw);
                //        mUtility.visibleGroupBox(true, grbDraw);
                //        //mUtility.visibleDataGridView(true, dgvDraw);
                //        lblTypeCaption.Text = "Draw";
                //        saveFlag = true;
                //    }
                //    else
                //    {
                //        //mUtility.enableGroupBox(true, grbVote);
                //        mUtility.visibleGroupBox(true, grbVote);
                //        //mUtility.visibleDataGridView(true, dgvVote);
                //        lblTypeCaption.Text = "Vote";
                //        saveFlag = false;
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cboPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboPeriod.SelectedIndex != -1)
                {
                    //DataTable m = new DataTable();

                    mPeriodObj.Ask = Convert.ToString(cboPeriod.SelectedValue);
                    mPeriodObj = (PeriodObj)mMasterBLL.selectObjbyAskobj("LM_Period", mPeriodObj);
                    //mPeriodObj.StartDate = mPeriodObj.StartDate;                    
                    //mListObj.StartDate = mPeriodObj.StartDate;// "4/2/2015 7:34:20 PM";// mPeriodObj.StartDate;
                    if (cboLuckyType.SelectedValue != null && cboLuckyType.SelectedValue.ToString() != "0" && cboLuckyType.SelectedIndex != -1)
                    {
                        mListObj.TypeAsk = cboLuckyType.SelectedValue.ToString();
                    }
                    else
                    {
                        mListObj.TypeAsk = "1";
                    }
                    dgvVote.DataSource = mMasterBLL.getPersonVote("CS_SP_SELECT_VOTE", Convert.ToInt64(mListObj.TypeAsk), mPeriodObj.StartDate, mPeriodObj.EndDate);
                    //dgvVote.DataSource = mMasterBLL.selectDataTablebyIndex("LM_List", mListObj, 4);
                    sequenceGridviewcolumn();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvVote_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvVote.Columns.Count > 7)
            {
                if ((int)e.ColumnIndex == 14 || (int)e.ColumnIndex == 15) //main competator
                {
                    if (e.Value != null)
                    {
                        mCompetatorObj.Ask = Convert.ToString(e.Value);
                        //mCompetatorObj = (CompetatorObj)mMasterBLL.selectObjbyAskobj("LM_Competitor", mCompetatorObj);
                        e.Value = ((CompetatorObj)mMasterBLL.selectObjbyAskobj("LM_Competitor", mCompetatorObj)).CompetatorCode;
                    }
                }


                if ((int)e.ColumnIndex == 18 || (int)e.ColumnIndex == 23) //+/-
                {
                    if (e.Value != null)
                    {
                        if (e.Value.ToString() == "1")
                        {
                            e.Value = "+";
                        }
                        else if (e.Value.ToString() == "2")
                        {
                            e.Value = "-";
                        }
                    }
                }

                ////sd and ed
                //if ((int)e.ColumnIndex == 24 || (int)e.ColumnIndex == 25)
                //{
                //    if (e.Value != null)
                //    {
                //        e.Value = Utility.getDateVale(e.Value.ToString());
                //    }
                //}

                //if ((int)e.ColumnIndex == 13) //main competator
                //{
                //    if (e.Value != null)
                //    {
                //        mCompetatorObj.Ask = Convert.ToInt64(e.Value);
                //        DataTable m = new DataTable();
                //        m = mMasterBLL.selectDataTablebyAsk("Competator", mCompetatorObj);
                //        if (m.Rows.Count > 0)
                //        {
                //            e.Value = m.Rows[0][1].ToString();
                //        }
                //    }
                //}

                if ((int)e.ColumnIndex == 16 || (int)e.ColumnIndex == 21) //up/down
                {
                    if (e.Value != null)
                    {
                        if (Convert.ToInt32(e.Value) == 1)
                        {
                            e.Value = "+";// LuckyMasterEnum.ResultType.Draw.ToString();
                        }
                        else if (Convert.ToInt32(e.Value) == 2)
                        {
                            e.Value = "-";// LuckyMasterEnum.ResultType.Vote.ToString();
                        }
                    }
                }

                if ((int)e.ColumnIndex == 20 || (int)e.ColumnIndex == 22) //percent
                {
                    if (e.Value != null)
                    {
                        e.Value = decimal.Round(Convert.ToDecimal(e.Value), 0);
                    }
                }

                //if ((int)e.ColumnIndex == 2 || (int)e.ColumnIndex == 3 || (int)e.ColumnIndex == 6) //amount
                //{
                //    if (e.Value != null)
                //    {
                //        e.Value = decimal.Round(Convert.ToDecimal(e.Value), 2);
                //    }
                //}

            }
        }


        private void dgvDraw_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (dgvDraw.Columns.Count > 1)
            {
                if ((int)e.ColumnIndex == 0) //main competator
                {
                    //e.Value = txtAmount.Text.Trim();
                    //if (e.Value != null)
                    //{

                    //}
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvDraw.DataSource = new DataTable();
            lblCount.Text = "Count : ";
            LblTotal.Text = "Total : ";
            lblComm.Text = "Comm : ";
            mdt = new DataTable(); ;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            btnSave_Click(null, null);
            MessageBox.Show("To Print Slip");
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            try
            {
                FindOne L_FindOne = new FindOne("LM_Period", new PeriodObj());
                L_FindOne.ShowDialog();
                if (L_FindOne.Result != null)
                {
                    cboPeriod.Text = "";
                    cboPeriod.SelectedValue = L_FindOne.Result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            try
            {
                FindOne L_FindOne = new FindOne("LM_Master", new MasterObj());
                L_FindOne.ShowDialog();
                if (L_FindOne.Result != null)
                {
                    cboMaster.Text = "";
                    cboMaster.SelectedValue = L_FindOne.Result;
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                FindOne L_FindOne = new FindOne("LM_Player", new PlayerObj());
                L_FindOne.ShowDialog();
                if (L_FindOne.Result != null)
                {
                    cboPlayer.Text = "";
                    cboPlayer.SelectedValue = L_FindOne.Result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            try
            {
                FindOne L_FindOne = new FindOne("LM_Agent", new AgentObj());
                L_FindOne.ShowDialog();
                if (L_FindOne.Result != null)
                {
                    cboAgent.Text = "";
                    cboAgent.SelectedValue = L_FindOne.Result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}