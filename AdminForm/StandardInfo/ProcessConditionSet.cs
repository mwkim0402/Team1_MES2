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
    public partial class ProcessConditionSet : dgvTwoWithInput
    {
        MainForm frm;
        List<ComboItem> processCombo;
        List<ComboItem> ItemCombo;
        List<ComboItem> workCombo;
        List<ItemVo> itemList;
        List<ConditionSpecVo> condSpecMaster;
        public ProcessConditionSet()
        {
            InitializeComponent();
        }
        private void ProcessConditionSet_Load(object sender, EventArgs e)
        {
            frm = (MainForm)this.MdiParent;
            ShowDgv();
            LoadList();
            ComboBind();
            dgvSelect.CellDoubleClick += ItemDataSearch;
        }
        private void SearchClick(object sender, EventArgs e)
        {
            LoadList();
        }
        private void LoadList()
        {
            WorkCenterService workService = new WorkCenterService();
            workCombo = (from item in workService.GetAllWorkCenter()
                            select new ComboItem
                            {
                                comboText = item.Wc_Code,
                                comboValue = item.Wc_Name
                            }).ToList();
            ProcessService proService = new ProcessService();
            processCombo = (from item in proService.GetAllProcess()
                            select new ComboItem
                            {
                                comboText = item.Process_Code,
                                comboValue = item.Process_Name
                            }).ToList();
            ItemService itemService = new ItemService();
            itemList = itemService.GetAllItemInfo();
            ItemCombo = (from item in itemList
                         select new ComboItem
                         {
                             comboText = item.Item_Code,
                             comboValue = item.Item_Name
                         }).ToList();
            dgvSelect.DataSource = ItemCombo;
            ConditionSpecService condService = new ConditionSpecService();
            condSpecMaster = condService.GetAllCond();

           
        }
        private void ComboBind()
        {
            ComboClass.ComboBind(processCombo, cbProGroup, false);
            ComboClass.ComboBind(ItemCombo, cbItemCd, false);
            ComboClass.ComboBind(workCombo, cbWorkCd, false);
            cbProGroup.SelectedIndex = 1;
            cbItemCd.SelectedIndex = 1;
        }

        private void ItemDataSearch(object sender, DataGridViewCellEventArgs e)
        {
            string item = dgvSelect.Rows[e.RowIndex].Cells[0].Value.ToString();
            List<ConditionSpecVo> bindList = condSpecMaster.FindAll(x => x.Item_Code == item).ToList();
            dgvSearchResult.DataSource = bindList;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (dgvSearchResult.SelectedRows.Count < 1)
            {
                frm.lblAlert.Text = "복사할 상품의 정보를 선택하세요";
                return;
            }
            ConditionSpecVo copyVo = condSpecMaster.Find(x => x.Condition_Code == dgvSearchResult.SelectedRows[0].Cells[2].Value.ToString());
            txtUSL.Text = copyVo.USL.ToString();
            txtSL.Text = copyVo.SL.ToString();
            txtLSL.Text = copyVo.LSL.ToString();
            txtDataDESC.Text = copyVo.Spec_Desc;
            cbProGroup.Text = copyVo.Condition_Group;
            txtUnit.Text = copyVo.Condition_Unit;
        }

    

        private void CondSpec_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += this.SearchClick;
        }

        private void CondSpec_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= this.SearchClick;
        }
       

        private void ShowDgv()
        {
            tabPage3.Text = "품목 정보";
            tabPage4.Text = "공정 조건 조회";
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "품목 코드", "comboText", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "품목 명", "comboValue", true, 100);

            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목코드", "Item_Code", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "작업장", "Wc_Code", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "검사항목코드", "Condition_Code", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "검사항목", "Condition_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "그룹", "Condition_Group", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "SPEC", "Spec_Desc", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "기준값", "SL", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "상한값", "USL", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "하한값", "LSL", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "공정단위", "Condition_Unit", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비고", "Remark", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용여부", "Use_YN", true, 100);
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            ConditionSpecVo conVo = new ConditionSpecVo
            {
                Wc_Code = cbWorkCd.Text,
                Item_Code = cbItemCd.Text,
                Condition_Code = txtCondCode.Text,
                Condition_Name = txtCondName.Text,
                Spec_Desc = txtDataDESC.Text,
                USL = Convert.ToDecimal(txtUSL.Text),
                SL = Convert.ToDecimal(txtSL.Text),
                LSL = Convert.ToDecimal(txtLSL.Text),
                Condition_Group = cbProGroup.Text,
                Condition_Unit = txtUnit.Text,
                Use_YN = rbY.Checked ? "Y" : "N",
                Remark = txtNote.Text
            };
            ConditionSpecService service = new ConditionSpecService();
            service.InsertCondSpecsMaster(conVo);
            CommonClass.InitControl(panel1);
            frm.btnS.PerformClick();
        }
    }
}
