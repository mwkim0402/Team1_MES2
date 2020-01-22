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
    public partial class MaterialManagement : dgvOne
    {
        List<MaterialManage> Allist;
        MainForm frm;
        public MaterialManagement()
        {
            InitializeComponent();
        }

        private void MaterialManagement_Load(object sender, EventArgs e)
        {
            ShowDgv();
            frm = (MainForm)this.MdiParent;
            MES_DB.PerformService service = new MES_DB.PerformService();
            Allist = service.GetAllMaterial();

        }

        private void GetData(object sender, EventArgs e)
        {
            if (txtYear.Text != "")
            {
                List<MaterialManage> list = (from item in Allist
                                             where item.YYYY == txtYear.Text
                                             select item).ToList();
                dgvSearchResult.DataSource = list;
            }
            else
            {
                dgvSearchResult.DataSource = Allist;
            }
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "생산년도", "YYYY", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "레벨코드", "Level_Code", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "레벨명", "Level_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "차수", "Prd_Order", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "원자재 LOT 번호", "Mat_LotNo", true, 100);
        }

        private void MaterialManagement_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += new System.EventHandler(this.GetData);
        }

        private void MaterialManagement_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= new System.EventHandler(this.GetData);
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("숫자를 입력해주세요.");
            }
            
        }
    }
}
