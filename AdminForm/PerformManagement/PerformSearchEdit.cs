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
    public partial class PerformSearchEdit : Form
    {
        PerformSearchVO Edit;
        public PerformSearchEdit(PerformSearchVO edit)
        {
            InitializeComponent();
            Edit = edit;
        }
        private void PerformSearchEdit_Load(object sender, EventArgs e)
        {
            cmbSelect.SelectedIndex = 0;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //수정하기
            bool Check = false;
            MES_DB.PerformService service = new MES_DB.PerformService();
            if(cmbSelect.SelectedItem.ToString() == "투입수량")
            {
                Edit.In_Qty_Main = Convert.ToInt32(nuCount.Value);
                service.EditPerformSearch(Edit);
                Check = true;
            }
            else if(cmbSelect.SelectedItem.ToString() == "불량")
            {
                Edit.Bad_Qty = Convert.ToInt32(nuCount.Value);
                service.EditPerformSearch(Edit);
                Check = true;
            }
            else if(cmbSelect.SelectedItem.ToString() == "생산수량")
            {
                Edit.Prd_Qty = Convert.ToInt32(nuCount.Value);
                service.EditPerformSearch(Edit);
                Check = true;
            }
            else
            {
                MessageBox.Show("항목을 선택해주세요.");
            }


            if (Check == true)
            {
                MessageBox.Show("수정되었습니다.");
                this.Close();
            }
            else
                MessageBox.Show("값을 선택해주세요.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
