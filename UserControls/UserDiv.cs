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
    public partial class UserDiv : UserControl
    {
        public UserDiv()
        {
            InitializeComponent();
            //this.Padding = new System.Windows.Forms.Padding(10);
        }


        public string Date
        {
            get { return label3.Text; }
            set { label3.Text = value; }
        }
        public string UserName
        {
            get { return Namelabel.Text; }
            set { Namelabel.Text = value; }
        }
        public string Department
        {
            get { return DepartmentLabel.Text; }
            set { DepartmentLabel.Text = value; }
        }

        public System.Drawing.Color Color
        {
            get { return splitter1.BackColor; }
            set { splitter1.BackColor = value; }
        }

    }
}
