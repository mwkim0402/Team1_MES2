using MES_DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminForm
{
    
    public partial class ProcessInfo : AdminForm.dgvOneWithInput
    {
        List<ProcessVo> list;
        MainForm frm;
        public ProcessInfo()
        {
            InitializeComponent();          
        }

        private void ProcessInfo_Load(object sender, EventArgs e)
        {
            frm = (MainForm)this.MdiParent;
            ShowDgv();
            this.dgvSearchResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchResult.CellDoubleClick += CellDoubleClick;
            LoadData();
            BindCombo();
            dgvSearchResult.ColumnHeadersHeight = 30;
        }
        private void LoadData()
        {
            ProcessService service = new ProcessService();
            list = service.GetAllProcess();
            dgvSearchResult.DataSource = list;
        }
        private void SaveButton(object sender, EventArgs e)
        {
            LoadData();
        }
        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "공정코드", "Process_Code", true, 200);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "공정 명", "Process_Name", true, 250);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "공정그룹", "Process_Group", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비고", "Remark", true, 400);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용여부", "Use_YN", true, 120, DataGridViewContentAlignment.MiddleCenter);

            dgvSearchResult.RowHeadersVisible = false;
            DataGridViewCheckBoxColumn chkboxCol = new DataGridViewCheckBoxColumn();
            chkboxCol.Width = 30;
            chkboxCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSearchResult.Columns.Insert(0, chkboxCol);
        }
        private void BindCombo()
        {
            List<ComboItem> comboItems = new List<ComboItem>();
            comboItems.Add(new ComboItem
            {
                comboText = "압연",
                comboValue = "압연"
            });
            comboItems.Add(new ComboItem
            {
                comboText = "제선",
                comboValue = "제선"
            });
            comboItems.Add(new ComboItem
            {
                comboText = "제강",
                comboValue = "제강"
            });
            comboItems.Add(new ComboItem
            {
                comboText = "포장",
                comboValue = "포장"
            });
            ComboClass.ComboBind(comboItems, cbInsertGroup, false);
            ComboClass.ComboBind(comboItems, cbUpdateGroup, false);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbInsertGroup.Text == "제선")
                txtInsertCode.Text = CreateCode("IM", list.Count + 1);
            else if(cbInsertGroup.Text == "제강") 
                txtInsertCode.Text =  CreateCode("SM", list.Count + 1);
            else if (cbInsertGroup.Text == "압연")
                txtInsertCode.Text = CreateCode("RL", list.Count + 1);
            else if (cbInsertGroup.Text == "포장")
                txtInsertCode.Text = CreateCode("PK", list.Count + 1);
        }

        private string CreateCode(string Group, int num)
        {
            return string.Format(DateTime.Now.ToShortDateString().Replace("-", "") + "_"+Group+"_{0:D4}", num);
        }

        private void btnInsSave_Click(object sender, EventArgs e)
        {
            ProcessVo insertVo = new ProcessVo();
            insertVo.Process_Group = cbInsertGroup.Text;
            insertVo.Process_Code = txtInsertCode.Text;
            insertVo.Process_Name = txtInsertName.Text;
            insertVo.Use_YN = rbUse.Checked ? "Y" : "N";
            insertVo.Remark = txtInsRemark.Text;

            ProcessService service = new ProcessService();
            service.InsertProcess(insertVo);
            CommonClass.InitControl(pnlParent1);
            frm.btnS.PerformClick();
        }
        private void CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tcParent2.SelectedIndex = 1;
            string upDateID = dgvSearchResult.Rows[e.RowIndex].Cells[1].Value.ToString();
            ProcessVo updateVo = list.Find(x => x.Process_Code == upDateID);
            txtUpCode.Text = updateVo.Process_Code;
            txtUpName.Text = updateVo.Process_Name;
            cbUpdateGroup.Text = updateVo.Process_Group;
            if (updateVo.Use_YN == "Y")
                rbUpTrue.Checked = true;
            else
                rbUpFalse.Checked = true;
            txtUpRemark.Text = updateVo.Remark;
        }
        private void ProcessInfo_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += SaveButton;
        }

        private void ProcessInfo_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= SaveButton;
        }

        private void btnUpButton_Click(object sender, EventArgs e)
        {
            ProcessVo updateVo = new ProcessVo();
            updateVo.Process_Code = txtUpCode.Text;
            updateVo.Process_Name = txtUpName.Text;
            updateVo.Process_Group = cbUpdateGroup.Text;
            updateVo.Use_YN = rbUpTrue.Checked ? "Y" : "N";
            updateVo.Remark = txtUpRemark.Text;

            ProcessService service = new ProcessService();
            service.UpdateProcess(updateVo);

            CommonClass.InitControl(panel1);
            frm.btnS.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<ProcessVo> searchList;
            if (txtFacCode.Text == "")
                searchList = list.FindAll(x => x.Process_Name.ToUpper().Contains(txtFacName.Text.ToUpper()));
            else if (txtFacName.Text == "")
                searchList = list.FindAll(x => x.Process_Code.ToUpper().Contains(txtFacCode.Text.ToUpper()));
            else
                searchList = list.FindAll(x => x.Process_Name.ToUpper().Contains(txtFacName.Text.ToUpper()) && x.Process_Code.ToUpper().Contains(txtFacCode.Text.ToUpper()));

            if (searchList.Count < 1)
            {
               // frm.lblAlert.Text = "검색한 조건의 데이터가 존재하지 않습니다.";
                return;
            }
           // frm.lblAlert.Text = $"{searchList.Count} 건의 데이터가 조회되었습니다.";
            dgvSearchResult.DataSource = searchList;
        }
    }
}
