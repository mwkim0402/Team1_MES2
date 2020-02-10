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
        string url = string.Empty;
        string filename = string.Empty;
        public ViewFaultyImage(string name,string path)
        {
            InitializeComponent();
            url = path;
            filename = name;
        }
        
        private void ViewFaultyImage_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(url+"/"+filename);
        }
    }
}
