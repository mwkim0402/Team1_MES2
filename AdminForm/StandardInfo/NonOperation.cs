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
    public partial class NonOperation : dgvOneWithInput
    {
        MainForm frm;
        List<NonOperationVO> nonOpMaList;
        public NonOperation()
        {
            InitializeComponent();
        }

        private void NonOperation_Load(object sender, EventArgs e)
        {
            frm = (MainForm)this.MdiParent;
            NonOperationMaService service = new NonOperationMaService();
            nonOpMaList = service.GettNonOperationMa();
            ShowDgv();
            dgvSearchResult.DataSource = nonOpMaList;
            CommonClass.Userauthority(btnSave,button1);
        }

        private void ShowDgv()
        {
            dgvSearchResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비가동 대분류 코드", "Nop_Ma_Code", true, 300);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비가동 대분류 명", "Nop_Ma_Name", true, 300);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용유무", "Use_YN", true, 300,DataGridViewContentAlignment.MiddleCenter);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NonOperationVO noVo = new NonOperationVO
            {
                Nop_Ma_Code = txtNonOperationCode.Text,
                Nop_Ma_Name = txtNonOperationName.Text,
                Use_YN = rbY.Checked ? "Y" : "N"
            };
            NonOperationMaService service = new NonOperationMaService();
            try
            {
                if (service.InsertNonOperationMa(noVo))
                {
                    frm.btnS.PerformClick();
                }
            }
            catch(Exception err)
            {
                //frm.lblAlert.Text = err.Message;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            NonOperationMaService service = new NonOperationMaService();
            nonOpMaList = service.GettNonOperationMa();
            dgvSearchResult.DataSource = nonOpMaList;
        }
        private void NonOperation_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += btnSearch_Click;
        }

        private void NonOperation_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= btnSearch_Click;
        }
    }
}
