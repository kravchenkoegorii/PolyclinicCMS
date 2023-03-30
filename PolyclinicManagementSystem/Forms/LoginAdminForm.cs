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
                Error_Label.Text = "";
                adminForm.Show();
                Hide();
            }
            else
            {
                Error_Label.ForeColor = Color.Red;
                Error_Label.Text = "Користувач не знайдений!";
            }
        }

        private void Email_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Email_TextBox.Text.Contains("@") || !Email_TextBox.Text.Contains(".") || Email_TextBox.Text == "")
            {
                Email_TextBox.ForeColor = Color.Red;
            }
            else
            {
                Email_TextBox.ForeColor = Color.Black;
            }
        }

        private void Password_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Password_TextBox.Text.Length < 5 || Password_TextBox.Text.Length > 20)
            {
                Password_TextBox.ForeColor = Color.Red;
            }
            else
            {
                Password_TextBox.ForeColor = Color.Black;
            }
        }
    }
}
