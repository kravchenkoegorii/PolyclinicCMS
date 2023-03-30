using PolyclinicManagementSystem.DAOs;
using PolyclinicManagementSystem.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PolyclinicManagementSystem
{
    public partial class RegisterPatientForm : Form
    {
        private string _name;

        private string _surname;

        private IPatientsDao _patientsDao;

        private IDoctorsDao _doctorsDao;

        public RegisterPatientForm(string name, string surname)
        {
            InitializeComponent();
            _patientsDao = new PatientsDao();
            _doctorsDao = new DoctorsDao();
            _name = name;
            _surname = surname;
        }

        private void Add_Button_Click(object sender, System.EventArgs e)
        {
            PatientModel model = new PatientModel
            {
                Id = _patientsDao.GetPatientsCount() + 1,
                Name = Name_TextBox.Text,
                Surname = Surname_TextBox.Text,
                Patronymic = Patronymic_TextBox.Text,
                BirthDate = DateTime.Parse(BirthDate_TextBox.Text),
                Address = Adress_TextBox.Text,
                PassportCode = PassportCode_TextBox.Text,
                PhoneNumber = Phone_TextBox.Text,
                DoctorName = _name,
                DoctorSurname = _surname
            };

            _patientsDao.AddPattient(model);

            Hide();
        }

        private void Name_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Name_TextBox.Text.Length <= 1 || Name_TextBox.Text.Any(c => char.IsDigit(c)))
            {
                Name_TextBox.ForeColor = Color.Red;
            }
            else
            {
                Name_TextBox.ForeColor = Color.Black;
            }
        }

        private void Surname_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Surname_TextBox.Text.Length <= 1 || Surname_TextBox.Text.Any(c => char.IsDigit(c)))
            {
                Surname_TextBox.ForeColor = Color.Red;
            }
            else
            {
                Surname_TextBox.ForeColor = Color.Black;
            }
        }

        private void Patronymic_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Patronymic_TextBox.Text.Length <= 1 || Patronymic_TextBox.Text.Any(c => char.IsDigit(c)))
            {
                Patronymic_TextBox.ForeColor = Color.Red;
            }
            else
            {
                Patronymic_TextBox.ForeColor = Color.Black;
            }
        }

        private void PassportCode_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (PassportCode_TextBox.Text.Length != 9)
            {
                PassportCode_TextBox.ForeColor = Color.Red;
            }
            else
            {
                PassportCode_TextBox.ForeColor = Color.Black;
            }
        }

        private void Phone_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Phone_TextBox.Text.Contains("+380") || Phone_TextBox.Text.Length != 13)
            {
                Phone_TextBox.ForeColor = Color.Red;
            }
            else
            {
                Phone_TextBox.ForeColor = Color.Black;
            }
        }

        private void PassportCode_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Phone_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '+'))
            {
                e.Handled = true;
            }
        }
    }
}