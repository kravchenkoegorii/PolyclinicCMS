using PolyclinicManagementSystem.DAOs;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PolyclinicManagementSystem
{
    public partial class LoginDoctorForm : Form
    {
        private IDoctorsDao _doctorsDao;

        public LoginDoctorForm()
        {
            InitializeComponent();
            _doctorsDao = new DoctorsDao();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            if (_doctorsDao.LoginDoctor(Email_TextBox.Text, Password_TextBox.Text))
            {
                DoctorForm doctorForm = new DoctorForm(_doctorsDao.GetName(), _doctorsDao.GetSurname());
                Error_Label.Text = "";
                doctorForm.Show();
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

        private void label2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "МояПоліклініка.chm/glosarij.htm#2");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "МояПоліклініка.chm::/glosarij.htm#3");
        }
    }
}