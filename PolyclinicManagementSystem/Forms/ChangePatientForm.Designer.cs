namespace PolyclinicManagementSystem.Forms
{
    partial class ChangePatientForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.Phone_TextBox = new System.Windows.Forms.TextBox();
            this.Address_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Surname_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.helpProvider1.SetHelpKeyword(this.button1, "funktsional__dlya_administratora_.htm#12");
            this.helpProvider1.SetHelpNavigator(this.button1, System.Windows.Forms.HelpNavigator.Topic);
            this.button1.Location = new System.Drawing.Point(148, 133);
            this.button1.Name = "button1";
            this.helpProvider1.SetShowHelp(this.button1, true);
            this.button1.Size = new System.Drawing.Size(157, 56);
            this.button1.TabIndex = 40;
            this.button1.Text = "Змінити дані";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Phone_TextBox
            // 
            this.Phone_TextBox.Location = new System.Drawing.Point(101, 92);
            this.Phone_TextBox.MaxLength = 13;
            this.Phone_TextBox.Name = "Phone_TextBox";
            this.Phone_TextBox.Size = new System.Drawing.Size(238, 20);
            this.Phone_TextBox.TabIndex = 38;
            this.Phone_TextBox.TextChanged += new System.EventHandler(this.Phone_TextBox_TextChanged);
            this.Phone_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Phone_TextBox_KeyPress);
            // 
            // Address_TextBox
            // 
            this.Address_TextBox.Location = new System.Drawing.Point(101, 65);
            this.Address_TextBox.Name = "Address_TextBox";
            this.Address_TextBox.Size = new System.Drawing.Size(238, 20);
            this.Address_TextBox.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Номер телефону";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Адреса";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Прізвище";
            // 
            // Surname_TextBox
            // 
            this.Surname_TextBox.Location = new System.Drawing.Point(101, 39);
            this.Surname_TextBox.Name = "Surname_TextBox";
            this.Surname_TextBox.Size = new System.Drawing.Size(238, 20);
            this.Surname_TextBox.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Ім\'я";
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(101, 12);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(238, 20);
            this.Name_TextBox.TabIndex = 39;
            // 
            // button2
            // 
            this.helpProvider1.SetHelpKeyword(this.button2, "funktsional__dlya_administratora_.htm#11");
            this.helpProvider1.SetHelpNavigator(this.button2, System.Windows.Forms.HelpNavigator.Topic);
            this.button2.Location = new System.Drawing.Point(345, 12);
            this.button2.Name = "button2";
            this.helpProvider1.SetShowHelp(this.button2, true);
            this.button2.Size = new System.Drawing.Size(101, 47);
            this.button2.TabIndex = 41;
            this.button2.Text = "Загрузити дані";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\kravc\\OneDrive\\Рабочий стол\\PolyclinicManagementSystem\\МояПоліклініка.ch" +
    "m";
            // 
            // ChangePatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 201);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Phone_TextBox);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.Surname_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Address_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.HelpButton = true;
            this.helpProvider1.SetHelpKeyword(this, "funktsional__dlya_administratora_.htm#13");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePatientForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Форма для зміни даних пацієнта";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.ChangePatientForm_HelpButtonClicked);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Phone_TextBox;
        private System.Windows.Forms.TextBox Address_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Surname_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}