﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FieldOperationForm
{
    public partial class Notice : Form
    {
        bool TagMove;
        int MValX, MValY;
        List<Notice_Vo> NList = null;
        Main_P main;
        public Notice(Main_P main1)
        {
          
            LoadNList();
            InitializeComponent();
            main = main1;
        }

        // DataGridView 컬럼 설정
        private void AddNewColumnToDataGridView(DataGridView dgv, string headerText, string dataPropertyName, bool visibility,
           int colWidth = 100, DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleLeft)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = headerText;
            col.DataPropertyName = dataPropertyName;
            col.Width = colWidth;
            col.Visible = visibility;
            col.ValueType = typeof(string);
            col.ReadOnly = true;
            col.DefaultCellStyle.Padding = new Padding(3);
            col.DefaultCellStyle.Alignment = textAlign;
            dgv.Columns.Add(col);
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Ivory;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew;
            //    dgv.RowsDefaultCellStyle.BackColor = Color.Ivory;


            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Ivory;

            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.CadetBlue;
            dgv.RowTemplate.Height = 60;


        }
        private void Setdgv()
        {

            AddNewColumnToDataGridView(dgv_Notice, "제목", "Title", true, 440);
            AddNewColumnToDataGridView(dgv_Notice, "등록일", "Notice_Date", true, 130);
            AddNewColumnToDataGridView(dgv_Notice, "작성자", "Ins_Emp", true, 100);
           AddNewColumnToDataGridView(dgv_Notice, "등록일", "Description", false, 150);



            this.dgv_Notice.Font = new Font("나눔고딕", 14, FontStyle.Bold);
            this.dgv_Notice.DefaultCellStyle.Font = new Font("나눔고딕", 15, FontStyle.Bold);
            dgv_Notice.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgv_Notice.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_Notice.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        private void LoadNList()
        {
            Notice_Service service = new Notice_Service();
            NList = service.NoticeList();
        }

        private void Notice_Load(object sender, EventArgs e)
        {
            Setdgv();
            dgv_Notice.DataSource = NList;
        }

        private void Notice_Shown(object sender, EventArgs e)
        {

            dgv_Notice.CurrentCell = null;
        }

        private void dgv_Notice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                Notice_Service service = new Notice_Service();

                txt_Title.Text = dgv_Notice.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_Name.Text = dgv_Notice.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_date.Text = dgv_Notice.Rows[e.RowIndex].Cells[2].Value.ToString();
                List< Notice_Vo> vo = service.GetNotice( txt_Title.Text);

                txt_Des.Text = vo[0].Description.ToString();
                ////vo.Title =                      txt_Title.Text;
                ////vo.Ins_Emp =                 txt_Name.Text;
                ////vo.Notice_Date =             txt_Name.Text;
                ////vo.Description =             txt_Des.Text;


                //  txt_Name.Text = vo.Ins_Emp;
                //   txt_Name.Text = vo.Notice_Date;
                //  txt_Des.Text = vo.Description;
            }
            catch
            {

            }

        }

        private void dgv_Notice_SelectionChanged(object sender, EventArgs e)
        {
            
            }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            TagMove = true;
            MValX = e.X;
            MValY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (TagMove == true)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            this.Close();
            main.lbl_Notice.Enabled = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            TagMove = false;
        }
    }
    }

