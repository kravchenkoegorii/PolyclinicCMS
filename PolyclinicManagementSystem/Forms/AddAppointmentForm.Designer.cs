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
            this.PatientId_Label = new System.Windows.Forms.Label();
            this.Date_TextBox = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Error_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(104, 153);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(120, 46);
            this.Add_Button.TabIndex = 0;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Date_Label
            // 
            this.Date_Label.AutoSize = true;
            this.Date_Label.Location = new System.Drawing.Point(26, 47);
            this.Date_Label.Name = "Date_Label";
            this.Date_Label.Size = new System.Drawing.Size(30, 13);
            this.Date_Label.TabIndex = 1;
            this.Date_Label.Text = "Date";
            this.Date_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PatientId_Label
            // 
            this.PatientId_Label.AutoSize = true;
            this.PatientId_Label.Location = new System.Drawing.Point(26, 81);
            this.PatientId_Label.Name = "PatientId_Label";
            this.PatientId_Label.Size = new System.Drawing.Size(49, 13);
            this.PatientId_Label.TabIndex = 1;
            this.PatientId_Label.Text = "PatientId";
            this.PatientId_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Date_TextBox
            // 
            this.Date_TextBox.Location = new System.Drawing.Point(80, 44);
            this.Date_TextBox.Name = "Date_TextBox";
            this.Date_TextBox.Size = new System.Drawing.Size(183, 20);
            this.Date_TextBox.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(80, 79);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(183, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // Error_Label
            // 
            this.Error_Label.AutoSize = true;
            this.Error_Label.Location = new System.Drawing.Point(26, 119);
            this.Error_Label.Name = "Error_Label";
            this.Error_Label.Size = new System.Drawing.Size(0, 13);
            this.Error_Label.TabIndex = 4;
            // 
            // AddAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 211);
            this.Controls.Add(this.Error_Label);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Date_TextBox);
            this.Controls.Add(this.PatientId_Label);
            this.Controls.Add(this.Date_Label);
            this.Controls.Add(this.Add_Button);
            this.Name = "AddAppointmentForm";
            this.Text = "AddAppointmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Label Date_Label;
        private System.Windows.Forms.Label PatientId_Label;
        private System.Windows.Forms.TextBox Date_TextBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label Error_Label;
    }
}