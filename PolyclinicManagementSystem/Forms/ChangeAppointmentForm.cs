using PolyclinicManagementSystem.DAOs.Interfaces;
using PolyclinicManagementSystem.DAOs;
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
    public partial class ChangeAppointmentForm : Form
    {
        private int _docId;
        private IAppointmentsDao _appointmentsDao;
        private IPatientsDao _patientsDao;

        public ChangeAppointmentForm(int docId)
        {
            InitializeComponent();
            _appointmentsDao = new AppointmentsDao();
            _patientsDao = new PatientsDao();
            _docId = docId;
        }

        private void Change_Button_Click(object sender, EventArgs e)
        {
            if (!_patientsDao.CheckPatient((int)numericUpDown1.Value))
            {
                Error_Label.Text = "Error: Incorrect values!";
                Error_Label.ForeColor = Color.Red;
                return;
            }
            else if(!_appointmentsDao.CheckAppointment((int)numericUpDown2.Value))
            {
                Error_Label.Text = "Error: Incorrect values!";
                Error_Label.ForeColor = Color.Red;
                return;
            }
            else
            {
                Error_Label.Text = "";
                Error_Label.ForeColor = Color.Black;
            }

            AppointmentModel model = new AppointmentModel
            {
                Id = (int)numericUpDown2.Value,
                Date = DateTime.Parse(Date_TextBox.Text),
                DoctorId = _docId,
                PatientId = (int)numericUpDown1.Value
            };

            _appointmentsDao.ChangeAppointment(model);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            AppointmentModel model = _appointmentsDao.GetAppointment((int)numericUpDown2.Value);
            if(model == null)
            {
                Date_TextBox.Text = "";
                numericUpDown1.Value = 0;
                return;
            }
            Date_TextBox.Text = model.Date.ToString();
            numericUpDown1.Value = model.PatientId;
        }
    }
}
