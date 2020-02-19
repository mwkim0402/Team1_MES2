using FieldOperationForm;
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
    

    public partial class MainChild : Form
    {
        MainForm frm;
        UserCalendar workCalendar;
        UserInfoVo userInfo;
        List<UserPlanVo> userPlanList;
        public MainChild()
        {
            InitializeComponent();
        }
        
        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainChild_Load(object sender, EventArgs e)
        {            
            GetUserInfo();
            UserInfoService service = new UserInfoService();
            userPlanList = service.GetUserPlan(Global.LoginID);
            GridViewSettings();
            DateTime[] planDate = (from item in userPlanList
                                  select Convert.ToDateTime(item.Plan_Date)).ToArray();
            workCalendar = new UserCalendar(planDate);
            workCalendar.Location = new Point(4, 16);
            workCalendar.Change_Month += MonthChange;
           //workCalendar.Search_Click += btnSearch;
            groupBox1.Controls.Add(workCalendar);
            frm = (MainForm)this.MdiParent;

            lblID.Text = $"{Global.LoginID.ToString()}님 ";           
        }
        
        private void MainChild_Activated(object sender, EventArgs e)
        {
           // frm.lblLocation.Text = "위치정보 : Home";
        }
        private void btnSearch(object sender, EventArgs e)
        {
            List<UserPlanVo> bindList = (from item in userPlanList
                                         where Convert.ToDateTime(item.Plan_Date).Date == Convert.ToDateTime($"{workCalendar.lblYear.Text.Split('년')[0]}-{workCalendar.lblMonth.Text}-{workCalendar.lblDate.Text}")
                                              select item).ToList();
            dgvPlanInfo.DataSource = bindList;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName != "")
                {
                    //pictureBox1.Image = Bitmap.FromFile(openFileDialog1.FileName);
                    pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                    this.ClientSize = pictureBox1.Image.Size;
                }
            }
        }
        private void GetUserInfo()
        {
            UserInfoDac dac = new UserInfoDac();
            userInfo = dac.GetUserInfo(Global.LoginID);
            lblUserID.Text = userInfo.User_ID.ToString();
            lblUserName.Text = userInfo.User_Name;
            lblDept.Text = userInfo.Default_Process_Code;
            lblGrade.Text = userInfo.UserGroup_Name;
            lblPhone.Text = userInfo.User_Phone;
            lblEmail.Text = userInfo.User_Email;
        }
        private void GridViewSettings()
        {
            CommonClass.AddNewColumnToDataGridView(dgvPlanInfo, "아이디", "User_ID", false, 200);
            CommonClass.AddNewColumnToDataGridView(dgvPlanInfo, "번호", "Seq", false, 200);
            CommonClass.AddNewColumnToDataGridView(dgvPlanInfo, "계획 날짜", "Plan_Date", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvPlanInfo, "제목", "Title", true, 300);
            CommonClass.AddNewColumnToDataGridView(dgvPlanInfo, "내용", "Notice", true, 450);
            List<UserPlanVo> bindList = (from item in userPlanList
                                         where (Convert.ToDateTime(item.Plan_Date).Month == DateTime.Now.Month) && (Convert.ToDateTime(item.Plan_Date).Year == DateTime.Now.Year)
                                         select item).ToList();
            dgvPlanInfo.DataSource = bindList;

            CommonClass.AddNewColumnToDataGridView(dgvNotice, "번호", "Seq", false, 200);
            CommonClass.AddNewColumnToDataGridView(dgvNotice, "공지 날짜", "Notice_Date", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvNotice, "제목", "Title", true, 300);
            CommonClass.AddNewColumnToDataGridView(dgvNotice, "공지 내용", "Description", true, 800);
            NoticeService noticeService = new NoticeService();
            dgvNotice.DataSource = noticeService.GetAllNotice();
        }
        private void MonthChange(object sender, EventArgs e)
        {
            string joinDate = $"{ workCalendar.lblMonth.Text.Split('년')[0]}-{workCalendar.lblMonth.Text}";
            List<UserPlanVo> bindList = (from item in userPlanList
                                         where Convert.ToDateTime(item.Plan_Date).Year == Convert.ToDateTime($"{workCalendar.lblYear.Text.Split('년')[0]}-{workCalendar.lblMonth.Text}-1").Year
                                         && Convert.ToDateTime(item.Plan_Date).Month == Convert.ToDateTime($"{workCalendar.lblYear.Text.Split('년')[0]}-{workCalendar.lblMonth.Text}-1").Month
                                         select item).ToList();
            dgvPlanInfo.DataSource = bindList;
        }
    }
}
