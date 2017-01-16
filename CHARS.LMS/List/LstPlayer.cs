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
    public partial class LstPlayer :LstBase
    {
        public LstPlayer()
        {
            InitializeComponent();
            loadGrid();
            //setToolTip();
            //hideGridviewcolumn();
        }
        Utility mUtility = new Utility();
        MasterBLL mMasterBLL = new MasterBLL();
        PlayerObj mPlayerObj = new PlayerObj();
        PlayerToolTip mPlayerToolTip = new PlayerToolTip();
        PersonObj mPersonObj = new PersonObj();

        #region"Properties"
        private void prepareFilter()
        {

        }
        private void setToolTip()
        {
            try
            {
                this.dgvPlayer.Columns[0].ToolTipText = mPlayerToolTip.Ask.ToString();
                this.dgvPlayer.Columns[1].ToolTipText = mPlayerToolTip.PersonAsk.ToString();
                this.dgvPlayer.Columns[2].ToolTipText = mPlayerToolTip.PlayerCode.ToString();
                this.dgvPlayer.Columns[3].ToolTipText = mPlayerToolTip.PlayerDescription.ToString();
                this.dgvPlayer.Columns[4].ToolTipText = mPlayerToolTip.PlayerPhone.ToString();
                this.dgvPlayer.Columns[5].ToolTipText = mPlayerToolTip.PlayerAddress.ToString();
                this.dgvPlayer.Columns[6].ToolTipText = mPlayerToolTip.PlayerEmail.ToString();
                this.dgvPlayer.Columns[7].ToolTipText = mPlayerToolTip.PlayerRemark.ToString();
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
                this.dgvPlayer.Columns[0].Visible = false;
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
                dgvList.DataSource = mMasterBLL.selectDataTable("Player", "1,3,2,5");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //GeneralUtility.ShowErrorMsg(ex);
            }

        }


        #endregion

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                SetPlayer L_SetPlayer = new SetPlayer();
                L_SetPlayer.ShowDialog();
                if (L_SetPlayer.DialogResult == DialogResult.Cancel)
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
                if (dgvPlayer.Rows.Count > 0)
                {
                    //if (dgvPlayer.CurrentRow.Cells[dgvtxaskey.Index].Value != null)
                    if (dgvPlayer.CurrentRow.Cells[0].Value != null)
                    {
                        //pan.BackColor = Color.AliceBlue;
                        //SetPlayer L_SetPlayer = new SetPlayer((long)dgvPlayer.CurrentRow.Cells[dgvtxaskey.Index].Value);
                        SetPlayer L_SetPlayer = new SetPlayer((string)dgvPlayer.CurrentRow.Cells[0].Value);
                        L_SetPlayer.ShowDialog();
                        if (L_SetPlayer.DialogResult == DialogResult.Cancel)
                        {
                            loadGrid();
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

        private void dgvPlayer_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((int)e.ColumnIndex == dgvPlayer.Columns[1].Index)
            {
                if (e.Value != null)
                {
                    mPersonObj.Ask = e.Value.ToString();
                    //DataTable m = new DataTable();
                    //m = mMasterBLL.selectDataTablebyAsk("Person", mPersonObj);                    
                    //if (m.Rows.Count > 0)
                    //{
                    //    e.Value = m.Rows[0][1].ToString();
                    //}
                    mPersonObj = (PersonObj)mMasterBLL.selectObjbyAskobj("Person", mPersonObj);
                    e.Value = mPersonObj.PersonName;

                }
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {

        }
    }
}