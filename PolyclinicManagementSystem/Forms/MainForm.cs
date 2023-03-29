using PolyclinicManagementSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            DoctorRole_Button.Enabled = false;
        }

        private void AdministratorRole_Button_Click(object sender, EventArgs e)
        {
            LoginAdminForm logAdmin = new LoginAdminForm();
            logAdmin.Show();
            AdministratorRole_Button.Enabled = false;
        }
    }
}