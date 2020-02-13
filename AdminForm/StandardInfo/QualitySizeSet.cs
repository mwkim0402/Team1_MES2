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
    public partial class QualitySizeSet : AdminForm.dgvTwoWithInput
    {
        MainForm frm;
        List<ComboItem> processCombo;
        List<ComboItem> ItemCombo;
        List<ItemVo> itemList;
        List<InspectVo> inspectMaster;
        public QualitySizeSet()
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
            cbSampleSize.SelectedIndex = 0;
        }
        private void ShowDgv()
        {
            tabPage3.Text = "품목 조회";
            tabPage4.Text = "품질 규격 조회";
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "품목 코드", "comboText", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSelect, "품목 명", "comboValue", true, 120);

            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목코드", "Item_Code", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "공정코드", "Process_Code", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "검사항목 코드", "Inspect_Code", true, 180);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "검사항목 명", "Inspect_Name", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "SPEC", "Spec_Desc", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "검사항목", "Inspect_Group", true, 120, DataGridViewContentAlignment.MiddleRight);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "검사단위", "Inspect_Unit", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "규격상한값", "USL", true, 150,DataGridViewContentAlignment.MiddleRight);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "규격하한값", "SL", true, 150, DataGridViewContentAlignment.MiddleRight);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "규격기준값", "LSL", true, 150, DataGridViewContentAlignment.MiddleRight);
           
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용여부", "Use_YN", true, 120,DataGridViewContentAlignment.MiddleCenter);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비고", "Remark", true, 200);
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
                //frm.lblAlert.Text = "복사할 상품의 정보를 선택하세요";
                return;
            }
            InspectVo copyVo = inspectMaster.Find(x => x.Inspect_Code == dgvSearchResult.SelectedRows[0].Cells[2].Value.ToString());
            txtUSL.Text = copyVo.USL.ToString();
            txtSL.Text = copyVo.SL.ToString();
            txtLSL.Text = copyVo.LSL.ToString();
            txtDataDESC.Text = copyVo.Spec_Desc;
            cbSampleSize.Text = copyVo.Inspect_Group.ToString();
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
                Inspect_Group = cbSampleSize.Text,
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            //frm.lblAlert.Text = "";
            timer1.Stop();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbSampleSize.Text == "길이" || cbSampleSize.Text == "두께")
            {
                txtUnit.Text = "mm";
            }
            else if(cbSampleSize.Text == "무게")
            {
                txtUnit.Text = "kg/m";
            }
            else
            {
                txtUnit.Text = "kgf/㎟";
            }
        }

        private void fcFac_Load(object sender, EventArgs e)
        {

        }

        private void cbItemCd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbItemCd.SelectedValue != null)
            {
                int count = inspectMaster.FindAll(x => x.Process_Code == cbProcessCd.Text.ToString() && x.Item_Code == cbItemCd.Text.ToString()).Count + 1;
                string id = $"{cbProcessCd.Text.ToString().Substring(0, 2)}{cbItemCd.Text.ToString()}_InSpect{count}";
                txtInsepctCode.Text = id;
            }         
        }
    }
}
