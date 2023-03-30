namespace PolyclinicManagementSystem.Forms
{
    partial class LoginAdminForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Email_TextBox = new System.Windows.Forms.TextBox();
            this.Login_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Error_Label
            // 
            this.Error_Label.AutoSize = true;
            this.Error_Label.Location = new System.Drawing.Point(121, 157);
            this.Error_Label.Name = "Error_Label";
            this.Error_Label.Size = new System.Drawing.Size(0, 13);
            this.Error_Label.TabIndex = 11;
            this.Error_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(11, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Пароль";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Location = new System.Drawing.Point(112, 120);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.PasswordChar = '*';
            this.Password_TextBox.Size = new System.Drawing.Size(209, 20);
            this.Password_TextBox.TabIndex = 7;
            this.Password_TextBox.Text = "admin";
            this.Password_TextBox.TextChanged += new System.EventHandler(this.Password_TextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(35, 82);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ел. адреса";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Email_TextBox
            // 
            this.Email_TextBox.Location = new System.Drawing.Point(112, 82);
            this.Email_TextBox.Name = "Email_TextBox";
            this.Email_TextBox.Size = new System.Drawing.Size(209, 20);
            this.Email_TextBox.TabIndex = 8;
            this.Email_TextBox.Text = "admin@admin.com";
            this.Email_TextBox.TextChanged += new System.EventHandler(this.Email_TextBox_TextChanged);
            // 
            // Login_Button
            // 
            this.Login_Button.Location = new System.Drawing.Point(124, 185);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(130, 50);
            this.Login_Button.TabIndex = 6;
            this.Login_Button.Text = "Авторизуватись";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введіть вашу ел. адресу та пароль";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 245);
            this.Controls.Add(this.Error_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Email_TextBox);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.label1);
            this.Name = "LoginAdminForm";
            this.Text = "Форма авторизації (Адміністратор)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Error_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Email_TextBox;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Label label1;
    }
}