using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportToReport.UserControls
{
    public partial class MainSplitConteiner : UserControl
    {
        public MainSplitConteiner()
        {
            InitializeComponent();
             flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
        }

        public void AddUserDiv(UserDiv userDiv)
        {
            flowLayoutPanel1.Controls.Add(userDiv);
        }       

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
