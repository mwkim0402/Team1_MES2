using FieldOperationForm.FieldVo;
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
    public partial class UpdateNonOperation : Form
    {
        List<NonOperation_Vo> MList = null;
        string a1;
        string b1;
        string c1;


        public UpdateNonOperation(string a, string b, string c)
        {
            InitializeComponent();
            a1 = a;
            b1 = b;
            c1 = c;
        }

        private void UpdateNonOperation_Load(object sender, EventArgs e)
        {
            txt_Workplace.Text = a1;
            
            txt_Detail.Text = c1;
            txt_Hap.Text = b1;

            txt_Workplace1.Text = a1;
            txt_Detail1.Text = c1;
            cb_Hap.Text = b1;


            initComboBox();

        }

        private void initComboBox()
        {
            NonOperation_Service service = new NonOperation_Service();
            MList = service.GetMa_NameList();
            if (MList.Count > 1)
            {
                List<string> NonList = (from item in MList
                                        select item.Nop_Ma_Name).ToList();
                CommonUtil.ComboBinding(cb_Hap, NonList);
            }

        }

        private void btn_Write_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("변경 하시겠습니까?", "알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                NonOperation_Service service = new NonOperation_Service();

                updateNonOperation_Vo vo = new updateNonOperation_Vo();
                vo.Nop_Ma_Name = txt_Hap.Text;
                vo.Nop_Mi_Name = txt_Detail.Text;
                vo.Nop_Ma_Name1 = cb_Hap.Text;
                vo.Nop_Mi_Name1 = txt_Detail1.Text;
                service.UpdateNop(vo);

                this.Close();

            }
        }
    }

}

