using FieldOperationForm.JobOrder_Package;
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
    public partial class PaletteBarCode : Form
    {

        Main_P main;
        string a;
        string c;
        string f;
        string t;
        public PaletteBarCode(Main_P main1)
        {
            InitializeComponent();
            main = main1;
            Setdgv();
            SetGrid();
        }
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

            AddNewColumnToDataGridView(dataGridView1, "작업지시번호", "Workorderno", true, 300);
            AddNewColumnToDataGridView(dataGridView1, "팔레트번호", "Pallet_No", true, 177);
            AddNewColumnToDataGridView(dataGridView1, "바코드번호", "Barcode_No", true, 300);
            AddNewColumnToDataGridView(dataGridView1, "제품", "Item_Name", true, 200);
            AddNewColumnToDataGridView(dataGridView1, "날짜", "In_Date", true, 130);
            AddNewColumnToDataGridView(dataGridView1, "수량", "Prd_Qty", true, 130);
            AddNewColumnToDataGridView(dataGridView1, "단위", "Plan_Unit", true, 130);
            AddNewColumnToDataGridView(dataGridView1, "날짜", "StartDate", false, 130);
            AddNewColumnToDataGridView(dataGridView1, "날짜", "EndDate", false, 130);
            
      




            this.dataGridView1.Font = new Font("나눔고딕", 15, FontStyle.Bold);
            this.dataGridView1.DefaultCellStyle.Font = new Font("나눔고딕", 15, FontStyle.Bold);



            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv_NonOperation.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv_NonOperation.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



        }

        private void SetGrid()
        {
            Search_Vo vo = new Search_Vo();
            vo.StartDate = dtp_SDate.Value.ToString("yyyy-MM-dd");
            vo.EndDate = dtp_EDate.Value.ToString("yyyy-MM-dd");
            Search_Service service = new Search_Service();
            dataGridView1.DataSource = service.SearchBarcodeDate(vo);
           
        }

        private void PaletteBarCode_Load(object sender, EventArgs e)
        {
          
        }

        private void dtp_SDate_ValueChanged(object sender, EventArgs e)
        {
            SetGrid();
        }

        private void dtp_EDate_ValueChanged(object sender, EventArgs e)
        {
            SetGrid();
        }
        private void TextSet()
        {
            string strConn = ConfigurationManager.ConnectionStrings["Project"].ConnectionString;
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string strSql = String.Format("select Pallet_No,Grade_Code,Grade_Detail_Code,Size_Code,Prd_Qty from Goods_In_History where Barcode_No='{0}'", a);

                SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
                da.Fill(ds, "Goods_In_History");
                conn.Close();


            }
            string w;
            string e;
            string r;
            string i;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                w = dr["Grade_Code"].ToString();
                e = dr["Grade_Detail_Code"].ToString();
                r = dr["Size_Code"].ToString();
                i = dr["Prd_Qty"].ToString();
                txt_Rating.Text = w.ToString();
                txt_RatingDetail.Text = e.ToString();
                txt_Size.Text = r.ToString();
                txt_PaletteQuantity.Text = i.ToString();
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                a = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_PaletteNum.Text = a;
                f = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                t = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();

                TextSet();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_Reissue_Click(object sender, EventArgs e)
        {
         
            c = txt_PaletteQuantity.Text;
          
        

            string strConn = ConfigurationManager.ConnectionStrings["Project"].ConnectionString;
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string strSql = String.Format(@"select Barcode_No from Goods_In_History
                where Barcode_No='{0}'", a);

                SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
                da.Fill(ds, "Barcode_No");
                conn.Close();
            }
            // Barcode_Service service = new Barcode_Service();

            XtraReport1 rpt = new XtraReport1(c, f, t);
            //   rpt.DataSource = service.GetBarcode(cb_Item.Text);
            rpt.DataSource = ds.Tables["Barcode_No"];
            BarCode frm = new BarCode(rpt);
            //frm.documentViewer1.DocumentSource = rpt;
            //frm.ShowDialog();
        }
    }
}
