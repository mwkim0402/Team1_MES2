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
    public partial class ItemClassInfo : dgvOne
    {
        MainForm frm;
        public ItemClassInfo()
        {
            frm = (MainForm)this.MdiParent;
            InitializeComponent();
        }

        private void ItemClassInfo_Load(object sender, EventArgs e)
        {
           //  frm.Search_Click += new System.EventHandler(this.Search_Click);
           // ItemService service = new ItemService();;
            ShowDgv();
           // dgvSearchResult.DataSource = service.GetAllItem();
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
            ItemService service = new ItemService();
            
        }

        public void Search_Click(object sender, EventArgs e)
        {
            ItemService service = new ItemService();
            dgvSearchResult.DataSource = service.GetAllItem();
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
        }
    }
}
