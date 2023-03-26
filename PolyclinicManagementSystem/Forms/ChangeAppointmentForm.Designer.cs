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
            this.Error_Label = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Date_TextBox = new System.Windows.Forms.TextBox();
            this.PatientId_Label = new System.Windows.Forms.Label();
            this.Date_Label = new System.Windows.Forms.Label();
            this.Change_Button = new System.Windows.Forms.Button();
            this.Id_Label = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // Error_Label
            // 
            this.Error_Label.AutoSize = true;
            this.Error_Label.Location = new System.Drawing.Point(65, 141);
            this.Error_Label.Name = "Error_Label";
            this.Error_Label.Size = new System.Drawing.Size(0, 13);
            this.Error_Label.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(89, 94);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(183, 20);
            this.numericUpDown1.TabIndex = 9;
            // 
            // Date_TextBox
            // 
            this.Date_TextBox.Location = new System.Drawing.Point(89, 59);
            this.Date_TextBox.Name = "Date_TextBox";
            this.Date_TextBox.Size = new System.Drawing.Size(183, 20);
            this.Date_TextBox.TabIndex = 8;
            // 
            // PatientId_Label
            // 
            this.PatientId_Label.AutoSize = true;
            this.PatientId_Label.Location = new System.Drawing.Point(35, 96);
            this.PatientId_Label.Name = "PatientId_Label";
            this.PatientId_Label.Size = new System.Drawing.Size(49, 13);
            this.PatientId_Label.TabIndex = 6;
            this.PatientId_Label.Text = "PatientId";
            this.PatientId_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Date_Label
            // 
            this.Date_Label.AutoSize = true;
            this.Date_Label.Location = new System.Drawing.Point(35, 62);
            this.Date_Label.Name = "Date_Label";
            this.Date_Label.Size = new System.Drawing.Size(30, 13);
            this.Date_Label.TabIndex = 7;
            this.Date_Label.Text = "Date";
            this.Date_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Change_Button
            // 
            this.Change_Button.Location = new System.Drawing.Point(99, 173);
            this.Change_Button.Name = "Change_Button";
            this.Change_Button.Size = new System.Drawing.Size(120, 46);
            this.Change_Button.TabIndex = 5;
            this.Change_Button.Text = "Change";
            this.Change_Button.UseVisualStyleBackColor = true;
            this.Change_Button.Click += new System.EventHandler(this.Change_Button_Click);
            // 
            // Id_Label
            // 
            this.Id_Label.AutoSize = true;
            this.Id_Label.Location = new System.Drawing.Point(35, 27);
            this.Id_Label.Name = "Id_Label";
            this.Id_Label.Size = new System.Drawing.Size(16, 13);
            this.Id_Label.TabIndex = 7;
            this.Id_Label.Text = "Id";
            this.Id_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(89, 25);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(183, 20);
            this.numericUpDown2.TabIndex = 11;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // ChangeAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 231);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.Error_Label);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Date_TextBox);
            this.Controls.Add(this.PatientId_Label);
            this.Controls.Add(this.Id_Label);
            this.Controls.Add(this.Date_Label);
            this.Controls.Add(this.Change_Button);
            this.Name = "ChangeAppointmentForm";
            this.Text = "ChangeAppointmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Error_Label;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox Date_TextBox;
        private System.Windows.Forms.Label PatientId_Label;
        private System.Windows.Forms.Label Date_Label;
        private System.Windows.Forms.Button Change_Button;
        private System.Windows.Forms.Label Id_Label;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}