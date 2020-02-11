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
    public partial class UserManager : dgvOneWithInput
    {
        MainForm frm;
        List<UserManagerVO> allList;
        public UserManager()
        {
            InitializeComponent();
        }

        private void UserManager_Load(object sender, EventArgs e)
        {
            cmbEditProcess.SelectedIndex = 0;
            cmbProcess.SelectedIndex = 0;
            cmbGroupCode.SelectedIndex = 0;
            cmbEditGroupCode.SelectedIndex = 0;
            frm = (MainForm)this.MdiParent;
            ShowDgv();
            CommonClass.Userauthority(btnSave, btnEdit);
        }

        private void ShowDgv()
        {
            dgvSearchResult.CellDoubleClick += DgvSearchResult_CellDoubleClick;
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용자 이름", "User_Name", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용자 ID", "User_ID", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용자 그룹코드", "UserGroup_Code", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용자 그룹 명", "UserGroup_Name", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용여부", "Use_YN", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "패스워드 초기화 횟수", "Pw_Reset_Count", true, 200);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "기본 공정", "User_Type", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "x", "Default_Process_Code", false, 100);
        }

        
        private void DgvSearchResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEditName.Text = dgvSearchResult.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtEditID.Text = dgvSearchResult.Rows[e.RowIndex].Cells[1].Value.ToString();
            foreach (var item in cmbEditUserType.Items)
            {
                if (item.ToString() == dgvSearchResult.Rows[e.RowIndex].Cells[6].Value.ToString())
                {
                    cmbEditUserType.SelectedItem = item;
                }
            }

            if (dgvSearchResult.Rows[e.RowIndex].Cells[4].Value.ToString() == "Y")
            {
                rbEditUseY.Checked = true;
            }
            else
            {
                rbEditUserN.Checked = true;
            }

            foreach (var item in cmbEditProcess.Items)
            {
                if (item.ToString() == dgvSearchResult.Rows[e.RowIndex].Cells[7].Value.ToString())
                {
                    cmbEditProcess.SelectedItem = item;
                }
            }

            foreach (var item in cmbEditGroupCode.Items)
            {
                if (item.ToString() == dgvSearchResult.Rows[e.RowIndex].Cells[2].Value.ToString())
                {
                    cmbEditGroupCode.SelectedItem = item;
                }
            }
            //txtEditGroupCode.Text = dgvSearchResult.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEditGroupName.Text = dgvSearchResult.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void UserManager_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += new System.EventHandler(this.GetData);
        }

        private void UserManager_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= new System.EventHandler(this.GetData);
        }
        private void GetData(object sender, EventArgs e)
        {
            MES_DB.UserService service = new MES_DB.UserService();
            allList = service.GetAllUserManager();

            dgvSearchResult.DataSource = allList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MES_DB.UserService service = new MES_DB.UserService();
            UserManagerVO user = new UserManagerVO();
            int numchk = 0;
            bool isNum = int.TryParse(txtUserIDInput.Text, out numchk);
            if (isNum == true)
            {
                user.User_ID = Convert.ToInt32(txtUserIDInput.Text);
            }
            else
            {
                MessageBox.Show("숫자를 입력해주세요.");
                return;
            }

            if (txtUserNameInput.Text != "")
                user.User_Name = txtUserNameInput.Text;
            else
            {
                MessageBox.Show("이름을 입력해주세요.");
                return;
            }

            if (cmbProcess.SelectedIndex != 0)
                user.UserGroup_Code = cmbProcess.SelectedItem.ToString();
            else
            {
                MessageBox.Show("타입 항목을 선택해주세요.");
                return;
            }

            if (cmbProcess.SelectedIndex != 0)
            {
                user.User_Type = cmbProcess.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("공정을 선택해주세요.");
                return;
            }

            if (rbUse_Use.Checked == true)
            {
                user.Use_YN = "Y";
            }
            else if (rbNoUse_Use.Checked == true)
            {
                user.Use_YN = "N";
            }
            else
            {
                MessageBox.Show("사용유무를 선택해주세요.");
                return;
            }

            if (cmbGroupCode.SelectedItem.ToString() == "-- 선택 --")
            {
                MessageBox.Show("그룹코드를 입력해주세요.");
                return;
            }
            else
            {
                user.UserGroup_Code = cmbGroupCode.SelectedItem.ToString();
            }

            if (txtGroupName.Text == "")
            {
                MessageBox.Show("그룹 이름을 입력해주세요.");
                return;
            }
            else
            {
                user.UserGroup_Name = txtGroupName.Text;
            }
            user.Default_Process_Code = cmbUserType.SelectedItem.ToString();
            service.InsUserManager(user);
            MessageBox.Show("입력되었습니다.");
            frm.btnS.PerformClick();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UserManagerVO user = new UserManagerVO();
            MES_DB.UserService service = new MES_DB.UserService();
            user.User_ID = Convert.ToInt32(txtEditID.Text);
            user.User_Type = cmbEditProcess.SelectedItem.ToString();
            if (cmbEditProcess.SelectedItem.ToString() != "-- 선택 --")
            {
                user.Default_Process_Code = cmbEditUserType.SelectedItem.ToString();
            }
            user.UserGroup_Code = cmbEditGroupCode.SelectedItem.ToString();
            user.UserGroup_Name = txtEditGroupName.Text;

            if (rbEditUseY.Checked == true)
            {
                user.Use_YN = "Y";
            }
            else if (rbEditUserN.Checked == true)
            {
                user.Use_YN = "N";
            }
            else
            {
                MessageBox.Show("사용유무를 선택해주세요.");
            }

            service.UpdateUserManager(user);
            MessageBox.Show("수정되었습니다.");
            frm.btnS.PerformClick();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string selectitem = string.Empty;
            if (cmbUsable.SelectedItem.ToString() != null)
                selectitem = cmbUsable.SelectedItem.ToString();

            List<UserManagerVO> list = (from item in allList
                                        where item.User_ID == Convert.ToInt32(txtUserID.Text) && item.User_Name == txtUserName.Text && item.Use_YN == selectitem && item.UserGroup_Code == fcPermiGroup.SendCode
                                        select item).ToList();

            dgvSearchResult.DataSource = list;
        }

        private void cmbGroupCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGroupCode.SelectedIndex != 0)
            {
                if (allList != null)
                {
                    List<string> Name = (from item in allList
                                         where item.UserGroup_Code == cmbGroupCode.SelectedItem.ToString()
                                         select item.UserGroup_Name).ToList();
                    txtGroupName.Text = Name[0];
                }
                else
                {
                    cmbGroupCode.SelectedIndex = 0;
                    MessageBox.Show("전체조회를 눌러주세요.");
                }
            }

        }

        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUserType.SelectedIndex == 1)
                cmbGroupCode.SelectedIndex = 2;
            else
                cmbGroupCode.SelectedIndex = 1;

        }

        private void cmbEditUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEditUserType.SelectedIndex == 1)
            {
                cmbEditGroupCode.SelectedItem = "UserLevel2";
            }
            else
                cmbEditGroupCode.SelectedItem = "UserLevel1";
        }

        private void cmbEditGroupCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbEditGroupCode.SelectedIndex == 1)
            {
                txtEditGroupName.Text = "사원";
            }
            else
            {
                txtEditGroupName.Text = "임원";
            }
        }
    }
}
