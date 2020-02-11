using MES_DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class GvInformation : dgvOneWithInput
    {
        MainForm frm;
        List<GvInfoVo> gvList;
        public GvInformation()
        {
            InitializeComponent();
        }

        private void GvInformation_Load(object sender, EventArgs e)
        {
            frm = (MainForm)this.MdiParent;
            ShowDgv();
           
        }

        private void ShowDgv()
        {
            dgvSearchResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "대차코드", "GV_Code", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "대차명", "GV_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "대차그룹", "GV_Group", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "대차상태", "GV_Status", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용유무", "Use_YN", true, 100, DataGridViewContentAlignment.MiddleCenter);
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            GvInfoVo gvVo = new GvInfoVo
            {
                GV_Code = txtTruckCodeInput.Text,
                GV_Name = txtTruckNameInput.Text,
                GV_Group = cmbGVGroup.Text,
                GV_Status = "빈대차",
                Use_YN = rbY.Checked ? "Y" : "N"
            };
            GVInfoService service = new GVInfoService();
            if (service.InsertGVInfo(gvVo))
            {
                frm.lblAlert.Text = "등록완료되었습니다";
                CommonClass.InitControl(pnlParent1);                
                frm.btnS.PerformClick();
                cmbGVGroup.SelectedIndex = 1;
            }
            else
            {
                frm.lblAlert.Text = "등록 실패하였습니다.";
            }
        }
        private void Search_Click(object sender, EventArgs e)
        {
            GVInfoService service = new GVInfoService();
            gvList = service.GetAllGVInfo();
            dgvSearchResult.DataSource = gvList;
        }
        private void GvInformation_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += Search_Click;
            frm.btnS.PerformClick();
            int count = gvList.FindAll(x => x.GV_Group == "제강 대차").Count + 1;
            txtTruckCodeInput.Text = "SMGV_" + string.Format("{0:D3}", count);
        }

        private void GvInformation_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= Search_Click;
        }

        private void cmbGVGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbGVGroup.Text == "제강 대차")
            {
                int count = gvList.FindAll(x => x.GV_Group == "제강 대차").Count +1;
                txtTruckCodeInput.Text = "SMGV_"+string.Format("{0:D3}", count);
            }
            else
            {
                int count = gvList.FindAll(x => x.GV_Group == "압연 대차").Count+1;
                txtTruckCodeInput.Text = "RollGV_" + string.Format("{0:D3}", count);
            }
            
        }
    }
}
