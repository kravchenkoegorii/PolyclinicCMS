using System.ComponentModel;

namespace PolyclinicManagementSystem
{
    partial class AdministratorForm
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
            this.components = new System.ComponentModel.Container();
            this.ShowDoctors_Button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddDoctor_Button = new System.Windows.Forms.Button();
            this.ChangeDoctor_Button = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.patientModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChangePatient_Button = new System.Windows.Forms.Button();
            this.ShowPatients_Button = new System.Windows.Forms.Button();
            this.AddSpec_Button = new System.Windows.Forms.Button();
            this.Graphic_Button = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorSurnameataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowDoctors_Button
            // 
            this.ShowDoctors_Button.Location = new System.Drawing.Point(12, 12);
            this.ShowDoctors_Button.Name = "ShowDoctors_Button";
            this.ShowDoctors_Button.Size = new System.Drawing.Size(139, 56);
            this.ShowDoctors_Button.TabIndex = 0;
            this.ShowDoctors_Button.Text = "Переглянути всіх лікарів";
            this.ShowDoctors_Button.UseVisualStyleBackColor = true;
            this.ShowDoctors_Button.Click += new System.EventHandler(this.ShowDoctors_Button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.passportCodeDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.specializationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.doctorModelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(157, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(701, 177);
            this.dataGridView1.TabIndex = 1;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Прізвище";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "По батькові";
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "Дата народження";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адреса";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // passportCodeDataGridViewTextBoxColumn
            // 
            this.passportCodeDataGridViewTextBoxColumn.DataPropertyName = "PassportCode";
            this.passportCodeDataGridViewTextBoxColumn.HeaderText = "Код паспорту";
            this.passportCodeDataGridViewTextBoxColumn.Name = "passportCodeDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Номер телефону";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Ел. адреса";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // specializationDataGridViewTextBoxColumn
            // 
            this.specializationDataGridViewTextBoxColumn.DataPropertyName = "Specialization";
            this.specializationDataGridViewTextBoxColumn.HeaderText = "Спеціалізація";
            this.specializationDataGridViewTextBoxColumn.Name = "specializationDataGridViewTextBoxColumn";
            // 
            // doctorModelBindingSource
            // 
            this.doctorModelBindingSource.DataSource = typeof(PolyclinicManagementSystem.Models.DoctorModel);
            // 
            // AddDoctor_Button
            // 
            this.AddDoctor_Button.Location = new System.Drawing.Point(12, 71);
            this.AddDoctor_Button.Name = "AddDoctor_Button";
            this.AddDoctor_Button.Size = new System.Drawing.Size(139, 56);
            this.AddDoctor_Button.TabIndex = 0;
            this.AddDoctor_Button.Text = "Додати лікаря";
            this.AddDoctor_Button.UseVisualStyleBackColor = true;
            this.AddDoctor_Button.Click += new System.EventHandler(this.AddDoctor_Button_Click);
            // 
            // ChangeDoctor_Button
            // 
            this.ChangeDoctor_Button.Location = new System.Drawing.Point(12, 133);
            this.ChangeDoctor_Button.Name = "ChangeDoctor_Button";
            this.ChangeDoctor_Button.Size = new System.Drawing.Size(139, 56);
            this.ChangeDoctor_Button.TabIndex = 0;
            this.ChangeDoctor_Button.Text = "Змінити лікаря";
            this.ChangeDoctor_Button.UseVisualStyleBackColor = true;
            this.ChangeDoctor_Button.Click += new System.EventHandler(this.ChangeDoctor_Button_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.surnameDataGridViewTextBoxColumn1,
            this.patronymicDataGridViewTextBoxColumn1,
            this.birthDateDataGridViewTextBoxColumn1,
            this.addressDataGridViewTextBoxColumn1,
            this.passportCodeDataGridViewTextBoxColumn1,
            this.phoneNumberDataGridViewTextBoxColumn1,
            this.doctorNameDataGridViewTextBoxColumn,
            this.doctorSurnameataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.patientModelBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(157, 216);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(701, 177);
            this.dataGridView2.TabIndex = 1;
            // 
            // patientModelBindingSource
            // 
            this.patientModelBindingSource.DataSource = typeof(PolyclinicManagementSystem.Models.PatientModel);
            // 
            // ChangePatient_Button
            // 
            this.ChangePatient_Button.Location = new System.Drawing.Point(12, 309);
            this.ChangePatient_Button.Name = "ChangePatient_Button";
            this.ChangePatient_Button.Size = new System.Drawing.Size(139, 56);
            this.ChangePatient_Button.TabIndex = 0;
            this.ChangePatient_Button.Text = "Змінити пацієнта";
            this.ChangePatient_Button.UseVisualStyleBackColor = true;
            this.ChangePatient_Button.Click += new System.EventHandler(this.ChangePatient_Button_Click);
            // 
            // ShowPatients_Button
            // 
            this.ShowPatients_Button.Location = new System.Drawing.Point(13, 247);
            this.ShowPatients_Button.Name = "ShowPatients_Button";
            this.ShowPatients_Button.Size = new System.Drawing.Size(138, 56);
            this.ShowPatients_Button.TabIndex = 2;
            this.ShowPatients_Button.Text = "Переглянути всіх пацієнтів";
            this.ShowPatients_Button.UseVisualStyleBackColor = true;
            this.ShowPatients_Button.Click += new System.EventHandler(this.ShowPatients_Button_Click);
            // 
            // AddSpec_Button
            // 
            this.AddSpec_Button.Location = new System.Drawing.Point(13, 458);
            this.AddSpec_Button.Name = "AddSpec_Button";
            this.AddSpec_Button.Size = new System.Drawing.Size(138, 55);
            this.AddSpec_Button.TabIndex = 3;
            this.AddSpec_Button.Text = "Додати нову спеціалізацію";
            this.AddSpec_Button.UseVisualStyleBackColor = true;
            this.AddSpec_Button.Click += new System.EventHandler(this.AddSpec_Button_Click);
            // 
            // Graphic_Button
            // 
            this.Graphic_Button.Location = new System.Drawing.Point(236, 458);
            this.Graphic_Button.Name = "Graphic_Button";
            this.Graphic_Button.Size = new System.Drawing.Size(136, 55);
            this.Graphic_Button.TabIndex = 4;
            this.Graphic_Button.Text = "Статистика";
            this.Graphic_Button.UseVisualStyleBackColor = true;
            this.Graphic_Button.Click += new System.EventHandler(this.Graphic_Button_Click);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Ім\'я";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // surnameDataGridViewTextBoxColumn1
            // 
            this.surnameDataGridViewTextBoxColumn1.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn1.HeaderText = "Прізвище";
            this.surnameDataGridViewTextBoxColumn1.Name = "surnameDataGridViewTextBoxColumn1";
            // 
            // patronymicDataGridViewTextBoxColumn1
            // 
            this.patronymicDataGridViewTextBoxColumn1.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn1.HeaderText = "По батькові";
            this.patronymicDataGridViewTextBoxColumn1.Name = "patronymicDataGridViewTextBoxColumn1";
            // 
            // birthDateDataGridViewTextBoxColumn1
            // 
            this.birthDateDataGridViewTextBoxColumn1.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn1.HeaderText = "Дата народження";
            this.birthDateDataGridViewTextBoxColumn1.Name = "birthDateDataGridViewTextBoxColumn1";
            // 
            // addressDataGridViewTextBoxColumn1
            // 
            this.addressDataGridViewTextBoxColumn1.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn1.HeaderText = "Адреса";
            this.addressDataGridViewTextBoxColumn1.Name = "addressDataGridViewTextBoxColumn1";
            // 
            // passportCodeDataGridViewTextBoxColumn1
            // 
            this.passportCodeDataGridViewTextBoxColumn1.DataPropertyName = "PassportCode";
            this.passportCodeDataGridViewTextBoxColumn1.HeaderText = "Код паспорту";
            this.passportCodeDataGridViewTextBoxColumn1.Name = "passportCodeDataGridViewTextBoxColumn1";
            // 
            // phoneNumberDataGridViewTextBoxColumn1
            // 
            this.phoneNumberDataGridViewTextBoxColumn1.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn1.HeaderText = "Номер телефону";
            this.phoneNumberDataGridViewTextBoxColumn1.Name = "phoneNumberDataGridViewTextBoxColumn1";
            // 
            // doctorNameDataGridViewTextBoxColumn
            // 
            this.doctorNameDataGridViewTextBoxColumn.DataPropertyName = "DoctorName";
            this.doctorNameDataGridViewTextBoxColumn.HeaderText = "Ім\'я лікаря";
            this.doctorNameDataGridViewTextBoxColumn.Name = "doctorNameDataGridViewTextBoxColumn";
            // 
            // doctorSurnameataGridViewTextBoxColumn
            // 
            this.doctorSurnameataGridViewTextBoxColumn.DataPropertyName = "DoctorSurname";
            this.doctorSurnameataGridViewTextBoxColumn.HeaderText = "Прізвище лікаря";
            this.doctorSurnameataGridViewTextBoxColumn.Name = "doctorSurnameataGridViewTextBoxColumn";
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 572);
            this.Controls.Add(this.Graphic_Button);
            this.Controls.Add(this.AddSpec_Button);
            this.Controls.Add(this.ShowPatients_Button);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ChangePatient_Button);
            this.Controls.Add(this.ChangeDoctor_Button);
            this.Controls.Add(this.AddDoctor_Button);
            this.Controls.Add(this.ShowDoctors_Button);
            this.Name = "AdministratorForm";
            this.Text = "Головне вікно (Адміністратор)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowDoctors_Button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddDoctor_Button;
        private System.Windows.Forms.Button ChangeDoctor_Button;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button ChangePatient_Button;
        private System.Windows.Forms.Button ShowPatients_Button;
        private System.Windows.Forms.BindingSource doctorModelBindingSource;
        private System.Windows.Forms.BindingSource patientModelBindingSource;
        private System.Windows.Forms.Button AddSpec_Button;
        private System.Windows.Forms.Button Graphic_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specializationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorSurnameataGridViewTextBoxColumn;
    }
}