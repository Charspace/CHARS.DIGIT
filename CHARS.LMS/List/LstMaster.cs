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
    public partial class LstMaster : LstBase
    {
        public LstMaster()
        {
            InitializeComponent();
            loadGrid();
            //setToolTip();
            //hideGridviewcolumn();
        }
        Utility mUtility = new Utility();
        MasterBLL mMasterBLL = new MasterBLL();
        MasterObj mMasterObj = new MasterObj();
        MasterToolTip mMasterToolTip = new MasterToolTip();
        PersonObj mPersonObj = new PersonObj();

        #region"Properties"       
        private void prepareFilter()
        {

        }
        private void setToolTip()
        {
            try
            {
                this.dgvMaster.Columns[0].ToolTipText = mMasterToolTip.Ask.ToString();
                this.dgvMaster.Columns[1].ToolTipText = mMasterToolTip.PersonAsk.ToString();
                this.dgvMaster.Columns[2].ToolTipText = mMasterToolTip.MasterCode.ToString();                
                this.dgvMaster.Columns[3].ToolTipText = mMasterToolTip.MasterDescription.ToString();
                this.dgvMaster.Columns[4].ToolTipText = mMasterToolTip.MasterPhone.ToString();
                this.dgvMaster.Columns[5].ToolTipText = mMasterToolTip.MasterAddress.ToString();
                this.dgvMaster.Columns[6].ToolTipText = mMasterToolTip.MasterEmail.ToString();
                this.dgvMaster.Columns[7].ToolTipText = mMasterToolTip.MasterCode.ToString();               
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
                this.dgvMaster.Columns[0].Visible = false;
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
                dgvConList.DataSource = mMasterBLL.selectDataTable("Master", "");
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
                SetMaster L_SetMaster = new SetMaster();
                L_SetMaster.ShowDialog();
                if (L_SetMaster.DialogResult == DialogResult.Cancel)
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
                if (dgvMaster.Rows.Count > 0)
                {
                    if (dgvMaster.CurrentRow.Cells[0].Value != null)
                        //if (dgvMaster.CurrentRow.Cells[dgvtxaskey.Index].Value != null)
                    {
                        //pan.BackColor = Color.AliceBlue;
                        //SetMaster L_SetMaster = new SetMaster((long)dgvMaster.CurrentRow.Cells[dgvtxaskey.Index].Value);
                        SetMaster L_SetMaster = new SetMaster((string)dgvMaster.CurrentRow.Cells[0].Value);
                        L_SetMaster.ShowDialog();
                        if (L_SetMaster.DialogResult == DialogResult.Cancel)
                        {
                            loadGrid();
                            setToolTip();
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

        private void dgvPerson_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void dgvMaster_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((int)e.ColumnIndex == dgvMaster.Columns[1].Index)
            {
                if (e.Value != null)
                {
                    //mPersonObj.Ask = Convert.ToInt64(e.Value);
                    DataTable m = new DataTable();
                    m = mMasterBLL.selectDataTablebyAsk("Person", mPersonObj);
                    if (m.Rows.Count > 0)
                    {
                        e.Value = m.Rows[0][1].ToString();
                    }

                }
            }
        }

    }
}