using System.ComponentModel;

namespace PolyclinicManagementSystem
{
    partial class RegisterDoctorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.Phone_TextBox = new System.Windows.Forms.TextBox();
            this.PassportCode_TextBox = new System.Windows.Forms.TextBox();
            this.Adress_TextBox = new System.Windows.Forms.TextBox();
            this.BirthDate_TextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Patronymic_TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Surname_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Add_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Email_TextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.Spec_ComboBox = new System.Windows.Forms.ComboBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // Phone_TextBox
            // 
            this.Phone_TextBox.Location = new System.Drawing.Point(149, 162);
            this.Phone_TextBox.MaxLength = 13;
            this.Phone_TextBox.Name = "Phone_TextBox";
            this.Phone_TextBox.Size = new System.Drawing.Size(238, 20);
            this.Phone_TextBox.TabIndex = 12;
            this.Phone_TextBox.TextChanged += new System.EventHandler(this.Phone_TextBox_TextChanged);
            this.Phone_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Phone_TextBox_KeyPress);
            // 
            // PassportCode_TextBox
            // 
            this.PassportCode_TextBox.Location = new System.Drawing.Point(149, 136);
            this.PassportCode_TextBox.MaxLength = 9;
            this.PassportCode_TextBox.Name = "PassportCode_TextBox";
            this.PassportCode_TextBox.Size = new System.Drawing.Size(238, 20);
            this.PassportCode_TextBox.TabIndex = 13;
            this.PassportCode_TextBox.TextChanged += new System.EventHandler(this.PassportCode_TextBox_TextChanged);
            this.PassportCode_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassportCode_TextBox_KeyPress);
            // 
            // Adress_TextBox
            // 
            this.Adress_TextBox.Location = new System.Drawing.Point(149, 110);
            this.Adress_TextBox.Name = "Adress_TextBox";
            this.Adress_TextBox.Size = new System.Drawing.Size(238, 20);
            this.Adress_TextBox.TabIndex = 14;
            // 
            // BirthDate_TextBox
            // 
            this.BirthDate_TextBox.Location = new System.Drawing.Point(149, 84);
            this.BirthDate_TextBox.Name = "BirthDate_TextBox";
            this.BirthDate_TextBox.Size = new System.Drawing.Size(238, 20);
            this.BirthDate_TextBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Номер телефону";
            // 
            // Patronymic_TextBox
            // 
            this.Patronymic_TextBox.Location = new System.Drawing.Point(149, 58);
            this.Patronymic_TextBox.Name = "Patronymic_TextBox";
            this.Patronymic_TextBox.Size = new System.Drawing.Size(238, 20);
            this.Patronymic_TextBox.TabIndex = 16;
            this.Patronymic_TextBox.TextChanged += new System.EventHandler(this.Patronymic_TextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Код паспорту";
            // 
            // Surname_TextBox
            // 
            this.Surname_TextBox.Location = new System.Drawing.Point(149, 31);
            this.Surname_TextBox.Name = "Surname_TextBox";
            this.Surname_TextBox.Size = new System.Drawing.Size(238, 20);
            this.Surname_TextBox.TabIndex = 17;
            this.Surname_TextBox.TextChanged += new System.EventHandler(this.Surname_TextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Адреса";
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(149, 5);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(238, 20);
            this.Name_TextBox.TabIndex = 18;
            this.Name_TextBox.TextChanged += new System.EventHandler(this.Name_TextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Дата народження";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "По батькові";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Прізвище";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ім\'я";
            // 
            // Add_Button
            // 
            this.helpProvider1.SetHelpKeyword(this.Add_Button, "funktsional__dlya_administratora_.htm#17");
            this.helpProvider1.SetHelpNavigator(this.Add_Button, System.Windows.Forms.HelpNavigator.Topic);
            this.Add_Button.Location = new System.Drawing.Point(120, 278);
            this.Add_Button.Name = "Add_Button";
            this.helpProvider1.SetShowHelp(this.Add_Button, true);
            this.Add_Button.Size = new System.Drawing.Size(158, 45);
            this.Add_Button.TabIndex = 4;
            this.Add_Button.Text = "Зареєструвати лікаря";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ел. адреса";
            // 
            // Email_TextBox
            // 
            this.Email_TextBox.Location = new System.Drawing.Point(149, 188);
            this.Email_TextBox.Name = "Email_TextBox";
            this.Email_TextBox.Size = new System.Drawing.Size(238, 20);
            this.Email_TextBox.TabIndex = 12;
            this.Email_TextBox.TextChanged += new System.EventHandler(this.Email_TextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Спеціалізація";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Пароль";
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Location = new System.Drawing.Point(149, 240);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.PasswordChar = '*';
            this.Password_TextBox.Size = new System.Drawing.Size(238, 20);
            this.Password_TextBox.TabIndex = 12;
            this.Password_TextBox.TextChanged += new System.EventHandler(this.Password_TextBox_TextChanged);
            // 
            // Spec_ComboBox
            // 
            this.Spec_ComboBox.FormattingEnabled = true;
            this.Spec_ComboBox.Location = new System.Drawing.Point(149, 215);
            this.Spec_ComboBox.Name = "Spec_ComboBox";
            this.Spec_ComboBox.Size = new System.Drawing.Size(238, 21);
            this.Spec_ComboBox.TabIndex = 20;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\kravc\\OneDrive\\Рабочий стол\\PolyclinicManagementSystem\\МояПоліклініка.ch" +
    "m";
            // 
            // RegisterDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 335);
            this.Controls.Add(this.Spec_ComboBox);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.Email_TextBox);
            this.Controls.Add(this.Phone_TextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PassportCode_TextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Adress_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BirthDate_TextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Patronymic_TextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Surname_TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Add_Button);
            this.HelpButton = true;
            this.helpProvider1.SetHelpKeyword(this, "funktsional__dlya_administratora_.htm#16");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "RegisterDoctorForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Форма реєстрації лікаря";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Phone_TextBox;
        private System.Windows.Forms.TextBox PassportCode_TextBox;
        private System.Windows.Forms.TextBox Adress_TextBox;
        private System.Windows.Forms.TextBox BirthDate_TextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Patronymic_TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Surname_TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Email_TextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.ComboBox Spec_ComboBox;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}