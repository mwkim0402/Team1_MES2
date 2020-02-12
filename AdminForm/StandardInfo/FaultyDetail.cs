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
    public partial class FaultyDetail : Form
    {
        List<FaultyMasterVo> faultyMasterList;
        List<FaultyDetailVo> faultyDetailList;
        MainForm frm;
        public FaultyDetail()
        {
            InitializeComponent();
        }

        private void FaultyDetail_Load(object sender, EventArgs e)
        {
            frm = (MainForm)this.MdiParent;
            ShowDgv();
            GetList();
            ComboBind();
        }
        private void GetList()
        {
            FaultyService service = new FaultyService();
            faultyMasterList = service.GetAllFaultyMaster();
            dgvSelect.DataSource = faultyMasterList;

            faultyDetailList = service.GetFaultyDetail();
        }
        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "불량현상 대분류 코드", "Def_Ma_Code", true, 200);
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "불량현상 대분류 명", "Def_Ma_Name", true, 200);
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "사용유무", "Use_YN", true, 150, DataGridViewContentAlignment.MiddleCenter);

            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "불량현상 대분류 코드", "Def_Ma_Code", true, 200);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "불량현상 상세분류 코드", "Def_Mi_Code", true, 250);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "불량현상 상세분류 명", "Def_Mi_Name", true, 250);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용여부", "Use_YN", true, 150, DataGridViewContentAlignment.MiddleCenter);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비고", "Remark", true, 500);
        }
        private void ComboBind()
        {
            List<ComboItem> list = (from item in faultyMasterList
                                    select new ComboItem
                                    {
                                        comboText = item.Def_Ma_Name,
                                        comboValue = item.Def_Ma_Code
                                    }).ToList();
            ComboClass.ComboBind(list, cbInsMasterCode, false);
        }
        private void btnSearch(object sender, EventArgs e)
        {
            FaultyService service = new FaultyService();
            faultyMasterList = service.GetAllFaultyMaster();
            dgvSelect.DataSource = faultyMasterList;
        }

        private void FaultyDetail_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += btnSearch;
        }

        private void FaultyDetail_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= btnSearch;
        }

        private void dgvSelect_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string masterID = dgvSelect.Rows[e.RowIndex].Cells[0].Value.ToString();
            List<FaultyDetailVo> list = (from item in faultyDetailList
                                         where item.Def_Ma_Code == masterID
                                         select item).ToList();
            dgvSearchResult.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FaultyDetailVo insertVo = new FaultyDetailVo();
            insertVo.Def_Ma_Code = cbInsMasterCode.SelectedValue.ToString();
            insertVo.Def_Mi_Code = txtInsDetailCode.Text;
            insertVo.Def_Mi_Name = txtInsDetailName.Text;
            insertVo.Use_YN = rbInsTrue.Checked ? "Y" : "F";
            insertVo.Remark = txtInsRemark.Text;

            FaultyService service = new FaultyService();
            service.InsertFaultyDetail(insertVo);

            frm.lblAlert.Text = "등록되었습니다.";

            faultyDetailList = service.GetFaultyDetail();

            CommonClass.InitControl(panel1);
        }
    }
}
