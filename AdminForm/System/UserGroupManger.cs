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
    public partial class UserGroupManger : dgvOneWithInput
    {
        MainForm frm;
        List<UserGroupManagerVO> allList;
        public UserGroupManger()
        {
            InitializeComponent();
        }

        private void UserGroupManger_Load(object sender, EventArgs e)
        {
            ShowDgv();
            frm = (MainForm)this.MdiParent;
            CommonClass.Userauthority(btnSave, btnEdit);
        }
        private void GetData(object sender, EventArgs e)
        {
            MES_DB.UserService service = new MES_DB.UserService();
            allList = service.UserGroupManagerForm();

            dgvSearchResult.DataSource = allList;
        }

        private void ShowDgv()
        {
            dgvSearchResult.CellDoubleClick += DgvSearchResult_CellDoubleClick;
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용자 그룹코드", "UserGroup_Code", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용자 그룹 명", "UserGroup_Name", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용여부", "Use_YN", true, 100);
        }

        private void DgvSearchResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEditUserGroupCode.Text = dgvSearchResult.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtEditUserGroupName.Text = dgvSearchResult.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (dgvSearchResult.Rows[e.RowIndex].Cells[2].Value.ToString() == "Y")
            {
                rbUse_EditUse.Checked = true;
            }
            else
            {
                rbUse_EditNoUse.Checked = true;
            }
        }

        private void UserGroupManger_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += new System.EventHandler(this.GetData);
            ToolStripManager.Merge(toolStrip1, frm.ToolStrip);
        }

        private void UserGroupManger_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= new System.EventHandler(this.GetData);
            ToolStripManager.RevertMerge(frm.ToolStrip);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserGroupManagerVO userVo = new UserGroupManagerVO();
            MES_DB.UserService service = new MES_DB.UserService();
            userVo.UserGroup_Code = txtUserCodeInput.Text;
            userVo.UserGroup_Name = txtUserNameInput.Text;
            if (rbUse_Use.Checked == true)
            {
                userVo.Use_YN = "Y";
            }
            else if (rbNoUse_Use.Checked == true)
            {
                userVo.Use_YN = "N";
            }
            else
            {
                MessageBox.Show("사용유무를 체크해주세요.");
                return;
            }
            service.InsUserGroupManagerForm(userVo);

            MessageBox.Show("입력되었습니다.");
            frm.btnS.PerformClick();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtEditUserGroupCode.Text == "" && txtEditUserGroupName.Text == "")
            {
                MessageBox.Show("위의 데이터를 선택하여 수정할 값을 선택해주세요.");
            }
            else
            {
                if (MessageBox.Show("수정하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    UserGroupManagerVO userVo = new UserGroupManagerVO();
                    MES_DB.UserService service = new MES_DB.UserService();
                    userVo.UserGroup_Code = txtEditUserGroupCode.Text;
                    userVo.UserGroup_Name = txtEditUserGroupName.Text;
                    if (rbUse_EditUse.Checked == true)
                    {
                        userVo.Use_YN = "Y";
                    }
                    else if (rbUse_EditNoUse.Checked == true)
                    {
                        userVo.Use_YN = "N";
                    }
                    service.UpdateUserGroupManagerForm(userVo);
                    MessageBox.Show("수정되었습니다.");
                    frm.btnS.PerformClick();
                }
                else
                {
                    MessageBox.Show("취소되었습니다.");
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            List<UserGroupManagerVO> list = (from item in allList
                                             where item.UserGroup_Code == txtUserCode.Text && item.UserGroup_Name == txtUserName.Text
                                             select item).ToList();
            dgvSearchResult.DataSource = list;
        }
    }
}
