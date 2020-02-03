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
    public partial class UserGroupPowerSetting : dgvOne
    {
        List<UserGroupPowerSettingVO> allList;
        MainForm frm;
        public UserGroupPowerSetting()
        {
            InitializeComponent();
        }

        private void UserGroupPowerSetting_Load(object sender, EventArgs e)
        {
            frm = (MainForm)this.MdiParent;
            ShowDgv();
        }


        private void ShowDgv()
        {
            dgvSearchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용자 명", "UserGroup_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "화면명", "Screen_Code", true, 200);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "권한", "Pre_Type", true, 120);
        }

        private void UserGroupPowerSetting_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += new System.EventHandler(this.GetData);
            ToolStripManager.Merge(toolStrip1, frm.ToolStrip);
        }

        private void UserGroupPowerSetting_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= new System.EventHandler(this.GetData);
            ToolStripManager.RevertMerge(frm.ToolStrip);
        }

        private void GetData(object sender, EventArgs e)
        {
            MES_DB.UserService service = new MES_DB.UserService();
            allList = service.GetAllUserGroupPowerSettingForm();
            dgvSearchResult.DataSource = allList;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            List<UserGroupPowerSettingVO> list = (from item in allList
                                                  where item.UserGroup_Name == fcUserGroup.SendName
                                                  select item).ToList();
            dgvSearchResult.DataSource = list;
        }
    }
}
