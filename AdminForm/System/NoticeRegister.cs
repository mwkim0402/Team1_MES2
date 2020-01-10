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
    public partial class NoticeRegister : dgvOneWithInput
    {
        public NoticeRegister()
        {
            InitializeComponent();
        }

        private void NoticeRegister_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "공지일자", "1", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "제목", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "내용", "1", true, 300);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용여부", "1", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "공지종료일자", "1", true, 120);
        }
    }
}
