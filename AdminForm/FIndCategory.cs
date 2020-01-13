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
    public partial class FIndCategory : UserControl
    {
        public FIndCategory()
        {
            InitializeComponent();
        }
        public string CategoryTable{get;set;}

        private void BtnFind_Click(object sender, EventArgs e)
        {
            CategorySearch frm = new CategorySearch(CategoryTable);
            frm.ShowDialog();
            txtCatCode.Text = frm.CatCode;
            txtCatName.Text = frm.CatName;

        }
    }
}
