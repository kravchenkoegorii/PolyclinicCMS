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
            this.SuspendLayout();
            // 
            // DoctorRole_Button
            // 
            this.DoctorRole_Button.Location = new System.Drawing.Point(93, 42);
            this.DoctorRole_Button.Name = "DoctorRole_Button";
            this.DoctorRole_Button.Size = new System.Drawing.Size(177, 46);
            this.DoctorRole_Button.TabIndex = 0;
            this.DoctorRole_Button.Text = "Doctor";
            this.DoctorRole_Button.UseVisualStyleBackColor = true;
            this.DoctorRole_Button.Click += new System.EventHandler(this.DoctorRole_Button_Click);
            // 
            // AdministratorRole_Button
            // 
            this.AdministratorRole_Button.Location = new System.Drawing.Point(93, 94);
            this.AdministratorRole_Button.Name = "AdministratorRole_Button";
            this.AdministratorRole_Button.Size = new System.Drawing.Size(177, 46);
            this.AdministratorRole_Button.TabIndex = 2;
            this.AdministratorRole_Button.Text = "Administrator";
            this.AdministratorRole_Button.UseVisualStyleBackColor = true;
            this.AdministratorRole_Button.Click += new System.EventHandler(this.AdministratorRole_Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 190);
            this.Controls.Add(this.AdministratorRole_Button);
            this.Controls.Add(this.DoctorRole_Button);
            this.Name = "MainForm";
            this.Text = "Polyclinic Management System";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button AdministratorRole_Button;

        private System.Windows.Forms.Button DoctorRole_Button;

        #endregion
    }
}