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
    public partial class ViewFaultyImage : Form
    {
        int Seq = 0;
        public ViewFaultyImage(int seq)
        {
            InitializeComponent();
            Seq = seq;
        }
        
        private void ViewFaultyImage_Load(object sender, EventArgs e)
        {
            MES_DB.PerformService service = new MES_DB.PerformService();
            List<RegFaultyVO> list  = service.GetImage(Seq);
            TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
            picFaulty.Image = (Bitmap)tc.ConvertFrom(list[0].Def_Image);
            //pictureBox1.Image = Image.FromFile(url+"/"+filename);
        }
    }
}
