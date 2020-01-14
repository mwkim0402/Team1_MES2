﻿using System;
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
    public enum CategoryMode { Process, WorkCenter, Employees, ScreenItem, Permission, System, Item, Inspect, Default, NonOper, Userdefine, Boxing, GV }
public partial class FIndCategory : UserControl
    {
        private CategoryMode category;
        private string catTable;
        public CategoryMode Category
        {
            get { return category; }
            set
            {
                category = value;
                if (category == CategoryMode.Process)
                    catTable = "Process";
                else if (category == CategoryMode.WorkCenter)
                    catTable = "WorkCenter";
                else if (category == CategoryMode.Employees)
                    catTable = "Employees";
                else if (category == CategoryMode.ScreenItem)
                    catTable = "ScreenItem";
                else if (category == CategoryMode.Permission)
                    catTable = "Permission";
                else if (category == CategoryMode.System)
                    catTable = "System";
                else if (category == CategoryMode.Item)
                    catTable = "Item";
                else if (category == CategoryMode.Inspect)
                    catTable = "Inspect";
                else if (category == CategoryMode.Default)
                    catTable = "Default";
                else if (category == CategoryMode.NonOper)
                    catTable = "NonOper";
                else if (category == CategoryMode.Userdefine)
                    catTable = "Userdefine";
                else if (category == CategoryMode.Boxing)
                    catTable = "Boxing";
                else // GV
                    catTable = "GV";
            }
        }

        public FIndCategory()
        {
            InitializeComponent();
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            CategorySearch frm = new CategorySearch(catTable);
            frm.ShowDialog();
            txtCatCode.Text = frm.CatCode;
            txtCatName.Text = frm.CatName;

        }
    }
}
