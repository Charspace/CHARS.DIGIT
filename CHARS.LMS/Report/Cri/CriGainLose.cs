using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHARS.HR.COMMON;
using CHARS.HR.COMMON.PL;
using CHARS.HR.COMMON.BLL;
using CHARS.HR.COMMON.General;
using CHARS.HR.PL.Setup;
using CHARS.HR.BOL;

namespace CHARS.LMS.List
{
    public partial class CriGainLose : CriBase
    {

        public CriGainLose()
        {
            InitializeComponent();
            loadReference();
        }
        MasterBLL mMasterBLL = new MasterBLL();
        Utility mUtility = new Utility();
        DataSet ds = new DataSet();
        DataTable L_Resultdtl = new DataTable();
        Dictionary<string, string> dic = new Dictionary<string, string>();
        string mReportName = "";
        string mStoreProcedure = "";
        private void loadReference()
        {
            loadPlayer();
            loadAgent();
            loadPeriod();
            loadLuckyType();
            loadMaster();
            loadList();
            cboOperator.SelectedIndex = 0;
            cboMaster.SelectedIndex = -1;
            cboPlayer.SelectedIndex = -1;
            cboAgent.SelectedIndex = -1;
            listBox1.SelectedIndex = 1;
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
            //cboPlayer.SelectedIndex = 0;
            if (cboPlayer.Items.Count > 0)
            {
                cboPlayer.SelectedIndex = 0;
            }
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
            //cboAgent.SelectedIndex = 0;
            if (cboAgent.Items.Count > 0)
            {
                cboAgent.SelectedIndex = 0;
            }
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
            //cboMaster.SelectedIndex = 0;
            if (cboMaster.Items.Count > 0)
            {
                cboMaster.SelectedIndex = 0;
            }
        }
        private void loadPeriod()
        {
            PeriodObj mPeriodObj = new PeriodObj();
            mPeriodObj.Status = "1";
            cboPeriod.DisplayMember = "Period Code";
            cboPeriod.ValueMember = "ASK";
            //DataTable periodTbl = mMasterBLL.selectDataTable("LM_Period", "");
            DataTable periodTbl = mMasterBLL.selectDataTablebyIndex("LM_Period", mPeriodObj, 10);
            if (periodTbl.Rows.Count > 0)
            {

                cboPeriod.DataSource = periodTbl;
                cboPeriod.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cboPeriod.AutoCompleteSource = AutoCompleteSource.CustomSource;
                cboPeriod.AutoCompleteCustomSource.AddRange(mUtility.getAutoCompleList(periodTbl, "Period Code"));
                cboPeriod.SelectedIndex = 0;
            }
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
            cboLuckyType.SelectedIndex = 0;
        }
        private void loadList()
        {
            //dgvcbodraw.DisplayMember = "List Code";
            //dgvcbodraw.ValueMember = "ASK";
            //dgvcbodraw.DataSource = mMasterBLL.selectDataTable("LM_List", "");
        }
        private void showRpt()
        {
            try
            {
                dic.Add("@LuckyTypeAsk", "20151022132842356");
                dic.Add("@PeriodAsk", "20151022223837168");
                dic.Add("@ListOperator", "1");
                dic.Add("@List", "242");
                dic.Add("@AmountOperator", "0");
                dic.Add("@FromAmount", "1");
                dic.Add("@ToAmount", "9999999999");
                dic.Add("@AgentAsk", "0");
                dic.Add("@PlayerAsk", "0");
                dic.Add("@MasterAsk", "0");
                L_Resultdtl = mMasterBLL.executeSelectProcedure("CS_SP_RPT_SUBMIT", dic);
                ds.Tables.Add(L_Resultdtl);
                ds.Tables[0].TableName = "Submit";
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    MessageBox.Show("There is no data to preview");
                    return;
                }
                else
                {
                    CHARS.HR.COMMON.General.Report.viewReport(ds, Application.StartupPath, "rptSubmit.rpt");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                bindFilter();
                ds = new DataSet();
                L_Resultdtl = mMasterBLL.executeSelectProcedure(mStoreProcedure, dic);
                ds.Tables.Add(L_Resultdtl);
                ds.Tables[0].TableName = "Gainlose";
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    MessageBox.Show("There is no data to preview");
                    return;
                }
                else
                {
                    //mReportName = listBox1.SelectedItem.ToString();
                    CHARS.HR.COMMON.General.Report.viewReport(ds, Application.StartupPath, mReportName);
                }
            }
        }
        private void bindFilter()
        {
            try
            {
                dic.Clear();
                dic.Add("@LuckyTypeAsk", cboLuckyType.SelectedValue.ToString());// "20151022132842356");
                dic.Add("@PeriodAsk", cboPeriod.SelectedValue.ToString());// "20151022223837168");
                
                dic.Add("@ListOperator", "0");

                if (txtList.Text.Trim() != "")
                {
                    dic.Add("@List", txtList.Text.Trim());
                }
                else
                {
                    dic.Add("@List", "");
                }              
                if (cboAgent.SelectedIndex != -1)
                {
                    dic.Add("@AgentAsk", cboAgent.SelectedValue.ToString());
                }
                else
                {
                    dic.Add("@AgentAsk", "0");
                }

                if (cboPlayer.SelectedIndex != -1)
                {
                    dic.Add("@PlayerAsk", cboPlayer.SelectedValue.ToString());
                }
                else
                {
                    dic.Add("@PlayerAsk", "0");
                }

                if (cboMaster.SelectedIndex != -1)
                {
                    dic.Add("@MasterAsk", cboMaster.SelectedValue.ToString());
                }
                else
                {
                    dic.Add("@MasterAsk", "0");
                }
                if (cboGainType.SelectedIndex != -1)
                {
                    dic.Add("@GainType", cboGainType.SelectedIndex.ToString());
                }
                else
                {
                    dic.Add("@GainType", "4");
                }  
                
                
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
                errorProvider1.Clear();
                bool valid = true;
                if (cboLuckyType.SelectedIndex == -1)
                {
                    valid = mUtility.setInvalidComboBox(errorProvider1, cboLuckyType);
                }
                else
                {
                    mUtility.setValidComboBox(errorProvider1, cboLuckyType);
                }
                if (cboPeriod.SelectedIndex == -1)
                {
                    valid = mUtility.setInvalidComboBox(errorProvider1, cboPeriod);
                }
                else
                {
                    mUtility.setValidComboBox(errorProvider1, cboPeriod);
                }
                if (cboMaster.SelectedIndex == -1)
                {
                    //valid = mUtility.setInvalidComboBox(errorProvider1, cboMaster);
                }
                else
                {
                    mUtility.setValidComboBox(errorProvider1, cboMaster);
                }
                if (cboAgent.SelectedIndex == -1)
                {
                    //valid = mUtility.setInvalidComboBox(errorProvider1, cboAgent);
                }
                else
                {
                    mUtility.setValidComboBox(errorProvider1, cboAgent);
                }
                if (cboPlayer.SelectedIndex == -1)
                {
                    //valid = mUtility.setInvalidComboBox(errorProvider1, cboPlayer);
                }
                else
                {
                    mUtility.setValidComboBox(errorProvider1, cboPlayer);
                }
                //if (cboPlayer.SelectedIndex == -1)
                //{
                //    valid = mUtility.setInvalidComboBox(errorProvider1, cboPlayer);
                //}
                //else
                //{
                //    mUtility.setValidComboBox(errorProvider1, cboPlayer);
                //}
                return valid;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                DataTable L_Resultdtl = new DataTable();
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("@LuckyTypeAsk", "20151022132842356");
                dic.Add("@PeriodAsk", "20151022223837168");
                dic.Add("@ListOperator", "1");
                dic.Add("@List", "2");
                dic.Add("@AmountOperator", "0");
                dic.Add("@FromAmount", "1");
                dic.Add("@ToAmount", "9999999999");
                dic.Add("@AgentAsk", "0");
                dic.Add("@PlayerAsk", "0");
                dic.Add("@MasterAsk", "0");
                L_Resultdtl = mMasterBLL.executeSelectProcedure("CS_SP_RPT_SUBMIT", dic);
                ds.Tables.Add(L_Resultdtl);
                ds.Tables[0].TableName = "Submit";
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    MessageBox.Show("There is no data to preview");
                    return;
                }
                else
                {
                    CHARS.HR.COMMON.General.Report.viewReport(ds, Application.StartupPath, "rptSubmitCheck.rpt");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (listBox1.SelectedIndex ==0)
        //    {
        //        mReportName = "rptAgentGainLose.rpt";
        //        mStoreProcedure = "CS_SP_RPT_AgentGainLost";
        //    }
        //    else if  (listBox1.SelectedIndex ==1)
        //    {
        //        mReportName = "rptPlayerGainLose.rpt";
        //        mStoreProcedure = "CS_SP_RPT_PlayerGainLost";
        //    }
        //    else if (listBox1.SelectedIndex == 2)
        //    {
        //        mReportName = "rptMasterGainLose.rpt";
        //        mStoreProcedure = "CS_SP_RPT_MastreGainLost";
        //    }
        //}

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolTipList_Popup(object sender, PopupEventArgs e)
        {

        }

        private void pan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grbList_Enter(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void lblPeriod_Click(object sender, EventArgs e)
        {

        }

        private void cboPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblluckyType_Click(object sender, EventArgs e)
        {

        }

        private void cboLuckyType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtList_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblList_Click(object sender, EventArgs e)
        {

        }

        private void cboOperator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void grbControl_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnMaster_Click(object sender, EventArgs e)
        {

        }

        private void lblMaster_Click(object sender, EventArgs e)
        {

        }

        private void cboMaster_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgent_Click(object sender, EventArgs e)
        {

        }

        private void btnPlayer_Click(object sender, EventArgs e)
        {

        }

        private void lblPlayer_Click(object sender, EventArgs e)
        {

        }

        private void cboPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblAgent_Click(object sender, EventArgs e)
        {

        }

        private void cboAgent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void cboAmountOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtFromAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
           // e.Handled = mUtility.checkNumberWithDecimalSeparator(e, txtFromAmount);
        }

        private void txtToAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = mUtility.checkNumberWithDecimalSeparator(e, txtToAmount);
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                mReportName = "rptAgentGainLose.rpt";
                mStoreProcedure = "CS_SP_RPT_GainLose";
            }
            else if (listBox1.SelectedIndex == 1)
            {
                mReportName = "rptPlayerGainLose.rpt";
                mStoreProcedure = "CS_SP_RPT_GainLose";
            }
            else if (listBox1.SelectedIndex == 2)
            {
                mReportName = "rptMasterGainLose.rpt";
                mStoreProcedure = "CS_SP_RPT_GainLose";
            }
        }

    }
}