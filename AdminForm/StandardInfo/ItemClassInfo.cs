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
    public partial class ItemClassInfo : dgvOne
    {
        MainForm frm;
        List<ItemGroupCombo> ItemGroupList = null;
        List<ItemGroupVo> itemGroupVo;
        List<ItemGroupVo> SearchGroupList;
        string[] levelArr = { "선택","Level1", "Level2", "Level3", "Level4", "Level5" };
        
        public ItemClassInfo()
        {
           
            InitializeComponent();
        }

        private void ItemClassInfo_Load(object sender, EventArgs e)
        {
            //  frm.Search_Click += new System.EventHandler(this.Search_Click);
            // ItemService service = new ItemService();;
            frm = (MainForm)this.MdiParent;
            ShowDgv();
            // dgvSearchResult.DataSource = service.GetAllItem();
            cmbLv.DataSource = levelArr;
            ItemService service = new ItemService();
            ItemGroupList = service.GetItemGroupCombo();
          
        }
        
        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "그룹코드", "Level_Code", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "그룹명", "Level_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "Level", "Level", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "P/L당 PCS 수량", "PCS_Qty", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "PCS당 소재량", "Mat_Qty", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용여부", "Use_YN", true, 100);
        }
        private void ItemLevelComboBind()
        {
                      
        }

        public void Search_Click(object sender, EventArgs e)
        {
            ItemService service = new ItemService();
            dgvSearchResult.DataSource = itemGroupVo = service.GetAllItem();
        }

        private void ItemClassInfo_Leave(object sender, EventArgs e)
        {
            //frm.Search_Click -= new System.EventHandler(this.Search_Click);
        }

        private void ItemClassInfo_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= new System.EventHandler(this.Search_Click);
        }

        private void ItemClassInfo_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += new System.EventHandler(this.Search_Click);
            frm.btnS.PerformClick();
        }

        private void cmbLv_SelectedIndexChanged(object sender, EventArgs e)
        { }
        //    if (cmbLv.Text == "선택")
        //    {
        //        cbLevelCode.DataSource = null;
        //        cbLevelCode.Items.Insert(0, "선택");
        //        cbLevelCode.SelectedIndex = 0;
        //    }
        //    else
        //    {
        //        List<ComboItem> comboList = (from value in ItemGroupList
        //                                     where value.Level == cmbLv.Text.Trim()
        //                                     select new ComboItem
        //                                     {
        //                                         comboText = value.Level_Code,
        //                                         comboValue = value.Level_Name
        //                                     }).ToList();
        //        ComboClass.ComboBind(comboList, cbLevelCode, true);
        //    }
        //}

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (cmbLv.Text == "선택")
            {
                if(txtGroupCode.Text == "" && txtGroupName.Text == "")
                {
                    MessageBox.Show("검색조건을 입력하세요");
                    return;
                }
                else if(txtGroupCode.Text == "")
                    SearchGroupList = itemGroupVo.FindAll(x => x.Level_Name.ToUpper().Contains(txtGroupName.Text.Trim().ToUpper()));
                else if(txtGroupName.Text =="")
                    SearchGroupList = itemGroupVo.FindAll(x => x.Level_Code.ToUpper().Contains(txtGroupCode.Text.Trim().ToUpper()));
                else 
                    SearchGroupList = itemGroupVo.FindAll(x => x.Level_Name.ToUpper().Contains(txtGroupName.Text.Trim().ToUpper()) &&x.Level_Code.ToUpper().Contains(txtGroupCode.Text.Trim().ToUpper()));
            }
            else
            {
                if (txtGroupCode.Text == "" && txtGroupName.Text == "")
                    SearchGroupList = itemGroupVo.FindAll(x => x.Level == cmbLv.Text);
                else if (txtGroupCode.Text == "")
                    SearchGroupList = itemGroupVo.FindAll(x => x.Level==cmbLv.Text && x.Level_Name.ToUpper().Contains(txtGroupName.Text.Trim().ToUpper()));
                else if (txtGroupName.Text == "")
                    SearchGroupList = itemGroupVo.FindAll(x => x.Level == cmbLv.Text && x.Level_Code.ToUpper().Contains(txtGroupCode.Text.Trim().ToUpper()));
                else
                    SearchGroupList = itemGroupVo.FindAll(x => x.Level == cmbLv.Text && x.Level_Name.ToUpper().Contains(txtGroupName.Text.Trim().ToUpper()) && x.Level_Code.ToUpper().Contains(txtGroupCode.Text.Trim().ToUpper()));
            }
            dgvSearchResult.DataSource = SearchGroupList;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
