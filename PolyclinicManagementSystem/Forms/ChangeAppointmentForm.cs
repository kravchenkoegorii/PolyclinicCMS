using PolyclinicManagementSystem.DAOs;
using PolyclinicManagementSystem.DAOs.Interfaces;
using PolyclinicManagementSystem.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PolyclinicManagementSystem.Forms
{
    public partial class ChangeAppointmentForm : Form
    {
        private bool _checkDate;

        private bool _checkPat;

        private string _name;

        private string _surname;

        private IAppointmentsDao _appointmentsDao;

        private IPatientsDao _patientsDao;

        private IDoctorsDao _doctorsDao;

        public ChangeAppointmentForm(string name, string surname)
        {
            InitializeComponent();
            _appointmentsDao = new AppointmentsDao();
            _patientsDao = new PatientsDao();
            _doctorsDao = new DoctorsDao();
            _name = name;
            _surname = surname;
        }

        private void Change_Button_Click_1(object sender, EventArgs e)
        {
            if (_checkDate == false && _checkPat == false)
            {
                Error_Label.ForeColor = Color.Red;
                Error_Label.Text = "Помилка: перевірте значення всіх полів!";
                return;
            }
            else
            {
                Error_Label.Text = "";
            }

            AppointmentModel model = new AppointmentModel
            {
                Date = DateTime.Parse(Date_TextBox.Text),
                DoctorName = _name,
                DoctorSurname = _surname,
                PatientName = PatName_TextBox.Text,
                PatientSurname = PatSurname_TextBox.Text
            };

            _appointmentsDao.ChangeAppointment(model);

            Hide();
        }

        private void CheckDate_Button_Click(object sender, EventArgs e)
        {
            var date = DateTime.Parse(Date_TextBox.Text);
            var appointments = _appointmentsDao.GetDoctorAppointments(_name, _surname);

            foreach (var item in appointments)
            {
                if (item.Date.Day == date.Day && item.Date.Month == date.Month && date.Hour != item.Date.Hour)
                {
                    if (date.Minute == 0 && date.Second == 0)
                    {
                        if (date.Hour >= 7 && date.Hour <= 20)
                        {
                            Date_TextBox.ForeColor = Color.Green;
                            _checkDate = true;
                        }
                        else
                        {
                            Date_TextBox.ForeColor = Color.Red;
                            _checkDate = false;
                            return;
                        }
                    }
                    else
                    {
                        Date_TextBox.ForeColor = Color.Red;
                        _checkDate = false;
                        return;
                    }
                }
                else
                {
                    Date_TextBox.ForeColor = Color.Red;
                    _checkDate = false;
                    return;
                }
            }

            if (appointments.Count == 0)
            {
                if (date.Minute == 0 && date.Second == 0)
                {
                    if (date.Hour >= 7 && date.Hour <= 20)
                    {
                        Date_TextBox.ForeColor = Color.Green;
                        _checkDate = true;
                    }
                    else
                    {
                        Date_TextBox.ForeColor = Color.Red;
                        _checkDate = false;
                        return;
                    }
                }
                else
                {
                    Date_TextBox.ForeColor = Color.Red;
                    _checkDate = false;
                    return;
                }
            }
        }

        private void CheckPatient_Button_Click(object sender, EventArgs e)
        {
            if (!_patientsDao.CheckPatient(PatName_TextBox.Text, PatSurname_TextBox.Text))
            {
                PatName_TextBox.ForeColor = Color.Red;
                PatSurname_TextBox.ForeColor = Color.Red;
                _checkPat = false;
            }
            else
            {
                PatName_TextBox.ForeColor = Color.Green;
                PatSurname_TextBox.ForeColor = Color.Green;
                _checkPat = true;
            }
        }

        private void PatName_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (PatName_TextBox.Text.Length <= 1 || PatName_TextBox.Text.Any(c => char.IsDigit(c)))
            {
                PatName_TextBox.ForeColor = Color.Red;
            }
            else
            {
                PatName_TextBox.ForeColor = Color.Black;
            }
        }

        private void PatSurname_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (PatSurname_TextBox.Text.Length <= 1 || PatSurname_TextBox.Text.Any(c => char.IsDigit(c)))
            {
                PatSurname_TextBox.ForeColor = Color.Red;
            }
            else
            {
                PatSurname_TextBox.ForeColor = Color.Black;
            }
        }
    }
}
