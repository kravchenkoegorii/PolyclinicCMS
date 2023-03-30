using PolyclinicManagementSystem.DAOs;
using PolyclinicManagementSystem.DAOs.Interfaces;
using PolyclinicManagementSystem.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PolyclinicManagementSystem.Forms
{
    public partial class AddAppointmentForm : Form
    {
        private bool _checkDate;

        private bool _checkDoc;

        private bool _checkPat;

        private string _name;

        private string _surname;

        private IAppointmentsDao _appointmentsDao;

        private IPatientsDao _patientsDao;

        private IDoctorsDao _doctorsDao;

        public AddAppointmentForm(string name, string surname)
        {
            InitializeComponent();
            _appointmentsDao = new AppointmentsDao();
            _patientsDao = new PatientsDao();
            _doctorsDao = new DoctorsDao();
            _name = name;
            _surname = surname;
            DocName_TextBox.Text = _name;
            DocSurname_TextBox.Text = _surname;
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (_checkDate == false || _checkDoc == false || _checkPat == false)
            {
                Error_Label.ForeColor = Color.Red;
                Error_Label.Text = "Помилка: перевірте значення всіх полів!";
                return;
            }
            else
            {
                Error_Label.Text = "";
            }

            var date = DateTime.Parse(Date_TextBox.Text);

            AppointmentModel model = new AppointmentModel
            {
                Id = (_appointmentsDao.GetAppointmentsCount() + 1),
                Date = date,
                DoctorName = DocName_TextBox.Text,
                DoctorSurname = DocSurname_TextBox.Text,
                PatientName = PatName_TextBox.Text,
                PatientSurname = PatSurname_TextBox.Text
            };

            _appointmentsDao.AddAppointment(model);

            Hide();
        }

        private void CheckDoctor_Button_Click(object sender, EventArgs e)
        {
            if (!_doctorsDao.CheckDoctor(DocName_TextBox.Text, DocSurname_TextBox.Text))
            {
                DocName_TextBox.ForeColor = Color.Red;
                DocSurname_TextBox.ForeColor = Color.Red;
                _checkDoc = false;
            }
            else
            {
                DocName_TextBox.ForeColor = Color.Green;
                DocSurname_TextBox.ForeColor = Color.Green;
                _checkDoc = true;
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

        private void CheckDate_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Date_TextBox.Text))
            {
                return;
            }
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

        private void DocName_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (DocName_TextBox.Text.Length <= 1 || DocName_TextBox.Text.Any(c => char.IsDigit(c)))
            {
                DocName_TextBox.ForeColor = Color.Red;
            }
            else
            {
                DocName_TextBox.ForeColor = Color.Black;
            }
        }

        private void DocSurname_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (DocSurname_TextBox.Text.Length <= 1 || DocSurname_TextBox.Text.Any(c => char.IsDigit(c)))
            {
                DocSurname_TextBox.ForeColor = Color.Red;
            }
            else
            {
                DocSurname_TextBox.ForeColor = Color.Black;
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
