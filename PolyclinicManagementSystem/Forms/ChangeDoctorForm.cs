using PolyclinicManagementSystem.DAOs;
using PolyclinicManagementSystem.DAOs.Interfaces;
using PolyclinicManagementSystem.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PolyclinicManagementSystem.Forms
{
    public partial class ChangeDoctorForm : Form
    {
        private IDoctorsDao _doctorsDao;

        private ISpecializationDao _specDao;

        private bool _isFound = false;

        public ChangeDoctorForm()
        {
            InitializeComponent();
            _doctorsDao = new DoctorsDao();
            _specDao = new SpecializationDao();

            Spec_ComboBox.DataSource = _specDao.GetAllSpec();
            Spec_ComboBox.DisplayMember = "Name";
            Spec_ComboBox.ValueMember = "Name";
            Spec_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Spec_ComboBox.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_isFound == false)
            {
                return;
            }

            DoctorModel model = new DoctorModel
            {
                Name = Name_TextBox.Text,
                Surname = Surname_TextBox.Text,
                Address = Address_TextBox.Text,
                PhoneNumber = Phone_TextBox.Text,
                Email = Email_TextBox.Text,
                Specialization = Spec_ComboBox.SelectedValue.ToString()
            };

            _doctorsDao.ChangeDoctor(model);

            Hide();
        }

        private void Phone_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '+'))
            {
                e.Handled = true;
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

        private void Email_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Email_TextBox.Text.Contains("@") || !Email_TextBox.Text.Contains(".") || Email_TextBox.Text == "")
            {
                Email_TextBox.ForeColor = Color.Red;
            }
            else
            {
                Email_TextBox.ForeColor = Color.Black;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var doctor = _doctorsDao.GetDoctor(Name_TextBox.Text, Surname_TextBox.Text);
            if (string.IsNullOrEmpty(doctor.Name) || string.IsNullOrEmpty(doctor.Surname))
            {
                Name_TextBox.ForeColor = Color.Red;
                Surname_TextBox.ForeColor = Color.Red;
                _isFound = false;
                return;
            }
            else
            {
                Name_TextBox.ForeColor = Color.Green;
                Surname_TextBox.ForeColor = Color.Green;
                Name_TextBox.Enabled = false;
                Surname_TextBox.Enabled = false;
                _isFound = true;

                Address_TextBox.Text = doctor.Address;
                Phone_TextBox.Text = doctor.PhoneNumber;
                Email_TextBox.Text = doctor.Email;
                Spec_ComboBox.SelectedValue = doctor.Specialization;
            }
        }

        private void ChangeDoctorForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            helpProvider1.HelpNamespace = "file://C:\\Users\\kravc\\OneDrive\\Рабочий стол\\PolyclinicManagementSystem\\МояПоліклініка.chm";
            Help.ShowHelp(this, helpProvider1.HelpNamespace, HelpNavigator.Topic, "funktsional__dlya_administratora_.htm#5");
        }
    }
}
