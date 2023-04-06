namespace PolyclinicManagementSystem.Forms
{
    partial class AddAppointmentForm
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
            this.Add_Button = new System.Windows.Forms.Button();
            this.Date_Label = new System.Windows.Forms.Label();
            this.Date_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DocName_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DocSurname_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PatName_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PatSurname_TextBox = new System.Windows.Forms.TextBox();
            this.Error_Label = new System.Windows.Forms.Label();
            this.CheckDate_Button = new System.Windows.Forms.Button();
            this.CheckDoctor_Button = new System.Windows.Forms.Button();
            this.CheckPatient_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(165, 201);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(120, 46);
            this.Add_Button.TabIndex = 0;
            this.Add_Button.Text = "Записати";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Date_Label
            // 
            this.Date_Label.AutoSize = true;
            this.Date_Label.Location = new System.Drawing.Point(12, 27);
            this.Date_Label.Name = "Date_Label";
            this.Date_Label.Size = new System.Drawing.Size(67, 13);
            this.Date_Label.TabIndex = 1;
            this.Date_Label.Text = "Дата та час";
            this.Date_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Date_TextBox
            // 
            this.Date_TextBox.Location = new System.Drawing.Point(143, 24);
            this.Date_TextBox.MaxLength = 100;
            this.Date_TextBox.Name = "Date_TextBox";
            this.Date_TextBox.Size = new System.Drawing.Size(183, 20);
            this.Date_TextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ім\'я лікаря";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DocName_TextBox
            // 
            this.DocName_TextBox.Location = new System.Drawing.Point(143, 50);
            this.DocName_TextBox.Name = "DocName_TextBox";
            this.DocName_TextBox.Size = new System.Drawing.Size(183, 20);
            this.DocName_TextBox.TabIndex = 2;
            this.DocName_TextBox.TextChanged += new System.EventHandler(this.DocName_TextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Прізвище лікаря";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DocSurname_TextBox
            // 
            this.DocSurname_TextBox.Location = new System.Drawing.Point(143, 76);
            this.DocSurname_TextBox.Name = "DocSurname_TextBox";
            this.DocSurname_TextBox.Size = new System.Drawing.Size(183, 20);
            this.DocSurname_TextBox.TabIndex = 2;
            this.DocSurname_TextBox.TextChanged += new System.EventHandler(this.DocSurname_TextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ім\'я пацієнта";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PatName_TextBox
            // 
            this.PatName_TextBox.Location = new System.Drawing.Point(143, 102);
            this.PatName_TextBox.Name = "PatName_TextBox";
            this.PatName_TextBox.Size = new System.Drawing.Size(183, 20);
            this.PatName_TextBox.TabIndex = 2;
            this.PatName_TextBox.TextChanged += new System.EventHandler(this.PatName_TextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Прізвище пацієнта";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PatSurname_TextBox
            // 
            this.PatSurname_TextBox.Location = new System.Drawing.Point(143, 128);
            this.PatSurname_TextBox.Name = "PatSurname_TextBox";
            this.PatSurname_TextBox.Size = new System.Drawing.Size(183, 20);
            this.PatSurname_TextBox.TabIndex = 2;
            this.PatSurname_TextBox.TextChanged += new System.EventHandler(this.PatSurname_TextBox_TextChanged);
            // 
            // Error_Label
            // 
            this.Error_Label.AutoSize = true;
            this.Error_Label.Location = new System.Drawing.Point(140, 172);
            this.Error_Label.Name = "Error_Label";
            this.Error_Label.Size = new System.Drawing.Size(0, 13);
            this.Error_Label.TabIndex = 3;
            // 
            // CheckDate_Button
            // 
            this.CheckDate_Button.Location = new System.Drawing.Point(332, 22);
            this.CheckDate_Button.Name = "CheckDate_Button";
            this.CheckDate_Button.Size = new System.Drawing.Size(99, 23);
            this.CheckDate_Button.TabIndex = 4;
            this.CheckDate_Button.Text = "Перевірити час";
            this.CheckDate_Button.UseVisualStyleBackColor = true;
            this.CheckDate_Button.Click += new System.EventHandler(this.CheckDate_Button_Click);
            // 
            // CheckDoctor_Button
            // 
            this.CheckDoctor_Button.Location = new System.Drawing.Point(332, 48);
            this.CheckDoctor_Button.Name = "CheckDoctor_Button";
            this.CheckDoctor_Button.Size = new System.Drawing.Size(99, 48);
            this.CheckDoctor_Button.TabIndex = 5;
            this.CheckDoctor_Button.Text = "Перевірити лікаря";
            this.CheckDoctor_Button.UseVisualStyleBackColor = true;
            this.CheckDoctor_Button.Click += new System.EventHandler(this.CheckDoctor_Button_Click);
            // 
            // CheckPatient_Button
            // 
            this.CheckPatient_Button.Location = new System.Drawing.Point(332, 100);
            this.CheckPatient_Button.Name = "CheckPatient_Button";
            this.CheckPatient_Button.Size = new System.Drawing.Size(99, 48);
            this.CheckPatient_Button.TabIndex = 6;
            this.CheckPatient_Button.Text = "Перевірити пацієнта";
            this.CheckPatient_Button.UseVisualStyleBackColor = true;
            this.CheckPatient_Button.Click += new System.EventHandler(this.CheckPatient_Button_Click);
            // 
            // AddAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 259);
            this.Controls.Add(this.CheckPatient_Button);
            this.Controls.Add(this.CheckDoctor_Button);
            this.Controls.Add(this.CheckDate_Button);
            this.Controls.Add(this.Error_Label);
            this.Controls.Add(this.PatSurname_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PatName_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DocSurname_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DocName_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Date_TextBox);
            this.Controls.Add(this.Date_Label);
            this.Controls.Add(this.Add_Button);
            this.Name = "AddAppointmentForm";
            this.Text = "Форма запису пацієнта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Label Date_Label;
        private System.Windows.Forms.TextBox Date_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DocName_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DocSurname_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PatName_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PatSurname_TextBox;
        private System.Windows.Forms.Label Error_Label;
        private System.Windows.Forms.Button CheckDate_Button;
        private System.Windows.Forms.Button CheckDoctor_Button;
        private System.Windows.Forms.Button CheckPatient_Button;
    }
}