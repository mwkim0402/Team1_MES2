using MES_DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class RegFaultyImage : AdminForm.dgvTwo
    {
        MainForm frm;
        List<RegFaultyVO> allList;
        DateTime StartDate;
        DateTime EndDate;
        public RegFaultyImage()
        {
            InitializeComponent();
        }

        private void RegFaultyImage_Load(object sender, EventArgs e)
        {
            frm = (MainForm)this.MdiParent;
            ShowDgv();

        }



        private void GetData(object sender, EventArgs e)
        {
            MES_DB.PerformService service = new MES_DB.PerformService();
            allList = service.GetAllRegFaultyImage();
            dgvProductRequset.DataSource = allList;

        }
        private void ShowDgv()
        {
            tabPage4.Text = "작업지시";
            tabPage2.Text = "상세내역";
            dgvProductRequset.CellDoubleClick += ViewDgvDetail;
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "작업지시상태", "Wo_Status", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "작업지시번호", "Workorderno", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "생산일자", "Plan_Date", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "품목코드", "Item_Code", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "품목명", "Item_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "작업장", "Wc_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "실적", "Prd_Qty", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "불량대분류", "Def_Ma_Code", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "불량상세분류", "Def_Mi_Code", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "발생일시", "Def_Date", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "불량수량", "Def_Qty", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "불량사진", "Def_Image_Name", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "공정이름", "Process_name", false, 100);



            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "작업지시번호", "Workorderno", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "품목코드", "Item_Code", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "품목명", "Item_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "불량대분류", "Def_Ma_Code", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "불량상세분류", "Def_Mi_Code", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "발생일시", "Def_Date", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "불량수량", "Def_Qty", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "불량사진", "Def_Image_Name", true, 100);
        }

        private void ViewDgvDetail(object sender, DataGridViewCellEventArgs e)
        {
            string itemCode = dgvProductRequset.Rows[e.RowIndex].Cells[7].Value.ToString();

            List<RegFaultyVODetail> list = (from item in allList
                                            where item.Def_Ma_Code == itemCode
                                            select new RegFaultyVODetail
                                            {
                                                Workorderno = item.Workorderno,
                                                Item_Code = item.Item_Code,
                                                Item_Name = item.Item_Name,
                                                Def_Ma_Code = item.Def_Ma_Code,
                                                Def_Mi_Code = item.Def_Mi_Code,
                                                Def_Qty = item.Def_Qty,
                                                Def_Date = item.Def_Date,
                                                Def_Image_Name = item.Def_Image_Name
                                            }).ToList();
            dgvJobOrder.DataSource = list;
        }


        private void RegFaultyImage_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += new System.EventHandler(this.GetData);
            ToolStripManager.Merge(toolStrip1, frm.ToolStrip);
        }

        private void RegFaultyImage_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= new System.EventHandler(this.GetData);
            ToolStripManager.RevertMerge(frm.ToolStrip);
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            StartDate = dtpStart.Value;
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            EndDate = dtpEnd.Value;
        }

        private void toolStrip1_Click(object sender, EventArgs e)
        {
            //if (StartDate != null && EndDate != null && fcFactory.SendCode != null && fcWork.SendCode != null)
            //{
            //    List<RegFaultyVO> listLamda = allList.FindAll(x => x.Plan_Date >= StartDate.Date && (x.Plan_Date <= EndDate.Date) && x.Process_name == fcFactory.SendName && x.Wc_Name == fcWork.SendName);
            //    dgvProductRequset.DataSource = listLamda;
            //}
            //else
            //{
            //    MessageBox.Show("모든 항목을 선택해주세요.");
            //}
            if ((fcWork.SendCode != null && fcWork.SendName != "") && (fcFactory.SendCode != null && fcFactory.SendCode != ""))
            {
                List<RegFaultyVO> list = (from item in allList
                                          where item.Process_name == fcFactory.SendName && item.Wc_Name == fcWork.SendName
                                          select item).ToList();
                dgvProductRequset.DataSource = list;
            }
            else if ((fcWork.SendCode != null && fcWork.SendCode != "") && (fcFactory.SendCode == null || fcFactory.SendCode == ""))
            {
                List<RegFaultyVO> list = (from item in allList
                                          where item.Wc_Name == fcWork.SendName
                                          select item).ToList();
                dgvProductRequset.DataSource = list;
            }
            else if ((fcWork.SendCode == null || fcWork.SendCode == "") && (fcFactory.SendCode != null && fcFactory.SendCode != ""))
            {
                List<RegFaultyVO> list = (from item in allList
                                          where item.Process_name == fcFactory.SendName
                                          select item).ToList();
                dgvProductRequset.DataSource = list;
            }
        }
    }
}
