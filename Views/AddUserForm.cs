using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using ReportToReport.Models;
using System.Data.Entity;

namespace ReportToReport.Views
{
    public partial class AddUserForm : MetroSetForm
    {
        //BindingList<Department> departments = new BindingList<Department>();
        AppContext db = new AppContext();
        public bool IsAdmin = false;

        public AddUserForm()
        {
            InitializeComponent();
            DateToolTip.SetToolTip(DeadlinePanel, "Можно изменить в любое время");
        }

        private void AddUserFormCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            db.Departments.Load();
            this.departmentBindingSource.DataSource = db.Departments.Local.ToBindingList<Department>();
        }

       

        private void DateToolTip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void AddDepartmentButton_Click(object sender, EventArgs e)
        {
            AddDepartmentForm addDepartmentForm = new AddDepartmentForm();
            addDepartmentForm.ShowDialog();
        }

        private void AdmincheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                IsAdmin = true;
            }
            else
            {
                IsAdmin = false;
            }
        }
    }
}
