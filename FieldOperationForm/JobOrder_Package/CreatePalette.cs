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
    public partial class CreatePalette : Form
    {
        Main_P main;
    //    List<Palette_Vo> PList = null;
        string a;
    //    SqlConnection strConn;
        List<Workorderno_Vo> MList = null;
      

        public CreatePalette(Main_P main1)
        {
            InitializeComponent();
            main = main1;
            Setdgv();
            SetPaletteList();
            initComboBox();



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
            col.DefaultCellStyle.Padding = new Padding(3);
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

         
            AddNewColumnToDataGridView(dataGridView1, "팔레트번호", "Pallet_No", true, 350);
            AddNewColumnToDataGridView(dataGridView1, "등급", "Grade_Code", true, 300);
            AddNewColumnToDataGridView(dataGridView1, "등급상세", "Grade_Detail_Code", true, 350);
            AddNewColumnToDataGridView(dataGridView1, "사이즈", "Size_Code", true, 347);




            this.dataGridView1.Font = new Font("나눔고딕", 17, FontStyle.Bold);
            this.dataGridView1.DefaultCellStyle.Font = new Font("나눔고딕", 17, FontStyle.Bold);



            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



        }



        private void CreatePalette_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 5;
         
        }


        private void SetPaletteList()
        {
            Palette_Service service = new Palette_Service();
            List<PaletteDetail_Vo> PList = service.PaletteList();
            dataGridView1.DataSource = PList;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                a = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_PaletteNum.Text = a;
                TextSet();
            }
            catch
            {

            }
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
        private void initComboBox()
        {
            Workorderno_Service service = new Workorderno_Service();
            MList = service.GetWorkorderno(main.lbl_Job.Text);
            if (MList.Count > 0)
            {
                List<string> NonList = (from item in MList
                                        select item.Workorderno).ToList();
                CommonUtil.ComboBinding(cb_Item, NonList);
            }

        }

        private void cb_Item_SelectedIndexChanged(object sender, EventArgs e)
        {
            noTextSet();
        }

        private void noTextSet()
        {
            string strConn = ConfigurationManager.ConnectionStrings["Project"].ConnectionString;
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string strSql = String.Format(@"select I.item_Name ,c.Wc_Name,w.Plan_Date,w.Plan_Qty,w.Plan_Unit from WorkOrder w, Item_Master I, WorkCenter_Master c
                    where I.Item_Code = w.Item_Code and c.Wc_Code = w.Wc_Code and Workorderno = '{0}'", cb_Item.Text);

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
                txt_WorkDate.Text = Convert.ToDateTime(dr["Plan_Date"]).ToString().Substring(0,10);
                txt_ResultNum.Text= dr["Plan_Qty"].ToString();
                txt_unit.Text= dr["Plan_Unit"].ToString();
            }

        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            CreatePal();
            SetPaletteList();
         
          string c;
            string f;
            string t;
            c = txt_ResultNum.Text;
            t = txt_Item.Text;
            f = cb_Item.Text;

            string strConn = ConfigurationManager.ConnectionStrings["Project"].ConnectionString;
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string strSql = String.Format(@"select Barcode_No from Goods_In_History
                where Workorderno='{0}'", cb_Item.Text);

                SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
                da.Fill(ds, "Barcode_No");
                conn.Close();
            }
               // Barcode_Service service = new Barcode_Service();
            
            XtraReport1 rpt = new XtraReport1(c,  f, t);
            //   rpt.DataSource = service.GetBarcode(cb_Item.Text);
            rpt.DataSource = ds.Tables["Barcode_No"];
            BarCode frm = new BarCode(rpt);
            //frm.documentViewer1.DocumentSource = rpt;
            //frm.ShowDialog();
        }

        private void CreatePal()
        {
            CreatePalette_Vo vo = new CreatePalette_Vo();
            vo.Workorderno = cb_Item.Text;
            vo.Pallet_No = txt_PaletteNum.Text;
         //   vo.Pallet_Qty =Convert.ToInt32( txt_PaletteQuantity.Text);
            vo.Size_Code = txt_Size.Text;
            vo.Grade_Code = txt_Rating.Text;
            vo.Grade_Detail_Code = txt_RatingDetail.Text;
            vo.Prd_Qty = Convert.ToInt32(txt_ResultNum.Text);
            CreatePalette_Service service = new CreatePalette_Service();
            service.CreatePalette_each(vo,int.Parse( txt_PaletteQuantity.Text), txt_Rating.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "전체")
            {
                SetPaletteList();
            }

            else
            {
                Palette_Service service = new Palette_Service();
                dataGridView1.DataSource = service.GetPaletteGrade(comboBox1.Text);
            }
        }
    }


}
