using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FieldOperationForm
{
    public partial class InspectForm : Form
    {
        Main_P main;
    
        decimal u;
        string t;
        string g;
        List<Workorderno_Vo> MList = null;
        string f;
        public InspectForm(Main_P main1)
        {
            InitializeComponent();
            main = main1;
            Setdgv();
            GetCon();
            initComboBox();
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
            col.DefaultCellStyle.Padding = new Padding(3);
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Ivory;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Honeydew;
            //    dgv.RowsDefaultCellStyle.BackColor = Color.Ivory;


            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Ivory;

            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.CadetBlue;

            dgv.RowTemplate.Height = 60;
        }

        private void Setdgv()
        {

            AddNewColumnToDataGridView(dataGridView1, "측정항목", "Inspect_Group", true, 240);
            AddNewColumnToDataGridView(dataGridView1, "USL", "USL", true, 170);
            AddNewColumnToDataGridView(dataGridView1, "SL", "SL", true, 170);
            AddNewColumnToDataGridView(dataGridView1, "LSL", "LSL", true, 170);
            AddNewColumnToDataGridView(dataGridView1, "LSL", "Wc_Name", false, 160);
            AddNewColumnToDataGridView(dataGridView1, "LSL", "Item_Name", false, 160);

            this.dataGridView1.Font = new Font("나눔고딕", 17, FontStyle.Bold);
            this.dataGridView1.DefaultCellStyle.Font = new Font("나눔고딕", 17, FontStyle.Regular);



            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            AddNewColumnToDataGridView(dataGridView2, "측정그룹", "Inspect_Group", true, 340);
            AddNewColumnToDataGridView(dataGridView2, "측정일시", "Inspect_Datetime", true, 530);
            AddNewColumnToDataGridView(dataGridView2, "측정값", "Inspect_Val", true, 254);
            AddNewColumnToDataGridView(dataGridView2, "측정일시", "Item_Name", false, 180);
            AddNewColumnToDataGridView(dataGridView2, "측정일시", "Wc_Name", false, 180);
            AddNewColumnToDataGridView(dataGridView2, "측정일시", "Workorderno", false, 180);
            AddNewColumnToDataGridView(dataGridView2, "측정일시", "Condition_Group1", false, 180);

            this.dataGridView2.Font = new Font("나눔고딕", 17, FontStyle.Bold);
            this.dataGridView2.DefaultCellStyle.Font = new Font("나눔고딕", 17, FontStyle.Regular);



            dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView2.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
   

        }
        #endregion


        private void GetCon()
        {
            Inspect_Service service = new Inspect_Service();
            dataGridView1.DataSource = service.GetInspetMaster(cb_WorkNum.Text);
        }

        private void ProcessCondition_Shown(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = null;
            dataGridView2.CurrentCell = null;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                //b = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                //c = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                //a = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                //d = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                //txt_MeasuredValue.Text = ((Convert.ToDecimal(a) + Convert.ToDecimal(b) + Convert.ToDecimal(c)) / 3).ToString();
                //f = txt_MeasuredValue.Text;
                //SetVal();



            }
            catch { }
        }
        private void SetVal()
        {
            Inspect_Service service = new Inspect_Service();
            dataGridView2.DataSource = service.GetInspectHis(cb_WorkNum.Text, t.ToString());
        }
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                g= dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
                u = Convert.ToDecimal(dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch { }
        }

        private void btn_Write_Click(object sender, EventArgs e)
        {
            if (t == null)
            {
                MessageBox.Show("측정항목을 선택해주세요.", "알림");
            }
            else
            {     
            Inspect_Service service = new Inspect_Service();
            service.InspectVal(cb_WorkNum.Text, Convert.ToDecimal(txt_MeasuredValue.Text), t.ToString());
                txt_MeasuredValue.Text = "";
            MessageBox.Show("입력완료","알림");
            SetVal();
            }


            //Inspect_Service service = new Inspect_Service();
            //Inspect_Vo vo = new Inspect_Vo();
            //vo.Item_Name = d;
            //vo.Inspect_Val = Convert.ToDecimal(txt_MeasuredValue.Text);

            //service.InsertInspect(vo);

            //MessageBox.Show("입력 완료");


        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
           
                if (MessageBox.Show("삭제 하시겠습니까?", "알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    Inspect_Service service = new Inspect_Service();
                    Inspect_Vo vo = new Inspect_Vo();
                    vo.Item_Name = txt_Item.Text;
                    vo.Condition_Val = u;
                    vo.Wc_Name = txt_WorkPlace.Text;
                    vo.Condition_Group = g;

                    service.deleteVal(vo);

                    SetVal();
                }
            
        }
        private void initComboBox()
        {
            Workorderno_Service service = new Workorderno_Service();
            MList = service.InsepctWork(main.lbl_Job.Text);
            if (MList.Count > 0)
            {
                List<string> NonList = (from item in MList
                                        select item.Workorderno).ToList();
                CommonUtil.ComboBinding(cb_WorkNum, NonList);
            }

        }
        private void noTextSet()
        {
            string strConn = ConfigurationManager.ConnectionStrings["Project"].ConnectionString;
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string strSql = String.Format(@"select I.item_Name ,c.Wc_Name,w.Plan_Date,w.Plan_Qty,w.Plan_Unit from WorkOrder w, Item_Master I, WorkCenter_Master c
                    where I.Item_Code = w.Item_Code and c.Wc_Code = w.Wc_Code and Workorderno = '{0}'", cb_WorkNum.Text);

                SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
                da.Fill(ds, "WorkOrder");
                conn.Close();


            }
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                //c = dr["Grade_Code"].ToString();
                //e = dr["Grade_Detail_Code"].ToString();
                //r = dr["Size_Code"].ToString();

                txt_Item.Text = dr["item_Name"].ToString();
                txt_WorkPlace.Text = dr["Wc_Name"].ToString();
                txt_WorkDate.Text = Convert.ToDateTime(dr["Plan_Date"]).ToString().Substring(0, 10);
                txt_ResultNum.Text = dr["Plan_Qty"].ToString();
                txt_unit.Text = dr["Plan_Unit"].ToString();
            }


        }

        private void cb_WorkNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            noTextSet();
            GetCon();
            txt_MeasuredValue.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                t = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                SetVal();
            }
            catch { }
        }
    }
}
