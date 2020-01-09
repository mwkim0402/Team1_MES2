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
    public partial class Notice : Form
    {

        List<Notice_Vo> NList = null;
        public Notice()
        {
          
            LoadNList();
            InitializeComponent();
        }

        // DataGridView 컬럼 설정
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

            AddNewColumnToDataGridView(dgv_Notice, "제목", "Title", true, 420);
            AddNewColumnToDataGridView(dgv_Notice, "작성자", "Ins_Emp", true, 100);
            AddNewColumnToDataGridView(dgv_Notice, "등록일", "Notice_Date", true, 130);
           AddNewColumnToDataGridView(dgv_Notice, "등록일", "Description", false, 150);


            dgv_Notice.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgv_Notice.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_Notice.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        private void LoadNList()
        {
            Notice_Service service = new Notice_Service();
            NList = service.NoticeList();
        }

        private void Notice_Load(object sender, EventArgs e)
        {
            Setdgv();
            dgv_Notice.DataSource = NList;
        }

        private void Notice_Shown(object sender, EventArgs e)
        {

            dgv_Notice.CurrentCell = null;
        }

        private void dgv_Notice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
    
            Notice_Vo notice = new Notice_Vo();
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                notice.Title = dgv_Notice.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_Name.Text = notice.Ins_Emp ;
               txt_date.Text = notice.Notice_Date;
              txt_Des.Text = notice.Description;
            }


            Notice_Service service = new Notice_Service();

            service.GetNotice(notice);
        }

        private void dgv_Notice_SelectionChanged(object sender, EventArgs e)
        {
            //Notice_Service service = new Notice_Service();
            
            //Notice_Vo notice = service.GetNotice();

                //txt_Title.Text = notice.Title;
                //txt_Name.Text = notice.Ins_Emp;
                //txt_date.Text = notice.Notice_Date;
                //txt_Des.Text = notice.Description;
        }

        
           
       

         
        
    }
}
