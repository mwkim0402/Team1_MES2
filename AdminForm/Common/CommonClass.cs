﻿using FieldOperationForm;
using MES_DB;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminForm
{
    public class CommonClass
    {
        public static void AddNewColumnToDataGridView(DataGridView dgv, string headerText, string dataPropertyName, bool visibility,
      int colWidth = 100, DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleLeft)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = headerText;
            col.DataPropertyName = dataPropertyName;
            col.Width = colWidth;
            col.Visible = visibility;
            col.ValueType = typeof(string);
            col.ReadOnly = true;
            col.DefaultCellStyle.Alignment = textAlign;
            dgv.Columns.Add(col);

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Silver;
            dgv.EnableHeadersVisualStyles = false;

            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.LightGray;
            // dgv.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            // dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.DimGray;

        }

        public static void InitControl(Panel panel)
        {
            foreach (var item in panel.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Text = "";
                }
                else if (item is ComboBox)
                {
                    ComboBox cb = (ComboBox)item;
                    cb.SelectedIndex = 0;
                }
                else if (item is NumericUpDown)
                {
                    NumericUpDown nu = (NumericUpDown)item;
                    nu.Value = 0;
                }
                else if (item is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)item;
                    dtp.Value = DateTime.Now;
                }
                else if (item is Panel)
                {
                    Panel pnl = (Panel)item;
                    InitControl(pnl);
                }
            }
        }

        public static void Userauthority(Button Insert, Button Edit)
        {
            // 폼마다 유저 권한 확인 후 버튼 사용여부 설정
            string[] Authority = Global.Authority.Split(',');
            // 로그인 했을때만 가능
            if (Authority != null)
            {
                Insert.Enabled = false;
                Edit.Enabled = false;
                for (int i = 0; i < Authority.Length; i++)
                {
                    if (Authority[i] == "추가")
                    {
                        Insert.Enabled = true;
                    }
                    else if (Authority[i] == "수정")
                    {
                        Edit.Enabled = true;
                    }
                }
            }
        }
        public static void Userauthority(Button Insert)
        {
            // 폼마다 유저 권한 확인 후 버튼 사용여부 설정
            string[] Authority = Global.Authority.Split(',');
            // 로그인 했을때만 가능
            if (Authority != null)
            {
                Insert.Enabled = false;
                for (int i = 0; i < Authority.Length; i++)
                {
                    if (Authority[i] == "추가")
                    {
                        Insert.Enabled = true;
                    }
                }
            }
        }
    }
}



