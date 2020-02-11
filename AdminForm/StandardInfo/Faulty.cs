using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MES_DB;

namespace AdminForm
{
    public partial class Faulty : dgvOneWithInput
    {
        List<FaultyMasterVo> faultyMasterList;
        List<FaultyMasterVo> searchList;
        MainForm frm;
        public Faulty()
        {
            InitializeComponent();
        }

        private void Faulty_Load(object sender, EventArgs e)
        {
            frm = (MainForm)this.MdiParent;
            ShowDgv();
            dgvSearchResult.CellDoubleClick += dataGridView1_CellDoubleClick;
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "불량현상 대분류 코드", "Def_Ma_Code", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "불량현상 대분류 명", "Def_Ma_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용유무", "Use_YN", true, 100);
        }
        private void btnSearch(object sender, EventArgs e)
        {
            FaultyService service = new FaultyService();
            faultyMasterList = service.GetAllFaultyMaster();
            dgvSearchResult.DataSource = faultyMasterList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FaultyMasterVo InsertVo = new FaultyMasterVo();
            InsertVo.Def_Ma_Code = txtMasterCode.Text;
            InsertVo.Def_Ma_Name = txtMasterName.Text;
            InsertVo.Use_YN = rbTrue.Checked ? "Y" : "F";

            try
            {
                FaultyService service = new FaultyService();
                bool Checked = service.InsertFaultyMaster(InsertVo);
                if (Checked)
                    frm.lblAlert.Text = "등록 완료하였습니다.";
                
                else
                    frm.lblAlert.Text = "등록 실패하였습니다. 다시 한번 확인해주세요.";

               
            }
            catch (Exception err)
            {
                frm.lblAlert.Text = err.Message;
            }
            finally
            {
               // frm.lblAlert.Text = string.Format(DateTime.Now.ToShortDateString().Replace("-","") + "_{0:D4}", 103);
                frm.btnS.PerformClick();
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tcParent2.SelectedIndex = 1;
            DataGridView gridView = (DataGridView)sender;
            string updateID = gridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            FaultyMasterVo updateMaster = faultyMasterList.Find(x => x.Def_Ma_Code == updateID);
            txtUpdateCode.Text = updateMaster.Def_Ma_Code;
            txtUpdateName.Text = updateMaster.Def_Ma_Name;
            if (updateMaster.Use_YN == "Y")
                rbUpdateTrue.Checked = true;
            else
                rbUpdateFalse.Checked = true;
        }

        private void Faulty_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += this.btnSearch;
        }

        private void Faulty_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= this.btnSearch;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FaultyMasterVo InsertVo = new FaultyMasterVo();
            InsertVo.Def_Ma_Code = txtUpdateCode.Text;
            InsertVo.Def_Ma_Name = txtUpdateName.Text;
            InsertVo.Use_YN = rbUpdateTrue.Checked ? "Y" : "F";

            try
            {
                FaultyService service = new FaultyService();
                bool Checked = service.UpdateFaultyMaster(InsertVo);
                if (Checked)
                    frm.lblAlert.Text = "등록 완료하였습니다.";
                else
                    frm.lblAlert.Text = "등록 실패하였습니다. 다시 한번 확인해주세요.";
            }
            catch (Exception err)
            {
                frm.lblAlert.Text = err.Message;
            }
            finally
            {
                frm.btnS.PerformClick();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtFaultCatCode.Text == "")
                searchList = faultyMasterList.FindAll(x => x.Def_Ma_Name.ToUpper().Contains(txtFaultCatCodeName.Text.ToUpper()));
            else if (txtFaultCatCodeName.Text == "")
                searchList = faultyMasterList.FindAll(x => x.Def_Ma_Code.ToUpper().Contains(txtFaultCatCode.Text.ToUpper()));
            else
                searchList = faultyMasterList.FindAll(x => x.Def_Ma_Name.ToUpper().Contains(txtFaultCatCodeName.Text.ToUpper()) && x.Def_Ma_Code.ToUpper().Contains(txtFaultCatCode.Text.ToUpper()));

            if (searchList.Count < 1)
            {
                frm.lblAlert.Text = "검색한 조건의 데이터가 존재하지 않습니다.";
                return;
            }
            //  frm.lblAlertTitle.Text = "[알람]";
            frm.lblAlert.Text = $"{searchList.Count} 건의 데이터가 조회되었습니다.";
            timer1.Start();
            dgvSearchResult.DataSource = searchList;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            frm.lblAlert.Text = "";
            timer1.Stop();
        }
    }
}
