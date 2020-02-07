using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Activities.Expressions;
using MES_DB;

namespace AdminForm
{
    public partial class UserCalendar : UserControl
    {
        public event EventHandler Search_Click;

        DateTime startDate;
        string StartBtnText;
        string InsertBtnText;
        int lastDay;
        string workCenter;
        public DateTime[] BordedDate { get; set; }
        public string SelectDate { get; set; }

        public UserCalendar()
        {
            InitializeComponent();
        }
        public UserCalendar(DateTime[] bordDate, string WorkCneter) : this()
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
        private void BordedDateChange(DateTime[] bordedDate)
        {
            if (bordedDate == null)
            {
                return;
            }
            string[] searchDate = (from item in bordedDate
                                     where item.Month.ToString() == lblMonth.Text && item.Year.ToString() == lblYear.Text.Split('년')[0]
                                     select item.Day.ToString()).ToArray();
            foreach (Button item in panel1.Controls)
            {
                if (searchDate.Contains(item.Text))
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
            foreach (Button item in panel1.Controls)
            {
                item.BackColor = Color.White;
                item.ForeColor = Color.Black;
                item.Text = "";
            }
            startDate = Convert.ToDateTime($"{lblYear.Text.Split('년')[0]}-{lblMonth.Text}-01");
            string day = startDate.ToString("dddd");
            lastDay = DateTime.DaysInMonth(int.Parse(lblYear.Text.Split('년')[0]), int.Parse(lblMonth.Text));
            SetStartDay(day);
            DayChange(StartBtnText);
            BordedDateChange(BordedDate);
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
            foreach (Button item in panel1.Controls)
            {
                item.BackColor = Color.White;
                item.ForeColor = Color.Black;
                item.Text = "";
            }
            startDate = Convert.ToDateTime($"{lblYear.Text.Split('년')[0]}-{lblMonth.Text}-01");
            string day = startDate.ToString("dddd");
            lastDay = DateTime.DaysInMonth(int.Parse(lblYear.Text.Split('년')[0]), int.Parse(lblMonth.Text));
            SetStartDay(day);
            DayChange(StartBtnText);
            BordedDateChange(BordedDate);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(btn.ForeColor == Color.Black)
            {
                return;
            }
            lblDate.Text = btn.Text;
            if (this.Search_Click != null)
                Search_Click(this, null);
        }
    }
}
