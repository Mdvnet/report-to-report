using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportToReport.Models;
using ReportToReport.Views;
using static MetroSet_UI.Controls.MetroSetCheckBox;
using MetroSet_UI.Controls;

namespace ReportToReport.UserControls
{
    public partial class CustomCheckBox : UserControl
    {
        AddDepartmentForm addDepartmentForm;

        public CustomCheckBox(AddDepartmentForm addDepartmentForm)
        {
            InitializeComponent();
            this.addDepartmentForm = addDepartmentForm;
            CkBox.CheckedChanged += addDepartmentForm.customCheckBox_CheckedChanged;
            
        }

                
        public string Title
        {
            get { return CkBox.Text; }
            set { if (CkBox.Text != null) CkBox.Text = value; }
        }

        public bool Checked
        {
            get { return CkBox.Checked; }
            set { CkBox.Checked = value; }
        }

        //public User UserBox 
        //{
        //    get { return user; }
        //    set { user = value; }
        //}

        public object UserBox
        {
            get { return CkBox.Tag; }
            set { CkBox.Tag = value; }
        }
    }
}
