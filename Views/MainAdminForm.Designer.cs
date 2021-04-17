namespace ReportToReport.Views
{
    partial class MainAdminForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AdminTabControl = new MetroSet_UI.Controls.MetroSetTabControl();
            this.EmployeesTabPage = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.metroSetButton2 = new MetroSet_UI.Controls.MetroSetButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroSetDefaultButton5 = new MetroSet_UI.Controls.MetroSetDefaultButton();
            this.metroSetDefaultButton4 = new MetroSet_UI.Controls.MetroSetDefaultButton();
            this.metroSetDefaultButton1 = new MetroSet_UI.Controls.MetroSetDefaultButton();
            this.metroSetButton1 = new MetroSet_UI.Controls.MetroSetButton();
            this.AddUserButton = new MetroSet_UI.Controls.MetroSetDefaultButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MainTabPage = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.mainSplitConteiner1 = new ReportToReport.UserControls.MainSplitConteiner();
            this.metroSetSetTabPage4 = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.metroSetDefaultButton3 = new MetroSet_UI.Controls.MetroSetDefaultButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.metroSetDefaultButton2 = new MetroSet_UI.Controls.MetroSetDefaultButton();
            this.metroSetSetTabPage2 = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddUserFormCloseButton = new MetroSet_UI.Controls.MetroSetDefaultButton();
            this.AdminTabControl.SuspendLayout();
            this.EmployeesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.MainTabPage.SuspendLayout();
            this.metroSetSetTabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminTabControl
            // 
            this.AdminTabControl.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.AdminTabControl.AnimateTime = 200;
            this.AdminTabControl.BackgroundColor = System.Drawing.Color.White;
            this.AdminTabControl.Controls.Add(this.EmployeesTabPage);
            this.AdminTabControl.Controls.Add(this.MainTabPage);
            this.AdminTabControl.Controls.Add(this.metroSetSetTabPage4);
            this.AdminTabControl.Controls.Add(this.metroSetSetTabPage2);
            this.AdminTabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminTabControl.IsDerivedStyle = false;
            this.AdminTabControl.ItemSize = new System.Drawing.Size(100, 38);
            this.AdminTabControl.Location = new System.Drawing.Point(3, 15);
            this.AdminTabControl.Name = "AdminTabControl";
            this.AdminTabControl.SelectedIndex = 0;
            this.AdminTabControl.SelectedTextColor = System.Drawing.Color.White;
            this.AdminTabControl.Size = new System.Drawing.Size(797, 508);
            this.AdminTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.AdminTabControl.Speed = 100;
            this.AdminTabControl.Style = MetroSet_UI.Enums.Style.Light;
            this.AdminTabControl.StyleManager = null;
            this.AdminTabControl.TabIndex = 5;
            this.AdminTabControl.ThemeAuthor = "Narwin";
            this.AdminTabControl.ThemeName = "MetroLite";
            this.AdminTabControl.UnselectedTextColor = System.Drawing.Color.Gray;
            this.AdminTabControl.UseAnimation = false;
            // 
            // EmployeesTabPage
            // 
            this.EmployeesTabPage.BaseColor = System.Drawing.Color.White;
            this.EmployeesTabPage.Controls.Add(this.metroSetButton2);
            this.EmployeesTabPage.Controls.Add(this.label2);
            this.EmployeesTabPage.Controls.Add(this.label1);
            this.EmployeesTabPage.Controls.Add(this.metroSetDefaultButton5);
            this.EmployeesTabPage.Controls.Add(this.metroSetDefaultButton4);
            this.EmployeesTabPage.Controls.Add(this.metroSetDefaultButton1);
            this.EmployeesTabPage.Controls.Add(this.metroSetButton1);
            this.EmployeesTabPage.Controls.Add(this.AddUserButton);
            this.EmployeesTabPage.Controls.Add(this.metroGrid1);
            this.EmployeesTabPage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EmployeesTabPage.ImageIndex = 0;
            this.EmployeesTabPage.ImageKey = null;
            this.EmployeesTabPage.IsDerivedStyle = false;
            this.EmployeesTabPage.Location = new System.Drawing.Point(4, 42);
            this.EmployeesTabPage.Name = "EmployeesTabPage";
            this.EmployeesTabPage.Size = new System.Drawing.Size(789, 462);
            this.EmployeesTabPage.Style = MetroSet_UI.Enums.Style.Light;
            this.EmployeesTabPage.StyleManager = null;
            this.EmployeesTabPage.TabIndex = 2;
            this.EmployeesTabPage.Text = "Сотрудники";
            this.EmployeesTabPage.ThemeAuthor = "Narwin";
            this.EmployeesTabPage.ThemeName = "MetroLite";
            this.EmployeesTabPage.ToolTipText = null;
            // 
            // metroSetButton2
            // 
            this.metroSetButton2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton2.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metroSetButton2.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton2.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton2.IsDerivedStyle = true;
            this.metroSetButton2.Location = new System.Drawing.Point(19, 410);
            this.metroSetButton2.Name = "metroSetButton2";
            this.metroSetButton2.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton2.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton2.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton2.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton2.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton2.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton2.Size = new System.Drawing.Size(156, 40);
            this.metroSetButton2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButton2.StyleManager = null;
            this.metroSetButton2.TabIndex = 46;
            this.metroSetButton2.Text = "Просмотреть";
            this.metroSetButton2.ThemeAuthor = "Narwin";
            this.metroSetButton2.ThemeName = "MetroLite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.2F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.label2.Location = new System.Drawing.Point(388, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 45;
            this.label2.Text = "Сортировать по:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(16, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 44;
            this.label1.Text = "Количество: ";
            // 
            // metroSetDefaultButton5
            // 
            this.metroSetDefaultButton5.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetDefaultButton5.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetDefaultButton5.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetDefaultButton5.Font = new System.Drawing.Font("Segoe UI", 9.2F);
            this.metroSetDefaultButton5.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetDefaultButton5.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetDefaultButton5.HoverTextColor = System.Drawing.Color.White;
            this.metroSetDefaultButton5.IsDerivedStyle = false;
            this.metroSetDefaultButton5.Location = new System.Drawing.Point(644, 49);
            this.metroSetDefaultButton5.Name = "metroSetDefaultButton5";
            this.metroSetDefaultButton5.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetDefaultButton5.NormalColor = System.Drawing.Color.White;
            this.metroSetDefaultButton5.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetDefaultButton5.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.metroSetDefaultButton5.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.metroSetDefaultButton5.PressTextColor = System.Drawing.Color.White;
            this.metroSetDefaultButton5.Size = new System.Drawing.Size(116, 29);
            this.metroSetDefaultButton5.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetDefaultButton5.StyleManager = null;
            this.metroSetDefaultButton5.TabIndex = 43;
            this.metroSetDefaultButton5.Text = "Отделу";
            this.metroSetDefaultButton5.ThemeAuthor = "Narwin";
            this.metroSetDefaultButton5.ThemeName = "MetroLite";
            // 
            // metroSetDefaultButton4
            // 
            this.metroSetDefaultButton4.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetDefaultButton4.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetDefaultButton4.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetDefaultButton4.Font = new System.Drawing.Font("Segoe UI", 9.2F);
            this.metroSetDefaultButton4.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetDefaultButton4.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetDefaultButton4.HoverTextColor = System.Drawing.Color.White;
            this.metroSetDefaultButton4.IsDerivedStyle = false;
            this.metroSetDefaultButton4.Location = new System.Drawing.Point(522, 49);
            this.metroSetDefaultButton4.Name = "metroSetDefaultButton4";
            this.metroSetDefaultButton4.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetDefaultButton4.NormalColor = System.Drawing.Color.White;
            this.metroSetDefaultButton4.NormalTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetDefaultButton4.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.metroSetDefaultButton4.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.metroSetDefaultButton4.PressTextColor = System.Drawing.Color.White;
            this.metroSetDefaultButton4.Size = new System.Drawing.Size(116, 29);
            this.metroSetDefaultButton4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetDefaultButton4.StyleManager = null;
            this.metroSetDefaultButton4.TabIndex = 42;
            this.metroSetDefaultButton4.Text = "Имени";
            this.metroSetDefaultButton4.ThemeAuthor = "Narwin";
            this.metroSetDefaultButton4.ThemeName = "MetroLite";
            // 
            // metroSetDefaultButton1
            // 
            this.metroSetDefaultButton1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetDefaultButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetDefaultButton1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetDefaultButton1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metroSetDefaultButton1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetDefaultButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetDefaultButton1.HoverTextColor = System.Drawing.Color.White;
            this.metroSetDefaultButton1.IsDerivedStyle = true;
            this.metroSetDefaultButton1.Location = new System.Drawing.Point(620, 399);
            this.metroSetDefaultButton1.Name = "metroSetDefaultButton1";
            this.metroSetDefaultButton1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetDefaultButton1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetDefaultButton1.NormalTextColor = System.Drawing.Color.Black;
            this.metroSetDefaultButton1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.metroSetDefaultButton1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.metroSetDefaultButton1.PressTextColor = System.Drawing.Color.White;
            this.metroSetDefaultButton1.Size = new System.Drawing.Size(156, 40);
            this.metroSetDefaultButton1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetDefaultButton1.StyleManager = null;
            this.metroSetDefaultButton1.TabIndex = 3;
            this.metroSetDefaultButton1.Text = "Удалить";
            this.metroSetDefaultButton1.ThemeAuthor = "Narwin";
            this.metroSetDefaultButton1.ThemeName = "MetroLite";
            // 
            // metroSetButton1
            // 
            this.metroSetButton1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metroSetButton1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton1.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton1.IsDerivedStyle = true;
            this.metroSetButton1.Location = new System.Drawing.Point(20, 364);
            this.metroSetButton1.Name = "metroSetButton1";
            this.metroSetButton1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton1.Size = new System.Drawing.Size(156, 40);
            this.metroSetButton1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButton1.StyleManager = null;
            this.metroSetButton1.TabIndex = 2;
            this.metroSetButton1.Text = "Редактировать";
            this.metroSetButton1.ThemeAuthor = "Narwin";
            this.metroSetButton1.ThemeName = "MetroLite";
            // 
            // AddUserButton
            // 
            this.AddUserButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddUserButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.AddUserButton.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.AddUserButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddUserButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddUserButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddUserButton.HoverTextColor = System.Drawing.Color.White;
            this.AddUserButton.IsDerivedStyle = true;
            this.AddUserButton.Location = new System.Drawing.Point(620, 353);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddUserButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.AddUserButton.NormalTextColor = System.Drawing.Color.Black;
            this.AddUserButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.AddUserButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.AddUserButton.PressTextColor = System.Drawing.Color.White;
            this.AddUserButton.Size = new System.Drawing.Size(156, 40);
            this.AddUserButton.Style = MetroSet_UI.Enums.Style.Light;
            this.AddUserButton.StyleManager = null;
            this.AddUserButton.TabIndex = 1;
            this.AddUserButton.Text = "Добавить";
            this.AddUserButton.ThemeAuthor = "Narwin";
            this.AddUserButton.ThemeName = "MetroLite";
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToOrderColumns = true;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.SurnameColumn,
            this.patronymicColumn,
            this.numberColumn,
            this.loginColumn,
            this.Department});
            this.metroGrid1.DataSource = this.userBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(19, 83);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.RowHeadersWidth = 51;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(757, 264);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroGrid1.TabIndex = 0;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "Имя";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.Width = 125;
            // 
            // SurnameColumn
            // 
            this.SurnameColumn.DataPropertyName = "Surname";
            this.SurnameColumn.HeaderText = "Фамилия";
            this.SurnameColumn.MinimumWidth = 6;
            this.SurnameColumn.Name = "SurnameColumn";
            this.SurnameColumn.Width = 125;
            // 
            // patronymicColumn
            // 
            this.patronymicColumn.DataPropertyName = "Patronymic";
            this.patronymicColumn.HeaderText = "Отчество";
            this.patronymicColumn.MinimumWidth = 6;
            this.patronymicColumn.Name = "patronymicColumn";
            this.patronymicColumn.Width = 125;
            // 
            // numberColumn
            // 
            this.numberColumn.DataPropertyName = "Number";
            this.numberColumn.HeaderText = "Телефон";
            this.numberColumn.MinimumWidth = 6;
            this.numberColumn.Name = "numberColumn";
            this.numberColumn.Width = 125;
            // 
            // loginColumn
            // 
            this.loginColumn.DataPropertyName = "Login";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.loginColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.loginColumn.HeaderText = "Логин";
            this.loginColumn.MinimumWidth = 6;
            this.loginColumn.Name = "loginColumn";
            this.loginColumn.Width = 125;
            // 
            // Department
            // 
            this.Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Department.DataPropertyName = "Department";
            this.Department.HeaderText = "Отдел";
            this.Department.MinimumWidth = 6;
            this.Department.Name = "Department";
            this.Department.Width = 67;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(ReportToReport.Models.User);
            // 
            // MainTabPage
            // 
            this.MainTabPage.BaseColor = System.Drawing.Color.White;
            this.MainTabPage.Controls.Add(this.mainSplitConteiner1);
            this.MainTabPage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MainTabPage.ImageIndex = 0;
            this.MainTabPage.ImageKey = null;
            this.MainTabPage.IsDerivedStyle = false;
            this.MainTabPage.Location = new System.Drawing.Point(4, 42);
            this.MainTabPage.Name = "MainTabPage";
            this.MainTabPage.Size = new System.Drawing.Size(789, 462);
            this.MainTabPage.Style = MetroSet_UI.Enums.Style.Light;
            this.MainTabPage.StyleManager = null;
            this.MainTabPage.TabIndex = 0;
            this.MainTabPage.Text = "Главная";
            this.MainTabPage.ThemeAuthor = "Narwin";
            this.MainTabPage.ThemeName = "MetroLite";
            this.MainTabPage.ToolTipText = null;
            // 
            // mainSplitConteiner1
            // 
            this.mainSplitConteiner1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitConteiner1.Location = new System.Drawing.Point(0, 0);
            this.mainSplitConteiner1.Margin = new System.Windows.Forms.Padding(4);
            this.mainSplitConteiner1.Name = "mainSplitConteiner1";
            this.mainSplitConteiner1.Size = new System.Drawing.Size(789, 462);
            this.mainSplitConteiner1.TabIndex = 0;
            // 
            // metroSetSetTabPage4
            // 
            this.metroSetSetTabPage4.BaseColor = System.Drawing.Color.White;
            this.metroSetSetTabPage4.Controls.Add(this.splitter1);
            this.metroSetSetTabPage4.Controls.Add(this.groupBox2);
            this.metroSetSetTabPage4.Controls.Add(this.groupBox1);
            this.metroSetSetTabPage4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.metroSetSetTabPage4.ImageIndex = 0;
            this.metroSetSetTabPage4.ImageKey = null;
            this.metroSetSetTabPage4.IsDerivedStyle = false;
            this.metroSetSetTabPage4.Location = new System.Drawing.Point(4, 42);
            this.metroSetSetTabPage4.Name = "metroSetSetTabPage4";
            this.metroSetSetTabPage4.Size = new System.Drawing.Size(789, 462);
            this.metroSetSetTabPage4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetSetTabPage4.StyleManager = null;
            this.metroSetSetTabPage4.TabIndex = 3;
            this.metroSetSetTabPage4.Text = "Настройки";
            this.metroSetSetTabPage4.ThemeAuthor = "Narwin";
            this.metroSetSetTabPage4.ThemeName = "MetroLite";
            this.metroSetSetTabPage4.ToolTipText = null;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(351, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(438, 462);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.metroSetDefaultButton3);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(42, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 192);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Уведомления";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 110);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Почта";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // metroSetDefaultButton3
            // 
            this.metroSetDefaultButton3.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetDefaultButton3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetDefaultButton3.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetDefaultButton3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metroSetDefaultButton3.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetDefaultButton3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetDefaultButton3.HoverTextColor = System.Drawing.Color.White;
            this.metroSetDefaultButton3.IsDerivedStyle = true;
            this.metroSetDefaultButton3.Location = new System.Drawing.Point(37, 66);
            this.metroSetDefaultButton3.Name = "metroSetDefaultButton3";
            this.metroSetDefaultButton3.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetDefaultButton3.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetDefaultButton3.NormalTextColor = System.Drawing.Color.Black;
            this.metroSetDefaultButton3.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.metroSetDefaultButton3.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.metroSetDefaultButton3.PressTextColor = System.Drawing.Color.White;
            this.metroSetDefaultButton3.Size = new System.Drawing.Size(211, 36);
            this.metroSetDefaultButton3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetDefaultButton3.StyleManager = null;
            this.metroSetDefaultButton3.TabIndex = 1;
            this.metroSetDefaultButton3.Text = "График";
            this.metroSetDefaultButton3.ThemeAuthor = "Narwin";
            this.metroSetDefaultButton3.ThemeName = "MetroLite";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.ExitButton);
            this.groupBox1.Controls.Add(this.metroSetDefaultButton2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(42, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 192);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Аккаунт";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(37, 110);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(211, 40);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Сменить пользователя";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // metroSetDefaultButton2
            // 
            this.metroSetDefaultButton2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetDefaultButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetDefaultButton2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetDefaultButton2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metroSetDefaultButton2.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetDefaultButton2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetDefaultButton2.HoverTextColor = System.Drawing.Color.White;
            this.metroSetDefaultButton2.IsDerivedStyle = true;
            this.metroSetDefaultButton2.Location = new System.Drawing.Point(37, 66);
            this.metroSetDefaultButton2.Name = "metroSetDefaultButton2";
            this.metroSetDefaultButton2.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetDefaultButton2.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetDefaultButton2.NormalTextColor = System.Drawing.Color.Black;
            this.metroSetDefaultButton2.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.metroSetDefaultButton2.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.metroSetDefaultButton2.PressTextColor = System.Drawing.Color.White;
            this.metroSetDefaultButton2.Size = new System.Drawing.Size(211, 36);
            this.metroSetDefaultButton2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetDefaultButton2.StyleManager = null;
            this.metroSetDefaultButton2.TabIndex = 1;
            this.metroSetDefaultButton2.Text = "Сменить пароль";
            this.metroSetDefaultButton2.ThemeAuthor = "Narwin";
            this.metroSetDefaultButton2.ThemeName = "MetroLite";
            // 
            // metroSetSetTabPage2
            // 
            this.metroSetSetTabPage2.BaseColor = System.Drawing.Color.White;
            this.metroSetSetTabPage2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.metroSetSetTabPage2.ImageIndex = 0;
            this.metroSetSetTabPage2.ImageKey = null;
            this.metroSetSetTabPage2.IsDerivedStyle = false;
            this.metroSetSetTabPage2.Location = new System.Drawing.Point(4, 42);
            this.metroSetSetTabPage2.Name = "metroSetSetTabPage2";
            this.metroSetSetTabPage2.Size = new System.Drawing.Size(789, 462);
            this.metroSetSetTabPage2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetSetTabPage2.StyleManager = null;
            this.metroSetSetTabPage2.TabIndex = 1;
            this.metroSetSetTabPage2.Text = "Статистика";
            this.metroSetSetTabPage2.ThemeAuthor = "Narwin";
            this.metroSetSetTabPage2.ThemeName = "MetroLite";
            this.metroSetSetTabPage2.ToolTipText = null;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.AdminTabControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(11, 81);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 522);
            this.panel1.TabIndex = 6;
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
            this.AddUserFormCloseButton.Location = new System.Drawing.Point(772, 11);
            this.AddUserFormCloseButton.Name = "AddUserFormCloseButton";
            this.AddUserFormCloseButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddUserFormCloseButton.NormalColor = System.Drawing.Color.White;
            this.AddUserFormCloseButton.NormalTextColor = System.Drawing.SystemColors.ControlDark;
            this.AddUserFormCloseButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.AddUserFormCloseButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.AddUserFormCloseButton.PressTextColor = System.Drawing.Color.White;
            this.AddUserFormCloseButton.Size = new System.Drawing.Size(30, 29);
            this.AddUserFormCloseButton.Style = MetroSet_UI.Enums.Style.Light;
            this.AddUserFormCloseButton.StyleManager = null;
            this.AddUserFormCloseButton.TabIndex = 22;
            this.AddUserFormCloseButton.Text = "X";
            this.AddUserFormCloseButton.ThemeAuthor = "Narwin";
            this.AddUserFormCloseButton.ThemeName = "MetroLite";
            this.AddUserFormCloseButton.Click += new System.EventHandler(this.AddUserFormCloseButton_Click);
            // 
            // MainAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(825, 617);
            this.Controls.Add(this.AddUserFormCloseButton);
            this.Controls.Add(this.panel1);
            this.DropShadowEffect = false;
            this.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "MainAdminForm";
            this.Padding = new System.Windows.Forms.Padding(11, 81, 11, 14);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportToReport | Панель администратора";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainAdminForm_FormClosed);
            this.Load += new System.EventHandler(this.MainAdminForm_Load);
            this.AdminTabControl.ResumeLayout(false);
            this.EmployeesTabPage.ResumeLayout(false);
            this.EmployeesTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.MainTabPage.ResumeLayout(false);
            this.metroSetSetTabPage4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetTabControl AdminTabControl;
        private MetroSet_UI.Child.MetroSetSetTabPage MainTabPage;
        private MetroSet_UI.Child.MetroSetSetTabPage metroSetSetTabPage2;
        private MetroSet_UI.Child.MetroSetSetTabPage EmployeesTabPage;
        private MetroSet_UI.Controls.MetroSetDefaultButton AddUserButton;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroSet_UI.Child.MetroSetSetTabPage metroSetSetTabPage4;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private MetroSet_UI.Controls.MetroSetDefaultButton metroSetDefaultButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ExitButton;
        private MetroSet_UI.Controls.MetroSetDefaultButton metroSetDefaultButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private MetroSet_UI.Controls.MetroSetDefaultButton AddUserFormCloseButton;
        private MetroSet_UI.Controls.MetroSetDefaultButton metroSetDefaultButton1;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton1;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroSet_UI.Controls.MetroSetDefaultButton metroSetDefaultButton5;
        private MetroSet_UI.Controls.MetroSetDefaultButton metroSetDefaultButton4;
        private UserControls.MainSplitConteiner mainSplitConteiner1;
    }
}