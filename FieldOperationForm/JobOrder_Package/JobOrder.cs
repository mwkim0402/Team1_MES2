using System;
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
    public partial class JobOrder : Form
    {
        List<Item_Vo> MList = null;
        List<Process_Vo> PList = null;
        List<WorkCenter_Vo> WList = null;
        Main_P main;
        public JobOrder(Main_P main1)
        {
            InitializeComponent();
            main = main1;
            Setdgv();
            initComboBox();
            ComboPro();
            ComboWork();
            SetGV();
        }
        #region 그리드뷰 설정
        private void AddNewColumnToDataGridView(DataGridView dgv, string headerText, string dataPropertyName, bool visibility,
int colWidth = 100, DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleLeft)
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

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew;
            //    dgv.RowsDefaultCellStyle.BackColor = Color.Ivory;


            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Ivory;

            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.DarkSlateGray;
        }

        private void Setdgv()
        {

            AddNewColumnToDataGridView(dataGridView1, "소성대차", "GV_Name", true, 252);
            AddNewColumnToDataGridView(dataGridView1, "품목코드", "Item_Code", true, 185);
            AddNewColumnToDataGridView(dataGridView1, "품목명", "Item_Name", true, 191);
            AddNewColumnToDataGridView(dataGridView1, "수량", "GV_Qty", true, 180);


            this.dataGridView1.Font = new Font("나눔고딕", 16, FontStyle.Bold);
            this.dataGridView1.DefaultCellStyle.Font = new Font("나눔고딕", 16, FontStyle.Bold);



            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv_NonOperation.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv_NonOperation.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



        }
        #endregion
        //품목명
        private void initComboBox()
        {
            Item_Service service = new Item_Service();
            MList = service.GetItemName();
            if (MList.Count > 1)
            {
                List<string> NonList = (from item in MList
                                        select item.Item_Name).ToList();
                CommonUtil.ComboBinding(cb_Item, NonList);
            }

        }
        //공정명
        private void ComboPro()
        {
            Process_Service service = new Process_Service();
            PList = service.GetProName();
            if (PList.Count >= 1)
            {
                List<string> NonList = (from item in PList
                                        select item.Process_name).ToList();
                CommonUtil.ComboBinding(cb_Process, NonList);
            }

        }
        //작업장 명
        private void ComboWork()
        {
            WorkCenter_Service service = new WorkCenter_Service();
            WList = service.GetWcName();
            if (WList.Count > 1)
            {
                List<string> NonList = (from item in WList
                                        select item.Wc_Name).ToList();
                CommonUtil.ComboBinding(cb_WorkPlace, NonList);
            }

        }

        private void JobOrder_Shown(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = null;
        }

        private void btn_JobOrder_Click(object sender, EventArgs e)
        {
            WorkOrder_Service service = new WorkOrder_Service();
            WorkOrder_Vo vo = new WorkOrder_Vo();
            vo.Item_Name = cb_Item.Text;
            vo.Wc_Name = cb_WorkPlace.Text;

            vo.Plan_Qty = Convert.ToInt32(txt_PlannedQuantity.Text);

            service.InsertWorkOrder(vo);
            MessageBox.Show("작업지시 생성 완료");
        }

        private void SetGV()
        {
            GVDry_Service service = new GVDry_Service();
            dataGridView1.DataSource = service.GetGV();
        }

        private void JobOrder_Load(object sender, EventArgs e)
        {
            txt_WorkerDate.Text = DateTime.Now.ToString();
        }
    }
}
