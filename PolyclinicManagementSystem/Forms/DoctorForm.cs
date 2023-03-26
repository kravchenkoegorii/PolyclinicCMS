using PolyclinicManagementSystem.DAOs;
using PolyclinicManagementSystem.DAOs.Interfaces;
using PolyclinicManagementSystem.Forms;
using System;
using System.Windows.Forms;

namespace PolyclinicManagementSystem
{
    public partial class DoctorForm : Form
    {
        private int _docId;
        private BindingSource _bindingSource1;
        private BindingSource _bindingSource2;
        private IDoctorsDao _doctorDao;
        private IAppointmentsDao _appointmentsDao;

        public DoctorForm(int docId)
        {
            InitializeComponent();
            _bindingSource1 = new BindingSource();
            _bindingSource2 = new BindingSource();
            _doctorDao = new DoctorsDao();
            _appointmentsDao = new AppointmentsDao();
            _docId = docId;
        }

        private void ShowPatients_Button_Click(object sender, EventArgs e)
        {
            _bindingSource1.DataSource = _doctorDao.GetAllDoctorPatients(_docId.ToString());
            dataGridView1.DataSource = _bindingSource1;
        }

        private void ShowAppointments_Button_Click(object sender, EventArgs e)
        {
            _bindingSource2.DataSource = _appointmentsDao.GetDoctorAppointments(_docId);
            dataGridView2.DataSource = _bindingSource2;
        }

        private void AddAppoint_Button_Click(object sender, EventArgs e)
        {
            AddAppointmentForm addAppointmentForm = new AddAppointmentForm(_docId);
            addAppointmentForm.Show();
        }

        private void ChangeAppoint_Button_Click(object sender, EventArgs e)
        {
            ChangeAppointmentForm changeAppointmentForm = new ChangeAppointmentForm(_docId);
            changeAppointmentForm.Show();
        }

        private void AddPatient_Button_Click_1(object sender, EventArgs e)
        {
            RegisterPatientForm regPatient = new RegisterPatientForm(_docId);
            regPatient.Show();
        }
    }
}