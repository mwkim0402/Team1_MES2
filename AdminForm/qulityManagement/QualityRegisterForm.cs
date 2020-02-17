using MES_DB;
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
    public partial class QulityRegisterForm : Form
    {
        QualityService service;
        InsQualityVO allQuality = new InsQualityVO();
        public QulityRegisterForm(InsQualityVO Ins)
        {
            InitializeComponent();
            allQuality = Ins;
        }

        private void QulityRegisterForm_Load(object sender, EventArgs e)
        {
            ComboBoxBinding();

            cmbItemName.SelectedValue = allQuality.Item_Code;
            cmbInspect.SelectedValue = allQuality.Inspect_Code;
            cmbProcessCode.SelectedValue = allQuality.Process_Code;
            cmbWork.SelectedValue = allQuality.WorkOrderNo;
        }

        private void ComboBoxBinding()
        {
            service = new QualityService();
            List<ItemCodeListVO> GetAllItemList = new List<ItemCodeListVO>();
            GetAllItemList = service.comboItemList();
            bool check = true;
            List<ComboItem> itemlist = new List<ComboItem>();
            List<ComboItem> Processlist = new List<ComboItem>();
            List<ComboItem> Inspectlist = new List<ComboItem>();
            List<ComboItem> Worklist = new List<ComboItem>();
            foreach (var item in GetAllItemList)
            {
                if(item.type == "item")
                {
                    InsertCombo(itemlist, item);
                }
                else if(item.type == "Process")
                {
                    InsertCombo(Processlist, item);
                }
                else if(item.type == "Inspect")
                {
                    InsertCombo(Inspectlist, item);
                }
                else if(item.type == "Work")
                {
                    InsertCombo(Worklist, item);
                }
            }

            ComboClass.ComboBind(itemlist, cmbItemName, check);
            ComboClass.ComboBind(Processlist, cmbProcessCode, check);
            ComboClass.ComboBind(Inspectlist, cmbInspect, check);
            ComboClass.ComboBind(Worklist, cmbWork, check);

        }

        private static void InsertCombo(List<ComboItem> itemlist, ItemCodeListVO item)
        {
            ComboItem combo = new ComboItem();
            combo.comboText = item.Item_Code;
            combo.comboValue = item.Item_Code;
            itemlist.Add(combo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("숫자를 입력해주세요.");
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cmbWork.SelectedIndex != 0 && cmbProcessCode.SelectedIndex !=0 && cmbItemName.SelectedIndex !=0 && cmbInspect.SelectedIndex != 0 && txtValue.Text != "" && txtValue.Text != null)
            {
                InsQualityVO insert = new InsQualityVO();
                insert.Inspect_Code = cmbInspect.SelectedValue.ToString();
                insert.Inspect_Val = Convert.ToInt32(txtValue.Text);
                insert.Item_Code = cmbItemName.SelectedValue.ToString();
                insert.Process_Code = cmbProcessCode.SelectedValue.ToString();
                insert.WorkOrderNo = cmbWork.SelectedValue.ToString();
                service.InsQuality(insert);

                MessageBox.Show("등록되었습니다.");
                this.Close();
            }
            else
            {
                MessageBox.Show("모든 항목에 값을 선택,입력해주세요.");
            }
        }
    }
}
