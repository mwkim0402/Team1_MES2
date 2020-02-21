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
using Microsoft.Office.Interop;

namespace AdminForm
{
    public partial class MoldInformationRegister : dgvOneWithInput
    {
        MainForm frm;
        List<MoldingInfoDetailVo> detailList = new List<MoldingInfoDetailVo>();
        string isUse;
        List<MoldingInfoVo> List = null;
        string selected = null;

        public MoldInformationRegister()
        {
           
            InitializeComponent();
        }
        private void LoadList()
        {
            MoldingService service = new MoldingService();
            List = service.GetMoldingInfo();
            dgvSearchResult.DataSource = List;
        }
        private void MoldInformationRegister_Load(object sender, EventArgs e)
        {

            //dgv 추가
            frm = (MainForm)this.MdiParent;
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "금형코드", "Mold_Code", true, 110);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "금형명", "Mold_Name", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "금형그룹", "Mold_Group", true, 140);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "금형상태", "Mold_Status", true, 110);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "금형누적타수", "Cum_Shot_Cnt", true, 150, DataGridViewContentAlignment.MiddleRight);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "금형누적생산량", "Cum_Prd_Qty", true, 150, DataGridViewContentAlignment.MiddleRight);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "금형누적사용시간", "Cum_Time", true, 160);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "보장타수", "Guar_Shot_Cnt", true, 110, DataGridViewContentAlignment.MiddleRight);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "구입금액", "Purchase_Amt", true, 110, DataGridViewContentAlignment.MiddleRight);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "입고일자", "In_Date", true, 150, DataGridViewContentAlignment.MiddleCenter);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "최종장착일시", "Last_Setup_Time", true, 150, DataGridViewContentAlignment.MiddleCenter);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "비고", "Remark", true, 80);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용유무", "Use_YN", true, 110, DataGridViewContentAlignment.MiddleCenter);
            LoadList();
            dgvSearchResult.DataSource = List;
            
            dgvSearchResult.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvSearchResult.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSearchResult.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSearchResult.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSearchResult.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvSearchResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSearchResult_DoubleClick);
            this.dgvSearchResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchResult_Click);
            //콤보바인딩
            List<ComboItem> item = (from items in List
                                    select  new ComboItem
                                    {
                                        comboText = items.Mold_Group,
                                        comboValue = items.Mold_Group
                                    }).Distinct().ToList() ;
            ComboClass.ComboBind(item , cmbMoldGroupSearch, true);
            //ComboClass.ComboBind(item, cmbMoldGroupI, false);
            //ComboClass.ComboBind(item, cmbMoldGroupM, false);

            cmbMoldGroupI.DataSource = cmbMoldGroupSearch.DataSource;
            cmbMoldGroupM.DataSource = cmbMoldGroupSearch.DataSource;
            

        }

        private void dgvSearchResult_Click(object sender, DataGridViewCellEventArgs e)
        {
            selected = dgvSearchResult.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void DgvSearchResult_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tcParent2.SelectedIndex = 1;
            MoldingService service = new MoldingService();
            detailList = service.GetMoldingInfoDetail(selected);
            txtMoldCodeM.Text = detailList[0].Mold_Code;
            txtMoldNameM.Text = detailList[0].Mold_Name;
            cmbMoldGroupM.SelectedValue = detailList[0].Mold_Group; //
            txtWarrentNumM.Text = detailList[0].Guar_Shot_Cnt.ToString();
            txtPriceM.Text = detailList[0].Purchase_Amt.ToString();
            dtpInputdateM.Value = detailList[0].In_Date;
            dtpLastEquipDateM.Value = detailList[0].Last_Setup_Time;
            txtPSM.Text = detailList[0].Remark;
            if (detailList[0].Use_YN.ToString() == "Y")
            {
                rbUseM.Checked = true;
            }
            else
            {
                rbNoUseM.Checked = true;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            MoldingService ser = new MoldingService();
            if (rbUse.Checked)
            {
                isUse = "Y";
            }
            else
            {
                isUse = "N";
            }
            if (int.TryParse(txtPrice.Text, out int price) && int.TryParse(txtWarrentNum.Text, out int warrentNum))
            {
                int result = ser.SaveMoldingInfo(txtMoldCodeInput.Text, txtMoldNameInput.Text, cmbMoldGroupI.SelectedValue.ToString(), int.Parse(txtPrice.Text), dtpInputdate.Value.ToString().Substring(0, 10), dtpLastEquipDate.Value.ToString().Substring(0, 10), int.Parse(txtWarrentNum.Text), txtPS.Text, isUse);
                if (result >= 1)
                {
                    MessageBox.Show("저장이 완료되었습니다.");
                    txtMoldCodeInput.Text = null;
                    txtMoldNameInput.Text = null;
                    cmbMoldGroupI.SelectedValue = 0;
                    txtWarrentNum.Text = null;
                    txtPrice.Text = null;
                    dtpInputdate.Value = DateTime.Now;
                    dtpLastEquipDate.Value = DateTime.Now;
                    rbUse.Checked = false;
                    rbNoUse.Checked = false;
                    LoadList();
                }
                else
                {
                    MessageBox.Show("오류.");
                }
            }
            else
            {
                MessageBox.Show("정확한 값을 입력해 주세요.");
            }

        }

        //검색
        private void Search_Click(object sender, EventArgs e)
        {
            LoadList();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //frm.lblAlertTitle.Text = "";
            //frm.lblAlert.Text = "<공지사항> Test 중 입니다.";
            timer1.Stop();
        }

    

        private void MoldInformationRegister_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += new EventHandler(this.Search_Click);
            frm.btnSave.Enabled = false;// 파일저장 비활성화
            frm.Insert_Click += new EventHandler(this.ExportToExcel);
        }

        private void MoldInformationRegister_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= new EventHandler(this.Search_Click);
            frm.btnSave.Enabled = true;// 파일저장 활성화
            frm.Insert_Click -= new EventHandler(this.ExportToExcel);
        }
        private void ExportToExcel(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;

            int i, j;

            saveFileDialog1.Filter = "Excel Files (*.xls)|*.xls";
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    xlApp = new Microsoft.Office.Interop.Excel.Application();
                    xlWorkBook = xlApp.Workbooks.Add();
                    xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                    for (i = 0; i < dgvSearchResult.Columns.Count; i++)
                    {
                        xlWorkSheet.Cells[1, i + 1] = dgvSearchResult.Columns[i].HeaderText;
                    }

                    for (i = 0; i < dgvSearchResult.RowCount; i++)
                    {
                        for (j = 0; j < dgvSearchResult.ColumnCount; j++)
                        {
                            xlWorkSheet.Cells[i + 2, j + 1] = dgvSearchResult[j, i].Value.ToString();
                        }
                    }

                    xlWorkBook.SaveAs(saveFileDialog1.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    xlWorkBook.Close(true);
                    xlApp.Quit();

                    releaseObject(xlWorkSheet);
                    releaseObject(xlWorkBook);
                    releaseObject(xlApp);

                    MessageBox.Show("저장 완료되었습니다.");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

            }
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }


        private void BtnModify_Click(object sender, EventArgs e)
        {
            detailList[0].Mold_Code = txtMoldCodeM.Text;
            detailList[0].Mold_Name=txtMoldNameM.Text;
            detailList[0].Mold_Group=cmbMoldGroupM.SelectedValue.ToString(); //
            detailList[0].Guar_Shot_Cnt=int.Parse( txtWarrentNumM.Text);
            detailList[0].Purchase_Amt= int.Parse(txtPriceM.Text);
            detailList[0].In_Date=dtpInputdateM.Value;
            detailList[0].Last_Setup_Time=dtpLastEquipDateM.Value;
            if (rbUseM.Checked)
            {
                detailList[0].Use_YN = "Y";
            }
            else
            {
                detailList[0].Use_YN = "N";
            }

            MoldingService ser = new MoldingService();
            int result = ser.UpdateMoldingInfo(detailList[0]);
            if (result >= 1)
            {
                MessageBox.Show("수정이 완료되었습니다.");
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            MoldingService ser = new MoldingService();
            if (txtMoldCodeSearch.Text != "")
            {
                if (txtMoldNameSearch.Text != "")
                {
                    if (cmbMoldGroupSearch.Text != "선택")
                    {
                        List = ser.SearchMoldingInfo(txtMoldCodeSearch.Text, txtMoldNameSearch.Text, cmbMoldGroupSearch.Text);
                    }
                    else
                    {
                        List = ser.SearchMoldingInfo(txtMoldCodeSearch.Text, txtMoldNameSearch.Text, "");
                    }
                }
                else
                {
                    if (cmbMoldGroupSearch.Text != "선택")
                    {
                        List = ser.SearchMoldingInfo(txtMoldCodeSearch.Text, "", cmbMoldGroupSearch.Text);
                    }
                    else
                    {
                        List = ser.SearchMoldingInfo(txtMoldCodeSearch.Text, "", "");
                    }
                }
            }
            else
            {
                if (txtMoldNameSearch.Text != "")
                {
                    if (cmbMoldGroupSearch.Text != "선택")
                    {
                        List = ser.SearchMoldingInfo("", txtMoldNameSearch.Text, cmbMoldGroupSearch.Text);
                    }
                    else
                    {
                        List = ser.SearchMoldingInfo("", txtMoldNameSearch.Text, "");
                    }
                }
                else
                {
                    if (cmbMoldGroupSearch.Text != "선택")
                    {
                        List = ser.SearchMoldingInfo("", "", cmbMoldGroupSearch.Text);
                    }
                    else
                    {
                        List = ser.SearchMoldingInfo("", "", "");
                    }
                }
            }
            if (List.Count < 1)
            {
                //frm.lblAlert.Text = "[알람] 검색한 조건의 데이터가 존재하지 않습니다.";
                return;
            }
            //frm.lblAlert.Text = $"[알람] {List.Count} 건의 데이터가 조회되었습니다.";
            timer1.Start();
            dgvSearchResult.DataSource = List;
        }
    }
}
