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

        public ChangePatientForm()
        {
            InitializeComponent();
            _patientsDao = new PatientsDao();
            Phone_TextBox.MaxLength = 12;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientModel model = new PatientModel
            {
                Id = (int)numericUpDown1.Value,
                Address = Address_TextBox.Text,
                PhoneNumber = Phone_TextBox.Text
            };

            _patientsDao.ChangePatient(model);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            PatientModel model = _patientsDao.GetPatient((int)numericUpDown1.Value);
            if(model == null)
            {
                Address_TextBox.Text = "";
                Phone_TextBox.Text = "";
                return;
            }
            Address_TextBox.Text = model.Address;
            Phone_TextBox.Text = model.PhoneNumber;
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
