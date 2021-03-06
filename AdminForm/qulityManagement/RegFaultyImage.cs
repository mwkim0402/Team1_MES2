﻿using MES_DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        string WorkOrder = string.Empty;
        string fileName = string.Empty;
        byte[] bImage;
        PictureBox pic;
        int seq = 0;
        public RegFaultyImage()
        {
            InitializeComponent();
        }

        private void RegFaultyImage_Load(object sender, EventArgs e)
        {
            frm = (MainForm)this.MdiParent;
            ShowDgv();
            StartDate = dtpStart.Value;
            EndDate = dtpEnd.Value;
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
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "작업지시상태", "Wo_Status", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "작업지시번호", "Workorderno", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "생산일자", "Plan_Date", true, 120, DataGridViewContentAlignment.MiddleCenter);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "품목코드", "Item_Code", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "품목명", "Item_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "작업장", "Wc_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "실적", "Prd_Qty", true, 100, DataGridViewContentAlignment.MiddleRight);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "불량이미지 건수", "workImageCount", true, 180, DataGridViewContentAlignment.MiddleRight);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "x", "Def_Ma_Code", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "x", "Def_Mi_Code", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "x", "Def_Date", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "x", "Def_Qty", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "x", "Def_Image_Name", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "x", "Process_name", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "x", "Def_Image", false, 100);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "x", "Def_Seq", false, 100);


            GetData();
        }

        private void GetData()
        {
            dgvJobOrder.CellDoubleClick += DgvProductRequset_CellDoubleClick;
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "작업지시번호", "Workorderno", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "품목코드", "Item_Code", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "품목명", "Item_Name", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "불량대분류", "Def_Ma_Code", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "불량상세분류", "Def_Mi_Code", true, 150);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "발생일시", "Def_Date", true, 120, DataGridViewContentAlignment.MiddleCenter);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "불량수량", "Def_Qty", true, 120, DataGridViewContentAlignment.MiddleRight);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "사진이름", "Def_Image_Name", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "불량사진", "Def_Image", false, 120);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "x", "Def_Image_Path", false, 100);
        }

        private void DgvProductRequset_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            WorkOrder = dgvJobOrder.Rows[e.RowIndex].Cells[1].Value.ToString();



            if (dgvJobOrder.Rows[e.RowIndex].Cells[8].Value != null)
            {
                //이미지 보여주기 해야함

                ViewFaultyImage frm = new ViewFaultyImage(seq);
                frm.ShowDialog();
            }
        }

        private void ViewDgvDetail(object sender, DataGridViewCellEventArgs e)
        {
            seq = Convert.ToInt32(dgvProductRequset.Rows[e.RowIndex].Cells[15].Value);
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
            btnImage.Enabled = true;
            btnFaltyIns.Enabled = true;
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
            if (allList != null)
            {
                if ((fcWork.SendCode != null && fcWork.SendName != "") && (fcFactory.SendCode != null && fcFactory.SendCode != ""))
                {
                    List<RegFaultyVO> list = (from item in allList
                                              where item.Process_name == fcFactory.SendName && item.Wc_Name == fcWork.SendName && item.Plan_Date >= StartDate.Date && item.Plan_Date <= EndDate.Date
                                              select item).ToList();
                    dgvProductRequset.DataSource = list;
                }
                else if ((fcWork.SendCode != null && fcWork.SendCode != "") && (fcFactory.SendCode == null || fcFactory.SendCode == ""))
                {
                    List<RegFaultyVO> list = (from item in allList
                                              where item.Wc_Name == fcWork.SendName && item.Plan_Date >= StartDate.Date && item.Plan_Date <= EndDate.Date
                                              select item).ToList();
                    dgvProductRequset.DataSource = list;
                }
                else if ((fcWork.SendCode == null || fcWork.SendCode == "") && (fcFactory.SendCode != null && fcFactory.SendCode != ""))
                {
                    List<RegFaultyVO> list = (from item in allList
                                              where item.Process_name == fcFactory.SendName && item.Plan_Date >= StartDate.Date && item.Plan_Date <= EndDate.Date
                                              select item).ToList();
                    dgvProductRequset.DataSource = list;
                }
                else if ((fcFactory.SendCode == null || fcFactory.SendCode == "") && (fcWork.SendCode == null || fcWork.SendCode == ""))
                {
                    List<RegFaultyVO> list = (from item in allList
                                              where item.Plan_Date >= StartDate.Date && item.Plan_Date <= EndDate.Date
                                              select item).ToList();
                    dgvProductRequset.DataSource = list;
                }
            }
            else
            {
                MessageBox.Show("전체조회를 눌러주세요.");
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            // 불량 이미지 등록하기
            string filePath = "/FaltyImage/";
            if (WorkOrder != null && WorkOrder != "")
            {
                openFileDialog1.Filter = "Images Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.png";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pic = new PictureBox();
                    pic.Image = new Bitmap(openFileDialog1.FileName);
                    pic.Tag = openFileDialog1.FileName;

                    FileStream fs = new FileStream(pic.Tag.ToString(), FileMode.Open, FileAccess.Read);
                    bImage = new byte[fs.Length];
                    fs.Read(bImage, 0, (int)fs.Length);


                    //cmd.Parameters.AddWithValue("@ImageNo", 1);
                    //cmd.Parameters.AddWithValue("@Image", bImage);
                    fs.Close();


                    fileName = openFileDialog1.FileName;
                    string[] fileNameArr = fileName.Split('\\');
                    for (int i = 0; i < fileNameArr.Length; i++)
                    {
                        fileName = fileNameArr[i];
                    }

                    //saveFileDialog1.FileName = fileName;
                    //saveFileDialog1.InitialDirectory = Application.StartupPath.Replace('\\', '/') + filePath;

                    // DB에 저장 될 저장 경로
                    //InsDBfilePath = saveFileDialog1.InitialDirectory;


                    //saveFileDialog1.InitialDirectory = Application.StartupPath.Replace('\\', '/') + filePath + fileName;
                    //string saveFilePath = saveFileDialog1.InitialDirectory;
                    //PictureBox pic = new PictureBox();
                    //pic.Image = Bitmap.FromFile(openFileDialog1.FileName);
                    //pic.Image.Save(saveFilePath);

                    MessageBox.Show("이미지 등록을 위한 불량등록버튼을 눌러주세요.");
                }
            }
            else
                MessageBox.Show("불량사진 넣을 항목을 선택해주세요.");
        }

        private void btnFaltyIns_Click(object sender, EventArgs e)
        {
            //DB 입력부분
            MES_DB.PerformService service = new MES_DB.PerformService();
            ImageConverter converter = new ImageConverter();
            byte[] imagebyte = (byte[])converter.ConvertTo(pic.Image, typeof(byte[]));

            if (MessageBox.Show("수정하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                service.InsFaltyImage(fileName, imagebyte, WorkOrder, Convert.ToInt32(nuFaultyCount.Value));


                dgvJobOrder.DataSource = null;
                GetData();
                frm.btnS.PerformClick();
            }
            else
            {
                MessageBox.Show("취소되었습니다.");
            }
        }
    }
}
