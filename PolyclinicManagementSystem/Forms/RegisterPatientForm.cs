using PolyclinicManagementSystem.DAOs;
using PolyclinicManagementSystem.Models;
using System;
using System.Windows.Forms;

namespace PolyclinicManagementSystem
{
    public partial class RegisterPatientForm : Form
    {
        private int _docId;
        private IPatientsDao _patientsDao;

        public RegisterPatientForm(int docId)
        {
            InitializeComponent();
            _patientsDao = new PatientsDao();
            _docId = docId;
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
                DoctorId = _docId
            };

            _patientsDao.AddPattient(model);
        }
    }
}