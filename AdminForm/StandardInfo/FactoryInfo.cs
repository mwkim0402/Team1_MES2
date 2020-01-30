using MES_DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class FactoryInfo : Form
    {
        List<WorkCenterVo> list;
        List<WorkCenterVo> searchList;
        List<ComboItem> processCombo;
        MainForm frm;
        public FactoryInfo()
        {
            InitializeComponent();
        }

        private void FactoryInfo_Load(object sender, EventArgs e)
        {
            frm = (MainForm)this.MdiParent;
            ShowDgv();
            LoadList();
            ComboBind();
        }
        private void SearchClick(object sender, EventArgs e)
        {
            LoadList();
        }
        private void LoadList()
        {
            WorkCenterService service = new WorkCenterService();
            list = service.GetAllWorkCenter();
            dataGridView1.DataSource = list;

            ProcessService proService = new ProcessService();
            processCombo = (from item in proService.GetAllProcess()
                            select new ComboItem
                            {
                                comboText = item.Process_Code,
                                comboValue = item.Process_Name
                            }).ToList();
        }
        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dataGridView1, "작업장 코드", "Wc_Code", true, 100);
            CommonClass.AddNewColumnToDataGridView(dataGridView1, "작업장 명", "Wc_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dataGridView1, "작업장 유형", "Wc_Group", true, 100);       
            CommonClass.AddNewColumnToDataGridView(dataGridView1, "공정 코드", "Process_Code", true, 100);
            CommonClass.AddNewColumnToDataGridView(dataGridView1, "작업지시 자동시작 여부", "Auto_Start_YN", true, 30);
            CommonClass.AddNewColumnToDataGridView(dataGridView1, "작업지시 자동 생성 유무", "Auto_Wo_YN", true,30);
            CommonClass.AddNewColumnToDataGridView(dataGridView1, "자동 비가동 여부", "Nop_Auto_YN", true, 30);
            CommonClass.AddNewColumnToDataGridView(dataGridView1, "자동 비가동 시간", "Nop_Check_Time", true, 100);
            CommonClass.AddNewColumnToDataGridView(dataGridView1, "실적등록유형", "Prd_Req_Type", true, 100);
            CommonClass.AddNewColumnToDataGridView(dataGridView1, "실적단위", "Prd_Unit", true, 100);
            CommonClass.AddNewColumnToDataGridView(dataGridView1, "팔레트생성유무", "Pallet_YN", true, 100);
            CommonClass.AddNewColumnToDataGridView(dataGridView1, "비고", "Remark", true, 100);
            CommonClass.AddNewColumnToDataGridView(dataGridView1, "사용유무", "Use_YN", true, 100);
            CommonClass.AddNewColumnToDataGridView(dataGridView1, "비가동 상태", "Wo_Status", true, 100);
            CommonClass.AddNewColumnToDataGridView(dataGridView1, "금형장착여부", "Mold_Setup_YN", true, 30);
        }
        private void ComboBind()
        {
            ComboClass.ComboBind(processCombo, cbProcessCode, false);
            cbProcessCode.SelectedIndex = 1;
            cmbWPCategory.SelectedIndex = 1;
        }
     
        private void cmbWPCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbWPCategory.Text == "소성")               
                txtWPCodeInput.Text = CreateCode("PL", list.FindAll(x => x.Wc_Code.Contains("PL")).Count + 1);
            else if (cmbWPCategory.Text == "건조")
                txtWPCodeInput.Text = CreateCode("DY", list.FindAll(x => x.Wc_Code.Contains("DY")).Count + 1);
            else if (cmbWPCategory.Text == "성형")
                txtWPCodeInput.Text = CreateCode("FR", list.FindAll(x => x.Wc_Code.Contains("FR")).Count + 1);
            else if (cmbWPCategory.Text == "포장")
                txtWPCodeInput.Text = CreateCode("PK", list.FindAll(x => x.Wc_Code.Contains("PK")).Count + 1);
        }

        private string CreateCode(string Group, int num)
        {
            return string.Format(Group + "Center_{0:D4}", num);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rbUse_NonOp_CheckedChanged(object sender, EventArgs e)
        {
            nuNonTime.Enabled = rbUse_NonOp.Checked;
        }

        private void cbProcessCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFactoryNameInput.Text = cbProcessCode.SelectedValue.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            WorkCenterVo item = new WorkCenterVo();
            item.Wc_Code = txtWPCodeInput.Text;
            item.Wc_Name = txtWPNameInput.Text;
            item.Wc_Group = cmbWPCategory.Text;
            item.Process_Code = cbProcessCode.Text;
            item.Prd_Unit = cmbPerformUnit.Text;
            item.Prd_Req_Type = "임시";
            item.Nop_Auto_YN = rbUse_NonOp.Checked ? "Y" : "N";
            item.Nop_Check_Time = rbUse_NonOp.Checked ? Convert.ToInt32(nuNonTime.Value) : 0;
            item.Mold_Setup_YN = rbUse_MoldEq.Checked ? "Y" : "N";
            item.Use_YN = rbUse_Use.Checked ? "Y" : "N";
            item.Pallet_YN = rbUse_Pallet.Checked ? "Y":"N";
            item.Auto_Wo_YN = rbUse_OrderCreate.Checked ? "Y" : "N";
            item.Auto_Start_YN = rbUse_OrderStart.Checked ? "Y" : "N";
            item.Mold_Setup_YN = rbUse_MoldEq.Checked ? "Y" : "N";
            item.Remark = txtPS.Text;

            WorkCenterService service = new WorkCenterService();
            service.InsertWorkCenter(item);
            frm.btnS.PerformClick();
            CommonClass.InitControl(panel1);
        }

        private void FactoryInfo_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += this.SearchClick;
        }

        private void FactoryInfo_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= this.SearchClick;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtWPCode.Text == "")
                searchList = list.FindAll(x => x.Wc_Name.ToUpper().Contains(txtWPName.Text.ToUpper()));
            else if (txtWPName.Text == "")
                searchList = list.FindAll(x => x.Wc_Code.ToUpper().Contains(txtWPCode.Text.ToUpper()));
            else
                searchList = list.FindAll(x => x.Wc_Name.ToUpper().Contains(txtWPName.Text.ToUpper()) && x.Wc_Code.ToUpper().Contains(txtWPCode.Text.ToUpper()));

            if (searchList.Count < 1)
            {
                frm.lblAlert.Text = "검색한 조건의 데이터가 존재하지 않습니다.";
                return;
            }
          //  frm.lblAlertTitle.Text = "[알람]";
            frm.lblAlert.Text = $"{searchList.Count} 건의 데이터가 조회되었습니다.";
            timer1.Start();
            dataGridView1.DataSource = searchList;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //frm.lblAlertTitle.Text = "";
            frm.lblAlert.Text = "";
            timer1.Stop();
        }
    }
}
