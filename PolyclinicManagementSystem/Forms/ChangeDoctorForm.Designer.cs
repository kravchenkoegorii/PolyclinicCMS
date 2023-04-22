namespace PolyclinicManagementSystem.Forms
{
    partial class ChangeDoctorForm
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
            this.Email_TextBox = new System.Windows.Forms.TextBox();
            this.Phone_TextBox = new System.Windows.Forms.TextBox();
            this.Address_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Spec_ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Surname_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // Email_TextBox
            // 
            this.Email_TextBox.Location = new System.Drawing.Point(110, 120);
            this.Email_TextBox.Name = "Email_TextBox";
            this.Email_TextBox.Size = new System.Drawing.Size(238, 20);
            this.Email_TextBox.TabIndex = 25;
            this.Email_TextBox.TextChanged += new System.EventHandler(this.Email_TextBox_TextChanged);
            // 
            // Phone_TextBox
            // 
            this.Phone_TextBox.Location = new System.Drawing.Point(110, 94);
            this.Phone_TextBox.MaxLength = 13;
            this.Phone_TextBox.Name = "Phone_TextBox";
            this.Phone_TextBox.Size = new System.Drawing.Size(238, 20);
            this.Phone_TextBox.TabIndex = 26;
            this.Phone_TextBox.TextChanged += new System.EventHandler(this.Phone_TextBox_TextChanged);
            this.Phone_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Phone_TextBox_KeyPress);
            // 
            // Address_TextBox
            // 
            this.Address_TextBox.Location = new System.Drawing.Point(110, 67);
            this.Address_TextBox.Name = "Address_TextBox";
            this.Address_TextBox.Size = new System.Drawing.Size(238, 20);
            this.Address_TextBox.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Спеціалізація";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ел. адреса";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Номер телефону";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Адреса";
            // 
            // button1
            // 
            this.helpProvider1.SetHelpKeyword(this.button1, "funktsional__dlya_administratora_.htm#12");
            this.helpProvider1.SetHelpNavigator(this.button1, System.Windows.Forms.HelpNavigator.Topic);
            this.button1.Location = new System.Drawing.Point(141, 178);
            this.button1.Name = "button1";
            this.helpProvider1.SetShowHelp(this.button1, true);
            this.button1.Size = new System.Drawing.Size(157, 56);
            this.button1.TabIndex = 29;
            this.button1.Text = "Змінити дані";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Spec_ComboBox
            // 
            this.Spec_ComboBox.FormattingEnabled = true;
            this.Spec_ComboBox.Location = new System.Drawing.Point(110, 145);
            this.Spec_ComboBox.Name = "Spec_ComboBox";
            this.Spec_ComboBox.Size = new System.Drawing.Size(238, 21);
            this.Spec_ComboBox.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Прізвище";
            // 
            // Surname_TextBox
            // 
            this.Surname_TextBox.Location = new System.Drawing.Point(110, 41);
            this.Surname_TextBox.Name = "Surname_TextBox";
            this.Surname_TextBox.Size = new System.Drawing.Size(238, 20);
            this.Surname_TextBox.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ім\'я";
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(110, 15);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(238, 20);
            this.Name_TextBox.TabIndex = 27;
            // 
            // button2
            // 
            this.helpProvider1.SetHelpKeyword(this.button2, "funktsional__dlya_administratora_.htm#11");
            this.helpProvider1.SetHelpNavigator(this.button2, System.Windows.Forms.HelpNavigator.Topic);
            this.button2.Location = new System.Drawing.Point(355, 15);
            this.button2.Name = "button2";
            this.helpProvider1.SetShowHelp(this.button2, true);
            this.button2.Size = new System.Drawing.Size(74, 46);
            this.button2.TabIndex = 31;
            this.button2.Text = "Загрузити дані";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\kravc\\OneDrive\\Рабочий стол\\PolyclinicManagementSystem\\МояПоліклініка.ch" +
    "m";
            // 
            // ChangeDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 246);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Spec_ComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Email_TextBox);
            this.Controls.Add(this.Phone_TextBox);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.Surname_TextBox);
            this.Controls.Add(this.Address_TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.HelpButton = true;
            this.helpProvider1.SetHelpKeyword(this, "funktsional__dlya_administratora_.htm#10");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeDoctorForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Форма для зміни даних лікаря";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.ChangeDoctorForm_HelpButtonClicked);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Email_TextBox;
        private System.Windows.Forms.TextBox Phone_TextBox;
        private System.Windows.Forms.TextBox Address_TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Spec_ComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Surname_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}