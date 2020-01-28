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
    public partial class ProcessConditionSet : dgvTwoWithInput
    {
        MainForm frm;
        List<ComboItem> processCombo;
        List<ComboItem> ItemCombo;
        List<ItemVo> itemList;
        List<InspectVo> inspectMaster;
        public ProcessConditionSet()
        {
            InitializeComponent();
        }
        private void QualitySizeSet_Load(object sender, EventArgs e)
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
            InspectService inspectService = new InspectService();
            inspectMaster = inspectService.GetAllInspect();
        }
        private void ComboBind()
        {
            ComboClass.ComboBind(processCombo, cbProcessCd, false);
            ComboClass.ComboBind(ItemCombo, cbItemCd, false);
            cbProcessCd.SelectedIndex = 1;
            cbItemCd.SelectedIndex = 1;
        }

        private void ItemDataSearch(object sender, DataGridViewCellEventArgs e)
        {
            string item = dgvSelect.Rows[e.RowIndex].Cells[0].Value.ToString();
            List<InspectVo> bindList = inspectMaster.FindAll(x => x.Item_Code == item).ToList();
            dgvSearchResult.DataSource = bindList;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (dgvSearchResult.SelectedRows.Count < 1)
            {
                frm.lblAlert.Text = "복사할 상품의 정보를 선택하세요";
                return;
            }
            InspectVo copyVo = inspectMaster.Find(x => x.Inspect_Code == dgvSearchResult.SelectedRows[0].Cells[2].Value.ToString());
            txtUSL.Text = copyVo.USL.ToString();
            txtSL.Text = copyVo.SL.ToString();
            txtLSL.Text = copyVo.LSL.ToString();
            txtDataDESC.Text = copyVo.Spec_Desc;
            txtSample.Text = copyVo.Sample_Size.ToString();
            txtUnit.Text = copyVo.Inspect_Unit;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InspectVo inspectVo = new InspectVo
            {
                Process_Code = cbProcessCd.Text,
                Item_Code = cbItemCd.Text,
                Inspect_Code = txtInsepctCode.Text,
                Inspect_Name = txtInspectName.Text,
                Spec_Desc = txtDataDESC.Text,
                USL = Convert.ToDecimal(txtUSL.Text),
                SL = Convert.ToDecimal(txtSL.Text),
                LSL = Convert.ToDecimal(txtLSL.Text),
                Sample_Size = Convert.ToInt32(txtSample.Text),
                Inspect_Unit = txtUnit.Text,
                Use_YN = rbY.Checked ? "Y" : "N",
                Remark = txtNote.Text
            };
            InspectService service = new InspectService();
            service.InsertInspectMaster(inspectVo);
            CommonClass.InitControl(panel1);
            frm.btnS.PerformClick();
        }

        private void QualitySizeSet_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += this.SearchClick;
        }

        private void QualitySizeSet_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= this.SearchClick;
        }
        private void ProcessConditionSet_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            tabPage3.Text = "";
            tabPage4.Text = "";
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "품목 등급", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "품목 명", "1", true, 100);

            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "설비", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "검사항목코드", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "검사항목", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "그룹", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "SPEC", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "기준값", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "샘플크기", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "검사기기", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "규격구분", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비고", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용여부", "1", true, 100);
        }
    }
}
