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
    public partial class Truck : Form
    {
        Main_P main;
     
        public Truck(Main_P main1)
        {
            InitializeComponent();
            main = main1;
        }
    }
}
