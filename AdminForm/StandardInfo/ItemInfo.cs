using MES_DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
 

namespace AdminForm
{
    public partial class ItemInfo : Form
    {
        MainForm frm;
        List<ItemGroupCombo> ItemGroupList = null;
        List<ItemVo> ItemList = null;
        public ItemInfo()
        {
            InitializeComponent();
        }

        private void ItemInfo_Load(object sender, EventArgs e)
        {
            ShowDgv();
            frm = (MainForm)this.MdiParent;

            ItemService service = new ItemService();
            ItemGroupList = service.GetItemGroupCombo();
            ItemGroupComboBind();

            dgvSearchResult.CellDoubleClick += dataGridView1_CellDoubleClick;
        }
        private void ItemGroupComboBind()
        {
            ComboBox[] comboArr= { cmbLv1, cmbLv2, cmbLv3, cmbLv4, cmbLv5 };
            ComboBox[] comboUpArr = { cmbUpLvl1, cmbUpLvl2, cmbUpLvl3, cmbUpLvl4, cmbUpLvl5 };
            for(int i =0; i<5; i++)
            {
                List<ComboItem> comboList = (from value in ItemGroupList
                                             where value.Level == "Level"+(i+1)
                                             select new ComboItem
                                             {
                                                 comboText = value.Level_Code,
                                                 comboValue = value.Level_Name
                                             }).ToList();
                ComboClass.ComboBind(comboList, comboArr[i], true);
                ComboClass.ComboBind(comboList, comboUpArr[i], false) ;
            }
            List<ComboItem> cmbItem = new List<ComboItem>();
            cmbItem.Add(new ComboItem
            {
                comboText = "완제품",
                comboValue = "완제품"
            });
            cmbItem.Add(new ComboItem
            {
                comboText = "자재",
                comboValue = "자재"
            });
            cmbItem.Add(new ComboItem
            {
                comboText = "반제품",
                comboValue = "반제품"
            });
            ComboClass.ComboBind(cmbItem, cmbInType, false) ;
            ComboClass.ComboBind(cmbItem, cbUpType, false);
        }
        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목코드", "Item_Code", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목명", "Item_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목 영문명", "Item_Name_Eng", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목 영문명 약어", "Item_Name_Eng_Alias", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목유형", "Item_Type", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "규격", "Item_Spec", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "단위", "Item_Unit", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "안전재고", "Item_Stock", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "Level 1", "Level_1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "Level 2", "Level_2", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "Level 3", "Level_3", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "Level 4", "Level_4", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "Level 5", "Level_5", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "LotSize", "LotSize", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "캐비티", "Cavity", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "시간당 생산량", "PrdQty_Per_Hour", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "배치당 생산량", "PrdQTy_Per_Batch", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "한줄당PCS수", "Line_Per_Qty", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "한Shot당 PCS수", "Shot_Per_Qty", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "건조대차 기본 수량 ", "Dry_GV_Qty", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "소성대차 기본 수량 ", "Heat_GV_Qty", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비고", "Remark", true, 100);
        }
        private void Search_Click(object sender, EventArgs e)
        {
            ItemService service = new ItemService();
            ItemList = service.GetAllItemInfo();
            this.dgvSearchResult.DataSource = ItemList;
        }

        private void ItemInfo_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += new System.EventHandler(this.Search_Click);
        }

        private void ItemInfo_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= new System.EventHandler(this.Search_Click);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(txtInCode.Text == "")
            {
                frm.lblAlertTitle.Text = "<경고>";
                frm.lblAlert.ForeColor = Color.Red;
                return;
            }
            ItemVo item = new ItemVo
            {
                Item_Code = txtInCode.Text,
                Item_Name = txtInName.Text,
                Item_Name_Eng = txtUpEngName.Text,
                Item_Name_Eng_Alias = txtEngAli.Text,
                Item_Type = cmbInType.Text,
                Item_Spec = txtInSpec.Text,
                Item_Unit = txtInUnit.Text,
                Level_1 = cmbLv1.Text,
                Level_2 = cmbLv2.Text,
                Level_3 = cmbLv3.Text,
                Level_4 = cmbLv4.Text,
                Level_5 = cmbLv5.Text,
                Item_Stock = Convert.ToDecimal(0),
                LotSize = Convert.ToDecimal(10),
                PrdQty_Per_Hour = Convert.ToDecimal(10),
                PrdQTy_Per_Batch = Convert.ToDecimal(10),
                Cavity = int.Parse(txtInCavity.Text),
                Line_Per_Qty = Convert.ToInt32(nuLinePCS.Value),
                Shot_Per_Qty = Convert.ToInt32(nuInShotPcs.Value),
                Dry_GV_Qty = Convert.ToInt32(nuInGVQty.Value),
                Heat_GV_Qty = Convert.ToInt32(nuInGVQty.Value),
                Remark = txtInremark.Text
            };
            ItemService service = new ItemService();
            if(service.InsertItemInfo(item))
            {
                MessageBox.Show("아이템 정보를 입력하였습니다");
            }
            else
            {
                MessageBox.Show("입력 실패다");
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabPage1.Select();
            string SearchID = dgvSearchResult.Rows[e.RowIndex].Cells[0].Value.ToString();
            List<ItemVo> updateList = (from item in ItemList
                                 where item.Item_Code == SearchID
                                 select item).ToList();
            ItemVo updateItem = updateList[0];
            
            txtUpCode.Text = SearchID;
            txtUpName.Text = updateItem.Item_Name;
            txtUpEnName.Text = updateItem.Item_Name_Eng;
            txtUpEngAbb.Text = updateItem.Item_Name_Eng_Alias;
            cbUpType.Text = updateItem.Item_Type;

            if (updateItem.Level_1 != null)
                cmbUpLvl1.Text = updateItem.Level_1;
            else
                cmbUpLvl1.Text = "선택";

            if (updateItem.Level_2 != null)
                cmbUpLvl2.Text = updateItem.Level_2;
            else
                cmbUpLvl2.Text = "선택";

            if (updateItem.Level_3 != null)
                cmbUpLvl3.Text = updateItem.Level_3;
            else
                cmbUpLvl3.Text = "선택";

            if (updateItem.Level_4 != null)
                cmbUpLvl4.Text = updateItem.Level_4;
            else
                cmbUpLvl4.Text = "선택";
            
            if (updateItem.Level_5 != null)
                cmbUpLvl5.Text = updateItem.Level_5;
            else
                cmbUpLvl5.Text = "선택";

            nuUpShot.Value = updateItem.Shot_Per_Qty;
            nuUpLine.Value = updateItem.Line_Per_Qty;
            nuUpProQty.Value = updateItem.PrdQty_Per_Hour;
            nuUpPerQty.Value = updateItem.PrdQty_Per_Hour;
            nuUpGVQty.Value = updateItem.Dry_GV_Qty;
            txtUpCavity.Text = updateItem.Cavity.ToString();
            txtUpUnit.Text = updateItem.Item_Unit.ToString();
            txtUpSpec.Text = updateItem.Item_Spec;
            txtUpRemark.Text = updateItem.Remark;

       }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
