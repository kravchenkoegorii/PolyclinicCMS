namespace PolyclinicManagementSystem
{
    partial class MainForm
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
            this.DoctorRole_Button = new System.Windows.Forms.Button();
            this.AdministratorRole_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // DoctorRole_Button
            // 
            this.helpProvider1.SetHelpKeyword(this.DoctorRole_Button, "pochatkova_forma.htm#2");
            this.helpProvider1.SetHelpNavigator(this.DoctorRole_Button, System.Windows.Forms.HelpNavigator.Topic);
            this.DoctorRole_Button.Location = new System.Drawing.Point(93, 42);
            this.DoctorRole_Button.Name = "DoctorRole_Button";
            this.helpProvider1.SetShowHelp(this.DoctorRole_Button, true);
            this.DoctorRole_Button.Size = new System.Drawing.Size(177, 46);
            this.DoctorRole_Button.TabIndex = 0;
            this.DoctorRole_Button.Text = "Лікар";
            this.DoctorRole_Button.UseVisualStyleBackColor = true;
            this.DoctorRole_Button.Click += new System.EventHandler(this.DoctorRole_Button_Click);
            // 
            // AdministratorRole_Button
            // 
            this.helpProvider1.SetHelpKeyword(this.AdministratorRole_Button, "pochatkova_forma.htm#1");
            this.helpProvider1.SetHelpNavigator(this.AdministratorRole_Button, System.Windows.Forms.HelpNavigator.Topic);
            this.AdministratorRole_Button.Location = new System.Drawing.Point(93, 94);
            this.AdministratorRole_Button.Name = "AdministratorRole_Button";
            this.helpProvider1.SetShowHelp(this.AdministratorRole_Button, true);
            this.AdministratorRole_Button.Size = new System.Drawing.Size(177, 46);
            this.AdministratorRole_Button.TabIndex = 2;
            this.AdministratorRole_Button.Text = "Адміністратор";
            this.AdministratorRole_Button.UseVisualStyleBackColor = true;
            this.AdministratorRole_Button.Click += new System.EventHandler(this.AdministratorRole_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Авторизуватися як:";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\kravc\\OneDrive\\Рабочий стол\\PolyclinicManagementSystem\\МояПоліклініка.ch" +
    "m";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 156);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdministratorRole_Button);
            this.Controls.Add(this.DoctorRole_Button);
            this.HelpButton = true;
            this.helpProvider1.SetHelpKeyword(this, "osnovne.htm");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Система “МояПоліклініка”";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.MainForm_HelpButtonClicked);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button AdministratorRole_Button;

        private System.Windows.Forms.Button DoctorRole_Button;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}