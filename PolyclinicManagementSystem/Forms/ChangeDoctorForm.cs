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
    public partial class ChangeDoctorForm : Form
    {
        private IDoctorsDao _doctorsDao;

        private ISpecializationDao _specDao;

        public ChangeDoctorForm()
        {
            InitializeComponent();
            _doctorsDao = new DoctorsDao();
            _specDao = new SpecializationDao();

            Spec_ComboBox.DataSource = _specDao.GetAllSpec();
            Spec_ComboBox.DisplayMember = "Name";
            Spec_ComboBox.ValueMember = "Name";
            Phone_TextBox.MaxLength = 12;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Email_TextBox.Text.Contains("@"))
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
                Id = (int)numericUpDown1.Value,
                Address = Address_TextBox.Text,
                PhoneNumber = Phone_TextBox.Text,
                Email = Email_TextBox.Text,
                Specialization = Spec_ComboBox.SelectedValue.ToString()
            };

            _doctorsDao.ChangeDoctor(model);
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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            DoctorModel model = _doctorsDao.GetDoctor((int)numericUpDown1.Value);
            Address_TextBox.Text = model.Address;
            Phone_TextBox.Text = model.PhoneNumber;
            Email_TextBox.Text = model.Email;
            Spec_ComboBox.SelectedText = model.Specialization;
        }
    }
}
