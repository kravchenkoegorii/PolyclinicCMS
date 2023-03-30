namespace PolyclinicManagementSystem.Forms
{
    partial class GraphicForm
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.doctorModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            ((System.ComponentModel.ISupportInitialize)(this.doctorModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Відобразити графік";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // doctorModelBindingSource
            // 
            this.doctorModelBindingSource.DataSource = typeof(PolyclinicManagementSystem.Models.DoctorModel);
            // 
            // pieChart1
            // 
            this.pieChart1.Location = new System.Drawing.Point(172, 12);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(577, 419);
            this.pieChart1.TabIndex = 2;
            this.pieChart1.Text = "pieChart1";
            // 
            // GraphicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 465);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.button1);
            this.Name = "GraphicForm";
            this.Text = "Форма статистики";
            ((System.ComponentModel.ISupportInitialize)(this.doctorModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource doctorModelBindingSource;
        private LiveCharts.WinForms.PieChart pieChart1;
    }
}