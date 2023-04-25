using PolyclinicManagementSystem.DAOs;
using PolyclinicManagementSystem.DAOs.Interfaces;
using PolyclinicManagementSystem.Forms;
using System;
using System.Windows.Forms;

namespace PolyclinicManagementSystem
{
    public partial class DoctorForm : Form
    {
        private string _name;

        private string _surname;

        private BindingSource _bindingSource1;

        private BindingSource _bindingSource2;

        private IDoctorsDao _doctorDao;

        private IAppointmentsDao _appointmentsDao;

        public DoctorForm(string name, string surname)
        {
            InitializeComponent();
            _bindingSource1 = new BindingSource();
            _bindingSource2 = new BindingSource();
            _doctorDao = new DoctorsDao();
            _appointmentsDao = new AppointmentsDao();
            _name = name;
            _surname = surname;
        }

        private void ShowPatients_Button_Click(object sender, EventArgs e)
        {
            _bindingSource1.DataSource = _doctorDao.GetAllDoctorPatients(_name, _surname);
            dataGridView1.DataSource = _bindingSource1;
        }

        private void ShowAppointments_Button_Click(object sender, EventArgs e)
        {
            _bindingSource2.DataSource = _appointmentsDao.GetAllAppointments();
            dataGridView2.DataSource = _bindingSource2;
        }

        private void AddAppoint_Button_Click(object sender, EventArgs e)
        {
            AddAppointmentForm addAppointmentForm = new AddAppointmentForm(_name, _surname);
            addAppointmentForm.Show();
        }

        private void ChangeAppoint_Button_Click(object sender, EventArgs e)
        {
            ChangeAppointmentForm changeAppointmentForm = new ChangeAppointmentForm(_name, _surname);
            changeAppointmentForm.Show();
        }

        private void AddPatient_Button_Click_1(object sender, EventArgs e)
        {
            RegisterPatientForm regPatient = new RegisterPatientForm(_name, _surname);
            regPatient.Show();
        }

        private void ShowMyAppoint_Button_Click(object sender, EventArgs e)
        {
            _bindingSource2.DataSource = _appointmentsDao.GetDoctorAppointments(_name, _surname);
            dataGridView2.DataSource = _bindingSource2;
        }

        private void DoctorForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            helpProvider1.HelpNamespace = Consts.ChmFilePath;
            Help.ShowHelp(this, helpProvider1.HelpNamespace, HelpNavigator.Topic, "kontseptsiya__dlya_likarya_.htm");
        }
    }
}