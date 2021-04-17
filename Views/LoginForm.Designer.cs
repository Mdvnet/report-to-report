namespace ReportToReport.Views
{
    partial class LoginForm
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
            this.styleManager1 = new MetroSet_UI.Components.StyleManager();
            this.LoginLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.PasswordLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.NotificationLabel = new MetroSet_UI.Controls.MetroSetLabel();
            this.LoginButton = new MetroSet_UI.Controls.MetroSetButton();
            this.LoginTextBox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.PasswordTextBox = new MetroSet_UI.Controls.MetroSetTextBox();
            this.PasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.CustomTheme = "C:\\Users\\Надя\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
            this.styleManager1.MetroForm = this;
            this.styleManager1.Style = MetroSet_UI.Enums.Style.Light;
            this.styleManager1.ThemeAuthor = "Narwin";
            this.styleManager1.ThemeName = "MetroLight";
            // 
            // LoginLabel
            // 
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.IsDerivedStyle = true;
            this.LoginLabel.Location = new System.Drawing.Point(307, 109);
            this.LoginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(91, 25);
            this.LoginLabel.Style = MetroSet_UI.Enums.Style.Light;
            this.LoginLabel.StyleManager = this.styleManager1;
            this.LoginLabel.TabIndex = 10;
            this.LoginLabel.Text = "Логин:";
            this.LoginLabel.ThemeAuthor = "Narwin";
            this.LoginLabel.ThemeName = "MetroLight";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.IsDerivedStyle = true;
            this.PasswordLabel.Location = new System.Drawing.Point(307, 195);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(91, 51);
            this.PasswordLabel.Style = MetroSet_UI.Enums.Style.Light;
            this.PasswordLabel.StyleManager = this.styleManager1;
            this.PasswordLabel.TabIndex = 11;
            this.PasswordLabel.Text = "Пароль:";
            this.PasswordLabel.ThemeAuthor = "Narwin";
            this.PasswordLabel.ThemeName = "MetroLight";
            // 
            // NotificationLabel
            // 
            this.NotificationLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotificationLabel.IsDerivedStyle = true;
            this.NotificationLabel.Location = new System.Drawing.Point(307, 402);
            this.NotificationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NotificationLabel.Name = "NotificationLabel";
            this.NotificationLabel.Size = new System.Drawing.Size(272, 25);
            this.NotificationLabel.Style = MetroSet_UI.Enums.Style.Light;
            this.NotificationLabel.StyleManager = this.styleManager1;
            this.NotificationLabel.TabIndex = 12;
            this.NotificationLabel.Text = "проверка";
            this.NotificationLabel.ThemeAuthor = "Narwin";
            this.NotificationLabel.ThemeName = "MetroLight";
            this.NotificationLabel.Visible = false;
            // 
            // LoginButton
            // 
            this.LoginButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.LoginButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.LoginButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.LoginButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.LoginButton.HoverTextColor = System.Drawing.Color.White;
            this.LoginButton.IsDerivedStyle = false;
            this.LoginButton.Location = new System.Drawing.Point(307, 360);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.LoginButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.LoginButton.NormalTextColor = System.Drawing.Color.White;
            this.LoginButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.LoginButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.LoginButton.PressTextColor = System.Drawing.Color.White;
            this.LoginButton.Size = new System.Drawing.Size(262, 39);
            this.LoginButton.Style = MetroSet_UI.Enums.Style.Light;
            this.LoginButton.StyleManager = this.styleManager1;
            this.LoginButton.TabIndex = 13;
            this.LoginButton.Text = "Войти";
            this.LoginButton.ThemeAuthor = "Narwin";
            this.LoginButton.ThemeName = "MetroLight";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.AutoCompleteCustomSource = null;
            this.LoginTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.LoginTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.LoginTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.LoginTextBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.LoginTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.LoginTextBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.LoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LoginTextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.LoginTextBox.Image = null;
            this.LoginTextBox.IsDerivedStyle = true;
            this.LoginTextBox.Lines = null;
            this.LoginTextBox.Location = new System.Drawing.Point(307, 140);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.LoginTextBox.MaxLength = 32767;
            this.LoginTextBox.Multiline = false;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.ReadOnly = false;
            this.LoginTextBox.Size = new System.Drawing.Size(262, 38);
            this.LoginTextBox.Style = MetroSet_UI.Enums.Style.Light;
            this.LoginTextBox.StyleManager = this.styleManager1;
            this.LoginTextBox.TabIndex = 14;
            this.LoginTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LoginTextBox.ThemeAuthor = "Narwin";
            this.LoginTextBox.ThemeName = "MetroLight";
            this.LoginTextBox.UseSystemPasswordChar = false;
            this.LoginTextBox.WatermarkText = "";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.AutoCompleteCustomSource = null;
            this.PasswordTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PasswordTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PasswordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.PasswordTextBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PasswordTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.PasswordTextBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PasswordTextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.PasswordTextBox.Image = null;
            this.PasswordTextBox.IsDerivedStyle = true;
            this.PasswordTextBox.Lines = null;
            this.PasswordTextBox.Location = new System.Drawing.Point(307, 229);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.PasswordTextBox.MaxLength = 32767;
            this.PasswordTextBox.Multiline = false;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.ReadOnly = false;
            this.PasswordTextBox.Size = new System.Drawing.Size(262, 38);
            this.PasswordTextBox.Style = MetroSet_UI.Enums.Style.Light;
            this.PasswordTextBox.StyleManager = this.styleManager1;
            this.PasswordTextBox.TabIndex = 15;
            this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PasswordTextBox.ThemeAuthor = "Narwin";
            this.PasswordTextBox.ThemeName = "MetroLight";
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.WatermarkText = "";
            // 
            // PasswordCheckBox
            // 
            this.PasswordCheckBox.AutoSize = true;
            this.PasswordCheckBox.Checked = true;
            this.PasswordCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PasswordCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordCheckBox.Location = new System.Drawing.Point(307, 298);
            this.PasswordCheckBox.Name = "PasswordCheckBox";
            this.PasswordCheckBox.Size = new System.Drawing.Size(160, 24);
            this.PasswordCheckBox.TabIndex = 16;
            this.PasswordCheckBox.Text = "Сохранить пароль";
            this.PasswordCheckBox.UseVisualStyleBackColor = true;
            this.PasswordCheckBox.CheckedChanged += new System.EventHandler(this.PasswordCheckBox_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 577);
            this.Controls.Add(this.PasswordCheckBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.NotificationLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(11, 79, 11, 14);
            this.StyleManager = this.styleManager1;
            this.Text = "Авторизация";
            this.ThemeName = "MetroLight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroSet_UI.Components.StyleManager styleManager1;
        private MetroSet_UI.Controls.MetroSetLabel PasswordLabel;
        private MetroSet_UI.Controls.MetroSetLabel LoginLabel;
        private MetroSet_UI.Controls.MetroSetLabel NotificationLabel;
        private MetroSet_UI.Controls.MetroSetButton LoginButton;
        private MetroSet_UI.Controls.MetroSetTextBox PasswordTextBox;
        private MetroSet_UI.Controls.MetroSetTextBox LoginTextBox;
        private System.Windows.Forms.CheckBox PasswordCheckBox;
    }
}