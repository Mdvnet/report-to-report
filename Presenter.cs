using ReportToReport.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportToReport
{
    public class Presenter
    {
        public static void ChangeUser(Form form)
        {
            Properties.Settings.Default.login = "";
            Properties.Settings.Default.Save();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            form.Close();
        }
    }
}
