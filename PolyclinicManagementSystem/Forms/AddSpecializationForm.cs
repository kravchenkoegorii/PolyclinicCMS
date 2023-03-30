using PolyclinicManagementSystem.DAOs;
using PolyclinicManagementSystem.DAOs.Interfaces;
using PolyclinicManagementSystem.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PolyclinicManagementSystem.Forms
{
    public partial class AddSpecializationForm : Form
    {
        private ISpecializationDao _specDao;

        public AddSpecializationForm()
        {
            InitializeComponent();
            _specDao = new SpecializationDao();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpecializationModel model = new SpecializationModel
            {
                Name = textBox1.Text
            };

            _specDao.AddSpec(model);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 1 || textBox1.Text.Any(c => char.IsDigit(c)))
            {
                textBox1.ForeColor = Color.Red;
            }
            else
            {
                textBox1.ForeColor = Color.Black;
            }
        }
    }
}
