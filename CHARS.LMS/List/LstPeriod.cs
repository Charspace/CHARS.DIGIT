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
using CHARS.HR.PL.Process;

namespace CHARS.LMS.List
{
    public partial class LstPeriod : LstBase
    {
        public LstPeriod()
        {
            InitializeComponent();            
            nmcYear.Value = Convert.ToDecimal(DateTime.Now.Year);
            loadGrid();
        }

        Utility mUtility = new Utility();
        MasterBLL mMasterBLL = new MasterBLL();
        PeriodObj mPeriodObj = new PeriodObj();
        PeriodToolTip mPeriodToolTip = new PeriodToolTip();
        LuckyTypeObj mLuckyTypeObj = new LuckyTypeObj();

        #region"Properties"
        private void prepareFilter()
        {

        }
        private void setToolTip()
        {
            try
            {
                this.dgvList.Columns[0].ToolTipText = mPeriodToolTip.Ask.ToString();
                this.dgvList.Columns[1].ToolTipText = mPeriodToolTip.LuckyTypeAsk.ToString();
                this.dgvList.Columns[2].ToolTipText = mPeriodToolTip.PeriodCode.ToString();
                this.dgvList.Columns[3].ToolTipText = mPeriodToolTip.PeriodDescription.ToString();
                this.dgvList.Columns[4].ToolTipText = mPeriodToolTip.StartDate.ToString();
                this.dgvList.Columns[5].ToolTipText = mPeriodToolTip.EndDate.ToString();                
                this.dgvList.Columns[6].ToolTipText = mPeriodToolTip.PeriodRemark.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void hideGridviewcolumn()
        {
            try
            {
                this.dgvList.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void sequenceGridviewcolumn()
        {
            //this.dgvPerson.Columns[0].Visible = false;
        }
        private void loadGrid()
        {
            try
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("@Year", Convert.ToString( nmcYear.Value));
                dgvList.DataSource = mMasterBLL.executeSelectProcedure("CS_SP_SELECT_PERIOD_BY", dic);
                mUtility.setDataGridColumn(ref dgvList);               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //try
            //{
            //    DataTable mm = new DataTable();
            //    dgvList.DataSource = mMasterBLL.selectDataTable("LM_Period", "");
            //    mUtility.setDataGridColumn(ref dgvList);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }
        #endregion



        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                SetPeriod L_SetPeriod = new SetPeriod();
                L_SetPeriod.ShowDialog();
                if (L_SetPeriod.DialogResult == DialogResult.Cancel)
                {
                    loadGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvList.Rows.Count > 0)
                {
                    if (dgvList.CurrentRow.Cells[0].Value != null)
                    //if (dgvList.CurrentRow.Cells[dgvtxaskey.Index].Value != null)
                    {
                        //pan.BackColor = Color.AliceBlue;
                        //SetPeriod L_SetPeriod = new SetPeriod((long)dgvList.CurrentRow.Cells[dgvtxaskey.Index].Value);
                        SetPeriod L_SetPeriod = new SetPeriod(dgvList.CurrentRow.Cells[0].Value.ToString());
                        L_SetPeriod.ShowDialog();
                        if (L_SetPeriod.DialogResult == DialogResult.Cancel)
                        {
                            loadGrid();
                            //setToolTip();
                        }
                        //pan.BackColor = System.Drawing.SystemColors.Control;
                        // this.textBox1.BackColor = System.Drawing.SystemColors.Control;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //GeneralUtility.ShowErrorMsg(ex);
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

        }

        private void butFind_Click(object sender, EventArgs e)
        {
            try
            {
                loadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnEdit_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((int)e.ColumnIndex == dgvList.Columns[7].Index)
            {
                if (e.Value != null)
                {
                    mLuckyTypeObj.Ask = Convert.ToString(e.Value);                 
                    mLuckyTypeObj = (LuckyTypeObj) mMasterBLL.selectObjbyAskobj("LM_LuckyType", mLuckyTypeObj);
                    e.Value = mLuckyTypeObj.LuckyTypeCode;                   

                }
            }
            if ((int)e.ColumnIndex == dgvList.Columns[6].Index)
            {
                if (e.Value != null)
                {
                    e.Value = Utility.getDateVale(e.Value.ToString()).Date.ToShortDateString();
                }
            }
            if ((int)e.ColumnIndex == dgvList.Columns[5].Index)
            {
                if (e.Value != null)
                {
                    e.Value = Utility.getDateVale(e.Value.ToString()).Date.ToShortDateString();
                }
            }
            if ((int)e.ColumnIndex == dgvList.Columns[9].Index)
            {
                if (e.Value != null)
                {
                    if (e.Value.ToString() == "1")
                    {
                        e.Value = "Process";
                    }
                    else
                    {
                        e.Value = "Open";
                    }
                }
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {

        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    mPeriodObj = new PeriodObj();
            //    mPeriodObj.Ask = dgvList.CurrentRow.Cells[0].Value.ToString();                
            //    mPeriodObj = (PeriodObj)mMasterBLL.selectObjbyAskobj("LM_Period", mPeriodObj);
            //    if (mPeriodObj.Status == "0")
            //    {
            //        btnProcess.Enabled = true;
            //        btnRevert.Enabled = false;
            //    }
            //    else
            //    {
            //        btnProcess.Enabled = false;
            //        btnRevert.Enabled = true;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}

        }

        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                mPeriodObj = new PeriodObj();
                mPeriodObj.Ask = dgvList.CurrentRow.Cells[0].Value.ToString();
                mPeriodObj = (PeriodObj)mMasterBLL.selectObjbyAskobj("LM_Period", mPeriodObj);
                if (mPeriodObj.Status == "0")
                {
                    btnProcess.Enabled = true;
                    btnRevert.Enabled = false;
                }
                else
                {
                    btnProcess.Enabled = false;
                    btnRevert.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnRefreshSea_Click(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable l_Result = new DataTable();
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("@PeridoAsk", Convert.ToString(dgvList.CurrentRow.Cells[0].Value.ToString()));
                l_Result = mMasterBLL.executeSelectProcedure("CS_SP_PROCESS_PERIOD", dic);
                if (l_Result.Rows.Count > 0)
                {
                    ProResult L_ProResult = new ProResult(dgvList.CurrentRow.Cells[7].Value.ToString(),
                        dgvList.CurrentRow.Cells[0].Value.ToString());
                    L_ProResult.ShowDialog();
                    if (L_ProResult.DialogResult == DialogResult.Cancel)
                    {
                       // loadGrid();
                    }
                   
                }
                else
                {
                    loadGrid();
                }
                //mUtility.setDataGridColumn(ref dgvList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable l_Result = new DataTable();
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("@PeridoAsk", Convert.ToString(dgvList.CurrentRow.Cells[0].Value.ToString()));
                l_Result = mMasterBLL.executeSelectProcedure("CS_SP_REVERT_PERIOD", dic);
                if (l_Result.Rows.Count > 0)
                {
                    loadGrid();
                }
                else
                {
                    loadGrid();                   
                }
                //mUtility.setDataGridColumn(ref dgvList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        
        }






    }
}