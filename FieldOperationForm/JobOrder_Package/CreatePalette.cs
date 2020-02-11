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
    public partial class CreatePalette : Form
    {
        Main_P main;
        List<Palette_Vo> PList = null;
        string a;
        SqlConnection strConn;

        public CreatePalette(Main_P main1)
        {
            InitializeComponent();
            main = main1;
            Setdgv();
            SetPaletteList();




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
            dgv.DefaultCellStyle.SelectionBackColor = Color.CadetBlue;
        }

        private void Setdgv()
        {

         
            AddNewColumnToDataGridView(dataGridView1, "팔레트번호", "Pallet_No", true, 255);
            AddNewColumnToDataGridView(dataGridView1, "제품", "Item_Name", true, 172);
            AddNewColumnToDataGridView(dataGridView1, "등급", "Grade_Code", true, 160);
            AddNewColumnToDataGridView(dataGridView1, "수량", "Prd_Qty", true, 160);




            this.dataGridView1.Font = new Font("나눔고딕", 15, FontStyle.Bold);
            this.dataGridView1.DefaultCellStyle.Font = new Font("나눔고딕", 15, FontStyle.Bold);



            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv_NonOperation.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv_NonOperation.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



        }



        private void CreatePalette_Load(object sender, EventArgs e)
        {

         
        }


        private void SetPaletteList()
        {
            Palette_Service service = new Palette_Service();
            List<Palette_Vo> PList = service.PaletteList();
            dataGridView1.DataSource = PList;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            a = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_PaletteNum.Text = a;
            TextSet();
        }

        private void TextSet()
        {
            string strConn = ConfigurationManager.ConnectionStrings["Project"].ConnectionString;
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string strSql = String.Format("select Pallet_No,Grade_Code,Grade_Detail_Code,Size_Code from Palette_Master where Pallet_No='{0}'",a);
                
                SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
                da.Fill(ds, "Palette_Master");
                conn.Close();
                

            }
            string w;
            string e;
            string r;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                w =dr["Grade_Code"].ToString();
                e =dr["Grade_Detail_Code"].ToString();
                r =dr["Size_Code"].ToString();
                
                txt_Rating.Text = w.ToString();
                txt_RatingDetail.Text = e.ToString();
                txt_Size.Text = r.ToString();
            }

        }
    }
}
