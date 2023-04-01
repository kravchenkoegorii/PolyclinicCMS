﻿using PolyclinicManagementSystem.Forms;
using System;
using System.Windows.Forms;

namespace PolyclinicManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void DoctorRole_Button_Click(object sender, EventArgs e)
        {
            LoginDoctorForm docLogin = new LoginDoctorForm();
            docLogin.Show();
        }

        private void AdministratorRole_Button_Click(object sender, EventArgs e)
        {
            LoginAdminForm logAdmin = new LoginAdminForm();
            logAdmin.Show();
        }
    }
}