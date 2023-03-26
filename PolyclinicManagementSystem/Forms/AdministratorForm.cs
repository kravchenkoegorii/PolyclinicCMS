using PolyclinicManagementSystem.DAOs;
using PolyclinicManagementSystem.DAOs.Interfaces;
using PolyclinicManagementSystem.Forms;
using System.Windows.Forms;

namespace PolyclinicManagementSystem
{
    public partial class AdministratorForm : Form
    {
        private IDoctorsDao _doctorsDao;

        private IPatientsDao _patientsDao;

        private BindingSource _bindingSource1;

        private BindingSource _bindingSource2;

        public AdministratorForm()
        {
            InitializeComponent();
            _bindingSource1 = new BindingSource();
            _bindingSource2 = new BindingSource();
            _doctorsDao = new DoctorsDao();
            _patientsDao = new PatientsDao();
        }

        private void ShowDoctors_Button_Click(object sender, System.EventArgs e)
        {
            _bindingSource1.DataSource = _doctorsDao.GetAllDoctors();
            dataGridView1.DataSource = _bindingSource1;
        }

        private void ShowPatients_Button_Click(object sender, System.EventArgs e)
        {
            _bindingSource2.DataSource = _patientsDao.GetAllPatients();
            dataGridView2.DataSource = _bindingSource2;
        }

        private void AddDoctor_Button_Click(object sender, System.EventArgs e)
        {
            RegisterDoctorForm form = new RegisterDoctorForm();
            form.Show();
        }

        private void ChangeDoctor_Button_Click(object sender, System.EventArgs e)
        {
            ChangeDoctorForm form = new ChangeDoctorForm();
            form.Show();
        }

        private void ChangePatient_Button_Click(object sender, System.EventArgs e)
        {
            ChangePatientForm form = new ChangePatientForm();
            form.Show();
        }

        private void AddSpec_Button_Click(object sender, System.EventArgs e)
        {
            AddSpecializationForm form = new AddSpecializationForm();
            form.Show();
        }

        private void Graphic_Button_Click(object sender, System.EventArgs e)
        {
            GraphicForm form = new GraphicForm();
            form.Show();
        }
    }
}