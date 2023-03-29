namespace PolyclinicManagementSystem.Forms
{
    partial class ChangeAppointmentForm
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
            this.CheckPatient_Button = new System.Windows.Forms.Button();
            this.CheckDate_Button = new System.Windows.Forms.Button();
            this.Error_Label = new System.Windows.Forms.Label();
            this.PatSurname_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PatName_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Date_TextBox = new System.Windows.Forms.TextBox();
            this.Date_Label = new System.Windows.Forms.Label();
            this.Change_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckPatient_Button
            // 
            this.CheckPatient_Button.Location = new System.Drawing.Point(332, 55);
            this.CheckPatient_Button.Name = "CheckPatient_Button";
            this.CheckPatient_Button.Size = new System.Drawing.Size(99, 48);
            this.CheckPatient_Button.TabIndex = 21;
            this.CheckPatient_Button.Text = "Перевірити пацієнта";
            this.CheckPatient_Button.UseVisualStyleBackColor = true;
            this.CheckPatient_Button.Click += new System.EventHandler(this.CheckPatient_Button_Click);
            // 
            // CheckDate_Button
            // 
            this.CheckDate_Button.Location = new System.Drawing.Point(332, 26);
            this.CheckDate_Button.Name = "CheckDate_Button";
            this.CheckDate_Button.Size = new System.Drawing.Size(99, 23);
            this.CheckDate_Button.TabIndex = 19;
            this.CheckDate_Button.Text = "Перевірити час";
            this.CheckDate_Button.UseVisualStyleBackColor = true;
            this.CheckDate_Button.Click += new System.EventHandler(this.CheckDate_Button_Click);
            // 
            // Error_Label
            // 
            this.Error_Label.AutoSize = true;
            this.Error_Label.Location = new System.Drawing.Point(140, 127);
            this.Error_Label.Name = "Error_Label";
            this.Error_Label.Size = new System.Drawing.Size(0, 13);
            this.Error_Label.TabIndex = 18;
            // 
            // PatSurname_TextBox
            // 
            this.PatSurname_TextBox.Location = new System.Drawing.Point(143, 83);
            this.PatSurname_TextBox.Name = "PatSurname_TextBox";
            this.PatSurname_TextBox.Size = new System.Drawing.Size(183, 20);
            this.PatSurname_TextBox.TabIndex = 13;
            this.PatSurname_TextBox.TextChanged += new System.EventHandler(this.PatSurname_TextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Прізвище пацієнта";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PatName_TextBox
            // 
            this.PatName_TextBox.Location = new System.Drawing.Point(143, 57);
            this.PatName_TextBox.Name = "PatName_TextBox";
            this.PatName_TextBox.Size = new System.Drawing.Size(183, 20);
            this.PatName_TextBox.TabIndex = 14;
            this.PatName_TextBox.TextChanged += new System.EventHandler(this.PatName_TextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ім\'я пацієнта";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Date_TextBox
            // 
            this.Date_TextBox.Location = new System.Drawing.Point(143, 28);
            this.Date_TextBox.MaxLength = 10;
            this.Date_TextBox.Name = "Date_TextBox";
            this.Date_TextBox.Size = new System.Drawing.Size(183, 20);
            this.Date_TextBox.TabIndex = 17;
            // 
            // Date_Label
            // 
            this.Date_Label.AutoSize = true;
            this.Date_Label.Location = new System.Drawing.Point(12, 31);
            this.Date_Label.Name = "Date_Label";
            this.Date_Label.Size = new System.Drawing.Size(67, 13);
            this.Date_Label.TabIndex = 12;
            this.Date_Label.Text = "Дата та час";
            this.Date_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Change_Button
            // 
            this.Change_Button.Location = new System.Drawing.Point(166, 150);
            this.Change_Button.Name = "Change_Button";
            this.Change_Button.Size = new System.Drawing.Size(120, 46);
            this.Change_Button.TabIndex = 7;
            this.Change_Button.Text = "Змінити запис";
            this.Change_Button.UseVisualStyleBackColor = true;
            this.Change_Button.Click += new System.EventHandler(this.Change_Button_Click_1);
            // 
            // ChangeAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 208);
            this.Controls.Add(this.CheckPatient_Button);
            this.Controls.Add(this.CheckDate_Button);
            this.Controls.Add(this.Error_Label);
            this.Controls.Add(this.PatSurname_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PatName_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Date_TextBox);
            this.Controls.Add(this.Date_Label);
            this.Controls.Add(this.Change_Button);
            this.Name = "ChangeAppointmentForm";
            this.Text = "Форма зміни запису";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckPatient_Button;
        private System.Windows.Forms.Button CheckDate_Button;
        private System.Windows.Forms.Label Error_Label;
        private System.Windows.Forms.TextBox PatSurname_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PatName_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Date_TextBox;
        private System.Windows.Forms.Label Date_Label;
        private System.Windows.Forms.Button Change_Button;
    }
}