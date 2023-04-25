using PolyclinicManagementSystem.Forms;
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

        private void MainForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            helpProvider1.HelpNamespace = Consts.ChmFilePath;
            Help.ShowHelp(this, helpProvider1.HelpNamespace, HelpNavigator.Topic, "pochatkova_forma.htm");
        }
    }
}