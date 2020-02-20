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
    public partial class NoticeSettings : Form
    {
        public NoticeSettings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "")
            {
                MessageBox.Show("제목을 입력하셔야합니다.");
                textBox2.Focus();
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("내용을 입력하셔야합니다.");
                textBox1.Focus();
                return;
            }

            NoticeVo vo = new NoticeVo
            {
                Title = textBox2.Text,
                Description = textBox1.Text,
                Notice_Date = dateTimePicker1.Value.ToString("yyyy-MM-dd")
            };
            NoticeService service = new NoticeService();
            service.InsertNotice(vo);
            this.Close();
        }
    }
}
