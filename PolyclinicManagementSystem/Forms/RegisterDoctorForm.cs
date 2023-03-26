using PolyclinicManagementSystem.DAOs;
using PolyclinicManagementSystem.DAOs.Interfaces;
using PolyclinicManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PolyclinicManagementSystem
{
    public partial class RegisterDoctorForm : Form
    {
        private IDoctorsDao _doctorsDao;

        private ISpecializationDao _specDao;

        public RegisterDoctorForm()
        {
            InitializeComponent();
            _doctorsDao = new DoctorsDao();
            _specDao = new SpecializationDao();

            Spec_ComboBox.DataSource = _specDao.GetAllSpec();
            Spec_ComboBox.DisplayMember = "Name";
            Spec_ComboBox.ValueMember = "Name";
            Phone_TextBox.MaxLength = 12;
        }

        private void Add_Button_Click(object sender, System.EventArgs e)
        {
            if(!Email_TextBox.Text.Contains("@"))
            {
                Email_TextBox.ForeColor = Color.Red;
                return;
            }
            else
            {
                Email_TextBox.ForeColor = Color.Black;
            }
            DoctorModel model = new DoctorModel
            {
                Name = Name_TextBox.Text,
                Surname = Surname_TextBox.Text,
                Patronymic = Patronymic_TextBox.Text,
                BirthDate = DateTime.Parse(BirthDate_TextBox.Text),
                Address = Adress_TextBox.Text,
                PassportCode = PassportCode_TextBox.Text,
                PhoneNumber = Phone_TextBox.Text,
                Email = Email_TextBox.Text,
                Specialization = Spec_ComboBox.SelectedValue.ToString(),
                Password = Password_TextBox.Text
            };

            _doctorsDao.AddDoctor(model);
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
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}