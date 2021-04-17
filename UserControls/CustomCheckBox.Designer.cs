namespace ReportToReport.UserControls
{
    partial class CustomCheckBox
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CkBox = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.SuspendLayout();
            // 
            // CkBox
            // 
            this.CkBox.BackColor = System.Drawing.Color.Transparent;
            this.CkBox.BackgroundColor = System.Drawing.Color.White;
            this.CkBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.CkBox.Checked = false;
            this.CkBox.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.CkBox.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.CkBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CkBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.CkBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CkBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CkBox.IsDerivedStyle = true;
            this.CkBox.Location = new System.Drawing.Point(0, 0);
            this.CkBox.Name = "CkBox";
            this.CkBox.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.CkBox.Size = new System.Drawing.Size(198, 16);
            this.CkBox.Style = MetroSet_UI.Enums.Style.Light;
            this.CkBox.StyleManager = null;
            this.CkBox.TabIndex = 0;
            this.CkBox.ThemeAuthor = "Narwin";
            this.CkBox.ThemeName = "MetroLite";
            // 
            // CustomCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CkBox);
            this.Name = "CustomCheckBox";
            this.Size = new System.Drawing.Size(198, 32);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetCheckBox CkBox;
    }
}
