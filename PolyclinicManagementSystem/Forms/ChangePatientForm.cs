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
    public partial class ChangePatientForm : Form
    {
        private IPatientsDao _patientsDao;

        private bool _isFound = false;

        public ChangePatientForm()
        {
            InitializeComponent();
            _patientsDao = new PatientsDao();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_isFound == false)
            {
                return;
            }

            PatientModel model = new PatientModel
            {
                Name = Name_TextBox.Text,
                Surname = Surname_TextBox.Text,
                Address = Address_TextBox.Text,
                PhoneNumber = Phone_TextBox.Text
            };

            _patientsDao.ChangePatient(model);

            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var patient = _patientsDao.GetPatient(Name_TextBox.Text, Surname_TextBox.Text);
            if (string.IsNullOrEmpty(patient.Name) || string.IsNullOrEmpty(patient.Surname))
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

                Address_TextBox.Text = patient.Address;
                Phone_TextBox.Text = patient.PhoneNumber;
            }
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
    }
}
