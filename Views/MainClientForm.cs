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
using MetroSet_UI.Controls;

namespace ReportToReport.Views
{
    public partial class MainClientForm : MetroSetForm
    {
        User user;
        public MainClientForm(User user)
        {
            this.user = user; 
            InitializeComponent();
        }

        public void AddFile(byte[] bytes, string filename)
        {
            using (AppContext appContext = new AppContext())
            {
                //File file = new File { Name = filename, Data = bytes};
                //appContext.Files.Add(file);
                //appContext.SaveChanges();
                //Report report = new Report { FileID = file.Id, Date = DateTime.Now, UserLogin = user.Login };
                //appContext.Reports.Add(report);
                //appContext.SaveChanges();
                //report.Date = DateTime.Now;
                //report.FileID = file.Id;
                //report.UserLogin = user.Login;
                //appContext.Reports.Add(report);
                //appContext.SaveChanges();
            }
            //using(AppContext appContext = new AppContext())
            //{
            //    //Report report 
            //}
        }

        private void AddUserFormCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string Filename = openFileDialog1.FileName;
            byte[] Bytes = System.IO.File.ReadAllBytes(Filename);
            AddFile(Bytes, Filename);

            FileNamelabel.Text = Filename + " загружен";
            FileNamelabel.Visible = true;
            SendButton.Visible = true;
            SendButtonClone.Visible = false;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            DownloadButton.Visible = false;
            DownloadButtonClone.Visible = true;
            SendButton.Visible = false;
            SendButtonClone.Visible = true;
        }

        private void ChangeUserLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Presenter.ChangeUser(this);
        }
    }
}
