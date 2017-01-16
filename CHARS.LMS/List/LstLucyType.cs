using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHARS.HR.COMMON.PL;
using CHARS.HR.COMMON;
using CHARS.HR.PL.Setup;
using CHARS.HR.COMMON.BLL;
using CHARS.HR.BOL;
using CHARS.HR.COMMON.General;
using CHARS.HR.PL;


namespace CHARS.LMS.List
{
    public partial class LstLucyType : LstBase
    {
        public LstLucyType()
        {
            InitializeComponent();
            loadGrid();
            //setToolTip();
            //hideGridviewcolumn();
        }
        Utility mUtility = new Utility();
        MasterBLL mMasterBLL = new MasterBLL();
        LuckyTypeObj mLuckyTypeObj = new LuckyTypeObj();
        LuckyTypeToolTip mLuckyTypeToolTip = new LuckyTypeToolTip();
        //LuckyMasterEnum mLuckyTypeEnum = new LuckyMasterEnum();

        #region"Private Mothod"
        private void prepareFilter()
        {

        }
        private void setToolTip()
        {
            try
            {
                this.dgvLuckyTypeList.Columns[0].ToolTipText = mLuckyTypeToolTip.Ask.ToString();
                this.dgvLuckyTypeList.Columns[1].ToolTipText = mLuckyTypeToolTip.LuckyTypeCode.ToString();
                this.dgvLuckyTypeList.Columns[2].ToolTipText = mLuckyTypeToolTip.LuckyTypeDescription.ToString();
                this.dgvLuckyTypeList.Columns[3].ToolTipText = mLuckyTypeToolTip.NumberofPass.ToString();
                this.dgvLuckyTypeList.Columns[4].ToolTipText = mLuckyTypeToolTip.ResultType.ToString();
                this.dgvLuckyTypeList.Columns[5].ToolTipText = mLuckyTypeToolTip.CommissionType.ToString();
                this.dgvLuckyTypeList.Columns[6].ToolTipText = mLuckyTypeToolTip.Commission.ToString();
                this.dgvLuckyTypeList.Columns[7].ToolTipText = mLuckyTypeToolTip.PassType.ToString();
                this.dgvLuckyTypeList.Columns[7].ToolTipText = mLuckyTypeToolTip.Pass.ToString();
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
                this.dgvLuckyTypeList.Columns[0].Visible = false;
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
                DataTable mm = new DataTable();
                dgvLuckyTypeList.DataSource = mMasterBLL.selectDataTable("LM_LuckyType", "");
                mUtility.setDataGridColumn(ref dgvLuckyTypeList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        #endregion

        #region"Private Event"
        private void LstLucyType_Load(object sender, EventArgs e)
        {
            loadGrid();
        }
        private void butFind_Click(object sender, EventArgs e)
        {
            try
            {
                FindBase L_FindBase = new FindBase("LM_LuckyType", new SetLuckyType());
                L_FindBase.ShowDialog();
                if (L_FindBase.DialogResult == DialogResult.OK)
                {
                    SetLuckyType msetBook = (SetLuckyType)L_FindBase.DynObject;
                    dgvLuckyTypeList.DataSource = mMasterBLL.searchData("LM_LuckyType", mLuckyTypeObj);
                }
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
                SetLuckyType L_SetLuckyType = new SetLuckyType();
                L_SetLuckyType.ShowDialog();
                if (L_SetLuckyType.DialogResult == DialogResult.Cancel)
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
                if (dgvLuckyTypeList.Rows.Count > 0)
                {
                    if (dgvLuckyTypeList.CurrentRow.Cells[0].Value != null)
                    {
                        string a = dgvLuckyTypeList.CurrentRow.Cells[0].Value.ToString();
                        SetLuckyType L_SetLuckyType = new SetLuckyType((long)dgvLuckyTypeList.CurrentRow.Cells[0].Value);
                        L_SetLuckyType.ShowDialog();
                        if (L_SetLuckyType.DialogResult == DialogResult.Cancel)
                        {
                            loadGrid();
                        }
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
                mLuckyTypeObj.Ask = dgvLuckyTypeList.CurrentRow.Cells[0].Value.ToString();
                HisBase L_HisBase = new HisBase("LM_LuckyType_History", mLuckyTypeObj);
                L_HisBase.ShowDialog();
                if (L_HisBase.DialogResult == DialogResult.OK)
                {
                    L_HisBase.Close();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvLuckyTypeList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if ((int)e.ColumnIndex == 5)
            {
                if (e.Value != null)
                {                    
                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }

            if ((int)e.ColumnIndex == 6)
            {
                if (e.Value != null)
                {
                    if (Convert.ToInt32(e.Value) == 1)
                    {
                        e.Value = LuckyMasterEnum.ResultType.Draw.ToString();
                    }
                    else if (Convert.ToInt32(e.Value) == 0)
                    {
                        e.Value = LuckyMasterEnum.ResultType.Vote.ToString();
                    }
                }
            }
            if ((int)e.ColumnIndex == 7)
            {
                if (e.Value != null)
                {
                    if (Convert.ToInt32(e.Value) == 1)
                    {
                        e.Value = LuckyMasterEnum.ComissionType.times.ToString();
                    }
                    else if (Convert.ToInt32(e.Value) == 0)
                    {
                        e.Value = LuckyMasterEnum.ComissionType.percent.ToString();
                    }
                }
            }
            if ((int)e.ColumnIndex == 9)
            {
                if (e.Value != null)
                {
                    if (Convert.ToInt32(e.Value) == 1)
                    {
                        e.Value = LuckyMasterEnum.PassType.times.ToString();
                    }
                    else if (Convert.ToInt32(e.Value) == 0)
                    {
                        e.Value = LuckyMasterEnum.PassType.percent.ToString();
                    }
                }
            }

            if ((int)e.ColumnIndex == 8)
            {
                if (e.Value != null)
                {                  
                    e.Value = Decimal.Round(Convert.ToDecimal(e.Value), 2);
                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }

            if ((int)e.ColumnIndex == 10)
            {
                if (e.Value != null)
                {
                    e.Value = Decimal.Round(Convert.ToDecimal(e.Value), 2);
                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }
        private void dgvLuckyTypeList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
        private void dgvLuckyTypeList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                //if (e.Context == DataGridViewDataErrorContexts.Commit)
                //{
                //    dgvGPFRate.Rows[e.RowIndex].ErrorText = e.Exception.ToString();
                //}
                //if (e.Context == DataGridViewDataErrorContexts.Parsing)
                //{
                //    dgvGPFRate.Rows[e.RowIndex].ErrorText = e.Exception.ToString();
                //}
                //if (e.Context == DataGridViewDataErrorContexts.Display)
                //{
                //    dgvGPFRate.Rows[e.RowIndex].ErrorText = e.Exception.ToString();
                //}
                //if (e.Context == DataGridViewDataErrorContexts.Formatting)
                //{
                //    dgvGPFRate.Rows[e.RowIndex].ErrorText = e.Exception.ToString();
                //}
                //if (e.Context == DataGridViewDataErrorContexts.ClipboardContent)
                //{
                //    dgvGPFRate.Rows[e.RowIndex].ErrorText = e.Exception.ToString();
                //}
                //if (e.Context == DataGridViewDataErrorContexts.CurrentCellChange)
                //{
                //    dgvGPFRate.Rows[e.RowIndex].ErrorText = e.Exception.ToString();
                //}
                //if (e.Context == DataGridViewDataErrorContexts.InitialValueRestoration)
                //{
                //    dgvGPFRate.Rows[e.RowIndex].ErrorText = e.Exception.ToString();
                //}
                //if (e.Context == DataGridViewDataErrorContexts.LeaveControl)
                //{
                //    dgvGPFRate.Rows[e.RowIndex].ErrorText = e.Exception.ToString();
                //}
                //if (e.Context == DataGridViewDataErrorContexts.PreferredSize)
                //{
                //    dgvGPFRate.Rows[e.RowIndex].ErrorText = e.Exception.ToString();
                //}
                //if (e.Context == DataGridViewDataErrorContexts.RowDeletion)
                //{
                //    dgvGPFRate.Rows[e.RowIndex].ErrorText = e.Exception.ToString();
                //}
                //if (e.Context == DataGridViewDataErrorContexts.Scroll)
                //{
                //    dgvGPFRate.Rows[e.RowIndex].ErrorText = e.Exception.ToString();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelBase L_ExcelBase = new ExcelBase("LM_LuckyType");
                L_ExcelBase.ShowDialog();
                if (L_ExcelBase.DialogResult == DialogResult.OK)
                {
                    L_ExcelBase.Close();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                DataTable l_Table = (DataTable)dgvLuckyTypeList.DataSource;
                DataTable l_PreviewData = new DataTable();
                l_PreviewData = l_Table.Copy();
                ds.Tables.Add(l_PreviewData);
                ds.Tables[0].TableName = "data";
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    MessageBox.Show("There is no data to preview");
                    return;
                }
                else
                {
                    CHARS.HR.COMMON.General.Report.viewReport(ds, Application.StartupPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable l_ExcelTable = (DataTable)dgvLuckyTypeList.DataSource;
                #region Remove Columns
                //l_tbl = l_Table.Copy();
                //l_tbl.AcceptChanges();

                ////l_tbl.Columns.Remove("Ask");
                ////l_tbl.Columns.Remove("TS");
                ////l_tbl.Columns.Remove("UD");
                ////l_tbl.Columns.Remove("UDdd");
                //if (l_tbl.Columns.Contains("Ask"))
                //{
                //    l_tbl.Columns.Remove("Ask");
                //}

                #endregion
                #region Change Header
                //l_tbl.Columns["EmployeeID"].ColumnName = "ID";
                //l_tbl.Columns["EmpName"].ColumnName = "Name";
                //l_tbl.Columns["T1"].ColumnName = "Income Tax No.";
                //l_tbl.Columns["N4"].ColumnName = "Categorys";
                //l_tbl.Columns["N3"].ColumnName = "No. of Children";
                //l_tbl.Columns["N10"].ColumnName = "No. of Parent";
                //l_tbl.Columns["T3"].ColumnName = "Effective Date";
                //l_tbl.Columns["MaritalStatus"].ColumnName = "Marital Status";

                //foreach (DataRow dtrow in l_tbl.Rows)
                //{
                //    dtrow.BeginEdit();
                //    if (dtrow["Categorys"].ToString() != "0")
                //    {
                //        dtrow["Category"] = Enum.GetName(typeof(PMEnum.IncomeTaxPCBCategory), dtrow["Categorys"]).Replace("_", " ");
                //    }
                //    if (dtrow["Effective Date"].ToString() != "0")
                //    {
                //        dtrow["Effective Date"] = GeneralUtility.StringToDate(dtrow["Effective Date"].ToString());
                //    }
                //    dtrow.EndEdit();
                //}
                //l_tbl.Columns.Remove("Categorys");
                #endregion
                #region Arrange Columns
                //// yyt 06-02-2013 set order of columns 
                //l_tbl.Columns["ID"].SetOrdinal(0);
                //l_tbl.Columns["Name"].SetOrdinal(1);
                //l_tbl.Columns["Income Tax No."].SetOrdinal(2);
                //l_tbl.Columns["Marital Status"].SetOrdinal(2);
                //l_tbl.Columns["Category"].SetOrdinal(3);
                //l_tbl.Columns["No. Of Parent"].SetOrdinal(4);
                //l_tbl.Columns["No. Of Children"].SetOrdinal(5);
                //l_tbl.Columns["Effective Date"].SetOrdinal(6);
                #endregion

                if (l_ExcelTable.Rows.Count <= 0)
                {
                    MessageBox.Show("There is no data to export");
                    return;
                }
                else
                {
                    ExcelUtil excel = new ExcelUtil();
                    excel.exportToExcel(l_ExcelTable, dgvLuckyTypeList);
                }
                #region Write data
                //SaveFileDialog l_save = new SaveFileDialog();
                //l_save.FileName = System.Windows.Forms.Application.StartupPath + "\\" + "EmployeeIncomeTax.xls";
                //l_save.Filter = "xls files (*.xls)|*.xls|xlsx files (*.xlsx)|*.xlsx";
                //if (l_save.ShowDialog() == DialogResult.OK)
                //{

                //    System.IO.FileInfo l_Finfo = new System.IO.FileInfo(l_save.FileName);
                //    if (l_Finfo.Exists)
                //    {
                //        System.IO.File.Delete(l_save.FileName);

                //    }       
                //    //System.Diagnostics.Process.Start(l_save.FileName);                   

                //}


                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}