﻿using FieldOperationForm;
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
            DateTime[] planDate = { Convert.ToDateTime("2020-02-10"), Convert.ToDateTime("2020-02-13") };
            workCalendar = new UserCalendar(planDate);
            workCalendar.Location = new Point(4, 16);
            groupBox1.Controls.Add(workCalendar);

            frm = (MainForm)this.MdiParent;

            lblID.Text = $"{Global.LoginID.ToString()}님 ";
            GetUserInfo();
        }

        private void MainChild_Activated(object sender, EventArgs e)
        {
           // frm.lblLocation.Text = "위치정보 : Home";
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
    }
}
