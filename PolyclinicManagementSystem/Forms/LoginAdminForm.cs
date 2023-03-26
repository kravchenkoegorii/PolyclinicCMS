using PolyclinicManagementSystem.DAOs;
using PolyclinicManagementSystem.DAOs.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolyclinicManagementSystem.Forms
{
    public partial class LoginAdminForm : Form
    {
        private IAdministratorDao _administratorDao;

        public LoginAdminForm()
        {
            InitializeComponent();
            _administratorDao = new AdministratorDao();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            if (_administratorDao.LoginAdmin(Email_TextBox.Text, Password_TextBox.Text))
            {
                AdministratorForm adminForm = new AdministratorForm();
                Email_TextBox.ForeColor = Color.Black;
                Password_TextBox.ForeColor = Color.Black;
                Error_Label.Text = "";
                adminForm.Show();
            }
            else
            {
                Email_TextBox.ForeColor = Color.Red;
                Password_TextBox.ForeColor = Color.Red;
                Error_Label.ForeColor = Color.Red;
                Error_Label.Text = "INCORRECT VALUES!";
            }
        }
    }
}
