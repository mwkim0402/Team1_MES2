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
    public partial class MoldInformationRegister : dgvOneWithInput
    {
        MainForm frm;
        List<MoldingInfoDetailVo> detailList = new List<MoldingInfoDetailVo>();
        int isUse;
        List<MoldingInfoVo> List = null;


        public MoldInformationRegister()
        {
           
            InitializeComponent();
        }
        private void LoadList()
        {
            MoldingService service = new MoldingService();
            List = service.GetMoldingInfo();
        }
        private void MoldInformationRegister_Load(object sender, EventArgs e)
        {

            //dgv 추가
            frm = (MainForm)this.MdiParent;
            AddNewColumnToDataGridView(dgvSearchResult, "금형코드", "Mold_Code", true, 100);
            AddNewColumnToDataGridView(dgvSearchResult, "금형명", "Mold_Name", true, 200);
            AddNewColumnToDataGridView(dgvSearchResult, "금형그룹", "Mold_Group", true, 150);
            AddNewColumnToDataGridView(dgvSearchResult, "금형상태", "Mold_Status", true, 100);
            AddNewColumnToDataGridView(dgvSearchResult, "금형누적타수", "Cum_Shot_Cnt", true, 150);
            AddNewColumnToDataGridView(dgvSearchResult, "금형누적생산량", "Cum_Prd_Qty", true, 150);
            AddNewColumnToDataGridView(dgvSearchResult, "금형누적사용시간", "Cum_Time", true, 145);
            AddNewColumnToDataGridView(dgvSearchResult, "보장타수", "Guar_Shot_Cnt", true, 100);
            AddNewColumnToDataGridView(dgvSearchResult, "구입금액", "Purchase_Amt", true, 100);
            AddNewColumnToDataGridView(dgvSearchResult, "입고일자", "In_Date", true, 150);
            AddNewColumnToDataGridView(dgvSearchResult, "최종장착일시", "Last_Setup_Time", true, 150);
            AddNewColumnToDataGridView(dgvSearchResult, "비고", "Remark", true, 80);
            AddNewColumnToDataGridView(dgvSearchResult, "사용유무", "Use_YN", true, 80);
            LoadList();
            dgvSearchResult.DataSource = List;

            dgvSearchResult.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvSearchResult.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSearchResult.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSearchResult.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSearchResult.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvSearchResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSearchResult_DoubleClick);
            //콤보바인딩
            //ComboClass.ComboBind(List<ComboItem> , cmbMoldGroupSearch, false);

            
        }

        private void DgvSearchResult_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MoldingService service = new MoldingService();
            detailList = service.GetMoldingInfoDetail(dgvSearchResult.SelectedRows[0].Cells[1].ToString());
            txtMoldCodeM.Text = detailList[0].Mold_Code;
            txtMoldNameM.Text = detailList[0].Mold_Name;
            cmbMoldGroupM.SelectedItem = detailList[0].Mold_Group; //
            txtWarrentNumM.Text = detailList[0].Guar_Shot_Cnt.ToString();
            txtPriceM.Text = detailList[0].Purchase_Amt.ToString();
            dtpInputdateM.Value = detailList[0].In_Date;
            dtpLastEquipDateM.Value = detailList[0].Last_Setup_Time;
            if (detailList[0].Use_YN.ToString() == "1")
            {
                rbUseM.Checked = true;
            }
            else
            {
                rbNoUseM.Checked = true;
            }
        }

        private void AddNewColumnToDataGridView(DataGridView dgv, string headerText, string dataPropertyName, bool visibility,
       int colWidth = 100, DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleCenter)
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

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;

            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.MidnightBlue;
        }
        //저장
        private void BtnSave_Click(object sender, EventArgs e)
        {
            MoldingService ser = new MoldingService();
            if (rbUse.Checked)
            {
                isUse = 1;
            }
            else if (rbNoUse.Checked)
            {
                isUse = 0;
            }
            else
            {
                MessageBox.Show("입력을 모두 해주세요.");
            }


            int result = ser.SaveMoldingInfo(txtMoldCodeInput.Text, txtMoldNameInput.Text, cmbMoldGroupI.SelectedItem.ToString(), txtPrice.Text, dtpInputdate.Value.ToString(),dtpLastEquipDate.Value.ToString(),txtWarrentNum.Text,txtPS.Text,isUse);
            if (result >= 1)
            {
                MessageBox.Show("저장이 완료되었습니다.");
                txtMoldCodeM.Text = null;
                txtMoldNameM.Text = null;
                cmbMoldGroupM.SelectedIndex = 0; //
                txtWarrentNumM.Text = null;
                txtPriceM.Text = null;
                dtpInputdateM.Value = DateTime.Now;
                dtpLastEquipDateM.Value = DateTime.Now;
                rbUse.Checked = false;
                rbNoUse.Checked = false;

            }
            else
            {
                MessageBox.Show("오류.");
            }
        }

        //검색
        private void Search_Click(object sender, EventArgs e)
        {
            MoldingService ser = new MoldingService();
            if (txtMoldCodeSearch.Text != "")
            {
                if (txtMoldNameSearch.Text != "")
                {
                    if (cmbMoldGroupSearch.Text != "")
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
                    if (cmbMoldGroupSearch.Text != "")
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
                    if (cmbMoldGroupSearch.Text != "")
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
                    if (cmbMoldGroupSearch.Text != "")
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
                frm.lblAlert.Text = "[알람] 검색한 조건의 데이터가 존재하지 않습니다.";
                return;
            }
            frm.lblAlert.Text = $"[알람] {List.Count} 건의 데이터가 조회되었습니다.";
            timer1.Start();
            dgvSearchResult.DataSource = List;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //frm.lblAlertTitle.Text = "";
            frm.lblAlert.Text = "<공지사항> Test 중 입니다.";
            timer1.Stop();
        }

    

    private void MoldInformationRegister_Activated(object sender, EventArgs e)
        {
            frm.Search_Click += new System.EventHandler(this.Search_Click);
        }

        private void MoldInformationRegister_Deactivate(object sender, EventArgs e)
        {
            frm.Search_Click -= new System.EventHandler(this.Search_Click);
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            detailList[0].Mold_Code = txtMoldCodeM.Text;
            detailList[0].Mold_Name=txtMoldNameM.Text;
            detailList[0].Mold_Group=cmbMoldGroupM.SelectedItem.ToString(); //
            detailList[0].Guar_Shot_Cnt=int.Parse( txtWarrentNumM.Text);
            detailList[0].Purchase_Amt= int.Parse(txtPriceM.Text);
            detailList[0].In_Date=dtpInputdateM.Value;
            detailList[0].Last_Setup_Time=dtpLastEquipDateM.Value;
            if (rbUseM.Checked)
            {
                detailList[0].Use_YN = '1';
            }
            else
            {
                detailList[0].Use_YN = '0';
            }

            MoldingService ser = new MoldingService();
            int result = ser.UpdateMoldingInfo(detailList[0]);
            if (result >= 1)
            {
                MessageBox.Show("수정이 완료되었습니다.");
            }
        }
    }
}
