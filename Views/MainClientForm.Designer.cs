namespace ReportToReport.Views
{
    partial class MainClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainClientForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FileNamelabel = new System.Windows.Forms.Label();
            this.AddUserFormCloseButton = new MetroSet_UI.Controls.MetroSetDefaultButton();
            this.SendButton = new MetroSet_UI.Controls.MetroSetButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ChangeUserLabel = new System.Windows.Forms.LinkLabel();
            this.DeadlinePanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.DeadlineTimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel8 = new MetroSet_UI.Controls.MetroSetLabel();
            this.DownloadButtonClone = new MetroSet_UI.Controls.MetroSetDefaultButton();
            this.SendButtonClone = new MetroSet_UI.Controls.MetroSetDefaultButton();
            this.CheckPictureBox = new System.Windows.Forms.PictureBox();
            this.DownloadButton = new MetroSet_UI.Controls.MetroSetButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.DeadlinePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FileNamelabel
            // 
            this.FileNamelabel.AutoSize = true;
            this.FileNamelabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileNamelabel.ForeColor = System.Drawing.Color.Green;
            this.FileNamelabel.Location = new System.Drawing.Point(89, 10);
            this.FileNamelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FileNamelabel.Name = "FileNamelabel";
            this.FileNamelabel.Size = new System.Drawing.Size(50, 23);
            this.FileNamelabel.TabIndex = 5;
            this.FileNamelabel.Text = "файл\r\n";
            this.FileNamelabel.Visible = false;
            // 
            // AddUserFormCloseButton
            // 
            this.AddUserFormCloseButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddUserFormCloseButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.AddUserFormCloseButton.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.AddUserFormCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddUserFormCloseButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddUserFormCloseButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddUserFormCloseButton.HoverTextColor = System.Drawing.Color.White;
            this.AddUserFormCloseButton.IsDerivedStyle = false;
            this.AddUserFormCloseButton.Location = new System.Drawing.Point(642, 17);
            this.AddUserFormCloseButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AddUserFormCloseButton.Name = "AddUserFormCloseButton";
            this.AddUserFormCloseButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddUserFormCloseButton.NormalColor = System.Drawing.Color.White;
            this.AddUserFormCloseButton.NormalTextColor = System.Drawing.SystemColors.ControlDark;
            this.AddUserFormCloseButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.AddUserFormCloseButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.AddUserFormCloseButton.PressTextColor = System.Drawing.Color.White;
            this.AddUserFormCloseButton.Size = new System.Drawing.Size(28, 27);
            this.AddUserFormCloseButton.Style = MetroSet_UI.Enums.Style.Light;
            this.AddUserFormCloseButton.StyleManager = null;
            this.AddUserFormCloseButton.TabIndex = 23;
            this.AddUserFormCloseButton.Text = "X";
            this.AddUserFormCloseButton.ThemeAuthor = "Narwin";
            this.AddUserFormCloseButton.ThemeName = "MetroLite";
            this.AddUserFormCloseButton.Click += new System.EventHandler(this.AddUserFormCloseButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SendButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SendButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.SendButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.SendButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.SendButton.HoverTextColor = System.Drawing.Color.White;
            this.SendButton.IsDerivedStyle = true;
            this.SendButton.Location = new System.Drawing.Point(106, 211);
            this.SendButton.Name = "SendButton";
            this.SendButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SendButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SendButton.NormalTextColor = System.Drawing.Color.White;
            this.SendButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.SendButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.SendButton.PressTextColor = System.Drawing.Color.White;
            this.SendButton.Size = new System.Drawing.Size(198, 41);
            this.SendButton.Style = MetroSet_UI.Enums.Style.Light;
            this.SendButton.StyleManager = null;
            this.SendButton.TabIndex = 24;
            this.SendButton.Text = "Отправить";
            this.SendButton.ThemeAuthor = "Narwin";
            this.SendButton.ThemeName = "MetroLite";
            this.SendButton.Visible = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(10, 75);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.ChangeUserLabel);
            this.splitContainer1.Panel1.Controls.Add(this.DeadlinePanel);
            this.splitContainer1.Panel1.Controls.Add(this.metroSetLabel8);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.DownloadButtonClone);
            this.splitContainer1.Panel2.Controls.Add(this.SendButtonClone);
            this.splitContainer1.Panel2.Controls.Add(this.DownloadButton);
            this.splitContainer1.Panel2.Controls.Add(this.SendButton);
            this.splitContainer1.Size = new System.Drawing.Size(662, 352);
            this.splitContainer1.SplitterDistance = 285;
            this.splitContainer1.TabIndex = 25;
            // 
            // ChangeUserLabel
            // 
            this.ChangeUserLabel.ActiveLinkColor = System.Drawing.Color.Gainsboro;
            this.ChangeUserLabel.AutoSize = true;
            this.ChangeUserLabel.Font = new System.Drawing.Font("Segoe UI", 9.8F);
            this.ChangeUserLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ChangeUserLabel.Location = new System.Drawing.Point(50, 306);
            this.ChangeUserLabel.Name = "ChangeUserLabel";
            this.ChangeUserLabel.Size = new System.Drawing.Size(191, 23);
            this.ChangeUserLabel.TabIndex = 27;
            this.ChangeUserLabel.TabStop = true;
            this.ChangeUserLabel.Text = "Сменить пользователя";
            this.ChangeUserLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChangeUserLabel_LinkClicked);
            // 
            // DeadlinePanel
            // 
            this.DeadlinePanel.BackColor = System.Drawing.Color.White;
            this.DeadlinePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DeadlinePanel.Controls.Add(this.textBox1);
            this.DeadlinePanel.Controls.Add(this.metroSetLabel4);
            this.DeadlinePanel.Controls.Add(this.DeadlineTimeTextBox);
            this.DeadlinePanel.Controls.Add(this.metroSetLabel3);
            this.DeadlinePanel.Location = new System.Drawing.Point(126, 37);
            this.DeadlinePanel.Name = "DeadlinePanel";
            this.DeadlinePanel.Size = new System.Drawing.Size(153, 105);
            this.DeadlinePanel.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.textBox1.Location = new System.Drawing.Point(19, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 30);
            this.textBox1.TabIndex = 42;
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Font = new System.Drawing.Font("Segoe UI", 9.2F);
            this.metroSetLabel4.IsDerivedStyle = false;
            this.metroSetLabel4.Location = new System.Drawing.Point(19, 58);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(59, 23);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 41;
            this.metroSetLabel4.Text = "Число";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
            // 
            // DeadlineTimeTextBox
            // 
            this.DeadlineTimeTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.DeadlineTimeTextBox.Location = new System.Drawing.Point(78, 23);
            this.DeadlineTimeTextBox.Mask = "00:00";
            this.DeadlineTimeTextBox.Name = "DeadlineTimeTextBox";
            this.DeadlineTimeTextBox.Size = new System.Drawing.Size(51, 30);
            this.DeadlineTimeTextBox.TabIndex = 25;
            this.DeadlineTimeTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Segoe UI", 9.2F);
            this.metroSetLabel3.IsDerivedStyle = false;
            this.metroSetLabel3.Location = new System.Drawing.Point(78, 58);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(64, 23);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 40;
            this.metroSetLabel3.Text = "Время";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // metroSetLabel8
            // 
            this.metroSetLabel8.Font = new System.Drawing.Font("Segoe UI", 9.2F);
            this.metroSetLabel8.IsDerivedStyle = false;
            this.metroSetLabel8.Location = new System.Drawing.Point(21, 48);
            this.metroSetLabel8.Name = "metroSetLabel8";
            this.metroSetLabel8.Size = new System.Drawing.Size(99, 23);
            this.metroSetLabel8.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel8.StyleManager = null;
            this.metroSetLabel8.TabIndex = 25;
            this.metroSetLabel8.Text = "Срок сдачи:";
            this.metroSetLabel8.ThemeAuthor = "Narwin";
            this.metroSetLabel8.ThemeName = "MetroLite";
            // 
            // DownloadButtonClone
            // 
            this.DownloadButtonClone.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DownloadButtonClone.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.DownloadButtonClone.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.DownloadButtonClone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DownloadButtonClone.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DownloadButtonClone.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DownloadButtonClone.HoverTextColor = System.Drawing.Color.White;
            this.DownloadButtonClone.IsDerivedStyle = true;
            this.DownloadButtonClone.Location = new System.Drawing.Point(106, 62);
            this.DownloadButtonClone.Name = "DownloadButtonClone";
            this.DownloadButtonClone.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DownloadButtonClone.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.DownloadButtonClone.NormalTextColor = System.Drawing.Color.Black;
            this.DownloadButtonClone.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.DownloadButtonClone.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.DownloadButtonClone.PressTextColor = System.Drawing.Color.White;
            this.DownloadButtonClone.Size = new System.Drawing.Size(198, 42);
            this.DownloadButtonClone.Style = MetroSet_UI.Enums.Style.Light;
            this.DownloadButtonClone.StyleManager = null;
            this.DownloadButtonClone.TabIndex = 29;
            this.DownloadButtonClone.Text = "Добавить файл";
            this.DownloadButtonClone.ThemeAuthor = "Narwin";
            this.DownloadButtonClone.ThemeName = "MetroLite";
            this.DownloadButtonClone.Visible = false;
            // 
            // SendButtonClone
            // 
            this.SendButtonClone.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SendButtonClone.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.SendButtonClone.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.SendButtonClone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendButtonClone.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.SendButtonClone.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.SendButtonClone.HoverTextColor = System.Drawing.Color.White;
            this.SendButtonClone.IsDerivedStyle = true;
            this.SendButtonClone.Location = new System.Drawing.Point(106, 211);
            this.SendButtonClone.Name = "SendButtonClone";
            this.SendButtonClone.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SendButtonClone.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.SendButtonClone.NormalTextColor = System.Drawing.Color.Black;
            this.SendButtonClone.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.SendButtonClone.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.SendButtonClone.PressTextColor = System.Drawing.Color.White;
            this.SendButtonClone.Size = new System.Drawing.Size(198, 42);
            this.SendButtonClone.Style = MetroSet_UI.Enums.Style.Light;
            this.SendButtonClone.StyleManager = null;
            this.SendButtonClone.TabIndex = 26;
            this.SendButtonClone.Text = "Отправить";
            this.SendButtonClone.ThemeAuthor = "Narwin";
            this.SendButtonClone.ThemeName = "MetroLite";
            // 
            // CheckPictureBox
            // 
            this.CheckPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CheckPictureBox.Image")));
            this.CheckPictureBox.Location = new System.Drawing.Point(39, 0);
            this.CheckPictureBox.Name = "CheckPictureBox";
            this.CheckPictureBox.Size = new System.Drawing.Size(36, 45);
            this.CheckPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CheckPictureBox.TabIndex = 28;
            this.CheckPictureBox.TabStop = false;
            this.CheckPictureBox.Visible = false;
            // 
            // DownloadButton
            // 
            this.DownloadButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.DownloadButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.DownloadButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.DownloadButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DownloadButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.DownloadButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.DownloadButton.HoverTextColor = System.Drawing.Color.White;
            this.DownloadButton.IsDerivedStyle = true;
            this.DownloadButton.Location = new System.Drawing.Point(106, 62);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.DownloadButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.DownloadButton.NormalTextColor = System.Drawing.Color.White;
            this.DownloadButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.DownloadButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.DownloadButton.PressTextColor = System.Drawing.Color.White;
            this.DownloadButton.Size = new System.Drawing.Size(198, 42);
            this.DownloadButton.Style = MetroSet_UI.Enums.Style.Light;
            this.DownloadButton.StyleManager = null;
            this.DownloadButton.TabIndex = 25;
            this.DownloadButton.Text = "Добавить файл";
            this.DownloadButton.ThemeAuthor = "Narwin";
            this.DownloadButton.ThemeName = "MetroLite";
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CheckPictureBox);
            this.panel1.Controls.Add(this.FileNamelabel);
            this.panel1.Location = new System.Drawing.Point(54, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 44);
            this.panel1.TabIndex = 30;
            // 
            // MainClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(682, 440);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.AddUserFormCloseButton);
            this.Font = new System.Drawing.Font("Segoe UI", 11.8F);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainClientForm";
            this.Padding = new System.Windows.Forms.Padding(10, 75, 10, 13);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShrubFarm | Андрей Иванов";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.DeadlinePanel.ResumeLayout(false);
            this.DeadlinePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label FileNamelabel;
        private MetroSet_UI.Controls.MetroSetDefaultButton AddUserFormCloseButton;
        private MetroSet_UI.Controls.MetroSetButton SendButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel DeadlinePanel;
        private System.Windows.Forms.TextBox textBox1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private System.Windows.Forms.MaskedTextBox DeadlineTimeTextBox;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel8;
        private MetroSet_UI.Controls.MetroSetButton DownloadButton;
        private System.Windows.Forms.PictureBox CheckPictureBox;
        private System.Windows.Forms.LinkLabel ChangeUserLabel;
        private MetroSet_UI.Controls.MetroSetDefaultButton DownloadButtonClone;
        private MetroSet_UI.Controls.MetroSetDefaultButton SendButtonClone;
        private System.Windows.Forms.Panel panel1;
    }
}