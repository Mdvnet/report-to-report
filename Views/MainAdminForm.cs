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
using ReportToReport.UserControls;

namespace ReportToReport.Views
{
    public partial class MainAdminForm : MetroSetForm
    {
        User user;
        Classes.Process process = new Classes.Process(new DateTime(2021, 3, 28), new DateTime(2021, 3, 30));
        BindingList<User> users = new BindingList<User>();
        //List<User> users = new List<User>();
        AppContext db = new AppContext();



        public MainAdminForm(User user)
        {
            this.user = user;
            InitializeComponent();
            CreateSplitConteiner(process.IsResults);
            //MainSplitConteiner mainSplitConteiner = new MainSplitConteiner();
            UserDiv userDiv = new UserDiv()
            {
                UserName = "Андрей Иванов",
                Date = DateTime.Now.ToString(),
                Department = "Бухгалтерия"
            };
            UserDiv userDiv1 = new UserDiv()
            {
                UserName = "Андрей Иванов",
                Date = DateTime.Now.ToString(),
                Department = "Бухгалтерия"
            };
            UserDiv userDi3 = new UserDiv()
            {
                UserName = "Андрей Иванов",
                Date = DateTime.Now.ToString(),
                Department = "Бухгалтерия"
            };
            UserDiv userDi4 = new UserDiv()
            {
                UserName = "Андрей Иванов",
                Date = DateTime.Now.ToString(),
                Department = "Бухгалтерия",
                Color = System.Drawing.Color.Orange
            };
            this.mainSplitConteiner1.AddUserDiv(userDiv);
            this.mainSplitConteiner1.AddUserDiv(userDiv1);
            this.mainSplitConteiner1.AddUserDiv(userDi3);
            this.mainSplitConteiner1.AddUserDiv(userDi4);
        }

        public void CreateSplitConteiner(bool isResult)
        {
            if (isResult)
            {
                UserControls.MainSplitConteiner mainSplitConteiner = new UserControls.MainSplitConteiner();
                MainTabPage.Controls.Add(mainSplitConteiner);
            }
            else
            {
                UserControls.IntermediateSsplitСontainer intermediateSsplitСontainer 
                    = new UserControls.IntermediateSsplitСontainer();
                MainTabPage.Controls.Add(intermediateSsplitСontainer);
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Presenter.ChangeUser(this);
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        public void LoadEmployees()
        {
            using(AppContext appContext = new AppContext())
            {
                //DataSet users1 = new DataSet();
                //users = appContext.Users.Where(u => u.IsAdmin == false).ToList();
               // users1 = (DataSet)appContext.Users.Where(u => u.IsAdmin == false);
                //users = users1.ToBindingList<User>();
                
            }
        }

        private void AdminTabControl_Click(object sender, EventArgs e)
        {

        }

        private void MainAdminForm_Load(object sender, EventArgs e)
        {
            db.Users.Load();
            BindingList<User> uuu = new BindingList<User>(); 
            uuu = db.Users.Local.ToBindingList<User>();
            this.userBindingSource.DataSource = uuu.Where(u => u.IsAdmin == false);
            
                //appContext.Users.Where(u => u.IsAdmin == false)
        }

        private void metroSetControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainAdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.Dispose();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
        }

        private void AddUserFormCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
