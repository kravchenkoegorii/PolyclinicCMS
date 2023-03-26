using PolyclinicManagementSystem.DAOs;
using PolyclinicManagementSystem.DAOs.Interfaces;
using PolyclinicManagementSystem.Models;
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
    public partial class AddAppointmentForm : Form
    {
        private int _docId;
        private IAppointmentsDao _appointmentsDao;
        private IPatientsDao _patientsDao;

        public AddAppointmentForm(int docId)
        {
            InitializeComponent();
            _appointmentsDao = new AppointmentsDao();
            _patientsDao = new PatientsDao();
            _docId = docId;
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (!_patientsDao.CheckPatient((int)numericUpDown1.Value))
            {
                Error_Label.Text = "Error: Patient does not exist!";
                Error_Label.ForeColor = Color.Red;
                return;
            }
            else
            {
                Error_Label.Text = "";
                Error_Label.ForeColor = Color.Black;
            }

            var date = DateTime.Parse(Date_TextBox.Text);
            var appointments = _appointmentsDao.GetDoctorAppointments(_docId);

            foreach(var item in appointments)
            {
                if (item.Date.Day == date.Day && item.Date.Month == date.Month && date.Hour != item.Date.Hour)
                {
                    if(date.Minute == 0 && date.Second == 0)
                    {
                        if (date.Hour >= 7 && date.Hour <= 20)
                        {
                            Date_TextBox.ForeColor = Color.Black;
                            Error_Label.Text = "";
                        }
                        else
                        {
                            Date_TextBox.ForeColor = Color.Red;
                            Error_Label.Text = "Error: time is incorrect!";
                            return;
                        }
                    }
                    else
                    {
                        Date_TextBox.ForeColor = Color.Red;
                        Error_Label.Text = "Error: time is incorrect!";
                        return;
                    }
                }
                else
                {
                    Date_TextBox.ForeColor = Color.Red;
                    Error_Label.Text = "Error: time is incorrect!";
                    return;
                }
            }

            if(appointments.Count == 0)
            {
                if (date.Minute == 0 && date.Second == 0)
                {
                    if (date.Hour >= 7 && date.Hour <= 20)
                    {
                        Date_TextBox.ForeColor = Color.Black;
                        Error_Label.Text = "";
                    }
                    else
                    {
                        Date_TextBox.ForeColor = Color.Red;
                        Error_Label.Text = "Error: time is incorrect!";
                        return;
                    }
                }
                else
                {
                    Date_TextBox.ForeColor = Color.Red;
                    Error_Label.Text = "Error: time is incorrect!";
                    return;
                }
            }

            AppointmentModel model = new AppointmentModel
            {
                Id = (_appointmentsDao.GetAppointmentsCount() + 1),
                Date = date,
                DoctorId = _docId,
                PatientId = (int)numericUpDown1.Value
            };

            _appointmentsDao.AddAppointment(model);
        }
    }
}
