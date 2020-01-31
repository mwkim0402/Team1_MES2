using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class UserCalendar : UserControl
    {
        DateTime startDate;
        string StartBtnText;
        string InsertBtnText;
        int lastDay;
        string workCenter;
        public string[] BordedDate { get; set; }
        public string SelectDate { get; set; }

        public UserCalendar()
        {
            InitializeComponent();
        }

        public UserCalendar(string[] bordDate, string WorkCneter) : this()
        {
            BordedDate = bordDate;
            workCenter = WorkCneter;
            lblMonth.Text = DateTime.Now.Month.ToString();
        }

        private void UserCalendar_Load(object sender, EventArgs e)
        {
            startDate = Convert.ToDateTime($"{lblYear.Text.Split('년')[0]}-{lblMonth.Text}-01");
            string day = startDate.ToString("dddd");
            lastDay = DateTime.DaysInMonth(int.Parse(lblYear.Text.Split('년')[0]), int.Parse(lblMonth.Text));
            SetStartDay(day);
            DayChange(StartBtnText);

            BordedDateChange(BordedDate);
        }
        private void SetStartDay(string day)
        {
            if (day == "일요일")
                StartBtnText = "btn1";
            else if (day == "월요일")
                StartBtnText = "btn2";
            else if (day == "화요일")
                StartBtnText = "btn3";
            else if (day == "수요일")
                StartBtnText = "btn4";
            else if (day == "목요일")
                StartBtnText = "btn5";
            else if (day == "금요일")
                StartBtnText = "btn6";
            else if (day == "토요일")
                StartBtnText = "btn7";
        }
        private void DayChange(string StartBtnText)
        {
            InsertBtnText = StartBtnText;
            for(int i =1; i<=lastDay; i++)
            {
                foreach (Button item in panel1.Controls)
                {
                    if(item.Name == InsertBtnText)
                    {
                        item.Text = i.ToString();
                        InsertBtnText = "btn" + (int.Parse(InsertBtnText.Split('n')[1]) + 1);
                    }
                }
            }
        }
        private void BordedDateChange(string[] bordedDate)
        {
            foreach (Button item in panel1.Controls)
            {
                if (bordedDate.Contains(item.Text))
                {
                    item.ForeColor = Color.White;
                    item.BackColor = Color.DarkGray;
                }
            }
        }

        private void btnMonUp_Click(object sender, EventArgs e)
        {
            if (int.Parse(lblMonth.Text) == 12)
            {
                lblYear.Text = $"{(int.Parse(lblYear.Text.Split('년')[0]) + 1)}년";
                lblMonth.Text = 1.ToString();
            }
            else
            {
                lblMonth.Text = (int.Parse(lblMonth.Text) + 1).ToString();
            }
        }

        private void btnMonthDown_Click(object sender, EventArgs e)
        {
            if (int.Parse(lblMonth.Text) == 1)
            {
                lblYear.Text = $"{(int.Parse(lblYear.Text.Split('년')[0]) - 1)}년";
                lblMonth.Text = 12.ToString();
            }
            else
            {
                lblMonth.Text = (int.Parse(lblMonth.Text) - 1).ToString();
            }
        }
    }
}
