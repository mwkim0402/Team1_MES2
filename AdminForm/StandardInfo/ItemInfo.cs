using MES_DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace AdminForm
{
    public partial class ItemInfo : Form
    {
        MainForm frm;
        List<ItemGroupCombo> ItemGroupList = null;
        List<ItemVo> ItemList = null;
        List<ItemVo> searchList = null;
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
            dgvSearchResult.ColumnHeadersHeight = 500;
        }
        private void ItemGroupComboBind()
        {
           // ComboBox[] comboArr= { cmbLv1, cmbLv2, cmbLv3, cmbLv4, cmbLv5 };
          //  ComboBox[] comboUpArr = { cmbUpLvl1, cmbUpLvl2, cmbUpLvl3, cmbUpLvl4, cmbUpLvl5 };
            for(int i =0; i<5; i++)
            {
                List<ComboItem> comboList = (from value in ItemGroupList
                                             where value.Level == "Level"+(i+1)
                                             select new ComboItem
                                             {
                                                 comboText = value.Level_Code,
                                                 comboValue = value.Level_Name
                                             }).ToList();
             //   ComboClass.ComboBind(comboList, comboArr[i], true);
              //  ComboClass.ComboBind(comboList, comboUpArr[i], false) ;
            }
            List<ComboItem> cmbItem = new List<ComboItem>();
            cmbItem.Add(new ComboItem
            {
                comboText = "완제품",
                comboValue = "완제품"
            });
            cmbItem.Add(new ComboItem
            {
                comboText = "원재료",
                comboValue = "원재료"
            });

            ComboClass.ComboBind(cmbItem, cmbInType, false) ;
            ComboClass.ComboBind(cmbItem, cbUpType, false);
            ComboClass.ComboBind(cmbItem, cmbProdCat, true);
        }
        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목코드", "Item_Code", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목명", "Item_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목 영문명", "Item_Name_Eng", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목 영문 약어", "Item_Name_Eng_Alias", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "품목유형", "Item_Type", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "규격", "Item_Spec", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "단위", "Item_Unit", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "안전재고", "Item_Stock", true, 150, DataGridViewContentAlignment.MiddleRight);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "압연공정 UPH", "RollingUPH", true, 180, DataGridViewContentAlignment.MiddleRight);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "제강공정 UPH", "SteelUPH", true, 180, DataGridViewContentAlignment.MiddleRight);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "제선공정 UPH", "IronUPH", true, 180, DataGridViewContentAlignment.MiddleRight);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "포장공정 UPH", "PackageUPH", true, 180, DataGridViewContentAlignment.MiddleRight);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비고", "Remark", true, 200);
            // customize dataviewgrid, add checkbox column
            dgvSearchResult.RowHeadersVisible = false;
            DataGridViewCheckBoxColumn chkboxCol = new DataGridViewCheckBoxColumn();
            chkboxCol.Width = 30;
            chkboxCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSearchResult.Columns.Insert(0, chkboxCol);      
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
            frm.Delete_Click += DeleteItem;
            frm.btnS.PerformClick();
        }

        private void ItemInfo_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= new System.EventHandler(this.Search_Click);
            frm.Delete_Click -= DeleteItem;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(txtInCode.Text == "")
            {
               // frm.lblAlertTitle.Text = "<경고>";
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
                //Level_1 = cmbLv1.Text,
             //   Level_2 = cmbLv2.Text,
              //  Level_3 = cmbLv3.Text,
              //  Level_4 = cmbLv4.Text,
              //  Level_5 = cmbLv5.Text,
                IronUPH = Convert.ToDecimal(nuInsIron.Value),
                RollingUPH = Convert.ToDecimal(nuInsRolling.Value),
                SteelUPH = Convert.ToDecimal(nuInsSteel.Value),
                PackageUPH = Convert.ToDecimal(nuInsPackage.Value),
                //Cavity = int.Parse(txtInCavity.Text),
              //  Line_Per_Qty = Convert.ToInt32(nuLinePCS.Value),
                           // Dry_GV_Qty = Convert.ToInt32(nuInGVQty.Value),
//Heat_GV_Qty = Convert.ToInt32(nuInGVQty.Value),
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
            if (e.ColumnIndex == 0)
            {
                return;
            }
            tabControl2.SelectedIndex = 1;
            ItemVo updateItem = ItemList.Find(x => x.Item_Code == dgvSearchResult.SelectedRows[0].Cells[1].Value.ToString());
            txtUpCode.Text = updateItem.Item_Code;
            txtUpName.Text = updateItem.Item_Name;
            txtUpEnName.Text = updateItem.Item_Name_Eng;
            txtUpEngAbb.Text = updateItem.Item_Name_Eng_Alias;
            cmbInType.Text = updateItem.Item_Type;
            txtUpSpec.Text = updateItem.Item_Spec;
            txtUpUnit.Text = updateItem.Item_Unit;
            nuUpIron.Value = updateItem.IronUPH;
            nuUpRolling.Value = updateItem.RollingUPH;
            nuUpSteel.Value = updateItem.SteelUPH;
            nuUpPack.Value = updateItem.PackageUPH;
            txtUpRemark.Text = updateItem.Remark;
       //     cmbUpLvl1.Text = updateItem.Level_1;
         //   cmbUpLvl2.Text = updateItem.Level_2;
           // cmbUpLvl3.Text = updateItem.Level_3;
            //cmbUpLvl4.Text = updateItem.Level_4;
            //cmbUpLvl5.Text = updateItem.Level_5;
            //txtUpCavity.Text = updateItem.Cavity.ToString();
            //nuUpLine.Value = updateItem.Line_Per_Qty;
            //nuUpShot.Value = updateItem.Shot_Per_Qty;
            //nuUpGVQty.Value = updateItem.Dry_GV_Qty;
            //nuUpProQty.Value = updateItem.PrdQty_Per_Hour;
            //nuUpPerQty.Value = updateItem.PrdQTy_Per_Batch;
            //txtUpRemark.Text = updateItem.Remark;

        }
        private void DeleteItem(object sender, EventArgs e)
        {
            ItemService service = new ItemService();
            for(int i =0;  dgvSearchResult.Rows.Count>i; i++)
            {
                bool isCheked = Convert.ToBoolean(dgvSearchResult.Rows[i].Cells[0].EditedFormattedValue);
                if (isCheked)
                {
                    service.DeleteItemInfo(dgvSearchResult.Rows[i].Cells[1].Value.ToString());
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbProdCat.Text == "선택")
            {
               // frm.lblAlert.Text = "[알람] 먼저 제품유형을 선택하여야 합니다.";
                timer1.Start();
                return;
            }
            else
            {
                if (txtProdCodeSearch.Text == "")
                    searchList = ItemList.FindAll(x => x.Item_Name.ToUpper().Contains(txtProdNameSearch.Text.ToUpper())&&x.Item_Type==cmbProdCat.Text);
                else if (txtProdNameSearch.Text == "")
                    searchList = ItemList.FindAll(x => x.Item_Code.ToUpper().Contains(txtProdCodeSearch.Text.ToUpper()) && x.Item_Type == cmbProdCat.Text);
                else
                    searchList = ItemList.FindAll(x => x.Item_Name.ToUpper().Contains(txtProdNameSearch.Text.ToUpper()) && x.Item_Code.ToUpper().Contains(txtProdCodeSearch.Text.ToUpper()) && x.Item_Type == cmbProdCat.Text);

                if (searchList.Count < 1)
                {
                  //  frm.lblAlert.Text = "[알람] 검색한 조건의 데이터가 존재하지 않습니다.";
                    return;
                }
                //  frm.lblAlertTitle.Text = "[알람]";
               // frm.lblAlert.Text = $"[알람] {searchList.Count} 건의 데이터가 조회되었습니다.";
                timer1.Start();
                dgvSearchResult.DataSource = searchList;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         //   frm.lblAlert.Text = "<공지사항> Test 중 입니다.";
            timer1.Stop();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbInType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbInType.Text == "완제품")
            {
                nuInsRolling.Enabled = nuInsPackage.Enabled = nuInsSteel.Enabled = nuInsIron.Enabled = true;
            }
            else
            {
                nuInsRolling.Value = nuInsPackage.Value = nuInsSteel.Value = nuInsIron.Value = 0;
                nuInsRolling.Enabled = nuInsPackage.Enabled = nuInsSteel.Enabled = nuInsIron.Enabled = false;
            }
        }
    }
}
