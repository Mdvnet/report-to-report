using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using ReportToReport.Models;
using MetroSet_UI.Forms;

namespace ReportToReport.Views
{
    public partial class LoginForm : MetroSetForm
    {
        public User user;
        bool IsSave = true;

        public LoginForm()
        {
            if (Properties.Settings.Default.login != null && Properties.Settings.Default.login != "")
            {
                User user = GetUser(Properties.Settings.Default.login);
                if (user == null)
                {
                    user = CreateAdmin();
                }
                CheckLoginAndPassword(user, user.Password);
            }
            else
            {
                InitializeComponent();
                this.Show();
            }
        }

        public User CreateAdmin()
        {
            User admin = new User
            {
                Login = "admin",
                Password = "00000",
                IsAdmin = true
            };
            using(AppContext appContext = new AppContext())
            {
                appContext.Users.Add(admin);
                appContext.SaveChanges();
            }
            return admin;
        }
        public void CheckLoginAndPassword(User user, string password)
        {
            if (user != null)
            {
                if (user.Password == password)
                {
                    SaveLogin(user, IsSave);
                    OpenMainForm(user, user.IsAdmin);
                }
                else
                {
                    ShowNotification(2);
                }
            }
            else
            {
                ShowNotification(1);
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            User user = GetUser(LoginTextBox.Text);
            CheckLoginAndPassword(user, PasswordTextBox.Text);
        }

        public void ShowNotification(int i)
        {
            string text;
            switch (i)
            {
                case 1 :
                    text = "Неверный логин";
                    break;
                case 2 :
                    text = "Неверный пароль";
                    break;
                default:
                    text = "Неверный логин или пароль";
                    break;
            }
            NotificationLabel.Text = text;
            NotificationLabel.Visible = true;
        }

        public User GetUser(string login)
        {
            using(var appContext = new AppContext())
            {
                return appContext.Users.Find(login);
            }
        }
        public void OpenMainForm(User user, bool isAdmin)
        {
            if (isAdmin)
            {
                MainAdminForm mainAdminForm = new MainAdminForm(user);
                mainAdminForm.Show();
                Close();
            }
            else
            {
                MainClientForm mainClientForm = new MainClientForm(user);
                mainClientForm.Show();
                Close();
            }
        }
        public void SaveLogin(User user, bool isSave)
        {
            if (isSave)
            {
                Properties.Settings.Default.login = user.Login;
                Properties.Settings.Default.password = user.Password;
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.login = "";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.Save();

            }
        }

        private void PasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                IsSave = true;
            }
            else
            {
                IsSave = false;
            }
        }


        //public bool IsFalseLogin(User user)
        //{
        //    using (var appContext = new AppContext())
        //    {
        //        return user == null;
        //    }
        //}
        //public bool IsFalsePassword(User user)
        //{
        //    using (var appContext = new AppContext())
        //    {
        //        return user.Password.ToString() != PasswordTextBox.Text;
        //    }
        //}
    }
}
