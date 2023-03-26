using System.ComponentModel;

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
            this.ShowAppointments_Button = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.AddAppoint_Button = new System.Windows.Forms.Button();
            this.ChangeAppoint_Button = new System.Windows.Forms.Button();
            this.AddPatient_Button = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientModelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowPatients_Button
            // 
            this.ShowPatients_Button.Location = new System.Drawing.Point(153, 12);
            this.ShowPatients_Button.Name = "ShowPatients_Button";
            this.ShowPatients_Button.Size = new System.Drawing.Size(171, 45);
            this.ShowPatients_Button.TabIndex = 0;
            this.ShowPatients_Button.Text = "Show patients";
            this.ShowPatients_Button.UseVisualStyleBackColor = true;
            this.ShowPatients_Button.Click += new System.EventHandler(this.ShowPatients_Button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.passportCodeDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.doctorIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientModelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 168);
            this.dataGridView1.TabIndex = 1;
            // 
            // ShowAppointments_Button
            // 
            this.ShowAppointments_Button.Location = new System.Drawing.Point(299, 248);
            this.ShowAppointments_Button.Name = "ShowAppointments_Button";
            this.ShowAppointments_Button.Size = new System.Drawing.Size(171, 45);
            this.ShowAppointments_Button.TabIndex = 2;
            this.ShowAppointments_Button.Text = "Show appointments";
            this.ShowAppointments_Button.UseVisualStyleBackColor = true;
            this.ShowAppointments_Button.Click += new System.EventHandler(this.ShowAppointments_Button_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn,
            this.doctorIdDataGridViewTextBoxColumn1,
            this.patientIdDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.appointmentModelBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(161, 299);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(442, 168);
            this.dataGridView2.TabIndex = 1;
            // 
            // AddAppoint_Button
            // 
            this.AddAppoint_Button.Location = new System.Drawing.Point(161, 473);
            this.AddAppoint_Button.Name = "AddAppoint_Button";
            this.AddAppoint_Button.Size = new System.Drawing.Size(163, 32);
            this.AddAppoint_Button.TabIndex = 3;
            this.AddAppoint_Button.Text = "Add appointment";
            this.AddAppoint_Button.UseVisualStyleBackColor = true;
            this.AddAppoint_Button.Click += new System.EventHandler(this.AddAppoint_Button_Click);
            // 
            // ChangeAppoint_Button
            // 
            this.ChangeAppoint_Button.Location = new System.Drawing.Point(440, 473);
            this.ChangeAppoint_Button.Name = "ChangeAppoint_Button";
            this.ChangeAppoint_Button.Size = new System.Drawing.Size(163, 32);
            this.ChangeAppoint_Button.TabIndex = 3;
            this.ChangeAppoint_Button.Text = "Change appointment";
            this.ChangeAppoint_Button.UseVisualStyleBackColor = true;
            this.ChangeAppoint_Button.Click += new System.EventHandler(this.ChangeAppoint_Button_Click);
            // 
            // AddPatient_Button
            // 
            this.AddPatient_Button.Location = new System.Drawing.Point(453, 13);
            this.AddPatient_Button.Name = "AddPatient_Button";
            this.AddPatient_Button.Size = new System.Drawing.Size(171, 44);
            this.AddPatient_Button.TabIndex = 4;
            this.AddPatient_Button.Text = "Add patient";
            this.AddPatient_Button.UseVisualStyleBackColor = true;
            this.AddPatient_Button.Click += new System.EventHandler(this.AddPatient_Button_Click_1);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // doctorIdDataGridViewTextBoxColumn1
            // 
            this.doctorIdDataGridViewTextBoxColumn1.DataPropertyName = "DoctorId";
            this.doctorIdDataGridViewTextBoxColumn1.HeaderText = "DoctorId";
            this.doctorIdDataGridViewTextBoxColumn1.Name = "doctorIdDataGridViewTextBoxColumn1";
            // 
            // patientIdDataGridViewTextBoxColumn
            // 
            this.patientIdDataGridViewTextBoxColumn.DataPropertyName = "PatientId";
            this.patientIdDataGridViewTextBoxColumn.HeaderText = "PatientId";
            this.patientIdDataGridViewTextBoxColumn.Name = "patientIdDataGridViewTextBoxColumn";
            // 
            // appointmentModelBindingSource
            // 
            this.appointmentModelBindingSource.DataSource = typeof(PolyclinicManagementSystem.Models.AppointmentModel);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // passportCodeDataGridViewTextBoxColumn
            // 
            this.passportCodeDataGridViewTextBoxColumn.DataPropertyName = "PassportCode";
            this.passportCodeDataGridViewTextBoxColumn.HeaderText = "PassportCode";
            this.passportCodeDataGridViewTextBoxColumn.Name = "passportCodeDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // doctorIdDataGridViewTextBoxColumn
            // 
            this.doctorIdDataGridViewTextBoxColumn.DataPropertyName = "DoctorId";
            this.doctorIdDataGridViewTextBoxColumn.HeaderText = "DoctorId";
            this.doctorIdDataGridViewTextBoxColumn.Name = "doctorIdDataGridViewTextBoxColumn";
            // 
            // patientModelBindingSource
            // 
            this.patientModelBindingSource.DataSource = typeof(PolyclinicManagementSystem.Models.PatientModel);
            // 
            // patientModelBindingSource1
            // 
            this.patientModelBindingSource1.DataSource = typeof(PolyclinicManagementSystem.Models.PatientModel);
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 523);
            this.Controls.Add(this.AddPatient_Button);
            this.Controls.Add(this.ChangeAppoint_Button);
            this.Controls.Add(this.AddAppoint_Button);
            this.Controls.Add(this.ShowAppointments_Button);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ShowPatients_Button);
            this.Name = "DoctorForm";
            this.Text = "DoctorForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientModelBindingSource1)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button AddAppoint_Button;
        private System.Windows.Forms.Button ChangeAppoint_Button;
        private System.Windows.Forms.Button AddPatient_Button;
    }
}