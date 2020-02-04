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
    public partial class FrmWaitForm : Form
    {
        public Action Worker { get; set; }

        public FrmWaitForm(Action worker)
        {
            InitializeComponent();

            Worker = worker;
        }

        private void frmWaitForm_Load(object sender, EventArgs e)
        {
 
            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
          
        }
    }
}
