﻿using System.ComponentModel;

namespace PolyclinicManagementSystem
{
    partial class DoctorForm
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
            this.ShowPatients_Button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ShowAppointments_Button = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentModelBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.AddAppoint_Button = new System.Windows.Forms.Button();
            this.ChangeAppoint_Button = new System.Windows.Forms.Button();
            this.AddPatient_Button = new System.Windows.Forms.Button();
            this.ShowMyAppoint_Button = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.appointmentModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentModelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentModelBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentModelBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentModelBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentModelBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowPatients_Button
            // 
            this.helpProvider1.SetHelpKeyword(this.ShowPatients_Button, "funktsional__dlya_likarya_.htm#7");
            this.helpProvider1.SetHelpNavigator(this.ShowPatients_Button, System.Windows.Forms.HelpNavigator.Topic);
            this.ShowPatients_Button.Location = new System.Drawing.Point(277, 12);
            this.ShowPatients_Button.Name = "ShowPatients_Button";
            this.helpProvider1.SetShowHelp(this.ShowPatients_Button, true);
            this.ShowPatients_Button.Size = new System.Drawing.Size(171, 45);
            this.ShowPatients_Button.TabIndex = 0;
            this.ShowPatients_Button.Text = "Переглянути всіх пацієнтів";
            this.ShowPatients_Button.UseVisualStyleBackColor = true;
            this.ShowPatients_Button.Click += new System.EventHandler(this.ShowPatients_Button_Click);
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
            this.phoneNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientModelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(79, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 168);
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
            // patientModelBindingSource
            // 
            this.patientModelBindingSource.DataSource = typeof(PolyclinicManagementSystem.Models.PatientModel);
            // 
            // ShowAppointments_Button
            // 
            this.helpProvider1.SetHelpKeyword(this.ShowAppointments_Button, "funktsional__dlya_likarya_.htm#9");
            this.helpProvider1.SetHelpNavigator(this.ShowAppointments_Button, System.Windows.Forms.HelpNavigator.Topic);
            this.ShowAppointments_Button.Location = new System.Drawing.Point(277, 248);
            this.ShowAppointments_Button.Name = "ShowAppointments_Button";
            this.helpProvider1.SetShowHelp(this.ShowAppointments_Button, true);
            this.ShowAppointments_Button.Size = new System.Drawing.Size(171, 45);
            this.ShowAppointments_Button.TabIndex = 2;
            this.ShowAppointments_Button.Text = "Показати всі записи";
            this.ShowAppointments_Button.UseVisualStyleBackColor = true;
            this.ShowAppointments_Button.Click += new System.EventHandler(this.ShowAppointments_Button_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.doctorNameDataGridViewTextBoxColumn,
            this.doctorSurnameDataGridViewTextBoxColumn,
            this.patientNameDataGridViewTextBoxColumn,
            this.patientSurnameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.appointmentModelBindingSource4;
            this.dataGridView2.Location = new System.Drawing.Point(162, 299);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(544, 168);
            this.dataGridView2.TabIndex = 1;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата та час";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // doctorNameDataGridViewTextBoxColumn
            // 
            this.doctorNameDataGridViewTextBoxColumn.DataPropertyName = "DoctorName";
            this.doctorNameDataGridViewTextBoxColumn.HeaderText = "Ім\'я лікаря";
            this.doctorNameDataGridViewTextBoxColumn.Name = "doctorNameDataGridViewTextBoxColumn";
            // 
            // doctorSurnameDataGridViewTextBoxColumn
            // 
            this.doctorSurnameDataGridViewTextBoxColumn.DataPropertyName = "DoctorSurname";
            this.doctorSurnameDataGridViewTextBoxColumn.HeaderText = "Прізвище лікаря";
            this.doctorSurnameDataGridViewTextBoxColumn.Name = "doctorSurnameDataGridViewTextBoxColumn";
            // 
            // patientNameDataGridViewTextBoxColumn
            // 
            this.patientNameDataGridViewTextBoxColumn.DataPropertyName = "PatientName";
            this.patientNameDataGridViewTextBoxColumn.HeaderText = "Ім\'я пацієнта";
            this.patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            // 
            // patientSurnameDataGridViewTextBoxColumn
            // 
            this.patientSurnameDataGridViewTextBoxColumn.DataPropertyName = "PatientSurname";
            this.patientSurnameDataGridViewTextBoxColumn.HeaderText = "Прізвище пацієнта";
            this.patientSurnameDataGridViewTextBoxColumn.Name = "patientSurnameDataGridViewTextBoxColumn";
            // 
            // appointmentModelBindingSource4
            // 
            this.appointmentModelBindingSource4.DataSource = typeof(PolyclinicManagementSystem.Models.AppointmentModel);
            // 
            // AddAppoint_Button
            // 
            this.helpProvider1.SetHelpKeyword(this.AddAppoint_Button, "funktsional__dlya_likarya_.htm#11");
            this.helpProvider1.SetHelpNavigator(this.AddAppoint_Button, System.Windows.Forms.HelpNavigator.Topic);
            this.AddAppoint_Button.Location = new System.Drawing.Point(277, 479);
            this.AddAppoint_Button.Name = "AddAppoint_Button";
            this.helpProvider1.SetShowHelp(this.AddAppoint_Button, true);
            this.AddAppoint_Button.Size = new System.Drawing.Size(171, 32);
            this.AddAppoint_Button.TabIndex = 3;
            this.AddAppoint_Button.Text = "Записати пацієнта";
            this.AddAppoint_Button.UseVisualStyleBackColor = true;
            this.AddAppoint_Button.Click += new System.EventHandler(this.AddAppoint_Button_Click);
            // 
            // ChangeAppoint_Button
            // 
            this.helpProvider1.SetHelpKeyword(this.ChangeAppoint_Button, "funktsional__dlya_likarya_.htm#12");
            this.helpProvider1.SetHelpNavigator(this.ChangeAppoint_Button, System.Windows.Forms.HelpNavigator.Topic);
            this.ChangeAppoint_Button.Location = new System.Drawing.Point(457, 479);
            this.ChangeAppoint_Button.Name = "ChangeAppoint_Button";
            this.helpProvider1.SetShowHelp(this.ChangeAppoint_Button, true);
            this.ChangeAppoint_Button.Size = new System.Drawing.Size(177, 32);
            this.ChangeAppoint_Button.TabIndex = 3;
            this.ChangeAppoint_Button.Text = "Змінити мій запис";
            this.ChangeAppoint_Button.UseVisualStyleBackColor = true;
            this.ChangeAppoint_Button.Click += new System.EventHandler(this.ChangeAppoint_Button_Click);
            // 
            // AddPatient_Button
            // 
            this.helpProvider1.SetHelpKeyword(this.AddPatient_Button, "funktsional__dlya_likarya_.htm#8");
            this.helpProvider1.SetHelpNavigator(this.AddPatient_Button, System.Windows.Forms.HelpNavigator.Topic);
            this.AddPatient_Button.Location = new System.Drawing.Point(457, 13);
            this.AddPatient_Button.Name = "AddPatient_Button";
            this.helpProvider1.SetShowHelp(this.AddPatient_Button, true);
            this.AddPatient_Button.Size = new System.Drawing.Size(177, 44);
            this.AddPatient_Button.TabIndex = 4;
            this.AddPatient_Button.Text = "Додати нового пацієнта";
            this.AddPatient_Button.UseVisualStyleBackColor = true;
            this.AddPatient_Button.Click += new System.EventHandler(this.AddPatient_Button_Click_1);
            // 
            // ShowMyAppoint_Button
            // 
            this.helpProvider1.SetHelpKeyword(this.ShowMyAppoint_Button, "funktsional__dlya_likarya_.htm#10");
            this.helpProvider1.SetHelpNavigator(this.ShowMyAppoint_Button, System.Windows.Forms.HelpNavigator.Topic);
            this.ShowMyAppoint_Button.Location = new System.Drawing.Point(457, 248);
            this.ShowMyAppoint_Button.Name = "ShowMyAppoint_Button";
            this.helpProvider1.SetShowHelp(this.ShowMyAppoint_Button, true);
            this.ShowMyAppoint_Button.Size = new System.Drawing.Size(177, 45);
            this.ShowMyAppoint_Button.TabIndex = 5;
            this.ShowMyAppoint_Button.Text = "Показати мої записи";
            this.ShowMyAppoint_Button.UseVisualStyleBackColor = true;
            this.ShowMyAppoint_Button.Click += new System.EventHandler(this.ShowMyAppoint_Button_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\kravc\\OneDrive\\Рабочий стол\\PolyclinicManagementSystem\\МояПоліклініка.ch" +
    "m";
            // 
            // appointmentModelBindingSource
            // 
            this.appointmentModelBindingSource.DataSource = typeof(PolyclinicManagementSystem.Models.AppointmentModel);
            // 
            // patientModelBindingSource1
            // 
            this.patientModelBindingSource1.DataSource = typeof(PolyclinicManagementSystem.Models.PatientModel);
            // 
            // appointmentModelBindingSource1
            // 
            this.appointmentModelBindingSource1.DataSource = typeof(PolyclinicManagementSystem.Models.AppointmentModel);
            // 
            // appointmentModelBindingSource2
            // 
            this.appointmentModelBindingSource2.DataSource = typeof(PolyclinicManagementSystem.Models.AppointmentModel);
            // 
            // appointmentModelBindingSource3
            // 
            this.appointmentModelBindingSource3.DataSource = typeof(PolyclinicManagementSystem.Models.AppointmentModel);
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 523);
            this.Controls.Add(this.ShowMyAppoint_Button);
            this.Controls.Add(this.AddPatient_Button);
            this.Controls.Add(this.ChangeAppoint_Button);
            this.Controls.Add(this.AddAppoint_Button);
            this.Controls.Add(this.ShowAppointments_Button);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ShowPatients_Button);
            this.HelpButton = true;
            this.helpProvider1.SetHelpKeyword(this, "kontseptsiya__dlya_likarya_.htm#1");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoctorForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Головне вікно (Лікар)";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.DoctorForm_HelpButtonClicked);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentModelBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentModelBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentModelBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button ShowPatients_Button;

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource patientModelBindingSource;
        private System.Windows.Forms.BindingSource patientModelBindingSource1;
        private System.Windows.Forms.Button ShowAppointments_Button;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource appointmentModelBindingSource;
        private System.Windows.Forms.Button AddAppoint_Button;
        private System.Windows.Forms.Button ChangeAppoint_Button;
        private System.Windows.Forms.Button AddPatient_Button;
        private System.Windows.Forms.BindingSource appointmentModelBindingSource2;
        private System.Windows.Forms.BindingSource appointmentModelBindingSource1;
        private System.Windows.Forms.BindingSource appointmentModelBindingSource3;
        private System.Windows.Forms.Button ShowMyAppoint_Button;
        private System.Windows.Forms.BindingSource appointmentModelBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}