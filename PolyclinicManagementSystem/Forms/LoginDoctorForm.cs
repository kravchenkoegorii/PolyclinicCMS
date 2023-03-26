using System;
using System.Drawing;
using System.Windows.Forms;
using PolyclinicManagementSystem.DAOs;

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
                DoctorForm doctorForm = new DoctorForm(_doctorsDao.GetSessionId());
                Email_TextBox.ForeColor = Color.Black;
                Password_TextBox.ForeColor = Color.Black;
                Error_Label.Text = "";
                doctorForm.Show();
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