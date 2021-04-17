using MetroSet_UI.Forms;
using ReportToReport.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportToReport.UserControls;
using MetroSet_UI.Controls;

namespace ReportToReport.Views
{
    public partial class AddDepartmentForm : MetroSetForm
    {
        public bool IsShowEmployees = false;
        public List<object> ToDepartmentUsers = new List<object>();
        public AddDepartmentForm()
        {
            InitializeComponent();
            
        }

        private void AddEmployeesButton_Click(object sender, EventArgs e)
        {
            if (IsShowEmployees) IsShowEmployees = false;
            else IsShowEmployees = true;
            AddEmployees(IsShowEmployees);
        }

        public void AddEmployees(bool isShow)
        {
            if (isShow)
            {
                EmployeesPanel.Controls.Clear();
                List<User> users = GetUndefinedUsers();
                foreach (User user in users)
                {
                    CustomCheckBox box = new CustomCheckBox(this);
                    //box.CheckedChanged += customCheckBox_CheckedChanged;
                    box.Title = user.Name + " " + user.Surname;
                    box.UserBox = user.Login;
                    EmployeesPanel.Controls.Add(box);
                    EmployeesPanel.Visible = true;
                }
            }
            else
            {
                EmployeesPanel.Visible = false;
            }
        }

        public void customCheckBox_CheckedChanged(object sender)
        {
            MetroSetCheckBox checkBox = (MetroSetCheckBox)sender;
            if (checkBox.Checked == true)
            {
                ToDepartmentUsers.Add(checkBox.Tag);
            }
            else
            {
                ToDepartmentUsers.Remove(checkBox.Tag);
            }
        }
        public List<User> GetUndefinedUsers()
        {
            using(AppContext appContext = new AppContext())
            {
                var users = new List<User>();
                users = appContext.Users.Where(u => u.Department == null).ToList();
                return users.Where(u => u.IsAdmin == false).ToList();  
            }
        }

        public void UpdateUsersByDepartment(List<object> users, Department department)
        {
            using (AppContext appContext = new AppContext())
            {
                foreach (var u in ToDepartmentUsers)
                {
                
                    User user = new User();
                    user = appContext.Users.Find(u.ToString());
                    user.Department = department;
                }
                appContext.SaveChanges();
            }
        }

        private void AddUserFormCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool IsAnNewDepartment(string name)
        {
            using(AppContext appContext = new AppContext())
            {
                foreach(Department department in appContext.Departments)
                {
                    if (department.Name == name) return false;
                }
            }
            return true;
        }

        private void CreateDepertmentButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(DepartmentTextBox.Text))
            {
                Notificationlabel.Visible = true;
                Notificationlabel.Text = "Введите название отдела!";
            }
            else if(!IsAnNewDepartment(DepartmentTextBox.Text))
            {
                Notificationlabel.Visible = true;
                Notificationlabel.Text = "Отдел "+ DepartmentTextBox.Text + " уже существует!";
            }
            else
            {
                Department department = new Department();
                department.Name = DepartmentTextBox.Text;
                using (AppContext appContext = new AppContext())
                {
                    appContext.Departments.Add(department);
                    appContext.SaveChanges();
                }
                UpdateUsersByDepartment(ToDepartmentUsers, department);
                MessageBox.Show("Отдел  \"" + department.Name + "\"  добавлен");
                this.Close();
            }
        }

    }
}
