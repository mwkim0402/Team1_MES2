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
            cmbTypeEdit.SelectedIndex = 0;
            cmbType.SelectedIndex = 0;
            frm = (MainForm)this.MdiParent;
            ShowDgv();
            CommonClass.Userauthority(btnSave, btnEdit);
        }

        private void ShowDgv()
        {
            dgvSearchResult.CellDoubleClick += DgvSearchResult_CellDoubleClick;
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용자 이름", "User_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용자 ID", "User_ID", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용자 그룹코드", "UserGroup_Code", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용자 그룹 명", "UserGroup_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용여부", "Use_YN", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "패스워드 초기화 횟수", "Pw_Reset_Count", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "기본 공정", "Default_Process_Code", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "x", "User_Type", false, 100);
        }

        private void DgvSearchResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEditName.Text = dgvSearchResult.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtEditID.Text = dgvSearchResult.Rows[e.RowIndex].Cells[1].Value.ToString();
            if(dgvSearchResult.Rows[e.RowIndex].Cells[6].Value == null)
                txtEditProcess.Text = "";
            else
                txtEditProcess.Text = dgvSearchResult.Rows[e.RowIndex].Cells[6].Value.ToString();

            if (dgvSearchResult.Rows[e.RowIndex].Cells[4].Value.ToString() == "Y")
            {
                rbEditUseY.Checked = true;
            }
            else
            {
                rbEditUserN.Checked = true;
            }

            foreach(var item in cmbTypeEdit.Items)
            {
                if(item.ToString() == dgvSearchResult.Rows[e.RowIndex].Cells[7].Value.ToString())
                {
                    cmbTypeEdit.SelectedItem = item;
                }
            }

            txtEditGroupCode.Text = dgvSearchResult.Rows[e.RowIndex].Cells[2].Value.ToString();
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
            if(isNum == true)
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

            if (cmbType.SelectedIndex != 0)
                user.UserGroup_Code = cmbType.SelectedItem.ToString();
            else
            { 
                MessageBox.Show("타입 항목을 선택해주세요.");
                return;
            }

            if (txtStandFac.Text != "")
            {
                user.Default_Process_Code = txtStandFac.Text;
            }
            else
            {
                MessageBox.Show("공정을 입력해주세요.");
                return;
            }

            if(rbUse_Use.Checked == true)
            {
                user.Use_YN = "Y";
            }
            else if(rbNoUse_Use.Checked == true)
            {
                user.Use_YN = "N";
            }
            else
            {
                MessageBox.Show("사용유무를 선택해주세요.");
                return;
            }

            if(txtGroupCode.Text == "")
            {
                MessageBox.Show("그룹코드를 입력해주세요.");
                return;
            }
            else
            {
                user.UserGroup_Code = txtGroupCode.Text;
            }

            if(txtGroupName.Text == "")
            {
                MessageBox.Show("그룹 이름을 입력해주세요.");
                return;
            }
            else
            {
                user.UserGroup_Name = txtGroupName.Text;
            }
            user.User_Type = cmbType.SelectedItem.ToString();
            service.InsUserManager(user);
            MessageBox.Show("입력되었습니다.");
            frm.btnS.PerformClick();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UserManagerVO user = new UserManagerVO();
            MES_DB.UserService service = new MES_DB.UserService();
            user.User_ID = Convert.ToInt32(txtEditID.Text);
            user.User_Type = cmbTypeEdit.SelectedItem.ToString();
            user.Default_Process_Code = txtEditProcess.Text;
            user.UserGroup_Code = txtEditGroupCode.Text;
            user.UserGroup_Name = txtEditGroupName.Text;
            
            if (rbEditUseY.Checked == true)
            {
                user.Use_YN = "Y";
            }
            else if(rbEditUserN.Checked == true)
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
    }
}
