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
    public partial class MenuManagement : Form
    {
        public MenuManagement()
        {
            InitializeComponent();
        }

        private void MenuManagement_Load(object sender, EventArgs e)
        {
            ShowDgv();
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "모듈 코드", "1", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvProductRequset, "모듈 명", "1", true, 100);

            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "화면 코드", "1", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvJobOrder, "화면 명", "1", true, 100);
        }
    }
}
