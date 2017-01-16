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
    public partial class LstPerson : LstBase
    {
        public LstPerson()
        {            
            InitializeComponent();            
            loadGrid();
            //setToolTip();
            //setMaxsize();
            //hideGridviewcolumn();
        }
        Utility mUtility = new Utility();
        MasterBLL mMasterBLL = new MasterBLL();
        PersonObj  mPersonObj = new PersonObj();
        PersonToolTip mPersonToolTip = new PersonToolTip();

        #region"Private Methods"
        private void prepareFilter()
        {

        }
        private void setToolTip()
        {
            try
            {
                this.dgvList.Columns[0].ToolTipText = mPersonToolTip.Ask.ToString();
                this.dgvList.Columns[1].ToolTipText = mPersonToolTip.PersonName.ToString();
                this.dgvList.Columns[2].ToolTipText = mPersonToolTip.PersonNiceName.ToString();
                this.dgvList.Columns[3].ToolTipText = mPersonToolTip.PersonAddress.ToString();
                this.dgvList.Columns[4].ToolTipText = mPersonToolTip.PersonPhone.ToString();
                this.dgvList.Columns[5].ToolTipText = mPersonToolTip.PersonPhone.ToString();
                this.dgvList.Columns[6].ToolTipText = mPersonToolTip.PersonRemark.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void hideGridviewcolumn()
        {
            this.dgvList.Columns[0].Visible = false;
        }
        private void setMaxsize()
        {
            try
            {
                this.dgvList.Columns[0].Width = 150;
                this.dgvList.Columns[1].Width = 150;
                this.dgvList.Columns[2].Width = 150;
                this.dgvList.Columns[3].Width = 150;
                this.dgvList.Columns[4].Width = 150;
                this.dgvList.Columns[5].Width = 150;
                this.dgvList.Columns[6].Width = 150;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void sequenceGridviewcolumn()
        {
            //this.dgvList.Columns[0].Visible = false;
        }
        private void loadGrid()
        {
            try
            {
                DataTable mm = new DataTable();
                
                    //DataTable a = mMasterBLL.getPersonData("CS_SP_SELECT_PERSON", "");
                    //dgvList.DataSource = a;
                dgvList.DataSource = mMasterBLL.getPersonData("CS_SP_SELECT_PERSON", "");
                dgvList.Columns[0].Visible=false;
                dgvList.Columns[1].Visible=false;
                dgvList.Columns[2].Visible=false;
                dgvList.Columns[3].Visible=false;
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
                SetPerson L_SetPerson = new SetPerson();
                L_SetPerson.ShowDialog();
                if (L_SetPerson.DialogResult == DialogResult.Cancel)
                {
                    loadGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void LstPerson_Load(object sender, EventArgs e)
        {
            try
            {
                //loadGrid();
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
                    {
                        //pan.BackColor = Color.AliceBlue;
                        SetPerson L_SetPerson = new SetPerson(dgvList.CurrentRow.Cells[0].Value.ToString(),
                            dgvList.CurrentRow.Cells[1].Value.ToString(), dgvList.CurrentRow.Cells[2].Value.ToString(), dgvList.CurrentRow.Cells[3].Value.ToString());
                        L_SetPerson.ShowDialog();
                        if (L_SetPerson.DialogResult == DialogResult.Cancel)
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
                //GeneralUtility.ShowErrorMsg(ex);
            }
        }
        private void butFind_Click(object sender, EventArgs e)
        {
            try
            {
                loadGrid();
                hideGridviewcolumn();
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
                //GeneralUtility.ShowErrorMsg(ex);
            }
        }

        #endregion

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                FindBase fb = new FindBase("Person", new PersonObj());
                fb.ShowDialog();
                if (fb.DialogResult == DialogResult.Cancel)
                {
                    PersonObj personObj = (PersonObj)fb.DynObject;

                    //string data = Utility.getPropertyValue2(periodObj);
                    //dgvList.DataSource = mMasterBLL.selectDataTableWithCondition("Person", personObj);

                }

                //loadGrid();
                //hideGridviewcolumn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void dgvList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((int)e.ColumnIndex == 19)
            {
                if (e.Value != null)
                {
                    e.Value = Decimal.Round(Convert.ToDecimal(e.Value), 2);
                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }




    }
}