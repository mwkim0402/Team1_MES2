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
    public partial class ModuleManager : dgvOneWithInput
    {
        public ModuleManager()
        {
            InitializeComponent();
        }

        private void ModuleManager_Load(object sender, EventArgs e)
        {
            ShowDgv();
            CommonClass.Userauthority(btnSave);
        }

        private void ShowDgv()
        {
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "모듈 코드", "1", true, 120);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "모듈 명", "1", true, 100);
            CommonClass.AddNewColumnToDataGridView(dgvSearchResult, "사용여부", "1", true, 120);
        }
    }
}
