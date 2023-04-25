using PolyclinicManagementSystem.DAOs;
using PolyclinicManagementSystem.DAOs.Interfaces;
using PolyclinicManagementSystem.Models;
using System;
using System.Drawing;
using System.Linq;
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
            Spec_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Spec_ComboBox.Enabled = true;
        }

        private void Add_Button_Click(object sender, System.EventArgs e)
        {
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

            Hide();
        }

        private void PassportCode_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
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

        private void Name_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Name_TextBox.Text.Length <= 1 || Name_TextBox.Text.Any(c => char.IsDigit(c)))
            {
                Name_TextBox.ForeColor = Color.Red;
            }
            else
            {
                Name_TextBox.ForeColor = Color.Black;
            }
        }

        private void Surname_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Surname_TextBox.Text.Length <= 1 || Surname_TextBox.Text.Any(c => char.IsDigit(c)))
            {
                Surname_TextBox.ForeColor = Color.Red;
            }
            else
            {
                Surname_TextBox.ForeColor = Color.Black;
            }
        }

        private void Patronymic_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Patronymic_TextBox.Text.Length <= 1 || Patronymic_TextBox.Text.Any(c => char.IsDigit(c)))
            {
                Patronymic_TextBox.ForeColor = Color.Red;
            }
            else
            {
                Patronymic_TextBox.ForeColor = Color.Black;
            }
        }

        private void PassportCode_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (PassportCode_TextBox.Text.Length != 9)
            {
                PassportCode_TextBox.ForeColor = Color.Red;
            }
            else
            {
                PassportCode_TextBox.ForeColor = Color.Black;
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

        private void Password_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Password_TextBox.Text.Length < 5 || Password_TextBox.Text.Length > 20)
            {
                Password_TextBox.ForeColor = Color.Red;
            }
            else
            {
                Password_TextBox.ForeColor = Color.Black;
            }
        }

        private void RegisterDoctorForm_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            helpProvider1.HelpNamespace = Consts.ChmFilePath;
            Help.ShowHelp(this, helpProvider1.HelpNamespace, HelpNavigator.Topic, "funktsional__dlya_administratora_.htm#4");
        }
    }
}