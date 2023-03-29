using System.ComponentModel;

namespace PolyclinicManagementSystem
{
    partial class RegisterPatientForm
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
            this.Add_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Surname_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Patronymic_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BirthDate_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Adress_TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PassportCode_TextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Phone_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(154, 228);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(158, 45);
            this.Add_Button.TabIndex = 0;
            this.Add_Button.Text = "Зареєструвати пацієнта";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ім\'я";
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(176, 29);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(238, 20);
            this.Name_TextBox.TabIndex = 2;
            this.Name_TextBox.TextChanged += new System.EventHandler(this.Name_TextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Прізвище";
            // 
            // Surname_TextBox
            // 
            this.Surname_TextBox.Location = new System.Drawing.Point(176, 55);
            this.Surname_TextBox.Name = "Surname_TextBox";
            this.Surname_TextBox.Size = new System.Drawing.Size(238, 20);
            this.Surname_TextBox.TabIndex = 2;
            this.Surname_TextBox.TextChanged += new System.EventHandler(this.Surname_TextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "По батькові";
            // 
            // Patronymic_TextBox
            // 
            this.Patronymic_TextBox.Location = new System.Drawing.Point(176, 82);
            this.Patronymic_TextBox.Name = "Patronymic_TextBox";
            this.Patronymic_TextBox.Size = new System.Drawing.Size(238, 20);
            this.Patronymic_TextBox.TabIndex = 2;
            this.Patronymic_TextBox.TextChanged += new System.EventHandler(this.Patronymic_TextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Дата народження";
            // 
            // BirthDate_TextBox
            // 
            this.BirthDate_TextBox.Location = new System.Drawing.Point(176, 108);
            this.BirthDate_TextBox.MaxLength = 10;
            this.BirthDate_TextBox.Name = "BirthDate_TextBox";
            this.BirthDate_TextBox.Size = new System.Drawing.Size(238, 20);
            this.BirthDate_TextBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Адреса";
            // 
            // Adress_TextBox
            // 
            this.Adress_TextBox.Location = new System.Drawing.Point(176, 134);
            this.Adress_TextBox.Name = "Adress_TextBox";
            this.Adress_TextBox.Size = new System.Drawing.Size(238, 20);
            this.Adress_TextBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Код паспорту";
            // 
            // PassportCode_TextBox
            // 
            this.PassportCode_TextBox.Location = new System.Drawing.Point(176, 160);
            this.PassportCode_TextBox.MaxLength = 9;
            this.PassportCode_TextBox.Name = "PassportCode_TextBox";
            this.PassportCode_TextBox.Size = new System.Drawing.Size(238, 20);
            this.PassportCode_TextBox.TabIndex = 2;
            this.PassportCode_TextBox.TextChanged += new System.EventHandler(this.PassportCode_TextBox_TextChanged);
            this.PassportCode_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassportCode_TextBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Номер телефону";
            // 
            // Phone_TextBox
            // 
            this.Phone_TextBox.Location = new System.Drawing.Point(176, 186);
            this.Phone_TextBox.MaxLength = 13;
            this.Phone_TextBox.Name = "Phone_TextBox";
            this.Phone_TextBox.Size = new System.Drawing.Size(238, 20);
            this.Phone_TextBox.TabIndex = 2;
            this.Phone_TextBox.TextChanged += new System.EventHandler(this.Phone_TextBox_TextChanged);
            this.Phone_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Phone_TextBox_KeyPress);
            // 
            // RegisterPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 280);
            this.Controls.Add(this.Phone_TextBox);
            this.Controls.Add(this.PassportCode_TextBox);
            this.Controls.Add(this.Adress_TextBox);
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
            this.Name = "RegisterPatientForm";
            this.Text = "Форма реєстрації пацієнта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Surname_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Patronymic_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BirthDate_TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Adress_TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PassportCode_TextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Phone_TextBox;
    }
}