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
    public partial class CategorySearch: Form
    {
        string catCode;
        string catName;

        public string CatCode { get => catCode; set => catCode = value; }
        public string CatName { get => catName; set => catName = value; }

        public CategorySearch()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // dgv 중 선택된 코드를 catCode에 입력
            // dgv 중 선택된 카테고리명을 catName에 입력

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //cmb와 txtsearch명으로 데이터를 검색해 dgv에 출력
        }
    }
}
